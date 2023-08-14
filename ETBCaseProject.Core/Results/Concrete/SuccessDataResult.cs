namespace ETBCaseProject.Core.Utilities.Results.Concrete
{
    /// <summary>
    /// Başarılı bir işlem sonucunda veri taşıyan sonuç nesnesi.
    /// </summary>
    /// <typeparam name="T">Verinin türü</typeparam>
    public class SuccessDataResult<T> : DataResult<T>, IDataResult<T> where T : class
    {
        /// <summary>
        /// Başarılı durumda varsayılan bir SuccessDataResult örneği oluşturur.
        /// </summary>
        public SuccessDataResult() : base(default, true)
        { }
        /// <summary>
        /// Belirli bir mesajla bir SuccessDataResult örneği oluşturur.
        /// </summary>
        /// <param name="message">Sonuç mesajı</param>
        public SuccessDataResult(string message) : base(default, true, message)
        { }
        /// <summary>
        /// Belirli bir veri ve mesajla bir SuccessDataResult örneği oluşturur.
        /// </summary>
        /// <param name="data">Taşınacak veri</param>
        /// <param name="message">Sonuç mesajı</param>
        public SuccessDataResult(T data, string message) : base(data, true, message)
        { }
    }
}
