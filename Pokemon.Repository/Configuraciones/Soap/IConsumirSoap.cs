using ServiceReference1;

namespace Pokemon.Repository.Configuraciones.Soap
{
    public interface IConsumirSoap
    {
        Task<ConsulatECTCResponse> ConsultaEstadosDeCuentaTCAsync(ConsulatECTCRequest servicioInput, ConsultaECTCServiceClient cliente);
        Task<ECDocTCResponse> ConsultaDocEstadoDeCuentaTCAsync(ECDocTCRequest servicioInput, ConsultaECTCServiceClient cliente);
    }
}
