using BP.API.Entidades;
using BP.API.Entidades.Excepciones;
using BP.Functional;
using Moq;
using NUnit.Framework;
using Pokemon.Domain.Interfaces.Services.ServiceName;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;
using Pokemon.Infrastructure.Services.ServiceName;
using Pokemon.Test.Utilitarios.Services.ServiceName;

namespace Pokemon.Test.InfraestructuraTest.Services.ServiceName
{
    public class ServiceNameInfraestructuraTest
    {
        #region Private

        /// <summary>
        /// 
        /// </summary>
        private DataEntrada dataEntrada;

        /// <summary>
        /// 
        /// </summary>
        private Mock<IServiceNameRepositorio> _mockIServiceNameRepositorio;

        /// <summary>
        /// 
        /// </summary>
        private IServiceNameInfraestructura _iServiceNameInfraestructura;
        /// <summary>
        /// 
        /// </summary>
        private Either<EError, ERespuesta<ETarjetas>> result;

        #endregion Private

        [SetUp]
        public void Setup()
        {
            dataEntrada = new DataEntrada();

            _mockIServiceNameRepositorio = new Mock<IServiceNameRepositorio>();

            _iServiceNameInfraestructura = new ServiceNameInfraestructura(_mockIServiceNameRepositorio.Object);

            _mockIServiceNameRepositorio.Setup(r => r.EjecutarConsultaEstadosCuentasTarjetasCredito(It.IsAny<EEntrada<EProveedor>>())).ReturnsAsync(result);
            _mockIServiceNameRepositorio.Verify();
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Obtener_ConsultaEstadosCuentasTarjetasCredito_ReturnsListaTarjetas()
        {

            // Act
            var respuesta = _iServiceNameInfraestructura.ConsultarTarjetas(dataEntrada._eProveedor);

            // Assert
            Assert.DoesNotThrowAsync(async () => await respuesta);
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Obtener_ConsultaEstadosCuentasTarjetasCredito_ReturnsCoreNegocioError()
        {
            // Arrange
            dataEntrada._eProveedor.HeaderIn = null;

            // Act            
            var ex = _iServiceNameInfraestructura.ConsultarTarjetas(dataEntrada._eProveedor);

            // Assert
            Assert.ThrowsAsync<CoreNegocioError>(async () => await ex);

        }
    }
}
