using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    public class clsTMarioFlordeFogo : IMario
    {
            public clsTMarioFlordeFogo() { }
            public IMario PegarCogumelo()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario Pega um GROW UP");
                Console.WriteLine("Mario ganhou 1000 pontos");
                Console.WriteLine("Status: MARIO FIRE FLOWER");
                Console.WriteLine("");
                return this;
            }
            public IMario PegarEstrela()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario Pega STARMAN");
                Console.WriteLine("Status: MARIO INVENCIVEL");
                Console.WriteLine("");
                return new clsTMarioInvencivel();
            }
            public IMario PegarFlorDeFogo()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario Pega FIRE FLOWER");
                Console.WriteLine("Mario ganhou 1000 pontos");
                Console.WriteLine("Status: MARIO FIRE FLOWER");
                Console.WriteLine("");
                return this;
            }
            public IMario ReceberDano()
            {
                Console.WriteLine("");
                Console.WriteLine("Mario é atingido");
                Console.WriteLine("Status: SUPER MARIO");
                Console.WriteLine("");
                return new clsTSuperMario();
            }
            public String RetornarTipo()
            {
                return "MARIO FLOR DE FOGO";
            }

    }
}
