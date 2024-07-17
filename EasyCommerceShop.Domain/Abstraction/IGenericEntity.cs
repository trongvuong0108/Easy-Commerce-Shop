namespace EasyCommerceShop.Domain.Abstraction
{
    public interface IGenericEntity<TKey> : IAuditTable, ISoftDelete
    {
        public TKey Id { get; set; }
    }
}
