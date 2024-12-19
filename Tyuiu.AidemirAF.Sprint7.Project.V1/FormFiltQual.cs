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
    public partial class FormFiltQual : Form
    {
        public int MinQual { get; private set; }
        public int MaxQual { get; private set; }
        public FormFiltQual()
        {
            InitializeComponent();
        }
        private void buttonReset_AAF_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void buttonPowerOk_AAF_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxQualMechFrom_AAF.Text, out int minQual) && int.TryParse(textBoxQualMechTo_AAF.Text, out int maxQual))
            {
                MinQual = minQual;
                MaxQual = maxQual;
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
