using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geldautomaat.classes
{
    public class cTransaction
    {
        SQL sql = new SQL();

        public DataSet GetData(int rekeningnummer)
        {
            string SQL = "SELECT amount,datum FROM `rekening` INNER JOIN transactie ON transactie.rekening_id = rekening.rekening_id WHERE rekeningsnummer = " + rekeningnummer + " ORDER BY transactie_id DESC LIMIT 3"; 
            return sql.getDataSet(SQL);
        }
    }
}
