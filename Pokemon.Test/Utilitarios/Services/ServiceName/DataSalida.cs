using ServiceReference1;

namespace Pokemon.Test.Utilitarios.Services.ServiceName
{
    public class DataSalida
    {
        public ConsulatECTCResponse mockStockData1;
        public DataSalida()
        {
            var cortes = new EstadoCuenta();

            cortes.CodProducto = "MCCHO112";
            cortes.FechaCorte = "24/03/2020";
            cortes.IdDocumento = "97";
            cortes.IdentCliente = "099268723001";
            cortes.NomProducto = "addad";
            cortes.NombreCliente = "Alex Adriano";
            cortes.NumTarjeta = "43533535xxxxx24242424";
            cortes.TipoBase = 1;

            mockStockData1 = new ConsulatECTCResponse();
            mockStockData1.CodError = "0";
            mockStockData1.MsgError = "Exito";
            EstadoCuenta[] datoscorte = new EstadoCuenta[1];
            datoscorte[0] = cortes;
            mockStockData1.Cortes = datoscorte;
        }
    }
}
