using BP.API.Entidades;
using BP.Comun.Extensiones;
using BP.Comun.Rest;
using BP.Comun.Rest.Interfaces;
using BP.Functional;
using Newtonsoft.Json;
using Pokemon.Domain.Interfaces.Services.PokeApi;
using Pokemon.Entity;
using Pokemon.Entity.DTO;
using Pokemon.Entity.Services.PokeApi.Salida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Pokemon.Repository.Services.PokeApi
{
    public class PokeApiRepositorio : IPokeApiRepositorio
    { 
        private readonly IApi _iApi;

        public PokeApiRepositorio(IApi iApi)
        {
            _iApi= iApi;
        }
    
    
        public async Task<Either<EError, IList<EPokemonDto>>> ConsultarPokemons(int numberOfPokemons)
        {
            EPokeApiResult result = new EPokeApiResult();
            try
            {
                var apiResult = (await _iApi.GetAsync($"{EConstantes.URL_POKEMON_API}?limit={numberOfPokemons}"));
                if(!string.IsNullOrEmpty(apiResult.Values)) 
                {
                    List<EPokemonDto> pokemonList = new List<EPokemonDto>();
                    var pokemonesFull = JsonConvert.DeserializeObject<EPokeApiResult>(apiResult.Values);
                    pokemonesFull.results.ForEach(x =>
                    {
                        pokemonList.Add(new EPokemonDto
                        {
                            Name = x.name,
                            Url = x.url,
                        });
                    });

                    return pokemonList;
                }
                else
                {
                    return new EError(this.GetFirstName(), MethodBase.GetCurrentMethod()!.Name,"")
                    {
                        Tipo = "No hay Data que mostrar",
                        Codigo = apiResult.StatusCode.ToString(),
                        Mensaje = apiResult.Message,
                        MensajeNegocio = apiResult.LongMessage
                    };
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
