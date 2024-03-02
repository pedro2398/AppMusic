using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusicCL.Models
{
    public class Playlist : ExibeMusica
    {
        private string title;
        private List<Musica> musicas;

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        { 
            this.title = title;
        }

        public List<Musica> getMusicas() 
        {
            return musicas;
        }

        public void addMusica(Musica musica)
        {
            this.musicas.Add(musica);
        }

        public Playlist()
        {
        
        }

        //construtor convencional
        public Playlist(string title, List<Musica> musicas) 
        {
            this.title = title;
            this.musicas = musicas;
        }

        //metodo sobrescrito
        protected override void exibeMusica(List<Musica> musicas)
        {
            this.exbibePlaylist();
            musicas.ForEach(item =>
            {
                Console.WriteLine(item.ToString());
            });
        }

        //metodo private
        private void exbibePlaylist()
        {
            Console.WriteLine($"Musicas da playlist: {this.getTitle}");
        }
    }
}
