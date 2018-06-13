using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            /*
            IMario personagem;
            personagem = new TMario();

            
            personagem = personagem.PegarCogumelo();
            personagem = personagem.PegarFlorDeFogo();
            personagem = personagem.ReceberDano();
            personagem = personagem.PegarCogumelo();
            personagem = personagem.PegarCogumelo();
            personagem = personagem.PegarFlorDeFogo();
            personagem = personagem.ReceberDano();
            personagem = personagem.ReceberDano();
            personagem = personagem.PegarCogumelo();
            personagem = personagem.ReceberDano();
            personagem = personagem.ReceberDano();
            
            Console.WriteLine("SUPER MARIO");
            Console.Write("SUPER");
            Console.Read();
            */

        }
    }
}
