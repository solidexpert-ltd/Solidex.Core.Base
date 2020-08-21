

using Solidex.Core.Base.ComplexTypes;
using Solidex.Core.Base.Enums;

namespace Solidex.Core.Base.Infrastructure
{
	public interface ICurrencyConverter
	{
		double Convert(double amount, Currency c1, Currency c2);
		Money Convert(Money m1, Currency c1);
	}
}