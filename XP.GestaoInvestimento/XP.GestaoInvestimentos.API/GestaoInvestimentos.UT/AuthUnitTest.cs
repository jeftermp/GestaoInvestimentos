using GestaoInvestimentos.Domain.Auth;
using GestaoInvestimentos.Services;
using GestaoInvestimentos.Services.Class;
using Microsoft.EntityFrameworkCore.Query;
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
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.API.json");
            _configuration = configBuilder.Build();
        }

        [Fact]
        public void Authenticate_ValidLogin_ReturnsOk()
        {
            ////Arrange
            var usuarioService = new UsuarioService(_configuration);
            UserAuth validLogin = new UserAuth { Username = "useradim@hcor.com.br", Password = "123456789" };

            //// Act
            var result = usuarioService.Authenticate(validLogin);

            //// Assert
            Assert.NotNull(result.Token);
        }

        [Fact]
        public void Authenticate_InvalidLogin_ReturnsFalse()
        {
            //Arrange
            var usuarioService = new UsuarioService(_configuration);
            UserAuth validLogin = new UserAuth { Username = "useradim@hcor.com.br", Password = "somepass" };

            //// Act
            var result = usuarioService.Authenticate(validLogin);

            //// Assert
            Assert.Null(result.Token);
        }
    }
}