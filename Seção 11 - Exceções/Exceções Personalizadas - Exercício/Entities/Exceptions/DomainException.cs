using System;


namespace Exceções_Personalizadas___Exercício.Entities.Exceptions
{
     class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message){
        }
    }
}
