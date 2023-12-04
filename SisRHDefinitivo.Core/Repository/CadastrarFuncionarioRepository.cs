using SisRH.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisRHDefinitivo.Core.Models;

namespace SisRHDefinitivo.Core.Repository
{
    public class CadastrarFuncionarioRepository : Conexao
    {
        public bool CadastrarFunc(CadastrarFuncModel cfm)
        {
            try
            {
                ConectarBanco();
                cmd = new SqlCommand("CadastrarFunc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@primeiro_nm_func", cfm.primeiro_nm_func);
                cmd.Parameters.AddWithValue("@sobre_nm_func", cfm.sobre_nm_func);
                cmd.Parameters.AddWithValue("@ultimo_nm_func", cfm.ultimo_nm_func);
                cmd.Parameters.AddWithValue("@matricula_func", cfm.matricula_func);
                cmd.Parameters.AddWithValue("@dt_nasc_func", cfm.dt_nasc_func);
                cmd.Parameters.AddWithValue("@sexo_func", cfm.sexo_func);
                cmd.Parameters.AddWithValue("@raca_func", cfm.raca_func);
                cmd.Parameters.AddWithValue("@tipo_sanguineo_func", cfm.tipo_sanguineo_func);
                cmd.Parameters.AddWithValue("@nm_mae_func", cfm.nm_mae_func);
                cmd.Parameters.AddWithValue("@nm_pai_func", cfm.nm_pai_func);
                cmd.Parameters.AddWithValue("@estado_civil_func", cfm.estado_civil_func);
                cmd.Parameters.AddWithValue("@nome_conjunge_func", cfm.nome_conjunge_func);
                cmd.Parameters.AddWithValue("@cidade_nasc", cfm.cidade_nasc);
                cmd.Parameters.AddWithValue("@numero_res_func", cfm.numero_res_func);
                cmd.Parameters.AddWithValue("@compl_func", cfm.compl_func);
                cmd.Parameters.AddWithValue("@tipo_moradia_func", cfm.tipo_moradia_func);
                cmd.Parameters.AddWithValue("@celular_func", cfm.celular_func);
                cmd.Parameters.AddWithValue("@whatsapp_func", cfm.whatsapp_func);
                cmd.Parameters.AddWithValue("@telefone_func", cfm.telefone_func);
                cmd.Parameters.AddWithValue("@email_func", cfm.email_func);
                cmd.Parameters.AddWithValue("@email_corp_func", cfm.email_corp_func);
                cmd.Parameters.AddWithValue("@num_agen_func", cfm.num_agen_func);
                cmd.Parameters.AddWithValue("@num_conta_func", cfm.num_conta_func);
                cmd.Parameters.AddWithValue("@fk_cargo", cfm.fk_cargo);
                cmd.Parameters.AddWithValue("@fk_banco", cfm.fk_banco);
                cmd.Parameters.AddWithValue("@cpf_func", cfm.cpf_func);
                cmd.Parameters.AddWithValue("@rg_func", cfm.rg_func);
                cmd.Parameters.AddWithValue("@dt_emissao_func", cfm.dt_emissao_func);
                cmd.Parameters.AddWithValue("@orgao_emissor_func", cfm.orgao_emissor_func);
                cmd.Parameters.AddWithValue("@reservista_func", cfm.reservista_func);
                cmd.Parameters.AddWithValue("@titulo_eleitor_func", cfm.titulo_eleitor_func);
                cmd.Parameters.AddWithValue("@zona_eleitor_func", cfm.zona_eleitor_func);
                cmd.Parameters.AddWithValue("@sessao_eleitor_func", cfm.sessao_eleitor_func);
                cmd.Parameters.AddWithValue("@cidade_eleitor_func", cfm.cidade_eleitor_func);
                cmd.Parameters.AddWithValue("@escolaridade_func", cfm.escolaridade_func);
                cmd.Parameters.AddWithValue("@cns_func", cfm.cns_func);
                cmd.Parameters.AddWithValue("@cert_nasc_func", cfm.cert_nasc_func);
                cmd.Parameters.AddWithValue("@cert_casamento_func", cfm.cert_casamento_func);
                cmd.Parameters.AddWithValue("@comprovante_res_func", cfm.comprovante_res_func);
                cmd.Parameters.AddWithValue("@nacionalidade_func", cfm.nacionalidade_func);
                cmd.Parameters.AddWithValue("@st_status_func", cfm.st_status_func);
                cmd.Parameters.AddWithValue("@Fk_dep", cfm.Fk_dep);
                cmd.Parameters.AddWithValue("@fk_cep", cfm.fk_cep);
                cmd.Parameters.AddWithValue("@Jornada_func", cfm.Jornada_func);
                cmd.Parameters.AddWithValue("@ST_Ativo", cfm.ST_Ativo);

                FecharBanco(cn);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
