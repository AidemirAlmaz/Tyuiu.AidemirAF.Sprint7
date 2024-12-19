using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    public partial class FormFiltPower : Form
    {
        public int MinPower { get; private set; }
        public int MaxPower { get; private set; }
        public FormFiltPower()
        {
            InitializeComponent();
        }
        private void buttonReset_AAF_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void buttonPowerOk_AAF_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCarPowerFrom_AAF.Text, out int minPower) && int.TryParse(textBoxCarPowerTo_AAF.Text, out int maxPower))
            {
                MinPower = minPower;
                MaxPower = maxPower;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid power values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
