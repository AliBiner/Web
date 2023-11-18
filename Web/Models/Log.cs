namespace Web.Models
{
    public class Log
    {
        public Log()
        {
            Admins = new List<Admin>();
            Images = new List<Image>();
        }
        public Guid Id { get; set; }
        public Guid AdminId { get; set; }
        public Guid ImageId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public string IPAdress { get; set; }

        public virtual IList<Admin> Admins { get; set; }
        public virtual IList<Image> Images { get; set; }
    }
}
