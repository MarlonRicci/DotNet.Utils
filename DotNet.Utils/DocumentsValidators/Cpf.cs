namespace DotNet.Utils.DocumentsValidators
{
    public class Cpf
    {
        public bool Validate(string cpf)
        {
            int sum = 0;
            string digits = string.Empty;

            cpf = cpf.Trim()
                     .Replace(".", "")
                     .Replace("-", "");

            if (cpf.Length != 11)
                return false;

            for (int i = 10; i > 1; i--)
                sum += int.Parse(cpf[10 - i].ToString()) * i;

            digits += GenerateDigit(sum);

            sum = 0;

            for (int i = 11; i > 1 ; i--)
                sum += int.Parse(cpf[11 - i].ToString()) * i;

            digits += GenerateDigit(sum);

            return cpf.EndsWith(digits);
        }

        private int GenerateDigit(int sum)
        {
            var rest = sum % 11;

            return (rest < 2) ? 0 : 11 - rest;
        }
    }
}
