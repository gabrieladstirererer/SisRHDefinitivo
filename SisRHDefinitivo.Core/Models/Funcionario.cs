namespace SisRHDefinitivo.Core.Models
{
    public class Funcionario
    {
        public int? id_func { get; set; }
        public string primeiro_nm_func { get; set; }
        public string sobre_nm_func { get; set; }
        public string ultimo_nm_func { get; set; }
        public int? matricula { get; set; }
        public DateTime? dt_nasc_func { get; set; }
        public bool sexo_func { get; set; }
        public int? raca_func { get; set; }
        public string tipo_sanguineo_func { get; set; }
        public string nm_mae_func { get; set; }
        public string nm_pai_func { get; set; }
        public string estado_civil_func { get; set; }
        public string nome_conjugue_func { get; set; }
        public string ponto_referencia { get; set; }
        public string cidade_nasc { get; set; }
        public int? numero_resr_func { get; set; }
        public string uf_residencial { get; set; }
        public string tipo_moradia { get; set; }
        public string celular_func { get; set; }
        public bool whatsapp_fun { get; set; }
        public string telefone_func { get; set; }
        public string email_func { get; set; }
        public string email_corp_func { get; set; }
        public string num_agen_func { get; set; }
        public string num_conta_func { get; set; }
        public int? fk_cargo { get; set; }
        public int? fk_dep { get; set; }
        public int? fk_banco { get; set; }
        public string cpf_funk { get; set; }
        public string rg_func { get; set; }
        public DateTime? dt_emissao_func { get; set; }
        public string orgao_emissor_func { get; set; }
        public string reservista_func { get; set; }
        public string titulo_eleitor_func { get; set; }
        public string zona_eleitor_func { get; set; }
        public string sessao_eleitor_func { get; set; }
        public string cidade_eleitor_func { get; set; }
        public string uf_eleitor_func { get; set; }
        public string escolaridade_func { get; set; }
        public string cns_func { get; set; }
        public string cert_nasc_func { get; set; }
        public string cert_casamento_func { get; set; }
        public string comprovante_res_func { get; set; }
        public string nacionalidade_func { get; set; }
        public int? st_status_func { get; set; }
    }
}
