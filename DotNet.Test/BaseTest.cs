using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace DotNet.Test
{
    [TestClass]
    public class BaseTest
    {
        [TestMethod]
        public dynamic AsyncOperation(Func<dynamic> func)
        {
            try
            {
                dynamic response = Task.Run(func).Result;

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
