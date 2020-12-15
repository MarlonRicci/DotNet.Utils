using DotNet.Utils.DocumentGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace DotNet.Test.DocumentGenerators
{
    [TestClass]
    public class CpfTest : BaseTest
    {
        private readonly Cpf cpfGenerator = new Cpf();

        [TestMethod]
        public void Generate()
        {
            var response = Task.FromResult(AsyncOperation(() => cpfGenerator.Generate())).Result;

            string presentation = response.ToString();

            Assert.IsNotNull(presentation);

            Console.WriteLine(presentation);
        }
    }
}
