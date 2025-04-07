/*
5. Exercício: Verificar Par ou Ímpar
Peça ao usuário que digite um número e informe se ele é par ou ímpar.
Dica: Utilize o operador % (módulo) para verificar se o resto da divisão por 2 é igual a
0.
*/
using System;

Console.WriteLine("Digite um numero: "); 
int num = int.Parse(Console.ReadLine()); 

if(num % 2 == 0){
    Console.WriteLine("O numero é par"); 
}else{
    Console.WriteLine("O numero é impar"); 
}