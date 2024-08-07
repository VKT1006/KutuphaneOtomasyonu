﻿using System;
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
    internal class YazarDataAccess : IYazarDataAccess
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


        public void delete(Yazar yazar)
        {
            try
            {
                conn.Open();

                query = "delete from yazarlar where id ="+yazar.id+"";

                cmd = new MySqlCommand(query,conn);

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

                query = "select * from yazarlar";

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

        public DataSet GetById(int id)
        {
            try
            {
                conn.Open();

                query = "select * from yazarlar where id="+id+"" ;

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

        public DataSet GetByName(string name)
        {
            try
            {
                conn.Open();

                query = "select * from yazarlar where ad like '%"+name+"%'";

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

        public void save(Yazar yazar)
        {
            try
            {
                conn.Open();

                query = "insert into yazarlar(id, ad, soyad, dogum_tarihi, aciklama) values(0,'"+yazar.ad+"', '"+yazar.soyad+"','"+yazar.dogumTarihi+"','"+yazar.aciklama+"')";
                
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

        public void update(Yazar yazar)
        {
            try
            {
                conn.Open();

                query = "update yazarlar set ad= '"+yazar.ad+"', soyad='"+yazar.soyad+"', dogum_tarihi='"+yazar.dogumTarihi+"', aciklama='"+yazar.aciklama+"' where id= "+yazar.id+"";

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

        public int GetIdByName(string name)
        {
            int id = 0;
            try
            {
                conn.Open();

                query = "select id from yazarlar where ad='"+name+"'";

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

            foreach(DataRow row in ds.Tables[0].Rows)
            {
                try {
                    string idString = row["ID"].ToString();
                    id = Convert.ToInt32(idString);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }

            return id;
        }

    }
}
