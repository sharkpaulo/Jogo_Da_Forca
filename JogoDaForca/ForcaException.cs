namespace JogoDaForca
{
    public class ForcaException : Exception
    {
        public ForcaException() { }
        public ForcaException(string message) : base("Aconteceu uma exceção -> " + message) { }
        public ForcaException(string message, Exception inner) : base("aconteceu uma exceção ->" + message, inner) { }
    }
}
