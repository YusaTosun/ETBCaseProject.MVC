namespace ETBCaseProject.MVC.Models.CustomerViewModels
{
    public class CustomerUpdateVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
