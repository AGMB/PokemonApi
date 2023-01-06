namespace Pokemon.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class EConstantes
    {
        #region TAGS DE CATALGOS
        /// <summary>
        /// 
        /// </summary>
        public const string TagBackendOpenShift = "OPENSHIFT";
        /// <summary>
        /// 
        /// </summary>
        public const string TagTimeoutWSServicioSipecom = "TimeoutWSServicioSipecom";
        /// <summary>
        /// 
        /// </summary>
        public const string TagUrlConsultaECTCServiceClient = "ConexionServicioSipecom";

        /// <summary>
        /// 
        /// </summary>
        public const string Recurso001 = "ConsultarServicioBase01";

        /// <summary>
        /// 
        /// </summary>
        public const string Comp_Cot = "WCFConsultaECTC_APP/ConsultaECTCService: ";

        #endregion TAGS DE CATALGOS


        #region TAG CODIGO ERROR

        /// <summary>
        /// 
        /// </summary>
        public const string ValExpCodigo = "9999";

        /// <summary>
        ///     Código que representa el header nulo.
        /// </summary>
        public const string HeaderInNullCode = "0001";

        /// <summary>
        ///     Descripción que representa el header vacio.
        /// </summary>
        public const string HeaderInNullDescription = "LA CABECERA ES NULA O NO EXISTE";

        /// <summary>
        /// Device Hash takes it from claims
        /// </summary>
        public const string DispositivoNullCode = "0002";

        /// <summary>
        /// Device Hash takes it from claims
        /// </summary>
        public const string DispositivoNullDescription = "DISPOSITIVO NULO O VACÍO";

        /// <summary>
        /// Company code 0010 by default
        /// </summary>
        public const string EmpresaNullCode = "0003";

        /// <summary>
        /// Company code 0010 by default
        /// </summary>
        public const string EmpresaNullDescription = "EMPRESA NULA O VACÍA";

        /// <summary>
        /// Code channel defined by business architecture WSO2 will send in the Claim
        /// </summary>
        public const string CanalNullCode = "0004";

        /// <summary>
        /// Code channel defined by business architecture WSO2 will send in the Claim
        /// </summary>
        public const string CanalNullDescription = "CANAL NULO O VACÍO";

        /// <summary>
        /// Medium code defined by business architecture WSO2 will send in the Claim
        /// </summary>
        public const string MedioNullCode = "0005";

        /// <summary>
        /// Medium code defined by business architecture WSO2 will send in the Claim
        /// </summary>
        public const string MedioNullDescription = "MEDIO NULO O VACÍO";

        /// <summary>
        /// Application code defined by business architecture WSO2 will send in the Claim
        /// </summary>
        public const string AplicacionNullCode = "0006";

        /// <summary>
        /// Application code defined by business architecture WSO2 will send in the Claim
        /// </summary>
        public const string AplicacionNullDescription = "APLICACIÓN NULA O VACÍA";

        /// <summary>
        /// Code of the agency where the user is registered
        /// </summary>
        public const string AgenciaNullCode = "0007";

        /// <summary>
        /// Code of the agency where the user is registered
        /// </summary>
        public const string AgenciaNullDescription = "AGENCIA NULA O VACÍA";

        /// <summary>
        /// Application code defined by enterprise architecture each application must place this value is the transactional log transaction type.
        /// </summary>
        public const string TipoTransaccionNullCode = "0008";

        /// <summary>
        /// Application code defined by enterprise architecture each application must place this value is the transactional log transaction type.
        /// </summary>
        public const string TipoTransaccionNullDescription = "TIPO TRANSACCION NULA O VACÍA";

        /// <summary>
        /// Field describes the geolocation
        /// </summary>
        public const string GeolocalizacionNullCode = "0009";

        /// <summary>
        /// Field describes the geolocation
        /// </summary>
        public const string GeolocalizacionNullDescription = "GEOLOCALIZACION NULA O VACÍA";

        /// <summary>
        /// generic user of the default transaction
        /// </summary>
        public const string UsuarioNullCode = "0010";

        /// <summary>
        /// generic user of the default transaction
        /// </summary>
        public const string UsuarioNullDescription = "USUARIO NULO O VACÍO";

        /// <summary>
        /// HASH of the transaction component is generated with the uniqueness component
        /// </summary>
        public const string UnicidadNullCode = "0011";

        /// <summary>
        /// HASH of the transaction component is generated with the uniqueness component
        /// </summary>
        public const string UnicidadNullDescription = "UNICIDAD NULA O VACÍA";

        /// <summary>
        /// Unique identifier of the transaction
        /// </summary>
        public const string GuidNullCode = "0012";

        /// <summary>
        /// Unique identifier of the transaction
        /// </summary>
        public const string GuidNullDescription = "GUID NULO O VACÍO";

        /// <summary>
        /// date and time of transaction yyyyMMddhhmmssSSSS
        /// </summary>
        public const string FechaHoraNullCode = "0013";

        /// <summary>
        /// date and time of transaction yyyyMMddhhmmssSSSS
        /// </summary>
        public const string FechaHoraNullDescription = "FECHA-HORA NULA O VACÍA";

        /// <summary>
        /// Language WSO2 will send on the Claim
        /// </summary>
        public const string IdiomaNullCode = "0014";

        /// <summary>
        /// Language WSO2 will send on the Claim
        /// </summary>
        public const string IdiomaNullDescription = "IDIOMA NULO O VACÍO";

        /// <summary>
        /// Session generated in WSO2 is sent in the claim
        /// </summary>
        public const string SesionNullCode = "0015";

        /// <summary>
        /// Session generated in WSO2 is sent in the claim
        /// </summary>
        public const string SesionNullDescription = "SESION NULA O VACÍA";

        /// <summary>
        /// Client IP address
        /// </summary>
        public const string IpNullCode = "0016";

        /// <summary>
        /// Client IP address
        /// </summary>
        public const string IpNullDescription = "IP NULA O VACÍA";

        /// <summary>
        ///     Código que representa el body nulo.
        /// </summary>
        public const string BodyNullCode = "0017";

        /// <summary>
        ///     Descripción que representa el body vacio.
        /// </summary>
        public const string BodyNullDescription = "EL CUERPO DEL SERVICIO ES NULO O NO EXISTE";

        /// <summary>
        /// 
        /// </summary>
        public const string IdentificacionErrorCode = "0019";

        /// <summary>
        /// 
        /// </summary>
        public const string IdentificacionDescription = "Identificacion null o vacia";

        /// <summary>
        /// 
        /// </summary>
        public const string CifErrorCode = "0018";

        /// <summary>
        /// 
        /// </summary>
        public const string CifDescription = "CIF no es válido";

        /// <summary>
        /// 
        /// </summary>
        public const string CodigoError19 = "0019";

        /// <summary>
        /// 
        /// </summary>
        public const string CodigoError20 = "0020";

        /// <summary>
        /// 
        /// </summary>
        public const string CodigoError21 = "0021";

        /// <summary>
        /// 
        /// </summary>
        public const string CodigoError22 = "0022";

        /// <summary>
        /// 
        /// </summary>
        public const string DescriptionError22 = "Ha ocurrido un error al intentar invocar a bancs - CodErrTK.";

        /// <summary>
        /// 
        /// </summary>
        public const string CodErrOk = "0000";

        /// <summary>
        /// 
        /// </summary>
        public const string Flag4 = "i";

        /// <summary>
        /// 
        /// </summary>
        public const string ErrorType = "ERR";

        #endregion

        #region TAG URL
        public const string UrlSipecom = "http://10.60.24.23/WCFConsultaECTC_APP/ConsultaECTCService.svc";
        #endregion

    }
}
