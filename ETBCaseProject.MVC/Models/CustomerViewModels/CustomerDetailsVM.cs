namespace ETBCaseProject.MVC.Models.CustomerViewModels
{
    public class CustomerDetailsVM
    {
        public CustomerDetailsVM()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age
        {
            get
            {
                TimeSpan difference = DateTime.Now - BirthDate;
                return (int)(difference.TotalDays / 365);
            }
        }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
