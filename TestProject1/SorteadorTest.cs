using AulasPOO.uteis;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class SorteadorTest
    {
        [TestMethod]
        public void MesmoTamanhoTest()
        {
            //Cenário
            List<string> nomes = ["Joao", "Lucas", "Daniel", "Rafael"];
            List<string> result = new List<string>();
            var sort = new Sorteador();
            //ação
            result = sort.NomesSorteados(nomes);
            //teste
            Assert.AreEqual(nomes.Count, result.Count);
        }
        [TestMethod]
        public void MesmoValorTest()
        {
            //Cenário
            List<string> nomes = ["Joao", "Lucas", "Daniel", "Rafael"];
            List<string> result = new List<string>();
            var sort = new Sorteador();
            //ação
            result = sort.NomesSorteados(nomes);
            //teste
            foreach (string nome in nomes)
            {
                Assert.IsTrue(result.Contains(nome));
            }

        } 
    }
}
