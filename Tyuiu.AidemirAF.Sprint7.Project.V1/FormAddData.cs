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
    public partial class FormAddData : Form
    {
        public string DriverLicense { get; private set; }
        public string FullName { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string FullNameMech { get; private set; }
        public string PhoneMech { get; private set; }
        public string QualMech { get; private set; }
        public string CarNumber { get; private set; }
        public string CarBrand { get; private set; }
        public string CarPower { get; private set; }
        public string CarColor { get; private set; }
        public string NameWorkshop { get; private set; }
        public string AddressWorkshop { get; private set; }
        public string PhoneWorkshop { get; private set; }
        public FormAddData()
        {
            InitializeComponent();
            buttonOK_AAF.Enabled = false;
        }

        private void buttonOK_AAF_Click(object sender, EventArgs e)
        {
            DriverLicense = textBoxDriverLicense_AAF.Text.Trim();
            FullName = textBoxFullName_AAF.Text.Trim();
            Address = textBoxAddress_AAF.Text.Trim();
            Phone = textBoxPhone_AAF.Text.Trim();
            FullNameMech = textBoxFullNameMech_AAF.Text.Trim();
            PhoneMech = textBoxPhoneMech_AAF.Text.Trim();
            QualMech = textBoxQualMech_AAF.Text.Trim();
            CarNumber = textBoxCarNumber_AAF.Text.Trim();
            CarBrand = textBoxCarBrand_AAF.Text.Trim();
            CarPower = textBoxVCarPower_AAF.Text.Trim();
            CarColor = textBoxCarColor_AAF.Text.Trim();
            NameWorkshop = textBoxNameWorkshop_AAF.Text.Trim();
            AddressWorkshop = textBoxAddressWorkshop_AAF.Text.Trim();
            PhoneWorkshop = textBoxPhoneWorkshop_AAF.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxDriverLicense_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxFullName_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxAddress_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxPhone_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxFullNameMech_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxPhoneMech_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxQualMech_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxCarNumber_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxCarBrand_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxVCarPower_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxCarColor_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxNameWorkshop_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxAddressWorkshop_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }

        private void textBoxPhoneWorkshop_AAF_TextChanged(object sender, EventArgs e)
        {
            CheckInPut();
        }
        private void CheckInPut()
        {
            buttonOK_AAF.Enabled = !string.IsNullOrWhiteSpace(textBoxAddressWorkshop_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxAddress_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxCarBrand_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxCarColor_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxCarNumber_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxDriverLicense_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxFullNameMech_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxFullName_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxNameWorkshop_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxPhoneMech_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxPhoneWorkshop_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxPhone_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxQualMech_AAF.Text) &&
                                   !string.IsNullOrWhiteSpace(textBoxVCarPower_AAF.Text);
        }
    }
}
