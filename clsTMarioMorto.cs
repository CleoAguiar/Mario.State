using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    public class clsTMarioMorto : IMario
    {
        public clsTMarioMorto() { }
        public IMario PegarCogumelo()
        {
            Console.WriteLine("");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Status: MARIO MORTO");
            Console.WriteLine("");
            return new clsTMario();
        }
        public IMario PegarEstrela()
        {
            Console.WriteLine("");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Status: MARIO MORTO");
            Console.WriteLine("");
            return new clsTMario();
        }
        public IMario PegarFlorDeFogo()
        {
            Console.WriteLine("");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Status: MARIO MORTO");
            Console.WriteLine("");
            return new clsTMario();
        }
        public IMario ReceberDano()
        {
            Console.WriteLine("");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Status: MARIO MORTO");
            Console.WriteLine("");
            return new clsTMario();
        }
        public String RetornarTipo()
        {
            return "MARIO MORTO";
        }

    }
}
