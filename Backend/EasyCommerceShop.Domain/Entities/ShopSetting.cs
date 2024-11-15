﻿using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class ShopSetting : GenericEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameLocalized { get; set; } = string.Empty;
        public CountryLanguageDetail? CountrySettings { get; set; } 
        public string Banner { get; set; } = string.Empty;
    }
}
