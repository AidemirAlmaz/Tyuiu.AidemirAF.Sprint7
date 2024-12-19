using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AidemirAF.Sprint7.Project.V1.Lib;

namespace Tyuiu.AidemirAF.Sprint7.Project.V1
{
    public partial class FormSearch : Form
    {
        public string SearchValue { get; private set; }
        public FormSearch()
        {
            InitializeComponent();
        }
        private void buttonSearch_AAF_Click(object sender, EventArgs e)
        {
            SearchValue = textBoxSearch_AAF.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonReset_AAF_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
