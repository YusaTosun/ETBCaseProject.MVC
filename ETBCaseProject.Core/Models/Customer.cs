namespace ETBCaseProject.Core.Models
{
    public class Customer : BaseEntity
    {
        public string FullName { get; set; }
        public string MailAddress { get; set; } //todo : null uyarısını düzeltip düzeltmemeye karar ver
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
