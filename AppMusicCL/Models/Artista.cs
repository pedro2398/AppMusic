using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMusicCL.Models
{
    public class Artista
    {
        private string name;
        private string bio;
        private List<Musica> musicas;

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getBio()
        {
            return bio;
        }

        public void setBio(string bio)
        {
            this.bio = bio;
        }

        public List<Musica> GetMusicas()
        {
            return musicas;
        }

        public void addMusica(Musica musica)
        {
            this.musicas.Add(musica);
        }

        public Artista()
        {
        
        }

        //construtor convencional
        public Artista(string name, string bio, List<Musica> musicas)
        {
            this.name = name;
            this.bio = bio;
            this.musicas = musicas;
        }

        //construtor que chama outro construtor
        public Artista(string nome, List<Musica> musicas) : this(nome, "bio não disponível", musicas)
        {

        }
    }
}
