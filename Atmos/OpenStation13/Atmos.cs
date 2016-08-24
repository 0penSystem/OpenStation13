using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenStation13
{
      

    /// <summary>
    /// AtmosGas is used to define different gases in such a way that they'll be consistent.
    /// </summary>
    class AtmosGas
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
        public double TotalMoles
        {
            get
            {
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
            if (mix.Keys.Contains(gas))
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
                temp += String.Format("\n{0}: {1} mol", gas.Key.Name, gas.Value);
            }


            return temp;
        }
    }

    /// <summary>
    /// A list of named gases, to make lives easier.
    /// </summary>
    public static class Gas
    {
        static AtmosGas Oxygen = new AtmosGas("Oxygen",31.999, -218.78, -182.96);
    }

}
