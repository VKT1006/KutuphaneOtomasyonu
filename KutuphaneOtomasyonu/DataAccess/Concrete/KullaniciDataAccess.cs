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
    internal class KullaniciDataAccess : IKullaniciDataAccess
    {

        static string server = "localhost";
        static string database = "kutuphaneotomasyonu";
        static string userName = "root";
        static string password = "";
        static string connectionString = "SERVER=" + server + ";"
            + "DATABASE=" + database + ";"
            + "UID=" + userName + ";"
            + "PASSWORD=" + password + ";";

        static string query = "";

        MySqlDataAdapter dataAdapter;
        MySqlCommand cmd;
        MySqlConnection conn = new MySqlConnection(connectionString);
        DataSet ds;

        public void delete(Kullanici kullanici)
        {
            try
            {
                conn.Open();

                query = "delete from kullanicilar where id = " + kullanici.id;

                cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public DataSet get(Kullanici kullanici)
        {
            return null;
        }

        public DataSet GetAll()
        {
            try
            {
                query = "select * from kullanicilar";

                conn.Open();

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

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
            try
            {
                conn.Open();

                query = "select * from kullanicilar where id = " + id;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

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

        public DataSet getByName(string name)
        {
            try
            {
                conn.Open();

                query = "select * from kullanicilar where kullanici_adi = " + name;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { 
                conn.Close();
            }

            return ds;
        }

        public void save(Kullanici kullanici)
        {
            try
            {
                conn.Open();

                //query =String.Format( "insert into kullanicilar(id,kullanici_adi,parola) values( {1}, {2}, {3} )",kullanici.id.ToString(), kullanici.kullaniciAdi, kullanici.parola);

                query = "insert into kullanicilar(id,kullanici_adi,parola) values("+kullanici.id + " , '"+kullanici.kullaniciAdi+"', '"+kullanici.parola+"')";

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

        public void update(Kullanici kullanici)
        {
            try
            {
                conn.Open();

                query = "UPDATE kullanicilar set kullanici_adi = " + kullanici.kullaniciAdi + ", parola = " + kullanici.parola + " where id = " + kullanici.id;

                cmd = new MySqlCommand(query,conn);

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
    }
}
