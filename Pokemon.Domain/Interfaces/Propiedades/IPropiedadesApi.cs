namespace Pokemon.Domain.Interfaces.Propiedades
{
    public interface IPropiedadesApi
    {
        string ConsultarApi(string key);
        string ConsultarCatalogo(string propiedad);
        string BackendOpenShift();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int PausaBackgroundService();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string BackendKafka();

    }
}
