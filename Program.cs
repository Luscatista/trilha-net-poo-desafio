using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("011 99998-88877", "Básico", "123654789", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Github Mobile");

Console.WriteLine();

Console.WriteLine("Smartphone IPhone: ");
Smartphone iphone = new Iphone("012 99988-99887", "Avançado","321654987", 512);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Sudoku");
