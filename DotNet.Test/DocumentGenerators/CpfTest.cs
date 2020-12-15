using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace DotNet.Test.DocumentGenerators
{
    [TestClass]
    public class CpfTest : BaseTest
    {
        private readonly Utils.DocumentGenerators.Cpf cpfGenerator = new Utils.DocumentGenerators.Cpf();
        private readonly Utils.DocumentsValidators.Cpf cpfValidator = new Utils.DocumentsValidators.Cpf();

        [TestMethod]
        public void Generate()
        {
            var response = Task.FromResult(AsyncOperation(() => cpfGenerator.Generate())).Result;

            string presentation = response.ToString();

            Assert.IsNotNull(presentation);
            Assert.IsTrue(cpfValidator.Validate(presentation));

            Console.WriteLine(presentation);
        }
    }
}
