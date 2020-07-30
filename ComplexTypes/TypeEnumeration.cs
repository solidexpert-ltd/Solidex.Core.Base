using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microcervices.Core.ComplexTypes
{
    public abstract class TypeEnumeration : IComparable
    {
        public string Value { get; set; }

        public TypeEnumeration(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public virtual int CompareTo(object obj)
        {
            return String.Compare(Value, ((TypeEnumeration) obj).Value, StringComparison.Ordinal);
        }

        public static IEnumerable<T> GetAll<T>() where T : TypeEnumeration
        {
            var fields = typeof(T).GetFields(BindingFlags.Public |
                                             BindingFlags.Static |
                                             BindingFlags.DeclaredOnly);

            return fields.Select(f => f.GetValue(null)).Cast<T>();
        }

    }

    
}