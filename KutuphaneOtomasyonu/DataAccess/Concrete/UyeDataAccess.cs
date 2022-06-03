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
    internal class UyeDataAccess : IUyeDataAccess
    {
        static string server = "localhost";
        static string database = "kutuphaneotomasyonu";
        static string UID = "root";
        static string password = "";
        static string query = "";
        static string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + UID + ";" + "PASSWORD=" + password + ";";

        MySqlConnection conn = new MySqlConnection(connString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataSet ds = new DataSet();


        public void delete(Uye uye)
        {
            try
            {
                conn.Open();

                query = "delete from uyeler where id = " + uye.id;

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

        public DataSet get(Uye uye)
        {
            return null;
        }

        public DataSet getAll()
        {
            try
            {
                conn.Open();

                query = "select * from uyeler";

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
            return ds;
        }

        public DataSet getByName(string name)
        {
            try
            {
                conn.Open();

                query = "select * from uyeler where ad= " + name;

                adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public void save(Uye uye)
        {
            try
            {

                conn.Open();

                query = "insert into uyeler(id, ad, soyad, adres_id, iletisim_bilgileri_id) values("+uye.id+",'"+uye.ad+"', '"+uye.soyad+"',"+uye.adresId+","+uye.iletisim_bilgileri_id+") ";

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

        public void update(Uye uye)
        {
            try
            {

                conn.Open();

                query = "update uyeler set ad=" + uye.ad + ", soyad= " + uye.soyad + ", adres_id=" + uye.adresId + ", iletisim_bilgileri_id=" + uye.iletisim_bilgileri_id + "where id=" + uye.id; 

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
    }
}
