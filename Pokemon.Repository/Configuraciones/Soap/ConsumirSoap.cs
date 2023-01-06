using BP.Comun.Logs.Base.Handlers;
using ServiceReference1;

namespace Pokemon.Repository.Configuraciones.Soap
{
    public class ConsumirSoap : IConsumirSoap
    {
        [Loggable]
        public async Task<ConsulatECTCResponse> ConsultaEstadosDeCuentaTCAsync(ConsulatECTCRequest servicioInput, ConsultaECTCServiceClient cliente)
        {
            return await cliente.ConsultaEstadosDeCuentaTCAsync(servicioInput);
        }
        [Loggable]
        public async Task<ECDocTCResponse> ConsultaDocEstadoDeCuentaTCAsync(ECDocTCRequest servicioInput, ConsultaECTCServiceClient cliente)
        {
            return await cliente.ConsultaDocEstadoDeCuentaTCAsync(servicioInput);
        }
    }
}
