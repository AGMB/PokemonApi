using BP.API.Entidades;
using BP.Functional;
using Pokemon.Entity.DTO;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Domain.Interfaces.Services.PokeApi
{
    public interface IPokeApiRepositorio
    {
        Task<Either<EError, IList<EPokemonDto>>> ConsultarPokemons(int numberOfPokemons);
    }
}
