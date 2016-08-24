using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStation13
{



    class AtmosContainer
    {
        private GasMixture mix;

        private double volume;
        private double pressure;
        private double temperature;

        public double Volume
        {
            get { return volume; }
            set { volume = value; pressure = EvalPressure(); }
        }
        public double Pressure
        {
            get { return pressure; }
            //set { pressure = value; }
        }
        public double Temperature
        {
            get { return temperature; }
        }



        public AtmosContainer(double InitVolume)
        {
            temperature = Gas.StandardTemperature;
            pressure = 0;
            volume = InitVolume;
            mix = new GasMixture();
        }

        public void AddGas(AtmosGas gas, double moles)
        {
            mix.Add(gas, moles);
            pressure = EvalPressure();
        }

        public void RemoveGas(AtmosGas gas, double moles)
        {
            mix.Remove(gas, moles);
            pressure = EvalPressure();
        }

        /// <summary>
        /// Heats the gas by the specified amount in K. Doesn't set the temperature!
        /// </summary>
        /// <param name="temperature"></param>
        public void HeatGas(double tempDifference)
        {
            temperature += tempDifference;
            pressure = EvalPressure();
        }

        public void PressurizeGas(double presDifference)
        {
            pressure += presDifference;
            temperature = EvalTemperature();
        }

        private double EvalPressure()
        {
            return ((mix.TotalMoles * Gas.IdealGasConstant * temperature) / volume);
        }

        private double EvalTemperature()
        {
            return ((pressure * volume) / (mix.TotalMoles * Gas.IdealGasConstant));
        }

        public override string ToString()
        {
            string temp = mix.ToString();
            if(!temp.Equals("No gas found."))
            {
                temp = string.Format("Atmos Container of Volume {0} m³\nPressure {1:f2} kPa\nTemperature {2} K\n{3}", volume, (pressure/1000), temperature,  mix.ToString());
            }
            return temp;

        }

    }   

    /// <summary>
    /// AtmosGas is used to define different gases in such a way that they'll be consistent.
    /// </summary>
    public class AtmosGas
    {
        public double MolWeight {get; } //grams per mol
        public double MeltingPoint { get; } //in Kelvin
        public double BoilingPoint { get; } //in Kelvin
        public string Name { get; }

        public AtmosGas(string name,double molWeight, double meltPoint, double boilPoint)
        {
            Name = name;
            MolWeight = molWeight;
            MeltingPoint = meltPoint;
            BoilingPoint = boilPoint;
        }

    }

    class GasMixture {

        //mols of gas X
        Dictionary<AtmosGas, double> mix;

        public GasMixture()
        {
            mix = new Dictionary<AtmosGas, double>();
        }
        public double TotalMoles
        {
            get
            {
                if (mix.Count == 0) return 0;

                double temp = 0;
                foreach (double m in mix.Values)
                {
                    temp += m;
                }
                return temp;
            }
        }


        public void Add(AtmosGas gas, double moles)
        {
            if ( mix.Keys.Contains(gas))
            {
                //not a new gas!
                mix[gas] += moles;
            }
            else
            {
                //a new gas!
                mix.Add(gas, moles);
            }
        }

        public void Remove(AtmosGas gas, double moles)
        {
            if (mix.Keys.Contains(gas))
            {
                //not a new gas!
                mix[gas] -= moles;
                if(mix[gas] < 0)
                {
                    //remove gas, it's extraneous.
                    mix.Remove(gas);
                }
            }
            else
            {
                //what gas?
                //Should this fail silently or throw an error?
            }
        }

       public override string ToString()
        {
            if (TotalMoles < 0)
            {
                return "No gas found.";
            }
            String temp = "Total Moles of gas: " + TotalMoles;
            foreach (var gas in mix)
            {
                temp += String.Format("\n{0}: {1} mol {2:p}", gas.Key.Name, gas.Value, (gas.Value / TotalMoles));
            }


            return temp;
        }
    }

    /// <summary>
    /// A list of named gases and constants, to make lives easier.
    /// </summary>
    public static class Gas
    {
        //Gas List

        public static AtmosGas Oxygen = new AtmosGas("Oxygen", 31.999, -218.78, -182.96);
        public static AtmosGas Hydrogen = new AtmosGas("Hydrogen", 31.999, -218.78, -182.96); //TODO: fix numbers here

        public static Dictionary<string, AtmosGas> GasList = new Dictionary<string, AtmosGas>() {
            { "Oxygen", Oxygen },
            { "Hydrogen", Hydrogen }
        };
        

        //Constants
        public static double StandardTemperature = 298.15; //298.15 K (25 °C, 77 °F) 
        public static double StandardPressure = 100000; // 100kPa
        public static double IdealGasConstant = 8.314; // J/(K·mol) 


        
    }

}
