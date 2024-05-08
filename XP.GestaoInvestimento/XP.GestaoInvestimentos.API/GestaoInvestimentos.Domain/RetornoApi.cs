namespace GestaoInvestimentos.Domain
{
    public class RetornoApi
    {
        #region properties
        public string? Date { get; set; }
        public bool HasError { get; set; }
        public string? Message { get; set; }
        public dynamic Object { get; set; }
        #endregion
    }
}