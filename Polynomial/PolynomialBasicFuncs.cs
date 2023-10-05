namespace Polynomial;

public partial class Polynomial
{
    private static bool VariableTerm(string monomial) =>
        TermType.IsMatch(monomial);
    
    private static int StringToPower(string str, string monomial) =>
        int.TryParse(str, out var result) ? result : VariableTerm(monomial) ? 1 : 0;

    private static int StringToCoefficient(string str) =>
        int.TryParse(str, out var result) ? result : 1;
}