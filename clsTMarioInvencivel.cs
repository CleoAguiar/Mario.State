using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    public class clsTMarioInvencivel : IMario
    {
            public clsTMarioInvencivel() { }
            public IMario PegarCogumelo()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario ganhou 1000 pontos Continua MARIO INVENCIVEL");
                Console.WriteLine("Status: MARIO INVENCIVEL");
                Console.WriteLine("");
                return this;
            }
            public IMario PegarEstrela()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario ganhou 1000 pontos Continua MARIO INVENCIVEL");
                Console.WriteLine("Status: MARIO INVENCIVEL");
                Console.WriteLine("");
                return this;
            }
            public IMario PegarFlorDeFogo()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario ganhou 1000 pontos Continua MARIO INVENCIVEL");
                Console.WriteLine("Status: MARIO INVENCIVEL");
                Console.WriteLine("");
                return this;
            }
            public IMario ReceberDano()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario ganhou 1000 pontos Continua MARIO INVENCIVEL");
                Console.WriteLine("Status: MARIO INVENCIVEL");
                Console.WriteLine("");
                return this;
            }
            public String RetornarTipo()
            {
                return "MARIO INVENCIVEL";
            }

    }
}
