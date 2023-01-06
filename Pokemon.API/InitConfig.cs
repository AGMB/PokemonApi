using BP.Comun.Centralizada.Interfaces;
using BP.Provider;
using BP.Provider.Configuration;
using Pokemon.Domain.Interfaces.Propiedades;

namespace Pokemon.API
{
    /// <summary>
    /// 
    /// </summary>
    public class InitConfig : IHostedService
    {
        /// <summary>
        /// Configuracion para Bancs
        /// </summary>
        private readonly IPropiedadesApi _iPropiedadesApi;

        /// <summary>
        /// 
        /// </summary>
        private readonly IConfiguracionCentralizada _iConfiguracionCentralizada;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iPropiedadesApi"></param>
        /// <param name="iConfiguracionCentralizada"></param>
        public InitConfig(IPropiedadesApi iPropiedadesApi, IConfiguracionCentralizada iConfiguracionCentralizada)
        {
            _iPropiedadesApi = iPropiedadesApi;
            _iConfiguracionCentralizada = iConfiguracionCentralizada;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Configurator config = new();
            ProviderConfiguration.Configure(config);
            Console.WriteLine("Carga Inicial Configuracion Centralizada");
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Finaliza Carga Configuracion Centralizada");
            return Task.CompletedTask;
        }
    }
}
