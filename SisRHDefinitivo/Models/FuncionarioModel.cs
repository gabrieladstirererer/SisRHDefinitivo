using SisRHDefinitivo.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.Adm.Models
{
    public class FuncionarioModel
    {
        [Display(Name = "Cod. Funcionario")]
        public int? id_func { get; set; }

        [Display(Name = "Nome")]
        public string primeiro_nm_func { get; set; }

        [Display(Name ="Sobrenome")]
        public string sobre_nm_func { get; set; }

        [Display(Name = "Ultimo Nome")]
        public string ultimo_nm_func { get; set; }

        [Display(Name = "Prontuario")]
        public int? matricula { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_nasc_func { get; set; }

        [Display(Name = "Sexo")]
        public bool sexo_func { get; set; }

        [Display(Name = "Raça")]
        public int? raca_func { get; set; }

        [Display(Name ="Tipo Sanguineo")]
        public string tipo_sanguineo_func { get; set; }

        [Display(Name = "Nome da Mãe")]
        public string nm_mae_func { get; set; }

        [Display(Name = "Nome do Pai")]
        public string nm_pai_func { get; set; }

        [Display(Name = "Estado Civil")]
        public string estado_civil_func { get; set; }

        [Display(Name = "Nome Conjugue Funcionario")]
        public string nome_conjugue_func { get; set; }

        [Display(Name = "Cidade Nascimento" )]
        public string cidade_nasc { get; set; }

        [Display(Name = "Numero Residência")]
        public int? numero_resr_func { get; set; }

        [Display(Name = "UF Residêncial")]
        public string uf_residencial { get; set; }

        [Display(Name = "Tipo Moradia")]
        public string tipo_moradia { get; set; }

        [Display(Name = "Telefone(Celular)")]
        public string celular_func { get; set; }

        [Display(Name = "Whatsapp")]
        public bool whatsapp_fun { get; set; }

        [Display(Name = "Cidade")]
        public string DS_cidadae { get; set; }

        [Display(Name = "Telefone" )]
        public string telefone_func { get; set; }

        [Display(Name = "Email")]
        public string email_func { get; set; }

        [Display(Name = "Email Corporativo")]
        public string email_corp_func { get; set; }

        [Display(Name = "NUM.Agencia")]
        public string num_agen_func { get; set; }

        [Display(Name = "NUM.Conta")]
        public string num_conta_func { get; set;}

        [Display(Name = "Cargo")]
        public int? fk_cargo { get; set; }

        [Display(Name = "Departamento")]
        public int? fk_dep { get; set; }

        [Display(Name = "Banco")]
        public int? fk_banco { get; set; }

        [Display(Name = "CPF")]
        public string cpf_funk { get; set; }

        [Display(Name = "RG")]
        public string rg_func { get; set; }

        [Display(Name = "Data de Emissão")]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? dt_emissao_func { get; set; }

        [Display(Name = "Orgão Emissor")]
        public string orgao_emissor_func { get; set; }

        [Display(Name = "Reservista Funcionario")]
        public string reservista_func { get; set; }

        [Display(Name = "Titulo de Eleitor")]
        public string titulo_eleitor_func { get; set; }

        [Display(Name = "Zona Eleitoral")]
        public string zona_eleitor_func { get; set; }

        [Display(Name = "Sessão Eleitoral")]
        public string sessao_eleitor_func { get; set; }

        [Display(Name = "Cidade Eleitoral")]
        public string cidade_eleitor_func { get; set; }

        [Display(Name = "UF Eleitoral")]
        public string uf_eleitor_func { get; set; }

        [Display(Name = "Escolaridade")]
        public string escolaridade_func { get; set; }

        [Display(Name = "CNS")]
        public string cns_func { get; set; }

        [Display(Name = "Certidão De Nascimento")]
        public string cert_nasc_func { get; set; }

        [Display(Name = "Certidão Casamento")]
        public string cert_casamento_func { get; set; }

        [Display(Name = "Comprovante Residência" )]
        public string comprovante_res_func { get; set; }

        [Display(Name = "Complemento")]
        public string compl_func { get; set; }

        [Display(Name = "Nacionalidade")]
        public string nacionalidade_func { get; set; }

        [Display(Name = "Ponto De Referência")]
        public string  ponto_referencia { get; set; }

        [Display(Name = "Ativo")]
        public int? st_status_func { get; set; }

        public static implicit operator FuncionarioModel(
            Funcionario funcionarioModel)
        {
            return new FuncionarioModel()
            {
                id_func = funcionarioModel.id_func,
                primeiro_nm_func = funcionarioModel.primeiro_nm_func,
                sobre_nm_func = funcionarioModel.sobre_nm_func,
                ultimo_nm_func = funcionarioModel.ultimo_nm_func,
                matricula = funcionarioModel.matricula,
                dt_nasc_func = funcionarioModel.dt_nasc_func,
                sexo_func = funcionarioModel.sexo_func,
                raca_func = funcionarioModel.raca_func,
                tipo_sanguineo_func = funcionarioModel.tipo_sanguineo_func,
                nm_mae_func = funcionarioModel.nm_mae_func,
                nm_pai_func = funcionarioModel.nm_pai_func,
                estado_civil_func = funcionarioModel.estado_civil_func,
                nome_conjugue_func = funcionarioModel.nome_conjugue_func,
                cidade_nasc = funcionarioModel.cidade_nasc,
                numero_resr_func = funcionarioModel.numero_resr_func,
                uf_residencial = funcionarioModel.uf_residencial,
                tipo_moradia = funcionarioModel.tipo_moradia,
                celular_func = funcionarioModel.celular_func,
                whatsapp_fun = funcionarioModel.whatsapp_fun,
                telefone_func = funcionarioModel.telefone_func,
                email_func = funcionarioModel.email_func,
                email_corp_func = funcionarioModel.email_corp_func,
                num_agen_func = funcionarioModel.num_agen_func,
                num_conta_func = funcionarioModel.num_conta_func,
                fk_cargo = funcionarioModel.fk_cargo,
                fk_dep = funcionarioModel.fk_dep,
                fk_banco = funcionarioModel.fk_banco,
                cpf_funk = funcionarioModel.cpf_funk,
                rg_func = funcionarioModel.rg_func,
                dt_emissao_func = funcionarioModel.dt_emissao_func,
                orgao_emissor_func = funcionarioModel.orgao_emissor_func,
                reservista_func = funcionarioModel.reservista_func,
                titulo_eleitor_func = funcionarioModel.titulo_eleitor_func,
                zona_eleitor_func = funcionarioModel.zona_eleitor_func,
                sessao_eleitor_func = funcionarioModel.sessao_eleitor_func,
                cidade_eleitor_func = funcionarioModel.cidade_eleitor_func,
                uf_eleitor_func = funcionarioModel.uf_eleitor_func,
                escolaridade_func = funcionarioModel.escolaridade_func,
                cns_func = funcionarioModel.cns_func,
                cert_nasc_func = funcionarioModel.cert_nasc_func,
                cert_casamento_func = funcionarioModel.cert_casamento_func,
                comprovante_res_func = funcionarioModel.comprovante_res_func,
                nacionalidade_func = funcionarioModel.nacionalidade_func,
                ponto_referencia = funcionarioModel.ponto_referencia,
                st_status_func = funcionarioModel.st_status_func
            };
        }
    }
}
