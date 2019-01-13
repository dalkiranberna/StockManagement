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
    public partial class Phones : Form
    {
        UnitOfWork _uw = new UnitOfWork();
        public Phones()
        {
            InitializeComponent();
        }

        private void btnCreatePhone_Click(object sender, EventArgs e)
        {
            new AddPhone().Show();
        }

        private void Phones_Load(object sender, EventArgs e)
        {
            FillBrandsCombobox();
            FillPhonesGrid();
        }

        public void FillPhonesGrid()
        {
            grid_phones.DataSource = null;
            grid_phones.DataSource = _uw.Phones.GetPhonesForDisplay();
        }

        private void FillBrandsCombobox()
        {
            UIHelper.FillBrandComboBox(cbxBrands, Properties.Resources.AllBrands); 
        }
        
        

        private void btn_Search_Click(object sender, EventArgs e)
        {
            grid_phones.DataSource = null;
            
            grid_phones.DataSource = _uw.Phones.SearchPhone(Convert.ToInt32(cbxBrands.SelectedValue), txtModel.Text);
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {

        }
    }
}
