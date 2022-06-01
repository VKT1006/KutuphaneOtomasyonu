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
    internal class IletisimBilgileriDataAccess : IIletisimBilgileriDataAccess
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


        public void delete(İletisimBilgileri iletisimBilgileri)
        {
            try
            {
                conn.Open();

                query = "delete from iletisim_bilgileri where id=" + iletisimBilgileri.id ;

                cmd = new MySqlCommand(query);

                cmd.ExecuteNonQuery();

                MessageBox.Show("İletişim Bilgileri Silindi!");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            
        }

        public DataSet getAll()
        {

            ds = new DataSet();

            try
            {
                conn.Open();

                query = "select * from iletisim_bilgileri";

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
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

                query = "select * from iletisim_bilgileri where id = " + id;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public DataSet getByUyeId(int uyeId)
        {
            ds = new DataSet();

            try
            {
                conn.Open();

                query = "select * from iletisim_bilgileri where id = " + uyeId;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public void save(İletisimBilgileri iletisimBilgileri)
        {
            try
            {
                conn.Open();

                query = "insert into iletisim_bilgileri(id, uye_id,  telefon, email) values("+ iletisimBilgileri.id+",'"+iletisimBilgileri.uyeId+"','"+iletisimBilgileri.telefon+"','"+iletisimBilgileri.email+"')";

                cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();



            }catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void update(İletisimBilgileri iletisimBilgileri)
        {
            try
            {
                conn.Open();

                query = "update iletisim_bilgileri SET id = " + iletisimBilgileri.id + ", uye_id=" + iletisimBilgileri.uyeId + ", telefon=" + iletisimBilgileri.telefon + ", email= " + iletisimBilgileri.email+ "where id=" + iletisimBilgileri.id;

                cmd = new MySqlCommand(query, conn);

                cmd.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
