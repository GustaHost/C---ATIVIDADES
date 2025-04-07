/*
2. Exercício: Calculando a Idade
Solicite que o usuário informe o seu ano de nascimento e calcule a idade considerando o
ano atual como 2024.
Dica: Subtraia o ano de nascimento do ano atual para obter a idade.
*/
using System;

Console.WriteLine("Digite o seu ano de nascimento: "); 
int ano = int.Parse(Console.ReadLine()); 

Console.WriteLine(2024 - ano + " é a sua idade ");