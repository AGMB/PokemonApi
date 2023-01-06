using BP.API.Entidades;
using BP.Comun.Extensiones;
using FluentValidation;
using Pokemon.Entity;

namespace Pokemon.Infrastructure.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidateHeaderIn : AbstractValidator<EHeader>
    {
        /// <summary>
        /// 
        /// </summary>
        public ValidateHeaderIn()
        {
            RuleFor(eHeader => eHeader)
                .Must(eHeader => !eHeader.Dispositivo.IsNullEmpty()).WithMessage(EConstantes.DispositivoNullDescription).WithErrorCode(EConstantes.DispositivoNullCode)
                .Must(eHeader => !eHeader.Empresa.IsNullEmpty()).WithMessage(EConstantes.EmpresaNullDescription).WithErrorCode(EConstantes.EmpresaNullCode)
                .Must(eHeader => !eHeader.Canal.IsNullEmpty()).WithMessage(EConstantes.CanalNullDescription).WithErrorCode(EConstantes.CanalNullCode)
                .Must(eHeader => !eHeader.Medio.IsNullEmpty()).WithMessage(EConstantes.MedioNullDescription).WithErrorCode(EConstantes.MedioNullCode)
                .Must(eHeader => !eHeader.Aplicacion.IsNullEmpty()).WithMessage(EConstantes.AplicacionNullDescription).WithErrorCode(EConstantes.AplicacionNullCode)
                .Must(eHeader => !eHeader.Agencia.IsNullEmpty()).WithMessage(EConstantes.AgenciaNullDescription).WithErrorCode(EConstantes.AgenciaNullCode)
                .Must(eHeader => !eHeader.TipoTransaccion.IsNullEmpty()).WithMessage(EConstantes.TipoTransaccionNullDescription).WithErrorCode(EConstantes.TipoTransaccionNullCode)
                .Must(eHeader => !eHeader.Geolocalizacion.IsNullEmpty()).WithMessage(EConstantes.GeolocalizacionNullDescription).WithErrorCode(EConstantes.GeolocalizacionNullCode)
                .Must(eHeader => !eHeader.Usuario.IsNullEmpty()).WithMessage(EConstantes.UsuarioNullDescription).WithErrorCode(EConstantes.UsuarioNullCode)
                .Must(eHeader => !eHeader.Unicidad.IsNullEmpty()).WithMessage(EConstantes.UnicidadNullDescription).WithErrorCode(EConstantes.UnicidadNullCode)
                .Must(eHeader => !eHeader.Guid.IsNullEmpty()).WithMessage(EConstantes.GuidNullDescription).WithErrorCode(EConstantes.GuidNullCode)
                .Must(eHeader => !eHeader.FechaHora.IsNullEmpty()).WithMessage(EConstantes.FechaHoraNullDescription).WithErrorCode(EConstantes.FechaHoraNullCode)
                .Must(eHeader => !eHeader.Idioma.IsNullEmpty()).WithMessage(EConstantes.IdiomaNullDescription).WithErrorCode(EConstantes.IdiomaNullCode)
                .Must(eHeader => !eHeader.Sesion.IsNullEmpty()).WithMessage(EConstantes.SesionNullDescription).WithErrorCode(EConstantes.SesionNullCode)
                .Must(eHeader => !eHeader.Ip.IsNullEmpty()).WithMessage(EConstantes.IpNullDescription).WithErrorCode(EConstantes.IpNullCode);
        }
    }
}