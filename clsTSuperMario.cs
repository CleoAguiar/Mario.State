using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    public class clsTSuperMario : IMario
    {
        public clsTSuperMario() { }
        public IMario PegarCogumelo()
        {
            Console.WriteLine("");
            Console.WriteLine("Mario Pega uma GROW UP");
            Console.WriteLine("Mario ganhou 1000 pontos");
            Console.WriteLine("Status: SUPER MARIO");
            Console.WriteLine("");
            return this;
        }
        public IMario PegarEstrela()
        {
            Console.WriteLine("");
            Console.WriteLine("Mario Pega uma Starman");
            Console.WriteLine("Status: MARIO INVENCIVEL");
            Console.WriteLine("");
            return new clsTMarioInvencivel();
        }
        public IMario PegarFlorDeFogo()
        {
            Console.WriteLine("");
            Console.WriteLine("Mario Pega uma Fire Flower");
            Console.WriteLine("Status: MARIO FIRE FLOWER");
            Console.WriteLine("");
            return new clsTMarioFlordeFogo();
        }
        public IMario ReceberDano()
        {
            Console.WriteLine("");
            Console.WriteLine("Mario foi atingido");
            Console.WriteLine("Status: MARIO");
            Console.WriteLine("");
            return new clsTMario();
        }
        public String RetornarTipo()
        {
            return "SUPER MARIO";
        }
    }
}
