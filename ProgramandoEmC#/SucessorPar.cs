﻿/*
Para se preparar para os outros problemas, vamos fazer um teste. Dado um número X, 
retorne o menor número par maior do que X.
Entrada
Uma linha contendo um número  0 < X < 107.
Saída
Uma linha contendo a resposta do problema.
 
Exemplo de Entrada	
1	
Exemplo de Saída
2
*/
//usei dotnet 6.0.101

int x = int.Parse(Console.ReadLine());

if (x % 2 == 0){
    x = x + 2;
} else {
   x = x + 1;
}

System.Console.WriteLine(x);
