namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>
    {
        public OperationResult()
        {
        }

        public OperationResult(T theResult, string message) : this()
        {
            this.Result = theResult;
            this.Message = message;
        }

        public T Result { get; set; }
        public string Message { get; set; }
    }

}
