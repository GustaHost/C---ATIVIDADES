/*
4. Exercício: Maior Número
Solicite dois números ao usuário e exiba na tela qual deles é o maior.
Utilize estruturas condicionais como if para fazer a verificação.
*/

using System;

Console.WriteLine("Digite o numero 1 para identificar o maior entre os numeros 1 e 2: "); 
int num1 = int.Parse(Console.ReadLine()); 

Console.WriteLine("Digite o numero 2 para identificar o maior entre os numeros 1 e 2: "); 
int num2 = int.Parse(Console.ReadLine()); 

if(num1 < num2){
    Console.WriteLine("O numero num1 é maior que o numero num2 "); 
}else{
    Console.WriteLine("O numero num2 é maior que o numero num1 "); 
}