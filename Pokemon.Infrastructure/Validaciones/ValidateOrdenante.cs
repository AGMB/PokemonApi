using FluentValidation;
using Pokemon.Entity;
using Pokemon.Entity.Services.ServiceName.Entrada;

namespace Pokemon.Infrastructure.Validaciones
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidateOrdenante : AbstractValidator<EProveedor>
    {
        /// <summary>
        /// 
        /// </summary>
        public ValidateOrdenante()
        {
            RuleFor(eOrdenante => eOrdenante.Ordenante.Identificacion)
                .NotEmpty().WithMessage(EConstantes.IdentificacionDescription).WithErrorCode(EConstantes.IdentificacionErrorCode)
                .WithMessage(EConstantes.IdentificacionDescription).WithErrorCode(EConstantes.IdentificacionErrorCode);

        }
    }
}