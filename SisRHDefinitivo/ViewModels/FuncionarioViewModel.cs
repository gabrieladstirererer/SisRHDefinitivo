using System.ComponentModel.DataAnnotations;

namespace SisRHDefinitivo.ViewModels
{
    public class FuncionarioViewModel
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

        [Display(Name = "Zona Eleitor Funcionario")]
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

        [Display(Name = "Comprovante Residencia" )]
        public string comprovante_res_func { get; set; }

        [Display(Name = "Complemento")]
        public string compl_func { get; set; }

        [Display(Name = "Nacionalidade")]
        public string nacionalidade_func { get; set; }

        [Display(Name = "Ponto De Referência")]
        public string  ponto_referencia { get; set; }

        [Display(Name = "Ativo")]
        public int? st_status_func { get; set; }
    }
}
