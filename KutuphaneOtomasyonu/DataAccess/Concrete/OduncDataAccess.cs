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
    internal class OduncDataAccess : IOduncDataAccess
    {

        static string server = "localhost";
        static string database = "kutuphaneotomasyonu";
        static string UID = "root";
        static string password = "";
        static string query = "";
        static string connString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + UID + ";" + "PASSWORD=" + password + ";" ;

        MySqlConnection conn = new MySqlConnection(connString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataSet ds = new DataSet();



        public void delete(Odunc odunc)
        {
            try
            {
                conn.Open();

                query = "delete from oduncler where id = "+odunc.id+"";

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

        public DataSet GetAll()
        {
            try
            {
                conn.Open();

                query = "select * from oduncler";

                adapter = new MySqlDataAdapter(query, conn);

                adapter.Fill(ds);


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

        public DataSet GetByBookId(int bookID)
        {
            try
            {
                conn.Open();

                query = "select * from oduncler where kitap_id ="+bookID+" ";

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

            return ds;
        }

        public DataSet GetByBookISBN(int ISBN)
        {
            return null;
        }

        public DataSet GetByUser(int userId)
        {
            try
            {
                conn.Open();

                query = "select * from oduncler where kullanici_id ="+userId+" ";

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

            return ds;
        }

        public void save(Odunc odunc)
        {
            try
            {
                conn.Open();

                query = "insert into oduncler(id, kitap_id, kullanici_id, teslim_tarihi, verilis_tarihi) values(0,"+odunc.kitapId+", '"+odunc.kullaniciId+"','"+odunc.teslimTarihi+"','"+odunc.tarih+"')"; 

                cmd = new MySqlCommand(query,conn);

                cmd.ExecuteNonQuery();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally { 
                conn.Close();
            }
        }

        public void update(Odunc odunc)
        {
            try
            {
                conn.Open();

                query = "Update oduncler set kitap_id =" + odunc.kitapId +", kullanici_id = " + odunc.kullaniciId +", teslim_tarihi=" + odunc.teslimTarihi  +", verilis_tarihi=" + odunc.tarih;

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
