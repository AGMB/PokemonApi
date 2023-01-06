using BP.Comun.Extensiones;
using BP.Comun.Propiedades;
using BP.Comun.Propiedades.Entidades;
using Pokemon.Domain.Interfaces.Propiedades;
using Pokemon.Entity;

namespace Pokemon.Repository.Configuraciones.Api
{
    /// <summary>
    /// Clase Principal para la Configuracion del servicio 
    /// Metodos para las consultas de los parametros del Servicio 
    /// </summary>
    public class PropiedadesApi : IPropiedadesApi
    {

        private readonly Propiedades configuracionCatalogos;
        private readonly Propiedades configuracionApi;

        /// <summary>
        /// Constructror de la Clase con la lectura del archivo 
        /// </summary>
        public PropiedadesApi()
        {
            // carga archivo de catalogos
            configuracionCatalogos = new Propiedades(Constantes.DirectorioCatalogos);

            // Carga del Archivo de Configuracion
            configuracionApi = new Propiedades(string.Format(Constantes.DirectorioMicroservicio, this.GetFirstName().ToLower()));

        }

        #region Consulta de Catalogos y Configuracion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string ConsultarApi(string key)
        {
            return configuracionApi.Get(key);
        }

        /// <summary>
        ///  Obtiene dato catalogo segun propiedad 
        /// </summary>
        /// <param name="propiedad"></param>
        /// <returns></returns>
        public string ConsultarCatalogo(string propiedad)
        {
            return configuracionCatalogos.Get(propiedad);
        }

        /// <summary>
        /// Obtiene codigo BackendOpenShift
        /// </summary>
        /// <returns></returns>
        public string BackendOpenShift()
        {
            return configuracionCatalogos.Get(EConstantes.TagBackendOpenShift);
        }

        /// <summary>
        /// Pausa BackgroundServices
        /// </summary>
        /// <returns></returns>
        public int PausaBackgroundService()
        {
            return configuracionApi.Get("PausaBGS").ToInt();
        }

        /// <summary>
        /// BackendKafka
        /// </summary>
        /// <returns></returns>
        public string BackendKafka()
        {
            return configuracionCatalogos.Get("KAFKA");
        }


        #endregion

    }
}

