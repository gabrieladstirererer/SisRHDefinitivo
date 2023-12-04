using SisRH.Classes;
using SisRHDefinitivo.Core.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SisRHDefinitivo.Core.Repository
{
    public class LoginRepository : Conexao
    {
        public bool BuscarPorLogin(int Matricula, string Senha)
        {
            try
            {
                ConectarBanco();
                cmd = new SqlCommand("Logar_select", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matricula", Matricula);
                cmd.Parameters.AddWithValue("@senha", Senha);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharBanco(cn);
            }
        }
    }
}
