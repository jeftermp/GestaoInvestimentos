namespace XP.GestaoInvestimentos.Domain
{
    public class Cliente
    {
        #region properties
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime DataCadastro { get; set; }

        #endregion

        #region Constructors
        public Cliente()
        {
            
        }
        // Constructor with parameters
        public Cliente(string nome, string sobrenome, string email, string telefone, DateTime? dataNascimento)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            DataCadastro = DateTime.Now; // Default value for DataCadastro
        }
        #endregion
    }
}
