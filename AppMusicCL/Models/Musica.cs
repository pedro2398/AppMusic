using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusicCL.Models
{
    public class Musica
    {
        private string title;
        private Artista artista;
        private string album;

        public string getTitle() {
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

        public string getAlbum()
        {
            return album;
        }

        public void setAlbum(Album album)
        {
            this.album = album.getTitle();
        }

        public Musica()
        {
        
        }

        //construtor convencional
        public Musica(string title, Artista artista) 
        {
            this.title = title;
            this.artista = artista;
            this.album = "Single";
        }

        //construtor especializado
        public Musica(string title, Album album) 
        {
            this.title = title;
            this.artista = album.getArtista();
            this.album = album.getTitle();
        }

        //construtor convencional
        public Musica(string title, Artista artista, Album album)
        { 
            this.title = title;
            this.artista = artista;
            this.album = album.getTitle();
        }


    }
}
