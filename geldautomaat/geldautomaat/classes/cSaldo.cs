using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace geldautomaat.classes
{
    public class cSaldo
    {
        SQL sql = new SQL();


        public string updateSaldo(decimal saldo, int rekening_id, string amount, string withdraw)
        {
            string SQLDATUM = " SELECT * FROM `transactie` WHERE DATE(`datum`) = CURDATE() and  rekening_id =" + rekening_id;
            DataTable dataTable = sql.getDataTable(SQLDATUM);


            if (dataTable.Rows.Count >= 3)
            {
                return "je kan niet meer dan 3 transactie perdag maken";
            }
            else
            {

                string SQLRekening = string.Format("Update rekening Set saldo ='{0}' WHERE rekening_id = {1}", Convert.ToInt32(saldo), rekening_id);
                sql.ExecuteNonQuery(SQLRekening);

                string SQLTransaction = string.Format("INSERT INTO `transactie` (`amount`,rekening_id) VALUES ('{0}',{1})", amount, rekening_id);
                sql.ExecuteNonQuery(SQLTransaction);
                return "je hebt " + amount + " gestort";

            }
        }
        public void DepositSaldo(decimal saldo, int rekening_id, string amount)
        {
                string SQLRekening = string.Format("Update rekening Set saldo ='{0}' WHERE rekening_id = {1}", Convert.ToInt32(saldo), rekening_id);
                sql.ExecuteNonQuery(SQLRekening);

                string SQLTransaction = string.Format("INSERT INTO `transactie` (`amount`,rekening_id) VALUES ('{0}',{1})", amount, rekening_id);
            sql.ExecuteNonQuery(SQLTransaction);
        }

    }
}
