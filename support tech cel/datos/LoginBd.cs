using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using entidades;
using Microsoft.VisualBasic.ApplicationServices;

namespace datos
{
    public class LoginBd
    {
        string cadena = "server=localhost; user=root; database=basetickets; password=Unah20232023";

        public User Autenticar(Login login)
        {
            User usuario = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuarios WHERE CodeUser = @CodeUser AND Password = @Password;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodeUser", MySqlDbType.VarChar, 50).Value = login.CodeUser;
                        comando.Parameters.Add("@Password", MySqlDbType.VarChar, 80).Value = login.Password;

                        MySqlDataReader dr = comando.ExecuteReader();

                        if (dr.Read())
                        {
                            usuario = new User();

                            usuario.CodeUser = dr["CodeUser"].ToString();
                            usuario.UserName = dr["UserName"].ToString();
                            usuario.Password = dr["Password"].ToString();
                            usuario.Email = dr["Email"].ToString();
                            usuario.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
                            usuario.Role = dr["Role"].ToString();
                            usuario.Active = Convert.ToBoolean(dr["Active"]);
                        }
                    }
                }

            }
            catch (System.Exception)
            {
            }
            return usuario;
        }


    }
}
