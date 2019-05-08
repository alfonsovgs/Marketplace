using Marketplace.Framework;
using System;

namespace Marketplace.Domain
{
    public class Money : Value<Money>
    {
        private const string DefaultCurrency = "EUR";

        public decimal Amount { get; set; }
        public string CurrencyCode { get; set; }

        protected Money(decimal amount, string currencyCode = "EUR")
        {
            if(decimal.Round(amount, 2) != amount) throw new ArgumentOutOfRangeException(nameof(amount), "Amount cannot have more that two decimals");
            Amount = amount;
            CurrencyCode = currencyCode;
        }

        public static Money FromDecimal(decimal amount, string currency = DefaultCurrency) => new Money(amount, currency);

        public static Money FromString(string amount, string currency = DefaultCurrency) => new Money(decimal.Parse(amount), currency);

        public Money Add(Money summand)
        {
            if (CurrencyCode != summand.CurrencyCode)
                throw new CurrencyMismatchException("Cannot sum amounts with different currencies");

            return new Money(Amount + summand.Amount);
        }

        public Money Substract(Money subtrahend)
        {
            if(CurrencyCode != subtrahend.CurrencyCode)
                throw new CurrencyMismatchException("Cannot subtract amounts with different currencies");

            return new Money(Amount - subtrahend.Amount);
        }

        public static Money operator +(Money summand1, Money summand2) => summand1.Add(summand2);

        public static Money operator -(Money minuend, Money subtrahend) => minuend.Add(subtrahend);
    }

    public class CurrencyMismatchException : Exception
    {
        public CurrencyMismatchException(string message) : base(message)
        {
            
        }
    }
}