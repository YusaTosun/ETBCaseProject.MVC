namespace ETBCaseProject.Core.DTOs
{
    /// <summary>
    /// Customer için özelleşmiş Data Transfer Object sınıfı.Customer Entity'si diğer entity'lerle ilişki kurduğu zaman gereksiz entity ve porperty'lerin taşınmasını önlemek için kullanılacak
    /// </summary>
    public class CustomerDto : BaseDto
    {
        public int Name { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
