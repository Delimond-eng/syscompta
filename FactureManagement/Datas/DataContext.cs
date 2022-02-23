using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace FactureManagement.Datas
{
    class DataContext
    {

        public SQLiteConnection con = new SQLiteConnection("Data Source=Ciscompta.db;Version=3;New=True;");
        public SQLiteCommand req;
        public SQLiteDataReader dr;


        //oledb
        public SQLiteConnection connect()
        {
            
            try
            {
                if (con.State == ConnectionState.Closed)

                    con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }

        public SQLiteConnection disconnect()
        {
            try
            {
                if (con.State == ConnectionState.Open)

                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return con;
        }

        public void ChargerCombo(string requete, string field, ComboBox cb)
        {
            try
            {
                connect();
                req = new SQLiteCommand(requete, con);
                dr = req.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr[field].ToString());
                }
                disconnect();
            }
            catch (Exception) { }
        }
    }
}
