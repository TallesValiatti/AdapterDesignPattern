namespace AdapterDesignPattern.Services
{
    public class ServiceResult<T>
    {
        public bool Success { get; private set; }
        public string Message { get; private set; }
        public T? Data { get; private set; }

        private ServiceResult(bool success, string message, T? data)
        {
            this.Success = success;
            this.Message = message;
            this.Data = data;
        }

        public static ServiceResult<T> CreateSuccessfulResult(T data) => new ServiceResult<T>(true, string.Empty, data);
        
        public static ServiceResult<T> CreateFailedResult(string message) => new ServiceResult<T>(false, message, default(T));
    }
}