using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound___04;
using ScreenSound___04.Modelos;
namespace ScreenSound___04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdernados(List<Musica> musicas)
        {
            var artistasOrdernados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine( "Lista de artistas ordernados");
            foreach (var artista in artistasOrdernados)
            {
                Console.WriteLine($"- {artista}");
            }
        }
    }
}
