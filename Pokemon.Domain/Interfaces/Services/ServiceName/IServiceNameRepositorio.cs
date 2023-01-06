using BP.API.Entidades;
using BP.Functional;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;

namespace Pokemon.Domain.Interfaces.Services.ServiceName
{
    public interface IServiceNameRepositorio
    {
        Task<Either<EError, ERespuesta<ETarjetas>>> EjecutarConsultaEstadosCuentasTarjetasCredito(EEntrada<EProveedor> entrada);
    }
}
