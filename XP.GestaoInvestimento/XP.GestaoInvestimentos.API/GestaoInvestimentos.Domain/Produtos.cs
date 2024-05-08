namespace GestaoInvestimentos.Domain
{
    public class Produto
    {
        #region Properties
        public int ID { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string UsuarioCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public string? UsuarioAlteracao { get; set; }
        public decimal? ValorMinimo { get; set; }
        public decimal? ValorMaximo { get; set; }
        public decimal? TaxaJurosMensal { get; set; }
        public string TaxasExtras { get; set; }
        public int? TempoMinimoResgate { get; set; }
        public DateTime? DataVencimento { get; set; }
        #endregion

        #region Constructors
        public Produto()
        {
        }
        
        public Produto(string descricao, string usuarioCadastro, decimal? valorMinimo, decimal? valorMaximo, decimal? taxaJurosMensal, string taxasExtras, int? tempoMinimoResgate, DateTime? dataVencimento)
        {
            Descricao = descricao;
            DataCadastro = DateTime.Now;
            UsuarioCadastro = usuarioCadastro;
            ValorMinimo = valorMinimo;
            ValorMaximo = valorMaximo;
            TaxaJurosMensal = taxaJurosMensal;
            TaxasExtras = taxasExtras;
            TempoMinimoResgate = tempoMinimoResgate;
            DataVencimento = dataVencimento;
        }
        #endregion
    }
}
