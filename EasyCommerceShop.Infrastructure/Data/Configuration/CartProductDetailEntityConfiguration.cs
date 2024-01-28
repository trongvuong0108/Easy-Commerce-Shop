using EasyCommerceShop.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Infrastructure.Data.Configuration
{
    public class CartProductDetailEntityConfiguration : IEntityTypeConfiguration<CartProductDetail>
    {
        public void Configure(EntityTypeBuilder<CartProductDetail> builder)
        {
            throw new NotImplementedException();
        }
    }
}
