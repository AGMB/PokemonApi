using BP.API.Entidades.Excepciones;
using BP.Comun.Centralizada.Interfaces;
using Moq;
using NUnit.Framework;
using ServiceReference1;
using Pokemon.Domain.Interfaces.Propiedades;
using Pokemon.Domain.Interfaces.Services.ServiceName;
using Pokemon.Entity;
using Pokemon.Repository.Configuraciones.Soap;
using Pokemon.Repository.Services.ServiceName;
using Pokemon.Test.Utilitarios.Services.ServiceName;

namespace Pokemon.Test.RepositorioTest.Services.ServiceName
{
    public class ServiceNameRepositorioTest
    {
        #region Private

        /// <summary>
        /// 
        /// </summary>
        private DataEntrada dataEntrada;
        /// <summary>
        /// 
        /// </summary>
        private DataSalida dataSalida;

        /// <summary>
        /// 
        /// </summary>
        private IServiceNameRepositorio _iServiceNameRepositorio;

        /// <summary>
        /// 
        /// </summary>
        private Mock<IPropiedadesApi> _mockIPropiedadesApi;

        /// <summary>
        /// 
        /// </summary>
        private Mock<IConfiguracionCentralizada> _mockIConfiguracionCentralizada;

        /// <summary>
        /// 
        /// </summary>
        private Mock<IConsumirSoap> _mockIConsumirSoap;


        #endregion Private      

        [SetUp]
        public void Setup()
        {
            dataEntrada = new DataEntrada();
            dataSalida = new DataSalida();
            _mockIPropiedadesApi = new Mock<IPropiedadesApi>();
            _mockIConfiguracionCentralizada = new Mock<IConfiguracionCentralizada>();
            _mockIConsumirSoap = new Mock<IConsumirSoap>();


            _mockIConfiguracionCentralizada.Setup(p => p.ConsultarTag(EConstantes.TagUrlConsultaECTCServiceClient, false)).Returns(EConstantes.UrlSipecom);


            _mockIPropiedadesApi.Setup(p => p.ConsultarCatalogo(EConstantes.TagTimeoutWSServicioSipecom)).Returns(EConstantes.TagTimeoutWSServicioSipecom);
            _mockIPropiedadesApi.Setup(p => p.ConsultarApi(EConstantes.TagUrlConsultaECTCServiceClient)).Returns(EConstantes.TagUrlConsultaECTCServiceClient);


            _iServiceNameRepositorio = new ConsultaTarjetaRepositorio(_mockIPropiedadesApi.Object, _mockIConfiguracionCentralizada.Object, _mockIConsumirSoap.Object);

        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Obtener_ConsultaEstadosCuentasTarjetasCredito_ReturnsListaTarjetas()
        {
            // Arrange
            _mockIConsumirSoap.Setup(r => r.ConsultaEstadosDeCuentaTCAsync(It.IsAny<ConsulatECTCRequest>(), It.IsAny<ConsultaECTCServiceClient>())).ReturnsAsync(dataSalida.mockStockData1);

            // Act
            var respuesta = _iServiceNameRepositorio.EjecutarConsultaEstadosCuentasTarjetasCredito(dataEntrada._eProveedor);

            // Assert
            Assert.DoesNotThrowAsync(async () => await respuesta);
            _mockIConsumirSoap.VerifyAll();
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void Obtener_ConsultaEstadosCuentasTarjetasCredito_ReturnsCoreExcepcion()
        {
            // Arrange
            _mockIConsumirSoap.Setup(r => r.ConsultaEstadosDeCuentaTCAsync(It.IsAny<ConsulatECTCRequest>(), It.IsAny<ConsultaECTCServiceClient>())).ReturnsAsync(It.IsAny<ConsulatECTCResponse>());

            // Act 
            var ex = _iServiceNameRepositorio.EjecutarConsultaEstadosCuentasTarjetasCredito(dataEntrada._eProveedor);

            // Assert
            Assert.ThrowsAsync<CoreExcepcion>(async () => await ex);
            _mockIConsumirSoap.VerifyAll();
        }
    }
}
