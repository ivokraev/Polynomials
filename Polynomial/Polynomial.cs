using System.Text;
using System.Text.RegularExpressions;

namespace Polynomial;

public partial class Polynomial
{
    private readonly SortedDictionary<int, int> _values = new();

    public Polynomial(string polynomialStr)
    {
        foreach (Match currMonomial in Monomial.Matches(polynomialStr.Trim()))
        {
            if (currMonomial.ToString().Length == 0) continue;
            var monomialValues = MonomialValues.Match(currMonomial.ToString());
            
            var currPower = StringToPower(monomialValues.Groups["power"].Value, monomialValues.Value);
            var currCoefficient = StringToCoefficient(monomialValues.Groups["coefficient"].Value);
            
            if (_values.ContainsKey(currPower)) _values[currPower] += currCoefficient;
            else _values.Add(currPower, currCoefficient);
        }
    }
}