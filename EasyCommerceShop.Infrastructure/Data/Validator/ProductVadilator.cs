using EasyCommerceShop.Infrastructure.Data.Entities;
using FluentValidation;

namespace EasyCommerceShop.Infrastructure.Data.Validator
{
    public class ProductVadilator : AbstractValidator<Product>
    {
        public ProductVadilator() 
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Thiếu tên kìa con đỉ ơi");
        }
    }
}
