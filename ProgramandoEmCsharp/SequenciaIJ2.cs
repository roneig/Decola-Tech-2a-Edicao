﻿/*
Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.
Entrada
Não há nenhuma entrada neste problema.
Saída
Imprima a sequencia conforme exemplo abaixo
	
I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=7
I=3 J=6
I=3 J=5
...
I=9 J=7
I=9 J=6
I=9 J=5
*/
//usei dotnet 6.0.101

for (int i = 1; i < 10; i += 2){

    for (int j =7; j > 4; j--){
        System.Console.WriteLine($"I={i} J={j}");
    }
}
