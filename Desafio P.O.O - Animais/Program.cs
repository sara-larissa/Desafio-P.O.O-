using Desafio_P.O.O___Animais.Models;

Cachorro dog = new Cachorro();
dog.animal =  "Cachorro";
dog.raca =  "Whippet";
dog.tamanho =  "Grande";

Gato cat = new Gato();
cat.animal =  "Gato";
cat.raca =  "Persa";
cat.tamanho =  "Pequeno";

Pato duck = new Pato();
duck.animal =  "Pato";
duck.raca =  "Marreco";
duck.tamanho =  "Pequeno";

dog.dadosAnimais( dog.raca, dog.tamanho);
dog.EmitirSom();

cat.dadosAnimais( cat.raca, cat.tamanho);
cat.EmitirSom();

duck.dadosAnimais(duck.raca, duck.tamanho);
duck.EmitirSom();