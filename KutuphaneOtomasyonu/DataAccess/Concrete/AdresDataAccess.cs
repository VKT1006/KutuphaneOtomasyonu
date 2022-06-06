using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu.DataAccess.Abstract;
using KutuphaneOtomasyonu.Entities;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyonu.DataAccess.Concrete
{
    internal class AdresDataAccess : IAdresDataAccess
    {
        static string server = "localhost";
        static string database = "kutuphaneotomasyonu";
        static string uid = "root";
        static string password = "";
        static string query = "";
        static string connString = "SERVER=" + server + ";" + " DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";" ;

        MySqlConnection conn = new MySqlConnection(connString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataSet ds;


        public void delete(Adres adres)
        {
            try
            {
                conn.Open();

                query = "delete from adresler where id = "+adres.id+"";
                
                cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet getAdres(int uyeId)
        {
            return null;
        }

        public DataSet getAll()
        {
            ds = new DataSet();
            try
            {
                conn.Open();

                query = "select * from adresler";

                adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);

                return ds;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public DataSet getById(int id)
        {
            ds = new DataSet();

            try
            {
                conn.Open();

                query = "select * from adresler where id = "+id+"";

                adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);

                return ds;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public void save(Adres adres)
        {
            try
            {
                conn.Open();

                query = "insert into adresler (id, adres) values(0,'"+adres.adres+"')";

                cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void update(Adres adres)
        {
            try
            {
                conn.Open();

                query = "update adresler set adres = '"+adres.adres+"' where id = "+adres.id+"";

                cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public int getLastSavedId()
        {
            ds = new DataSet();

            try
            {
                conn.Open();

                query = "select id from adresler where id = (select max(id) from adresler)";

                adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            int id = 0;
            
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                id = Convert.ToInt32( row["id"].ToString());  
            }

            return id;


        }

        public int getIdByAdres(string adres)
        {
            ds = new DataSet();

            try
            {
                conn.Open();

                query = "select id from adresler where adres = '" + adres + "'";

                adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            int id = 0;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                id = Convert.ToInt32(row["id"].ToString());
            }

            return id;
        }
    }
}
