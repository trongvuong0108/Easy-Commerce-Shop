using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCommerceShop.Domain.ApplicationModels
{
    public class ApplicationMailMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string cc { get; set; }
        public string bcc { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
