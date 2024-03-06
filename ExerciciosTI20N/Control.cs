﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Control
    {
        Model modelo;
        public Control() 
        {
            modelo = new Model();

            
        }//Fim do Construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Exercicio 1\n" +
                              "2. Exercicio 2\n" +
                              "3. Exercicio 3\n" +
                              "4. Exercicio 4\n"+
                              "5. Exercicio 5\n"+
                              "6. Exercicio 6\n"+
                              "7. Exercicio 7\n"+
                              "8. Exercicio 8\n"+
                              "9. Exercicio 9\n"+
                              "10.Exercicio 10\n"+
                              "11.Exercicio 11\n"+
                              "12.Exercicio 12\n");
        }//Fim do Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {

                Menu();//Mostrando as opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());
                        break;
                    case 3:
                        Console.WriteLine("A Soma dos números entre 1 a 100 é: " + modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine("Os multiplos de 5 de 1 até 50 são: " + modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        int Num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSeis(Num));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número para fazer a tabuada dele: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSete(num));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOito(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("A Soma do número 1 ao número escolhido é: " + modelo.ExercicioNove(num));
                        break;
                    case 10:
                        Console.WriteLine("Os números primos de 1 a 20 são: " + modelo.ExercicioDez());
                        break;
                    case 11:
                        Console.WriteLine("Informe um número para ver se ele é primo ou não");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOnze(num));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número para calcular o fatorial");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDoze(num));
                        break;
                    default:
                        Console.WriteLine("Código digitado não é válido! ");
                        break;
                   

                }//Fim do método
            } while (opcao != 0);
        }//Fim do Operacao

    }//Fim da Classe
}//Fim do Projeto
