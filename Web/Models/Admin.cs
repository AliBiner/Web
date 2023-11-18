namespace Web.Models
{
    public class Admin:BaseEntity
    {
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ImageId { get; set; }
        public virtual Image Image { get; set; }
        
        


    }
}
