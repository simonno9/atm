using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geldautomaat.classes
{
    public class cAdmin
    {
        SQL sql = new SQL();

        public DataSet GetData(string query)
        {
            string SQL = query;
            return sql.getDataSet(SQL);
        }


        public string NewUser(string voornaam, string achternaam)
        {
            string SQL = string.Format("INSERT INTO USER (`voornaam`, `achternaam`) VALUES ('{0}','{1}')", voornaam, achternaam);
            sql.ExecuteNonQuery(SQL);
            return "User was created";
        }
        public void NewRekening(int user_id, int rekeningnummer, string passwordHash)
        {
         
            string SQL = string.Format("INSERT INTO rekening (rekeningsnummer, saldo, pincode, status, user_id) VALUES ({0},{1},'{2}','{3}',{4})", rekeningnummer, 0, passwordHash, "active", user_id);
            sql.ExecuteNonQuery(SQL);

        }

        public void rekeningBlokkeren(int rekening_id)
        {
            string SQLSelectStatus = string.Format("select status FROM rekening WHERE rekening_id = {0}", rekening_id);
            DataTable datatable = sql.getDataTable(SQLSelectStatus);

            if (Convert.ToString(datatable.Rows[0]["status"]) == "active")
            {
                string SQLRekening = string.Format("Update rekening Set status = 'inactive' WHERE rekening_id = {0}", rekening_id);
                sql.ExecuteNonQuery(SQLRekening);
                System.Windows.MessageBox.Show("je hebt deze rekeningen geblokeerd");
            }
            else
            {
                System.Windows.MessageBox.Show("je hebt deze rekening ungeblokkeerd");

            }
                
        }
        

        public void rekeningDeblokkeren(int rekening_id)
        {
            string SQLSelectStatus = string.Format("select status FROM rekening WHERE rekening_id = {0}", rekening_id);
            DataTable datatable = sql.getDataTable(SQLSelectStatus);

            if (Convert.ToString(datatable.Rows[0]["status"]) == "inactive")
            {
                string SQLRekening = string.Format("Update rekening Set status = 'active' WHERE rekening_id = {0}", rekening_id);
                sql.ExecuteNonQuery(SQLRekening);
                System.Windows.MessageBox.Show("je hebt deze rekening ungeblokkeerd");
            }
            else
            {
                System.Windows.MessageBox.Show("deze rekening is niet geblokkeerd");

            }

        }
    }   
}
