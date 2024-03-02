using AppMusicCL.Models;


//criando albuns
Album boogieNaipe = new Album();
boogieNaipe.setTitle("Boogie Naipe");

Album forcaBruta = new Album();
forcaBruta.setTitle("Força Bruta");

Album damn = new Album();
damn.setTitle("DAMN.");

Album testing = new Album();
testing.setTitle("Testing");

//criando musicas
Musica gangstaBoogie = new Musica();
gangstaBoogie.setTitle("Gangsta Boogie");

Musica louisLaine = new Musica();
louisLaine.setTitle("Louis Laine");

Musica oTelefoneTocouNovamente = new Musica();
oTelefoneTocouNovamente.setTitle("O telefone tocou novamente");

Musica obaLaVemEla = new Musica();
obaLaVemEla.setTitle("Oba, lá vem ela");

Musica fear = new Musica();
fear.setTitle("Fear.");

Musica dna = new Musica();
dna.setTitle("DNA.");

Musica praiseTheLord = new Musica();
praiseTheLord.setTitle("Praise the Lord");

Musica riot = new Musica();
riot.setTitle("Riot");


//criando os artistas
Artista manoBrown = new Artista();
manoBrown.setName("Mano Brown");
manoBrown.setBio("Nascido no Capão Redondo, na zona sul de São Paulo, Mano Brown é considerado o maior nome do Rap Nacional");

Artista jorgeBen = new Artista();
jorgeBen.setName("Jorge Ben");
jorgeBen.setBio("Com um ritmo inconfudivel e musicas mundialmente famosas, Jorge Ben é com certeza um dos maiores nomes da musica brasileira");

Artista kendrickLamar = new Artista();
kendrickLamar.setName("Kendrick Lamar");
kendrickLamar.setBio("Das ruas de Comptom para o mundo! Um dos maiores letristas da nossa geração");

//populando os artistas das musicas 
louisLaine.setArtista(manoBrown);
gangstaBoogie.setArtista(manoBrown);
oTelefoneTocouNovamente.setArtista(jorgeBen);
obaLaVemEla.setArtista(jorgeBen);
dna.setArtista(kendrickLamar);
fear.setArtista(kendrickLamar);

//adicionado musicas aos artistas
manoBrown.addMusica(louisLaine);
manoBrown.addMusica(gangstaBoogie);
jorgeBen.addMusica(oTelefoneTocouNovamente);
jorgeBen.addMusica(obaLaVemEla);
kendrickLamar.addMusica(dna);
kendrickLamar.addMusica(fear);

//populando os artistas dos albuns
boogieNaipe.setArtista(manoBrown);
forcaBruta.setArtista(jorgeBen);
damn.setArtista(kendrickLamar);

//usando o construtor que chama outro construtor
List<Musica> musicasAsapRocky = new List<Musica>();
musicasAsapRocky.Add(riot);
musicasAsapRocky.Add(praiseTheLord);
Artista asapRocky = new Artista("Asap Rocky", musicasAsapRocky);
testing.setArtista(asapRocky);
riot.setArtista(asapRocky);
praiseTheLord.setArtista(asapRocky);

//adicionando musicas aos albuns
boogieNaipe.addMusica(gangstaBoogie);
boogieNaipe.addMusica(louisLaine);
forcaBruta.addMusica(oTelefoneTocouNovamente);
forcaBruta.addMusica(obaLaVemEla);
damn.addMusica(fear);
damn.addMusica(dna);
testing.addMusica(riot);
testing.addMusica(praiseTheLord);

//setando os albuns das musicas
gangstaBoogie.setAlbum(boogieNaipe);
louisLaine.setAlbum(boogieNaipe);
oTelefoneTocouNovamente.setAlbum(forcaBruta);
obaLaVemEla.setAlbum(forcaBruta);
fear.setAlbum(damn);
dna.setAlbum(damn);
riot.setAlbum(testing);
praiseTheLord.setAlbum(testing);

//criando playlists
Playlist playlistNacional = new Playlist();
playlistNacional.setTitle("Musicas nacionais");
playlistNacional.addMusica(obaLaVemEla);
playlistNacional.addMusica(oTelefoneTocouNovamente);
playlistNacional.addMusica(louisLaine);
playlistNacional.addMusica(gangstaBoogie);

Playlist playlistInternacional = new Playlist();
playlistInternacional.setTitle("Musicas internacionais");
playlistInternacional.addMusica(fear);
playlistInternacional.addMusica(dna);
playlistInternacional.addMusica(riot);
playlistInternacional.addMusica(praiseTheLord);

//criando as listas
List<Artista> artistas = new List<Artista>();
artistas.Add(asapRocky);
artistas.Add(manoBrown);
artistas.Add(kendrickLamar);
artistas.Add(jorgeBen);

List<Playlist> playlists = new List<Playlist>();
playlists.Add(playlistNacional);
playlists.Add(playlistInternacional);

List<Album> albums = new List<Album>();
albums.Add(testing);
albums.Add(boogieNaipe);
albums.Add(forcaBruta);
albums.Add(damn);

List<Musica> musicas = new List<Musica>();
musicas.Add(louisLaine);
musicas.Add(gangstaBoogie);
musicas.Add(obaLaVemEla);    
musicas.Add(oTelefoneTocouNovamente);
musicas.Add(riot);
musicas.Add(praiseTheLord);
musicas.Add(fear);
musicas.Add(dna);

while (true)
{
    Console.WriteLine("Bem vindo ao AppMusic!");
    Console.WriteLine("1 - Artistas");
    Console.WriteLine("2 - Musicas");
    Console.WriteLine("3 - Albuns");
    Console.WriteLine("4 - PLaylists");
    Console.WriteLine("5 - Encerrar");
}

Console.WriteLine("Programa encerrado!");
