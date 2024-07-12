namespace EasyCommerceShop.OrderService.Application.Abstraction
{
    public interface IPaymentService
    {
        public Task<string> doPayment();
    }
}
