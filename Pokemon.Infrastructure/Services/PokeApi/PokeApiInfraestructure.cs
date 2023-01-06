using BP.API.Entidades;
using BP.Functional;
using Pokemon.Domain.Interfaces.Services.PokeApi;
using Pokemon.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Infrastructure.Services.PokeApi
{
    public class PokeApiInfraestructure : IPokeApiInfraestructura
    {

        private readonly IPokeApiRepositorio _pokeApiRepositorio;

        public PokeApiInfraestructure(IPokeApiRepositorio pokeApiRepositorio)
        {
            _pokeApiRepositorio= pokeApiRepositorio;
        }
        public async Task<Either<EError, IList<EPokemonDto>>> ConsultarPokemons(int numberOfPokemons)
        {
            return await _pokeApiRepositorio.ConsultarPokemons(numberOfPokemons);
        }
    }
}
