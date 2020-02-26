using System.Collections.Generic;

namespace Plannoy.Domain.Transaction
{
    public class Money : ValueObject
    {
        public decimal Value { get; private set; }

        public Currency Currency { get; private set; }

        private Money()
        {
        }

        public Money(decimal value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }


        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
            yield return Currency;
        }
    }
}