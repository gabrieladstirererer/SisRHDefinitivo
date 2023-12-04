using SisRH.Classes;
using SisRHDefinitivo.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Core.Repository
{
    public class SelectFuncionarioRepository : Conexao
    {
        public List<Funcionario> ConsultarFunc(string nome, int matricula)
        {
            try
            {
                ConectarBanco();
                cmd = new SqlCommand("ListarFunc_Select", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@matricula", matricula);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cpf", "-1");
                //cmd.Parameters.AddWithValue("@nascimento", "-1");
                cmd.Parameters.AddWithValue("@nascimentoInt", -1);
                cmd.Parameters.AddWithValue("@cargo", -1);
                cmd.Parameters.AddWithValue("@dep", -1);
                cmd.Parameters.AddWithValue("@jornada", "-1");
               
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable funcs = new DataTable();
                    funcs.Load(dr);

                    List<Funcionario> lista = new List<Funcionario>();

                    foreach (DataRow row in funcs.Rows)
                    {
                        Funcionario model = new Funcionario();

                        model.Matricula_func = Convert.ToInt32(row["Matricula_func"]);
                        model.Nome = Convert.ToString(row["Nome"]);
                        model.Data_Nascimento = row.IsNull("Data_Nascimento") ? (DateTime?)null : row.Field<DateTime>("Data_Nascimento");
                        model.Sexo = Convert.ToString(row["Sexo"]);
                        model.Telefone = Convert.ToString(row["Telefone"]);
                        model.Cargo = Convert.ToString(row["Cargo"]);
                        model.Departamento = Convert.ToString(row["Departamento"]);
                        model.Data_Emissao = row.IsNull("Data_Emissao") ? (DateTime?)null : row.Field<DateTime>("Data_Emissao");                        

                        lista.Add(model);
                    }
                    FecharBanco(cn);
                    return lista;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
