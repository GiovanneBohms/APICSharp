using ScreenSound___04.Modelos;
using System.Text.Json;
using ScreenSound___04.Filtros;

using (HttpClient client = new HttpClient()){
    try
    {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExibirDetalhesDaMusica();
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"erouuuuuuuu:\n {ex.Message}");
    }
    
}