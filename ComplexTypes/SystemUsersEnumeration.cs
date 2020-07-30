using System;

namespace Solidex.Core.Base.ComplexTypes
{
    public class SystemUsersEnumeration: TypeEnumeration
    {
        public Guid Identificator { get; set; }

        public SystemUsersEnumeration(string value, Guid id) : base(value)
        {
            Identificator = id;
        }

        public override bool Equals(object obj)
        {
            return Identificator.Equals(((SystemUsersEnumeration) obj).Identificator);
        }

        public static readonly SystemUsersEnumeration SystemMessage = new SystemUsersEnumeration("SystemMessage", Guid.Parse("00000000-0000-0000-0001-000000000000"));
        public static readonly SystemUsersEnumeration Autoremove = new SystemUsersEnumeration("Autoremove", Guid.Parse("00000000-0000-0000-0001-000000000001"));
        public static readonly SystemUsersEnumeration YandexCash = new SystemUsersEnumeration("YandexCash", Guid.Parse("00000000-0000-0000-0000-000000000010"));
        public static readonly SystemUsersEnumeration WalletOne = new SystemUsersEnumeration("WalletOne", Guid.Parse("00000000-0000-0000-0000-000000000011"));
        public static readonly SystemUsersEnumeration WebPay = new SystemUsersEnumeration("WebPay", Guid.Parse("00000000-0000-0000-0000-000000000012"));
        public static readonly SystemUsersEnumeration Alfabank = new SystemUsersEnumeration("Alfabank", Guid.Parse("00000000-0000-0000-0000-000000000013"));
        public static readonly SystemUsersEnumeration Privat24 = new SystemUsersEnumeration("Privat24", Guid.Parse("00000000-0000-0000-0000-000000000014"));

    }
}