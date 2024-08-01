using ScreenSound___04.Modelos;
using System.Text.Json;
using ScreenSound___04.Filtros;

using (HttpClient client = new HttpClient()){
    try
    {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhesDaMusica();
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdernados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");

        var musicasPreferidasDoDaniel = new MusicasPreferidas("Daniel");
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasDoDaniel.ExibirMusicasFavoritas();

        musicasPreferidasDoDaniel.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"erouuuuuuuu:\n {ex.Message}");
    }
    
}