/* 
1. faça um programa que leia 10 numeros inteiros e imprima os seguintes itens:
    a.somente os valores pares;
    b.somente os valores impares;
    c.somente a primeira e a ultima posição;
*/
int tamanho = 10;
int[] numeros = new int[tamanho];
int num;

for (int i = 0; i < tamanho; i++)
{
    Console.WriteLine($"Digite o {i+1}º número:");
    numeros[i] = int.Parse( Console.ReadLine());
}
Console.WriteLine("Números pares:");
for (int i = 0;i < tamanho; i++)
{
    num = numeros[i];
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("Números impares:");
for (int i = 0; i < tamanho; i++)
{
    if (numeros[i] % 2 != 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine($"Primeira posição:\n{numeros[0]}\nUltima posição:\n{numeros[tamanho-1]}");