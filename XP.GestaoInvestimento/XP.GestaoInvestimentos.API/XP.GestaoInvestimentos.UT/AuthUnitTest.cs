namespace XP.GestaoInvestimentos.UT
{
    public class AuthUnitTest
    {
        //private readonly IAuthRepository _authRepository;
        //private readonly IServiceLogger _serviceLogger;
        //private readonly IConfiguration _configuration;
        //private readonly IConexaoOracle _conexaoOracle;

        //public UnitTest1()
        //{
        //    _authRepository = Mock.Of<IAuthRepository>();
        //    _serviceLogger = Mock.Of<IServiceLogger>();
        //    _conexaoOracle = Mock.Of<IConexaoOracle>();
        //    // Set up configuration
        //    var configBuilder = new ConfigurationBuilder()
        //        .AddJsonFile("appsettings.json");
        //    _configuration = configBuilder.Build();
        //}

        [Fact]
        public void Authenticate_ValidLogin_ReturnsOk()
        {
            ////Arrange
            //var authRepository = new AuthRepository(_conexaoOracle, _configuration);
            //var validLogin = new LoginRequest { Login = "jmpeixoto", Password = "" };

            //// Act
            //var result = authRepository.LoginAd(validLogin);

            //// Assert
            //Assert.NotNull(result.Object);
        }

        [Fact]
        public void Authenticate_InvalidLogin_ReturnsFalse()
        {
            //Arrange
            //var authRepository = new AuthRepository(_conexaoOracle, _configuration);
            //var validLogin = new LoginRequest { Login = "jmpeixoto", Password = "somepass" };

            //// Act
            //var result = authRepository.LoginAd(validLogin);

            //// Assert
            //Assert.True(result.HasError);
        }
    }
}