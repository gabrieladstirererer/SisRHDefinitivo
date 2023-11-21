//using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using SisRH.Classes;
using SisRHDefinitivo.Core.Models;
using System.Data;
using System.Data.SqlClient;

namespace SisRHDefinitivo.Core.Repository
{
    public class FolhaPontoRepository : Conexao
    {
       
        public List<FolhaPonto> ConsultarFolhaPonto(int matricula, int mes, int dia, int ano)
        {
            try
            {
                ConectarBanco();
                cmd = new SqlCommand("ConsultarFolhaPonto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prof", matricula);
                cmd.Parameters.AddWithValue("@mes", mes);
                cmd.Parameters.AddWithValue("@dia", dia);
                cmd.Parameters.AddWithValue("@ano", ano);
               

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable folha = new DataTable();
                    folha.Load(dr);

                    List<FolhaPonto> lista = new List<FolhaPonto>();

                    foreach (DataRow row in folha.Rows)
                    {
                        FolhaPonto model = new FolhaPonto();

                        model.Nome_Func = Convert.ToString(row["Nome"]);
                        model.Dt_apont_fp = Convert.ToString(row["Data1"]);
                        model.Hr_apont_fp_E1 = row.IsNull("E1") ? (TimeSpan?)null : row.Field<TimeSpan>("E1");
                        model.Hr_apont_fp_S1 = row.IsNull("S1") ? (TimeSpan?)null : row.Field<TimeSpan>("S1");
                        model.Hr_apont_fp_E2 = row.IsNull("E2") ? (TimeSpan?)null : row.Field<TimeSpan>("E2");
                        model.Hr_apont_fp_S2 = row.IsNull("S2") ? (TimeSpan?)null : row.Field<TimeSpan>("S2");
                        model.Hr_apont_fp_E3 = row.IsNull("E3") ? (TimeSpan?)null : row.Field<TimeSpan>("E3");
                        model.Hr_apont_fp_S3 = row.IsNull("S3") ? (TimeSpan?)null : row.Field<TimeSpan>("S3");
                        model.Desc_adv_fp = Convert.ToString(row["Observacao"]);
                        model.Horas_trabalhadas = Convert.ToString(row["horas_trabalhadas"]);
                        model.Horas_extras = Convert.ToString(row["horas_extras"]);

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
