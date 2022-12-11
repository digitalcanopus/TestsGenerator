using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private Generator.Generator _generator = new();

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}