using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.DataAccess.Abstract;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu.DataAccess.Concrete
{
    internal class KitapDataAccess : IKitapDataAccess
    {

        static string server = "localhost";
        static string database = "denemeKutuphaneOtomasyonu";
        static string username = "root";
        static string password = "";

        string commandSql;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        List<Kitap> kitaplar;

        static String conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

        public void delete(Kitap kitap)
        {
            using (conn = new MySqlConnection(conString))

                conn.Open();

            commandSql = "delete from table where id= " + kitap.id;

            cmd = new MySqlCommand(commandSql, conn);

            cmd.ExecuteNonQuery();  

            conn.Close();            

        }

        public DataSet get(Kitap kitap)
        {

            kitaplar = new List<Kitap>();

            conn = new MySqlConnection(conString);

            commandSql = "select * from kitaplar where id = " + kitap.id;

            dataAdapter = new MySqlDataAdapter(commandSql, conn);

            dataAdapter.Fill(dataSet);

            // this will transfer the data inside my dataset to an arrayList
            foreach(DataRow dr in dataSet.Tables[0].Rows)
            {
                //kitaplar.Add(new Kitap(dr["id"]))
            }


            return null;



        }

        public DataSet getAll()
        {
            return null;
        }

        public DataSet getById(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet getByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public DataSet getByName(string name)
        {
            throw new NotImplementedException();
        }

        public void save(Kitap kitap)
        {
            throw new NotImplementedException();
        }

        public void update(Kitap kitap)
        {
            throw new NotImplementedException();
        }
    }
}
