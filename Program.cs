Musica musica1 = new Musica();
musica1.Nome = "Click";
musica1.Artista = "Jisoo";
musica1.Duracao = 190;
musica1.Disponivel = true;
Console.WriteLine(musica1.Disponivel);

Musica musica2 = new Musica();
musica2.Nome = "In The End";
musica2.Artista = "Linkin Park";
musica2.Duracao = 217;
musica2.Disponivel = false;
Console.WriteLine(musica1.Disponivel);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();