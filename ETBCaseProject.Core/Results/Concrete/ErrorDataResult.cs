namespace ETBCaseProject.Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Hata durumunda veri taşıyan sonuç nesnesi.
    /// </summary>
    /// <typeparam name="T">Verinin türü</typeparam>
    public class ErrorDataResult<T> : DataResult<T> where T : class
    {
        public ErrorDataResult() : base(default, false)
        { }
        public ErrorDataResult(string message) : base(default, false, message)
        { }
        public ErrorDataResult(T data, string message) : base(data, false, message)
        { }
    }
}
