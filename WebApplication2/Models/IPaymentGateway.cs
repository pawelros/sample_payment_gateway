namespace WebApplication2.Models
{
    public interface IPaymentGateway
    {
        int Id { get; }
        PaymentGatewayResponse Book(decimal amount, string currency);
    }
}
