﻿using EasyCommerceShop.Domain.Abstraction;

namespace EasyCommerceShop.Domain.Entities
{
    public class Country : GenericEntity<int>
    {

        public string Name { get; set; } = string.Empty;
        public string NameLocalized { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DescriptionLocalized { get; set; } = string.Empty;
        public string CountryCode {  get; set; } = string.Empty;
        public float tax { get; set; }

        public virtual List<CountryLanguageDetail>? Languages { get; set; }
    }
}
