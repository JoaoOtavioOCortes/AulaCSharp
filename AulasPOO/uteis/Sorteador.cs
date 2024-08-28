using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{
    public class Sorteador
    {
        public List<string> NomesSorteados(List<string> nomes)
        {
            Random random = new Random();
            List<string> result = new List<string>();
            for (int i = nomes.Count; i > 0; i--)
            {
                int randomIndex = random.Next(i);
                result.Add(nomes[randomIndex]);
                nomes.Remove(nomes[i]);
            }
            return result;
            
        }
    }
}
