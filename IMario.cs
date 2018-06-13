using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario
{
    public interface IMario
    {
        IMario PegarCogumelo();
        IMario PegarEstrela();
        IMario PegarFlorDeFogo();
        IMario ReceberDano();
        String RetornarTipo();
    }
}
