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
    public partial class FormSort : Form
    {
        public string SortColumn { get; private set; }
        public ListSortDirection SortDirection { get; private set; }
        public FormSort()
        {
            InitializeComponent();
        }

        private void buttonFullName_AAF_Click(object sender, EventArgs e)
        {
            SortColumn = "ФИО владельца автомобиля";
            SortDirection = ListSortDirection.Ascending;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonPower_AAF_Click(object sender, EventArgs e)
        {
            SortColumn = "Мощность автомобиля (л/с)";
            SortDirection = ListSortDirection.Ascending;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonQual_AAF_Click(object sender, EventArgs e)
        {
            SortColumn = "Квалификация механика (механик разряда)";
            SortDirection = ListSortDirection.Ascending;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonReset_AAF_Click(object sender, EventArgs e)
        {
            SortColumn = null;
            SortDirection = ListSortDirection.Ascending;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
