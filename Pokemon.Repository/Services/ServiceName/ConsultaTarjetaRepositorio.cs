using BP.API.Entidades;
using BP.API.Entidades.Excepciones;
using BP.Comun.Centralizada.Interfaces;
using BP.Comun.Extensiones;
using BP.Comun.Logs.Base.Handlers;
using BP.Functional;
using ServiceReference1;
using System.ServiceModel;
using Pokemon.Domain.Interfaces.Propiedades;
using Pokemon.Domain.Interfaces.Services.ServiceName;
using Pokemon.Entity;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;
using Pokemon.Repository.Configuraciones.Soap;

namespace Pokemon.Repository.Services.ServiceName
{
    public class ConsultaTarjetaRepositorio : IServiceNameRepositorio
    {
        private readonly IPropiedadesApi _iPropiedadesApi;
        private readonly IConfiguracionCentralizada _iConfiguracionCentralizada;
        private readonly IConsumirSoap _iConsumirSoap;

        public ConsultaTarjetaRepositorio(IPropiedadesApi iPropiedadesApi, IConfiguracionCentralizada iConfiguracionCentralizada, IConsumirSoap iConsumirSoap)
        {
            _iPropiedadesApi = iPropiedadesApi;
            _iConfiguracionCentralizada = iConfiguracionCentralizada;
            _iConsumirSoap = iConsumirSoap;
        }

        #region EjecutarConsultarCotizacion
        [Loggable]
        public async Task<Either<EError, ERespuesta<ETarjetas>>> EjecutarConsultaEstadosCuentasTarjetasCredito(EEntrada<EProveedor> entrada)
        {
            ETarjetas creditoSalida = new ETarjetas();
            ConsulatECTCResponse result = new ConsulatECTCResponse();

            TimeSpan TIMEOUT = new TimeSpan(0, 0, _iPropiedadesApi.ConsultarApi(EConstantes.TagTimeoutWSServicioSipecom).ToInt());

            BasicHttpBinding basicbinding = new BasicHttpBinding
            {
                CloseTimeout = TIMEOUT,
            };
            string url = _iConfiguracionCentralizada.ConsultarTag(_iPropiedadesApi.ConsultarApi(EConstantes.TagUrlConsultaECTCServiceClient));
            ConsultaECTCServiceClient cliente = new ConsultaECTCServiceClient(basicbinding, new EndpointAddress(url));

            ConsulatECTCRequest servicioInput = new ConsulatECTCRequest()
            {
                AplicaRetCuentas = false,
                CodProducto = entrada.BodyIn.Beneficiario.CodProducto,
                FechaFin = entrada.BodyIn.Beneficiario.FechaFin,
                FechaInicio = entrada.BodyIn.Beneficiario.FechaInicio,
                IdCliente = entrada.BodyIn.Ordenante.Identificacion
            };

            try
            {
                result = await _iConsumirSoap.ConsultaEstadosDeCuentaTCAsync(servicioInput, cliente);

                #region Ejemplo para obtener informacion del servicio
                if (result.Cortes != null)
                    result.Cortes.ForEach(item =>
                    {
                        var corte = new ETarjeta
                        {
                            CodProducto = item.CodProducto,
                            FechaCorte = item.FechaCorte,
                            IdDocumento = item.IdDocumento,
                            IdentCliente = item.IdentCliente,
                            NomProducto = item.NomProducto,
                            NombreCliente = item.NombreCliente,
                            NumTarjeta = item.NumTarjeta,
                            TipoBase = item.TipoBase
                        };
                        creditoSalida.ListaTarjeta.Add(corte);
                    });
                #endregion

            }
            catch (Exception ex)
            {
                if (ex.InnerException.IsNull())
                {
                    throw new CoreExcepcion(EConstantes.ValExpCodigo, EConstantes.Comp_Cot + ex.Message, this.GetFirstName(), EConstantes.Recurso001, _iPropiedadesApi.ConsultarCatalogo(EConstantes.TagBackendOpenShift), ex);
                }
                else
                {
                    throw new CoreExcepcion(EConstantes.ValExpCodigo, EConstantes.Comp_Cot + ex.InnerException.Message, this.GetFirstName(), EConstantes.Recurso001, _iPropiedadesApi.ConsultarCatalogo(EConstantes.TagBackendOpenShift), ex);
                }
            }
            return new ERespuesta<ETarjetas>()
            {
                HeaderOut = entrada.HeaderIn,
                BodyOut = creditoSalida,
                Error = new EError(this.GetFirstName(), EConstantes.Recurso001, _iPropiedadesApi.ConsultarCatalogo(EConstantes.TagBackendOpenShift))
                {
                    MensajeNegocio = string.Empty,
                    Mensaje = result.MsgError
                }
            };
        }
    }
    #endregion EjecutarConsultarCotizacion

}


