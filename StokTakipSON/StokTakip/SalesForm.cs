using StokTakip.BusinessLogic;
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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            dg_Products.DataSource = null;
            dg_Products.DataSource = SalesManager.GetProducts();
            listBox1.DisplayMember = "ProductName";

            int[] widths = { 40, 160, 120, 150, 150 };
            for (int i = 0; i < widths.Length; i++)
                dg_Products.Columns[i].Width = widths[i];
                
        }
        
        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (Product item in listBox1.Items)
                total += item.Price;

            label1.Text = total.ToString("C");
        }


        private void dg_Products_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cells = dg_Products.SelectedRows[0].Cells;
            
            Product p;
            if (cells["IMEI1"].Value == "")
                p = new PhoneCase();
            else
                p = new Phone();
            
            p.ID = (int)cells["ID"].Value;
            p.Price = (decimal)cells["Price"].Value;
            p.ProductName = cells["ProductName"].Value.ToString();
            
            listBox1.Items.Add(p);
            CalculateTotal();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<Product> list = listBox1.Items.Cast<Product>().ToList();
            SalesManager.SellProducts(list);
            FillGrid();
            string message = list.Count + " ürün stoktan düşüldü:";

            decimal total = 0;
            foreach (var item in list)
            {
                message += Environment.NewLine;
                message += item.ProductName + " (" + item.Price + ")";
                total += item.Price;
            }
            message += Environment.NewLine;
            message += Environment.NewLine;
            message += "Toplam: " + total;
            MessageBox.Show(message);

            listBox1.Items.Clear();
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            dg_Products.DataSource = SalesManager.GetProducts(tb_search.Text);
        }
    }
}
