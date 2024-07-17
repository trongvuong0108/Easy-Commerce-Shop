namespace EasyCommerceShop.Domain.Abstraction;

public abstract class GenericEntity<TKey>: IGenericEntity<TKey>
{
    public DateTime? DateCreate { get; set; }
    public DateTime? DateChange { get; set; }
    public string? CreatedBy { get; set; }
    public string? ChangedBy { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeleteAt { get; set; }
    public TKey Id { get; set; }
}