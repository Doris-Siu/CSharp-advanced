
namespace CSharp_advanced
{
    public class YouTubeException : Exception
    {
        // create a constructor here - wrap the actual Exception as an inner exception of the custom one
        public YouTubeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}