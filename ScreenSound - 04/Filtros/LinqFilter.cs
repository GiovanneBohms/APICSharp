using System;
using System.Collections.Generic;
using System.Linq;
using ScreenSound___04.Modelos;

namespace ScreenSound___04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(musicas => musicas.Genero).Distinct().ToList();

            foreach (var genero in todosOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }
    }
}
