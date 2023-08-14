namespace ETBCaseProject.Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Başarılı bir işlem sonucunu temsil eden sonuç nesnesi.
    /// </summary>
    public class SuccessResult : Result
    {
        public SuccessResult() : base(true)
        { }
        public SuccessResult(string message) : base(true, message)
        { }

    }
}
