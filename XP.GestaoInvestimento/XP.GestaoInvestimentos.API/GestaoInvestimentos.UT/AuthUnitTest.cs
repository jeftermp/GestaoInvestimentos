using GestaoInvestimentos.Domain.Auth;
using GestaoInvestimentos.Services;
using GestaoInvestimentos.Services.Class;
using Microsoft.Extensions.Configuration;
using Moq;

namespace GestaoInvestimentos.UT
{
    public class AuthUnitTest
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IConfiguration _configuration;

        public AuthUnitTest()
        {
            _usuarioService = Mock.Of<IUsuarioService>();
            var configBuilder = new ConfigurationBuilder();
            _configuration = configBuilder.Build();
        }

        [Fact]
        public void Authenticate_ValidLogin_ReturnsOk()
        {
            ////Arrange
            UsuarioService usuarioService = new UsuarioService(_configuration);
            UserAuth validLogin = new UserAuth { Username = "useradim@hcor.com.br", Password = "123456789" };

            //// Act
            AuthenticateResponse result = _usuarioService.Authenticate(validLogin);

            //// Assert
            Assert.NotNull(result.Token);
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