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
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michel Teló");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"erouuuuuuuu:\n {ex.Message}");
    }
    
}