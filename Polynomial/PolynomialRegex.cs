using System.Text.RegularExpressions;

namespace Polynomial;

public partial class Polynomial
{
    private static readonly Regex Monomial = MonomialRegex();
    private static readonly Regex MonomialValues = MonomialValuesRegex();
    private static readonly Regex TermType = TermTypeRegex();

    [GeneratedRegex(@"([+-]?\d*x(?:\^\d*)?)|([+-]\d*)")]
    private static partial Regex MonomialRegex();

    [GeneratedRegex(@"(?<coefficient>[+-]?\d*)(?:x)?\^?(?<power>\d*)?")]
    private static partial Regex MonomialValuesRegex();

    [GeneratedRegex(@"\w(?<!\d)")]
    private static partial Regex TermTypeRegex();
}