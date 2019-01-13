using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class PhoneCaseCreate : Form
    {
        UnitOfWork _uw = new UnitOfWork();
        public PhoneCaseCreate()
        {
            InitializeComponent();
        }

        public void SelectPhoneCase (int id)
        {
            tabControl1.SelectTab(1);
            cbx_Cases.SelectedValue = id;
        }

        private void PhoneCaseCreate_Load(object sender, EventArgs e)
        {
            FillColorsCombo();
            FillPhoneCasesCombo();
        }

        private void FillPhoneCasesCombo()
        {
            cbx_Cases.DataSource = null;
            cbx_Cases.DisplayMember = "ProductName"; 
            cbx_Cases.ValueMember = "ID";
            cbx_Cases.DataSource = _uw.PhoneCases.GetPhoneCases();
        }

        private void FillColorsCombo()
        {
            Type T = typeof(CaseColor); 
            List<string> options;

            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                options = T.GetEnumNames().ToList(); 
            }
            else
            {
                var attrs = T.GetFields().SelectMany(x => x.CustomAttributes);
                var attrNames = attrs.SelectMany(x => x.ConstructorArguments);
                options = attrNames.Select(x => (string)x.Value).ToList();
            }
            cbx_color.DataSource = options;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tb_name.Clear();
            nupPrice.Value = 0;
            nupQty.Value = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            PhoneCase p = new PhoneCase();
            p.ProductName = tb_name.Text;
            p.CaseColor = (CaseColor)cbx_color.SelectedIndex;
            p.Price = nupPrice.Value;
            p.StockCount = (int)nupQty.Value;

            _uw.PhoneCases.InsertPhoneCase(p);

            RefreshMainGrid();
            FillPhoneCasesCombo(); 
        }

        private void RefreshMainGrid()
        {
            PhoneCaseManage f = (PhoneCaseManage)Application.OpenForms["PhoneCaseManage"]; 
            if (f != null) 
                f.FillGrid();
        }

        private void btn_AddStock_Click(object sender, EventArgs e)
        {
            int id = (int)cbx_Cases.SelectedValue;
            int qty = (int)nup_qtyAdd.Value;
            _uw.PhoneCases.AddStockToPhoneCase(id, qty);

            RefreshMainGrid();
            
        }

        private void RefreshCurrentStock()
        {
            if (cbx_Cases.SelectedItem == null)
                return;
            string template = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en" ? "Stock will be updated as 0 when saved." : "Kaydettiğinizde adet 0 olarak güncellenecektir.";
            var chosenCase = (PhoneCase)cbx_Cases.SelectedItem;
            var currentStock = chosenCase.StockCount;
            int latest = currentStock + (int)nup_qtyAdd.Value;
            lbl_Stock.Text = template.Replace("0", latest.ToString());

            RefreshMainGrid();
            FillPhoneCasesCombo();

        }

        private void cbx_Cases_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nup_qtyAdd_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nup_qtyAdd_Scroll(object sender, ScrollEventArgs e)
        {
            RefreshCurrentStock();
        }

        private void nup_qtyAdd_ValueChanged(object sender, EventArgs e)
        {
            RefreshCurrentStock();
        }
    }
}
