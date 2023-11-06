using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AfroPower
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\maria\\source\\repos\\AfroPower\\AfroPower\\BancoDeDados\\Banco.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                    var conn = ConexaoBanco();
                    var cmd = conn.CreateCommand();
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, conn);
                    da.Fill(dt);
                    conn.Close();

                    return dt;
                
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public static void dml(string q, string msgOK=null, string msgERRO=null)
       {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
             try { 
                   var conn = ConexaoBanco();
                   var cmd = conn.CreateCommand();
                   cmd.CommandText = q;
                   da = new SQLiteDataAdapter(cmd.CommandText, conn);
                   cmd.ExecuteNonQuery();
                   conn.Close();
                    if(msgOK!=null){

                    MessageBox.Show(msgOK);
                    }
             }catch(Exception ex){
                    if(msgERRO!=null){
                    MessageBox.Show(msgERRO+"\n"+ex.Message);
                    }
                   throw ex;
                   }
                 }


        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var conn = ConexaoBanco();
                var cmd = conn.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                  var conn = ConexaoBanco();
                  var cmd = conn.CreateCommand();
                  cmd.CommandText = sql;
                  da = new SQLiteDataAdapter(cmd.CommandText, conn);
                  da.Fill(dt);
                  conn.Close();

                    return dt;
                
            }
            catch (Exception ex)
            {
              
                throw ex;

            }
        }


        public static void NovoUsuario(Usuario u)
        {

            if (ExisteUsername(u))
            {
                MessageBox.Show("Username ja existe");
                return;
            }
            try
            {
                var conn = ConexaoBanco();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Usuarios (N_NOMEUSUARIO,N_EMAILUSUARIO,N_SENHAUSUARIO,N_DATANASCI,N_NIVEL)VALUES(@nome,@email,@senha,@data,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@data", u.data);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário cadastrado com sucesso!!!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro");
            }
        }
        public static bool ExisteUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var conn = ConexaoBanco();
            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT N_EMAILUSUARIO FROM tb_Usuarios WHERE N_EMAILUSUARIO= '" + u.email + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, conn);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
