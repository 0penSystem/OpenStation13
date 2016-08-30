using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenStation13
{
    public partial class AtmosCan : Form
    {
        AtmosContainer canister;

        private void UpdateDisplay()
        {
            GasDisplay.Text = canister.ToString();
        }

        public AtmosCan()
        {
            InitializeComponent();
            canister = new AtmosContainer((double)CanisterVolume.Value, 1000 * (double)CanisterBreak.Value);
            UpdateDisplay();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //what gas is selected?

            if (Gas.list.ContainsKey(GasPicker.Text)) {
                AtmosGas selectedGas = Gas.list[GasPicker.Text];

                //add whatever gas we have selected.
                canister.AddGas(selectedGas, (double)GasAmount.Value);
            }
            else
            {
                //whoops.
            }
            UpdateDisplay();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SetupCan_Click(object sender, EventArgs e)
        {
            canister = new AtmosContainer((double)CanisterVolume.Value, 1000 * (double)CanisterBreak.Value);
            UpdateDisplay();
        }

        private void AtmosCan_Load(object sender, EventArgs e)
        {

        }

        private void GasButtonOxy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HeatBtn_Click(object sender, EventArgs e)
        {
            canister.HeatGas((double)HeatValue.Value);
            UpdateDisplay();
        }
    }
}
