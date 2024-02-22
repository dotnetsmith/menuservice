using FluentValidation.Results;

namespace MenuService
{
    public class Result<T>
    {
        public T Value { get; set; }
        public bool IsSuccess { get; set; }
        public IList<string> Error { get; set; }
        public IList<ValidationFailure> ValidationErrors { get; set; }

        private Result(T value, bool isSuccess, IList<string> error, IList<ValidationFailure> validationErrors)
        {
            Value = value;
            IsSuccess = isSuccess;
            Error = error;
            ValidationErrors = validationErrors;
        }

        public static Result<T> Success(T value) => 
            new Result<T>(value, true, new List<string>(), default!);
        public static Result<T> Failure(IList<string> error) => 
            new Result<T>(default!, false, error, default!);
        public static Result<T> ValidationFailure(IList<ValidationFailure> error) => 
            new Result<T>(default!, false, new List<string>(), error);
        
    }
}
