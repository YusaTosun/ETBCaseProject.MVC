namespace ETBCaseProject.Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Başarısızlık durumunu temsil eden sonuç nesnesi.
    /// </summary>
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        { }
        public ErrorResult(string message) : base(false, message)
        { }
    }
}
