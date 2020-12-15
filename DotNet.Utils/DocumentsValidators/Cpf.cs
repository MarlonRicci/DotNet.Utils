namespace DotNet.Utils.DocumentsValidators
{
    public class Cpf
    {
        public bool Validate(string cpf)
        {
            int sum = 0;
            string digits = string.Empty;

            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim()
                     .Replace(".", "")
                     .Replace("-", "");

            if (cpf.Length != 11)
                return false;

            for (int i = 0; i < 9; i++)
                sum += int.Parse(cpf[i].ToString()) * multiplier1[i];

            digits += GenerateDigit(sum);

            sum = 0;

            for (int i = 0; i < 10; i++)
                sum += int.Parse(cpf[i].ToString()) * multiplier2[i];

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
