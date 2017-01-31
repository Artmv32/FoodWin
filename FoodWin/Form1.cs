using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtWeight_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            lblProficitVal.Text = tbProficit.Value + "%";
            var weight = txtWeight.Value;
            var proteins = txtProt.Value * weight;
            var fats = txtFat.Value * weight;
            var targetCals = (tbProficit.Value / new decimal(100)) * txtCal.Value + txtCal.Value;
            lblTargetCals.Text = string.Format("{0} ККал", targetCals.ToString());
            var carbCals = (targetCals - (fats * 9 + proteins * 4)) / 4;
            lblCarbsNorm.Text = carbCals + " г";
            lblFatNorm.Text = fats + " г";
            lblProtNorm.Text = proteins + " г";
        }

        private void tbProficit_Scroll(object sender, EventArgs e)
        {
            Refresh();
        }

        protected override void OnLoad(EventArgs e)
        {
            Refresh();

            base.OnLoad(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
