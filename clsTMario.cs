using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    public class clsTMario : IMario
    {            

            public clsTMario() { }
            public IMario PegarCogumelo() 
            {
                Console.WriteLine("");
                Console.WriteLine("Mario Pega um GROW UP");
                Console.WriteLine("Status: SUPER MARIO");
                Console.WriteLine("");
                return new clsTSuperMario();
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
                Console.WriteLine("Status: MARIO MORTO");
                Console.WriteLine("");
                return new clsTMarioMorto();
            }
            public String RetornarTipo()
            {
                return "MARIO";
            }        
    }
}
