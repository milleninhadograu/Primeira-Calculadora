using PrimeiroProjeto.Exercicio01;
using PrimeiroProjeto.Exercicios02;

var calculadora = new Calculadora();
//var resultado = calculadora.somar(23,23);
//Console.WriteLine(resultado);
//var resultado2 = calculadora.dividir(15, 2);
//Console.WriteLine(resultado2);
//var resultad = calculadora.subtrair(55, 15);
//Console.WriteLine(resultad);
//calculadora.multiplicar(,5);
//Console.WriteLine();
var padaria = new ComprarPao();

//padaria.total = 16;
//quantidade de paes , valor de um pao , resultado igual total...
//quan * val = resultado
Console.WriteLine("Digite a Quantidade de paes");

var quantidadePaes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Coloque o preço do pao");

var precodoPao = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(padaria.precodaCompra(calculadora,quantidadePaes, precodoPao));







