using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class AddPhone : Form
    {
        UnitOfWork _uw = new UnitOfWork();
        public AddPhone()
        {
            InitializeComponent();
        }

        private void AddPhone_Load(object sender, EventArgs e)
        {
            UIHelper.FillBrandComboBox(cbxBrand, Properties.Resources.Choose);
        }

        private void btnAdPhone_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone();
            newPhone.Brand = (Brand)cbxBrand.SelectedItem;
            newPhone.IMEI1 = tbIMEI1.Text;
            newPhone.IMEI2 = tbIMEI2.Text;
            newPhone.Price = nupPrice.Value;
            newPhone.ProductName = tbPhoneName.Text;
            newPhone.ModelCode = tbModelCode.Text;

            _uw.Phones.InsertPhone(newPhone);

            RefreshMainPhoneGrid(); 
        }

        private void RefreshMainPhoneGrid()
        {
            var openForm = Application.OpenForms["Phones"];
            Phones pForm = (Phones)openForm;
            pForm.FillPhonesGrid();
        }
    }
}
