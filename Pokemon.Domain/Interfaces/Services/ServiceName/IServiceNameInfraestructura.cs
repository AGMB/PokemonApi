using BP.API.Entidades;
using BP.Functional;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;

namespace Pokemon.Domain.Interfaces.Services.ServiceName
{
    public interface IServiceNameInfraestructura
    {
        Task<Either<EError, ERespuesta<ETarjetas>>> ConsultarTarjetas(EEntrada<EProveedor> entrada);
    }
}