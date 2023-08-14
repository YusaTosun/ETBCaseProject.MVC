namespace ETBCaseProject.Core.Models
{
    /// <summary>
    /// Bütün entity'lerin miras alması gereken temel entity sınıfı
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
