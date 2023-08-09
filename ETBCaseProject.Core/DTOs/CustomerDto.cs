﻿namespace ETBCaseProject.Core.DTOs
{
    public class CustomerDto : BaseDto
    {
        public int Name { get; set; }
        public string MailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
