using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Motoreport
{
    class ConnectDB
    {
        private string DB_name = "datamotor.sqlite";
        private string StrConnect = "Data Source = datamotor.sqlite";
        private SQLiteConnection cn;
        private string SQL_TABLE_CARS = "CREATE TABLE 'Autos' ('IDent' INTEGER NOT NULL,'Estate' INTEGER NOT NULL,'PLATECAR' TEXT NOT NULL,'Owner' TEXT NOT NULL,'Tel' TEXT NOT NULL,'DateIN' TEXT NOT NULL,'DateOUT' TEXT,'Brand' TEXT NOT NULL,'Model' TEXT NOT NULL, 'Engine' TEXT NOT NULL, 'YearCar' TEXT NOT NULL,'Motive' TEXT NOT NULL,'Diag' TEXT ,'Solv' TEXT,'Mat' TEXT,'MO' TEXT, PRIMARY KEY ('IDent' AUTOINCREMENT)); CREATE TABLE 'Turnos' ('IDTurn' INTEGER NOT NULL,'Client' TEXT NOT NULL,'Vehicle' TEXT NOT NULL,'Motive' TEXT NOT NULL,'InDATE' TEXT NOT NULL, PRIMARY KEY('IDTurn' AUTOINCREMENT));";
        private SQLiteCommand cmd_cn;

        public ConnectDB() { 
        
        }

        public bool InitializeDB() {
            bool r = false;
            if (!File.Exists(Path.GetFullPath(DB_name)))
            {
                try               {
                    SQLiteConnection.CreateFile(DB_name);
                    cn = new SQLiteConnection(StrConnect);
                    cn.Open();
                    cmd_cn = new SQLiteCommand(SQL_TABLE_CARS, cn);
                    
                    if(cmd_cn.ExecuteNonQuery() == 0){
                            r = true;
                    }
                    cn.Close();
                }catch(SQLiteException e){
                    MessageBox.Show(e.ToString());
                    r = false;
                }

            }
            return r;
        }




    }
}
