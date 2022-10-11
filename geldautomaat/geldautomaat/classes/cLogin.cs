using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace geldautomaat
{
    public class cLogin
    {
        private string _pincode;
        private int _rekeningsnummer;
        private int _saldo;
        private string _status;
        private string _voornaam;
        private string _achternaam;
        private int _rekening_id;
        private int _medewerker_id;
        private string _username;
        private string _password;

        public string password
        {
            get { return _password; }
            set { value = _password; }
        }
        public string username
        {
            get {  return _username; }
            set { value = _username; }
        }

        public int medewerker_id
        {
            get { return _medewerker_id; }
            set { value = _medewerker_id; }
        }
        public string pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }

        public int rekening_id
        {
            get { return _rekening_id; }
            set { _rekening_id = value; }
        }
        public int rekeneingsnummer
        {
            get { return _rekeningsnummer; }
            set { _rekeningsnummer = value; }
        }
        public int saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }
        SQL sql = new SQL();



        public DataTable read(string bank)
        {
            string SQL = string.Format("SELECT * FROM rekening WHERE rekeningsnummer = " + bank);



            DataTable datatable = sql.getDataTable(SQL);
            if (datatable.Rows.Count != 0 && datatable.Rows[0]["rekeningsnummer"].ToString() == bank)
            { 
                _rekeningsnummer = Convert.ToInt32(datatable.Rows[0]["rekeningsnummer"].ToString());
                _saldo = Convert.ToInt32(datatable.Rows[0]["saldo"].ToString());
                _pincode = datatable.Rows[0]["pincode"].ToString();
                _status = datatable.Rows[0]["status"].ToString();
                _rekening_id = Convert.ToInt32(datatable.Rows[0]["rekening_id"].ToString());


            } else
            {
                System.Windows.MessageBox.Show("deze gevens kloppen niet");

            }
            return datatable;


        }



        public DataTable loginAdmin(string rpassword, string rUsername)
        {
            string SQL = string.Format("SELECT * FROM medewerker WHERE password = '{0}' AND  username = '{1}'" , rpassword,rUsername);
            DataTable datatable = sql.getDataTable(SQL);
            if (datatable.Rows.Count != 0 && datatable.Rows[0]["username"].ToString() == rUsername && datatable.Rows[0]["password"].ToString() == rpassword)
            {
               _medewerker_id = Convert.ToInt32(datatable.Rows[0]["medewerker_id"].ToString());
                _username = datatable.Rows[0]["username"].ToString();

                _password = datatable.Rows[0]["password"].ToString();
            }
            else
            {
                System.Windows.MessageBox.Show("deze gevens kloppen niet");

            }
            return datatable;


        }
    }
}
