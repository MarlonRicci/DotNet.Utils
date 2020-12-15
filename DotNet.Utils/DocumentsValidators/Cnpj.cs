namespace DotNet.Utils.DocumentsValidators
{
    public class Cnpj
    {
        public bool Validate(string cnpj)
        {
            int sum = 0;
            string digits = string.Empty;

            int[] multiplier1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim()
                       .Replace(".", "")
                       .Replace("-", "")
                       .Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            for (int i = 0; i < 12; i++)
                sum += int.Parse(cnpj[i].ToString()) * multiplier1[i];

            digits += GenerateDigit(sum);

            sum = 0;

            for (int i = 0; i < 13; i++)
                sum += int.Parse(cnpj[i].ToString()) * multiplier2[i];

            digits += GenerateDigit(sum);

            return cnpj.EndsWith(digits);
        }

        private int GenerateDigit(int sum)
        {
            var rest = sum % 11;

            return (rest < 2) ? 0 : 11 - rest;
        }
    }
}
