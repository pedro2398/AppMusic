using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusicCL.Models
{
    public class Album : ExibeMusica
    {
        private string title;
        private Artista artista;
        private List<Musica> musicas;

        public string getTitle() 
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public Artista getArtista() 
        {
            return artista;
        }

        public void setArtista(Artista artista)
        {
            this.artista = artista;
        }

        public List<Musica> getMusicasAlbum()
        {
            return musicas;
        }

        public void addMusica(Musica musica)
        {
            this.musicas.Add(musica);
        }

        public Album()
        {
        
        }

        //construtor convencional
        public Album(string title, Artista artista, List<Musica> musicas)
        {
            this.title = title;
            this.artista = artista;
            this.musicas = musicas; 
        }

        //metodo sobrescrito
        protected override void exibeMusica(List<Musica> musicas)
        {
            this.exibeAlbum();
            musicas.ForEach(item =>
            {
                Console.WriteLine(item.ToString());
            });
        }

        //metodo internal
        internal void exibeAlbum() 
        {
            Console.WriteLine($"Musicas do Album: {this.getTitle}");
        }
    }
}
