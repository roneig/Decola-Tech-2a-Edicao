/*
Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100
Entrada
Não há nenhuma entrada neste problema.
Saída
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.
*/
//usei dotnet 6.0.101

using System;

double a, c, S = 0;

for (a = 1; a <= 100; a++){
    c = 1/a;
    S += c;
}

var x = Math.Round(S,2);
Console.WriteLine(x);
