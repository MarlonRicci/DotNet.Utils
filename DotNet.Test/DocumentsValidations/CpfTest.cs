using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace DotNet.Test.DocumentValidations
{
    [TestClass]
    public class CpfTest : BaseTest
    {
        private readonly Utils.DocumentValidations.Cpf cpfValidator = new Utils.DocumentValidations.Cpf();
        private readonly Utils.DocumentGenerators.Cpf cpfGenerator = new Utils.DocumentGenerators.Cpf();

        [TestMethod]
        public void Generate()
        {
            var response = Task.FromResult(AsyncOperation(() => cpfValidator.Validate(cpfGenerator.Generate()))).Result;

            Assert.IsTrue(response);

            Console.WriteLine(response);
        }
    }
}
