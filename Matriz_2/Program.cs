using System;

namespace Matriz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usuario vai entra com o valor da Linha e Coluna
            Console.WriteLine("Digite um valor para linha e coluna (Ex: 3 4): ");
            string[] line = Console.ReadLine().Split(' ');
            //Recebe o valor de m - linha
            int m = int.Parse(line[0]);
            //Recebe o valor de n - coluna
            int n = int.Parse(line[0]);
            //Esta criando a matriz com os valores da coluna e da linha 
            int[,] mat = new int[m, n];
            //Usuario vai entra com os numeros
            Console.WriteLine("Digite os números, separados por espaço (Ex: 10 08 15 12): ");
            for (int i = 0; i < m; i++)
            {
                // esta criando uma matriz de subcadeias
                string[] values = Console.ReadLine().Split(' ');
                // Loop das colunas da matriz
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            //Le um número X que pertence à matriz
            Console.WriteLine("Escolha um dos números digitados acima: ");
            //Recebe o valor de referência.
            int x = int.Parse(Console.ReadLine());
            //Criando uma repetição com o número de linhas 
            for (int i = 0; i < m; i++)  
            {
                //Criando uma repetição com o número de colunas 
                for (int j = 0; j < n; j++)
                {
                    //compara o valor da Linha e Coluna
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine($"Posição " + i + "," + j + ":");
                        if (j > 0)
                        {
                            //Numero a Esquerda
                            Console.WriteLine($"Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            //Numero Acima
                            Console.WriteLine($"Acima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)
                        {
                            //Numero a Direita
                            Console.WriteLine($"Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            //Numero Abaixo
                            Console.WriteLine($"Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}