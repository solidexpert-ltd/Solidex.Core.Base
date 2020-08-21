using System;
using Solidex.Core.Base.Enums;

namespace Solidex.Core.Base.ComplexTypes
{
    public class Money
    {
        public Money() { }

        public Money(Money price) : this(price.Amount, price.Currency)
        {
        }

        public Money(double v, Currency currency)
        {
            Amount = v;
            Currency = currency;
        }

        public double Amount { get; set; }

        public Currency Currency { get; set; }

        public static Money operator +(Money c1, Money c2)
        {
            if (c1.Currency != c2.Currency)
                throw new InvalidOperationException();
            return new Money(c1.Amount + c2.Amount, c1.Currency);
        }

        public static Money operator -(Money c1, Money c2)
        {
            if (c1.Currency != c2.Currency)
                throw new InvalidOperationException();
            return new Money(c1.Amount - c2.Amount, c1.Currency);
        }

        public static Money operator *(Money c1, double c2)
        {
            return new Money(c1.Amount * c2, c1.Currency);
        }

        public static Money operator /(Money c1, double c2)
        {
            return new Money(c1.Amount / c2, c1.Currency);
        }
    }
}