namespace Web.Models
{
    public class Image:BaseEntity
    {
        public string Url { get; set; }
       
        public Guid AdminId { get; set; }
        public virtual Admin Admin { get; set; }

    }
}
