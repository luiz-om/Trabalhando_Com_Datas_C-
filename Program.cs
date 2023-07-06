// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var data = DateTime.Now;

System.Console.WriteLine(data);
//FORMATAÇÃO DE DATAS
//somente o ano
//var dataFormatada = String.Format("{0:yyyy}", data);
var dataFormatada = String.Format("{0:yy}", data);

System.Console.WriteLine(dataFormatada);

// PARA MAIORES INFROMACOES CONSUTLAR 

//
// https://learn.microsoft.com/pt-br/dotnet/standard/base-types/custom-date-and-time-format-strings
var cadastro = DateTime.Now;
var dataProva = cadastro.AddMonths(6);
// addDAy
// addYears

System.Console.WriteLine($"Dia do cadastrado {cadastro}");
System.Console.WriteLine($"Dia da prova {dataProva}");