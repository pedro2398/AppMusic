using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusicCL.Models
{
    public class ExibeMusica
    {
        //metodo protected
        protected virtual void exibeMusica(List<Musica> list)
        {
            list.ForEach(item =>
            {
                Console.WriteLine(item.ToString());
            });
        }
    }
}
