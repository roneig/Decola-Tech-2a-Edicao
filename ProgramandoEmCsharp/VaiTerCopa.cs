/*
Entrada
A entrada contém vários casos de teste. Cada caso de teste consiste de uma linha contendo o número N de reclamações sobre a copa encaminhadas para o governo (0 ≤ N ≤ 100).
Saída
Para cada teste, a saída consiste de uma linha dizendo "vai ter copa!" caso não haja reclamações para o governo. Caso haja reclamações, a saída deverá dizer "vai ter duas!".
 
Exemplo de Entrada	
0
1
0
2
100
0
Exemplo de Saída
vai ter copa!
vai ter duas!
vai ter copa!
vai ter duas!
vai ter duas!
vai ter copa!
*/
//usei dotnet 6.0.101

string str;

while((str=Console.ReadLine()) != null) {
   
    int x = int.Parse(str);
    if ( x == 0 ) {
        System.Console.WriteLine("vai ter copa! ");
    } else {
        System.Console.WriteLine("vai ter duas!");
    }    
}           
