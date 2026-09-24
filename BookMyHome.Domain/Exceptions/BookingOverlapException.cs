namespace BookMyHome.Domain.Exceptions
{
    public class BookingOverlapException : Exception
    {
        public BookingOverlapException(string message) : base(message) { }
    }
}