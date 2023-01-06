using BP.API.Entidades;
using BP.Functional;
using Pokemon.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Domain.Interfaces.Services.PokeApi
{
    public interface IPokeApiInfraestructura
    {
        Task<Either<EError, IList<EPokemonDto>>> ConsultarPokemons(int numberOfPokemons);
    }
}
