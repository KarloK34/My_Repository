using System.Runtime.Serialization;

namespace Zad1
{
    [Serializable]
    public class NoSuchDogInShelterException : Exception
    {
        public NoSuchDogInShelterException() { }
        public NoSuchDogInShelterException(string message) : base(message) { }
        public NoSuchDogInShelterException(string message, Exception innerException) 
            : base(message, innerException) { }
        protected NoSuchDogInShelterException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    }
}
