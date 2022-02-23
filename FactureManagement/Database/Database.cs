using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using FactureManagement.App;

namespace Database
{
    public static class Database
    {
        
        public static void createDatabase()
        {
            try
            {
                if (!File.Exists(Application.StartupPath + "\\Ciscompta.db"))
                {
                    SQLiteConnection.CreateFile(Application.StartupPath + "\\Ciscompta.db");
                }
            }
            catch (SQLiteException)
            {
            }
        }

        public static void deleteDatabase()
        {
            try
            {
                string path = Application.StartupPath + "\\Ciscompta.db";
                FileInfo file = new FileInfo(path);
                if (file.Exists)
                {
                    SQLiteConnection connection = new SQLiteConnection("Data source=" + path + ";");
                    connection.Close();
                    GC.Collect();
                    GC.WaitForFullGCApproach();
                    file.Delete();
                }
                else
                {
                    return;
                }
            }
            catch (SQLiteException)
            {
            }
        }
        public static SQLiteConnection _con = new SQLiteConnection("Data Source=Ciscompta.db;Version=3;New=True;");
        public static SQLiteCommand _cmd;
        public static SQLiteDataReader _dr;
        public static void createTable( string TableName, string fields)
        {
            try
            {
                Database._con.Open();
                Database._cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS ["+TableName+"] ("+fields+")", Database._con);
                Database._cmd.ExecuteNonQuery();
                Database._con.Close();
            }
            catch (SQLiteException) {  }
          
        }

        
        public static void createTables()
        {
            try
            {
                Database.createTable("ACTIVATION", "id_activation INTEGER PRIMARY KEY AUTOINCREMENT,code_activation VARCHAR(30),delay INT,date_activation DATE,status VARCHAR(10) DEFAULT actif");
                Database.createTable("CLIENT", "idcli INTEGER PRIMARY KEY AUTOINCREMENT, nomcli VARCHAR(25), adresse VARCHAR(40),tel VARCHAR(15),Email VARCHAR(20),datecreate DATE");
                Database.createTable("COMPTE", "numCompte INTEGER PRIMARY KEY AUTOINCREMENT,intitule VARCHAR(25) UNIQUE NOT NULL, depotInit DOUBLE, soldeCompte DOUBLE, deviseCompte VARCHAR(5) NOT NULL, datecreateCompte DATE");
                Database.createTable("CONFIG", "idconfig INTEGER PRIMARY KEY AUTOINCREMENT,Esename VARCHAR(30) NOT NULL,idnat VARCHAR(15) NOT NULL, rccm VARCHAR(15) NOT NULL,adresseconfig VARCHAR(40) NOT NULL, email VARCHAR(25), phone VARCHAR(15), logo BLOB");
                Database.createTable("FACTURE", " numFac VARCHAR (10) PRIMARY KEY UNIQUE, datecreateFac DATE NOT NULL,montantFac DOUBLE,devisefac VARCHAR(5),idcli INTEGER REFERENCES CLIENT(idcli) ON DELETE NO ACTION ON UPDATE NO ACTION MATCH SIMPLE,statut VARCHAR(10) DEFAULT En_Attente,idconfig INTEGER REFERENCES CONFIG(idconfig) ON UPDATE NO ACTION");
                Database.createTable("FACTURE_DETAIL", "id INTEGER PRIMARY KEY AUTOINCREMENT,numFac VARCHAR(10) REFERENCES FACTURE(numFac) ON DELETE NO ACTION ON UPDATE NO ACTION NOT NULL, designation VARCHAR(30) NOT NULL,qte DOUBLE NOT NULL,pu DOUBLE NOT NULL,devisedetail VARCHAR(5)");
                Database.createTable("OPERATION", "idOp INTEGER PRIMARY KEY AUTOINCREMENT,Type VARCHAR(7)  NOT NULL,designOp  VARCHAR(30),dateOp DATE,montantOp DOUBLE NOT NULL,deviseOp VARCHAR(5) NOT NULL,numCompte INTEGER REFERENCES COMPTE(numCompte) ON UPDATE NO ACTION,soldeOp DOUBLE DEFAULT(0.0),numFac VARCHAR(10) DEFAULT(0),obs TEXT");
                Database.createTable("PAIEMENT", "numpaie INTEGER PRIMARY KEY AUTOINCREMENT,montantpaie DOUBLE NOT NULL,devisepaie VARCHAR(5) NOT NULL,montantres DOUBLE,modepaie VARCHAR(20),datepaie DATE,numFac VARCHAR REFERENCES FACTURE(numFac) ON UPDATE NO ACTION");
                Database.createTable("TAUX", "num INTEGER PRIMARY KEY AUTOINCREMENT,montantTaux DOUBLE  NOT NULL");
                Database.createTable("USER_MANAGER", "id INTEGER PRIMARY KEY AUTOINCREMENT,username VARCHAR(25) NOT NULL UNIQUE,pwd TEXT NOT NULL,profil VARCHAR(25) DEFAULT Administrateur");
                Database.createTable("TASKS", "idTask INTEGER PRIMARY KEY AUTOINCREMENT,designTask VARCHAR(100),dateTask DATETIME,houreTask TIME,status VARCHAR(1)");
                Database.createDefaultUser();
                Database.initTaux();
            }
            catch (Exception)
            {

            }
        }
        public static void createDefaultUser()
        {
            try
            {
                Database._con.Open();
                Database._cmd = new SQLiteCommand("SELECT * FROM USER_MANAGER", Database._con);
                Database._dr = Database._cmd.ExecuteReader();
                if (Database._dr.HasRows)
                {
                    Database._con.Close();
                }
                else
                {
                    Database._cmd = new SQLiteCommand("INSERT INTO USER_MANAGER(username,pwd) VALUES(@username,@pass) ", Database._con);
                    Database._cmd.Parameters.AddWithValue("@username", "admin");
                    Database._cmd.Parameters.AddWithValue("@pass", app.Encrypt("admin"));
                    Database._cmd.ExecuteNonQuery();
                    Database._con.Close();
                }
                
            }
            catch (SQLiteException ex) { MessageBox.Show(ex.Message); }
        }
        private static void initTaux() {
            try
            {
                Database._con.Open();
                Database._cmd = new SQLiteCommand("SELECT num FROM TAUX", Database._con);
                Database._dr = Database._cmd.ExecuteReader();
                if (Database._dr.HasRows)
                {
                    Database._con.Close();
                    return;
                }
                else
                {
                    Database._cmd = new SQLiteCommand("INSERT INTO TAUX(montantTaux) VALUES(@amount)", Database._con);
                    Database._cmd.Parameters.AddWithValue("@amount", 0000);
                    Database._cmd.ExecuteNonQuery();
                    Database._con.Close();
                }

            }
            catch (SQLiteException) { }
        }
    }
}
