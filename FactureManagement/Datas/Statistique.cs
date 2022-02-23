using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureManagement.Datas
{
    class Statistique : DataContext
    {
        public string count(string Table, string field)
        {
            string countable = "";
            try
            {
                connect();
                req = new SQLiteCommand("SELECT COUNT([" + field + "]) FROM ["+Table+"]",con);
                countable = req.ExecuteScalar().ToString();
                disconnect();
            }
            catch (Exception){}
            return countable;
        }

        public void changeTaux(double amount)
        {
            try
            {
                connect();
                req = new SQLiteCommand("UPDATE TAUX SET montantTaux=@montant",con);
                req.Parameters.AddWithValue("@montant",amount);
                req.ExecuteNonQuery();
                disconnect();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
        public string countOrWhere(string Table, string field,string cdt,string prdt1,string prdt2)
        {
            string countable = "";
            try
            {
                connect();
                req = new SQLiteCommand("SELECT COUNT([" + field + "]) FROM [" + Table + "] WHERE ["+cdt+"]='"+prdt1+ "' OR  [" + cdt + "]='" + prdt2 + "' ", con);
                countable = req.ExecuteScalar().ToString();
                disconnect();
            }
            catch (Exception) { }
            return countable;
        }

        public string countWhere(string Table, string field, string cdt, string prdt1)
        {
            string countable = "";
            try
            {
                connect();
                req = new SQLiteCommand("SELECT COUNT([" + field + "]) FROM [" + Table + "] WHERE [" + cdt + "]='" + prdt1 + "' ", con);
                countable = req.ExecuteScalar().ToString();
                disconnect();
            }
            catch (Exception) { }
            return countable;
        }

        public string countWhereDate()
        {
            string countable = "";
            try
            {
                connect();
                req = new SQLiteCommand("SELECT COUNT(numFac) FROM FACTURE WHERE datecreateFac='"+ DateTime.Now.ToString("yyyy-MM-dd")+"' ", con);
                countable = req.ExecuteScalar().ToString();
                disconnect();
            }
            catch (Exception) { }
            return countable;
        }
    }
}
