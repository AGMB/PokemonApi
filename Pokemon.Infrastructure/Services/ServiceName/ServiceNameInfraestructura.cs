using BP.API.Entidades;
using BP.API.Entidades.Excepciones;
using BP.Comun.Extensiones;
using BP.Comun.Logs.Base.Handlers;
using BP.Functional;
using System.Reflection;
using Pokemon.Domain.Interfaces.Services.ServiceName;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;
using Pokemon.Infrastructure.Validaciones;

namespace Pokemon.Infrastructure.Services.ServiceName
{
    public class ServiceNameInfraestructura : IServiceNameInfraestructura
    {
        private readonly IServiceNameRepositorio _IServiceNameRepositorio;
        public ServiceNameInfraestructura(IServiceNameRepositorio iServiceNameRepositorio)
        {
            _IServiceNameRepositorio = iServiceNameRepositorio;
        }
        [Loggable]
        public async Task<Either<EError, ERespuesta<ETarjetas>>> ConsultarTarjetas(EEntrada<EProveedor> entrada)
        {
            var consultarValidacion = new ValidateEBasicoTransaccion();
            var validationResult = await consultarValidacion.ValidateAsync(entrada);

            if (!validationResult.IsValid)
            {
                var falla = validationResult.Errors.First();
                throw new CoreNegocioError(falla.ErrorCode, falla.ErrorMessage, this.GetFirstName(), MethodBase.GetCurrentMethod().DeclaringType.Name, "");
            }
            return await _IServiceNameRepositorio.EjecutarConsultaEstadosCuentasTarjetasCredito(entrada);
        }
    }
}
