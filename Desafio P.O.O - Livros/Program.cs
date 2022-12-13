using Desafio_P.O.O___Livros.Models;


Livro lv = new Livro();
lv.Nome = "O diário de anne frank";

Autor autor = new Autor();
autor.nome = "Anne Frank";
autor.Email = "AnnieF@gmail.com";

lv.DadosAutor.Add(autor);

Console.WriteLine("Livro: " + lv.Nome + "");
Console.WriteLine("Autor(a): " + lv.DadosAutor[0].nome);
Console.WriteLine("Email do(a) Autor(a):" + lv.DadosAutor[0].Email);