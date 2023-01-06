namespace Pokemon.Entity.Services.ServiceName.Entrada
{
    public class EProveedor
    {
        public EOrdenante Ordenante { get; set; } = new EOrdenante();
        public EBeneficiario Beneficiario { get; set; } = new EBeneficiario();

    }
}
