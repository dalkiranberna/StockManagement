using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.BusinessLogic
{
    class PhoneCaseRepo
    {
        public List<PhoneCase> GetPhoneCases()
        {
            List<PhoneCase> list = new List<PhoneCase>();
            DataTable dt = Program.SqlHelper.GetTable("Select * From PhoneCase");
            foreach (DataRow item in dt.Rows)
            {
                PhoneCase pc = new PhoneCase();
                pc.ID = (int)item["ID"];
                pc.ProductName = item["ProductName"].ToString();
                pc.Price = (decimal)item["Price"];
                pc.CaseColor = (CaseColor)item["CaseColor"];
                pc.StockCount = (int)item["StockCount"];
                list.Add(pc);
            }

            return list;
        }

        public void InsertPhoneCase(PhoneCase newPhoneCase)
        {
            SqlParameter p1 = new SqlParameter("productName", newPhoneCase.ProductName);
            SqlParameter p2 = new SqlParameter("price", newPhoneCase.Price);
            SqlParameter p3 = new SqlParameter("caseColor", (int)newPhoneCase.CaseColor);
            SqlParameter p4 = new SqlParameter("stockCount", newPhoneCase.StockCount);

            Program.SqlHelper.ExecuteProc("InsertPhoneCase", p1, p2, p3, p4);
        }

        public void AddStockToPhoneCase(int id, int qty)
        {
            SqlParameter p1 = new SqlParameter("ID", id);
            SqlParameter p2 = new SqlParameter("qty", qty);

            Program.SqlHelper.ExecuteProc("UpdatePhoneCase", p1, p2);

        }

        public void Delete (int id)
        {
            Program.SqlHelper.ExecuteCommand("Delete From PhoneCase Where ID = " + id);
        }
    }
}
