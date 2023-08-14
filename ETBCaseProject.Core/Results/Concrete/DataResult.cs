namespace ETBCaseProject.Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Veri sonucu nesnesi, belirli bir türde veriyi ve işlem sonucunu taşır
    /// </summary>
    /// <typeparam name="T">Verinin türü</typeparam>
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public T Data { get; }
        public DataResult(T data, bool isSuccess) : base(isSuccess) => Data = data;
        public DataResult(T data, bool isSuccess, string message) : base(isSuccess, message) => Data = data;
    }
}
