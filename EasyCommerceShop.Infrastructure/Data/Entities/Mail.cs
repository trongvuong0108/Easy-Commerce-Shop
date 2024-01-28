using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Infrastructure.Data.Entities
{
    public class Mail
    {
        public Guid Id { get; set; }
        public string From  { get; set; }
        public string To  { get; set; }
        public string CC  { get; set; }
        public string Subject  { get; set; }
        public string Content  { get; set; }
    }
}
