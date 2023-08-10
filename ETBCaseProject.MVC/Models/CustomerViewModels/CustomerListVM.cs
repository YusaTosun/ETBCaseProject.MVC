namespace ETBCaseProject.MVC.Models.CustomerViewModels
{
    public class CustomerListVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
