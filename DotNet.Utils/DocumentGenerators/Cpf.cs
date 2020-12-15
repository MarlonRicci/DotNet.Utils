using System;

namespace DotNet.Utils.DocumentGenerators
{
    public class Cpf
    {
        public string Generate()
        {
            int sum = 0, rest;
            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            string randomCpf = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                sum += int.Parse(randomCpf[i].ToString()) * multiplier1[i];

            rest = sum % 11;
            rest = (rest < 2) ? 0 : 11 - rest;

            randomCpf += rest;
            sum = 0;

            for (int i = 0; i < 10; i++)
                sum += int.Parse(randomCpf[i].ToString()) * multiplier2[i];

            rest = sum % 11;

            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            randomCpf += rest;
            return randomCpf;
        }
    }
}
