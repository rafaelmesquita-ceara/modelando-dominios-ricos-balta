using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract<Name>()
                .Requires()
                .IsNotBetween(FirstName.Length, 3, 40, "Name.FirstName", "O nome deve conter entre 3 e 40 caracteres")
                .IsNotBetween(LastName.Length, 3, 40, "Name.LastName", "O sobrenome deve conter entre 3 e 40 caracteres")                
            );
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}