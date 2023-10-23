namespace SocialNetwork.BLL.Exceptions
{
    internal class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message) : base(message) { }
        public WrongPasswordException() { }
    }
}
