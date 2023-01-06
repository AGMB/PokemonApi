using BP.API.Constantes;
using BP.API.Entidades;
using BP.API.Entidades.Excepciones;
using BP.API.Entidades.Extensiones;
using BP.Comun.Extensiones;
using BP.Comun.Logs.Base.Handlers;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Pokemon.Domain.Interfaces.Propiedades;
using Pokemon.Domain.Interfaces.Services.ServiceName;
using Pokemon.Entity;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;

namespace Pokemon.API.Controllers
{
    #region DEFINICION DE VERSION DE API

    [ApiVersion("1")]

    #endregion DEFINICION DE VERSION DE API FIN

    [Route(Controlador.RutaVersion)]
    [ApiController]
    public class ServicioBaseController : ControllerBase
    {
        private readonly IPropiedadesApi _iPropiedadesApi;
        private readonly IServiceNameInfraestructura _IServiceNameInfraestructura;
        public ServicioBaseController(IPropiedadesApi iPropiedadesApi,
            IServiceNameInfraestructura IServiceNameInfraestructura)
        {
            _iPropiedadesApi = iPropiedadesApi;
            _IServiceNameInfraestructura = IServiceNameInfraestructura;
        }

        #region ConsultarServicio01 
        /// <summary>
        /// Metodo GET para consultar la estructura de entrada que se usara en el servicio
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route(EConstantes.Recurso001)]
        [Loggable]
        public IActionResult ConsultarCliente01()
        {
            return Ok(new EEntrada<string>(new EHeader(), ""));
        }

        /// <summary>
        /// Metodo POST para consultar los datos de un cliente
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(EConstantes.Recurso001)]
        [Loggable]
        public async Task<IActionResult> ConsultarCliente01(EEntrada<EProveedor> entrada)
        {
            EError error = new EError(this.GetFirstName(), EConstantes.Recurso001, _iPropiedadesApi.ConsultarCatalogo(EConstantes.TagBackendOpenShift));

            ERespuesta<ETarjetas> salida = new ERespuesta<ETarjetas>(entrada?.HeaderIn, new ETarjetas(), error);

            try
            {
                return (await _IServiceNameInfraestructura.ConsultarTarjetas(entrada)).Match(
                    Left => StatusCode(HttpStatusCode.BadRequest.ToInt(), salida.AgregarError(Left)),
                    Right => Ok(Right));
            }
            catch (CoreNegocioError negocioError)
            {
                negocioError.ProcesarError(salida);
                return StatusCode(HttpStatusCode.BadRequest.ToInt(), salida);
            }
            catch (Exception excepcion)
            {
                excepcion.ProcesarError(salida);
            }
            return StatusCode(HttpStatusCode.InternalServerError.ToInt(), salida);
        }
        #endregion ConsultarCliente01 
    }
}
