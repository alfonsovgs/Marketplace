using System;
using Marketplace.Framework;

namespace Marketplace.Domain
{
    public class ClassifiedAdTitle : Value<ClassifiedAdTitle>
    {
        private readonly string _value;

        private ClassifiedAdTitle(string value)
        {
            if(value.Length > 100) throw new ArgumentOutOfRangeException("Title cannot be longer that 100 characters", nameof(value));
            _value = value;
        }

        public static ClassifiedAdTitle FromString(string title) => new ClassifiedAdTitle(title);
    }
}
