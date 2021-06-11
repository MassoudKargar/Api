namespace Api.Domain.Exceptions
{
    public class UpdatePriceCannotBeMoreThenTenPercentException : ExceptionBase
    {
        public UpdatePriceCannotBeMoreThenTenPercentException(string message) : base(message)
        {
        }
    }
}
