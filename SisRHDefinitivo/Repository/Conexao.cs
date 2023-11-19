using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SisRH.Classes
{
    public class Conexao
    {
        protected SqlConnection cn;

        protected SqlCommand cmd;

        protected SqlDataReader dr;

        protected SqlDataAdapter da;
        
        protected DataSet ds;

        protected DataTable dt;

        protected string instrucaoSql;

        protected  string stringConexao = "server=pim4semestreteste.database.windows.net;database=SisRH;user id=masteruserteste;password=SisRH@2023!;";

        public void ConectarBanco()
        {
            try
            {
                cn = new SqlConnection(stringConexao);
               
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
               
                
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao abrir o banco" + ex.Message);
            }
        }

        public void FecharBanco(SqlConnection minhaConexao)
        {
            try
            {
                if (minhaConexao.State == ConnectionState.Open)
                {
                    minhaConexao.Close();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao fechar o banco" + ex.Message);
            }
        }

       


    }
}
