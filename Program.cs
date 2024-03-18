
// Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
// string.


// Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.

using System.IO.Pipes;

byte idade = 35;
Console.WriteLine(idade);

// Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.

string nome = "Maria";
Console.WriteLine(nome);

// Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura =3.45;
Console.WriteLine(altura);

// Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor
const byte ano = 12;
Console.WriteLine(ano);

// Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o
// valor 7.80 e exiba o seu valor

double? nota = 7.80;
Console.WriteLine(nota);

// Quais as diferenças entre os tipos por valor e os tipos por referência ?

// As variáveis de tipos de valor contêm diretamente seus dados enquanto variáveis de tipos de referência armazenam referências a seus dados.
// Exemplos: 
// int n1 = 1000; ---> Tipos por valor
// int n2 = n1; ---> Tipos por referência


// O que é um nullable type e qual a sua utilidade ?

// Nullable Types é um recurso do C# que nos permite atribuir o valor null a um tipo de dado que, por padrão, não aceita valores nulos: os tipos primitivos.
// Esse recurso é útil quando precisamos realizar operações em banco de dados e desejamos armazenar um valor nulo em um campo que,
// posteriormente, receberá um valor de tipo primitivo, como int, float, bool, etc.

// O que é Camel Case ? Dê um exemplo de sua aplicação.

// camelCase é uma convenção de nomenclatura usada por desenvolvedores de software para deixar seus códigos mais legíveis, utilizando
// letras maiúsculas no inicio das palavras, com exceção da primeira palavra.
// Exemplo > *umafrasequalquer* para *umaFraseQualquer*

// O que é Pascal Case ? Dê um exemplo de sua aplicação

// Possui o mesmopropósito de Camel Case, aumentar a legibilidade do código, no entanto, este utilizade de letras maiúsculas em todas iniciais de palavras
// Exemplo > *umafrasequalquer* para *UmaFraseQualquer*


// Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
// seguir imprima o valor da soma de x com y.

int x = 77;
int y = 66;
Console.WriteLine(x+y);

// Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
// string.
/* bool = false
char = 	'\0' (U+0000)
int = 0 
double = 0
decimal = 0
string = 
*/