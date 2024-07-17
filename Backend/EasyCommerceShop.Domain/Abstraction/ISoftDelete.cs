namespace EasyCommerceShop.Domain.Abstraction
{
    public interface ISoftDelete
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeleteAt { get; set; }
        public void Undo() 
        {
            IsDeleted = false;
            DeleteAt = null;
        }
    }
}
