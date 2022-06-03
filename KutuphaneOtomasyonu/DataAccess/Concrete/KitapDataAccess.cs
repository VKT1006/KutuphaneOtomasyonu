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



        static String conString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";

        public void delete(Kitap kitap)
        {
            try
            {
                conn.Open();

                query = "delete from kitaplar where id=" + kitap.id;

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

        public DataSet get(Kitap kitap)
        {
            ds = new DataSet();
            try
            {

                conn.Open();

                query = "select * from kitaplar where id =" + kitap.id;

                dataAdapter = new MySqlDataAdapter(query,conn);

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

        public DataSet getAll()
        {
            ds = new DataSet();
            try
            {

                conn.Open();

                query = "select * from kitaplar";

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;



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

        public DataSet getById(int id)
        {
            ds = new DataSet();
            try
            {

                conn.Open();

                query = "select * from kitaplar where id =" + kitap.id;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;



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

        public DataSet getByISBN(string isbn)
        {
            ds = new DataSet();
            try
            {

                conn.Open();

                query = "select * from kitaplar where ISBN =" + isbn;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;



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

        public DataSet getByName(string name)
        {
            ds = new DataSet();
            try
            {

                conn.Open();

                query = "select * from kitaplar where ad =" + name;

                dataAdapter = new MySqlDataAdapter(query, conn);

                dataAdapter.Fill(ds);

                return ds;



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

        public void save(Kitap kitap)
        {

            /*
             * 
             *  When We Want to add a book we gotta select an author !!!
             *   
            */
            try
            {

                conn.Open();

                query = "insert into kitaplar(id, ISBN, ad, sayfa_sayisi, yazar_id) values ("+ kitap.id+", '"+kitap.ISBN+"','"+kitap.kitapAdi+"','"+kitap.sayfaSayisi+"',"+kitap.yazarId+")";

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

        public void update(Kitap kitap)
        {
            try
            {
                conn.Open();

                query = "Update kitaplar SET id = " + kitap.id + ", ISBN = " + kitap.ISBN + ", ad=" + kitap.kitapAdi + ", sayfa_sayisi=" + kitap.sayfaSayisi + ", yazar_id = " + kitap.yazarId;

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
    }
}
