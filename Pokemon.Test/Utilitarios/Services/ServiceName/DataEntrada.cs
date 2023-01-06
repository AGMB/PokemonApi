using BP.API.Entidades;
using BP.Comun.Extensiones;
using Pokemon.Entity.Services.ServiceName.Entrada;
using Pokemon.Entity.Services.ServiceName.Salida;

namespace Pokemon.Test.Utilitarios.Services.ServiceName
{
    public class DataEntrada
    {
        public EEntrada<EProveedor> _eProveedor;
        public ERespuesta<ETarjetas> respuesta;
        public DataEntrada()
        {
            _eProveedor = new EEntrada<EProveedor>()
            {
                HeaderIn = new EHeader()
                {
                    Ip = "10.0.176.22",
                    Canal = "01",
                    Medio = "010002",
                    Aplicacion = "00704",
                    Usuario = "USINTERT",
                    Guid = "99604a608faa4b58a9873a68edd5a6f7",
                    Empresa = "0010",
                    Agencia = "2",
                    TipoTransaccion = "dadad",
                    Dispositivo = "ada",
                    Geolocalizacion = "addad",
                    Unicidad = "adad",
                    FechaHora = "2022-04-24",
                    Idioma = "Ess",
                    Sesion = "adda",
                    Bancs = new EBancs()
                    {
                        Teller = "88888",
                        Agencia = "1",
                        Institucion = "3",
                        Terminal = "1"
                    }
                },
                BodyIn = new EProveedor()
                {
                    Beneficiario = new EBeneficiario
                    {
                        FechaFin = "2022-04-24",
                        FechaInicio = "2022-04-24",
                        CodProducto = ""
                    },
                    Ordenante = new EOrdenante
                    {
                        Identificacion = "0001",
                        TipoIdentificacion = "0604434572"
                    }
                }
            };
            var cortes = new List<ETarjeta>();
            cortes.Add(new ETarjeta()
            {
                CodProducto = "MCCHO112",
                FechaCorte = "24/03/2020",
                IdDocumento = "97",
                IdentCliente = "099268723001",
                NomProducto = "addad",
                NombreCliente = "Alex Adriano",
                NumTarjeta = "43533535xxxxx24242424",
                TipoBase = 1
            });

            respuesta = new ERespuesta<ETarjetas>()
            {
                BodyOut = new ETarjetas()
                {
                    ListaTarjeta = cortes

                },
                Error = new EError(this.GetFirstName(), "", "00674")
            };

        }
    }
}
