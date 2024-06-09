using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Classe Personagem: Crie uma classe que represente o personagem do jogador, 
//contendo atributos básicos como nome, saúde, força, etc.

namespace Aula_11___RPG
{
    public class Personagem
    {
        public string nome;
        public int saude;
        public string classe;
        public int forca;
        public bool vivo;
        public string arma;
        public string habitat;
        public string habitat2;
        public string verboAtaque;


        //construtor que inicica com dados iniciais do personagem
        public Personagem()
        {
            nome = "NomePadrao";
            classe = "Samurai";
            saude = 100;
            forca = 10;
            vivo = true;
            arma = "Porrete";
            habitat = "Nao definido";
            habitat2 = "Nao definido";
            verboAtaque = "";
        }

        //funcao status que esta dentro do personagem
        //essa classe apenas escreve os que está dentro das variaveis (parametros da classe)
        public void Status()
        {


            Console.WriteLine("Saúde: " + saude);
            Console.WriteLine("Força: " + forca);
            Console.WriteLine("Arma: " + arma);

        }

        public void StatusCriou()
        {
            Console.WriteLine("Funcao Personagem Criado");
        }

        //FUNCAO ESCOLHER ARMA -----------------------------

        public void ArmaEscolher()
        {

            Console.WriteLine("Esolha a sua arma abaixo: ");
            Thread.Sleep(50);
            Console.WriteLine("[1]: Arco e Flecha");
            Console.WriteLine("[2]: Katana de Fogo");
            Console.WriteLine("[3]: Tábua de Madeira");
            Console.WriteLine("[4]: Esapada de Ouro");

            //TIPOS DE ARMA PARA ESOLHE, CADA ARMA COM SUA FORÇA E UM VERBO PARA USAR DURANTE O TEXTO 

            int arma_escolhida = Convert.ToInt32(Console.ReadLine());
            switch (arma_escolhida)
            {
                case 1:
                    Console.WriteLine("Você quer um Arco e Flecha");
                    Thread.Sleep(500);
                    arma = "Flecha";
                    verboAtaque = "flechada";
                    forca = 11;
                    break;
                case 2:
                    Console.WriteLine("Você optou pela Katana");
                    Thread.Sleep(500);
                    arma = "Katana";
                    verboAtaque = "katanada";
                    forca = 15;
                    break;
                case 3:
                    Console.WriteLine("Uma tábua de Madeira pode ser muito util...");
                    Thread.Sleep(500);
                    arma = "Tábua de Madeira";
                    verboAtaque = "madeirada";
                    forca = 9;
                    break;
                case 4:
                    Console.WriteLine("Uma espada é sempre uma boa esolha");
                    Thread.Sleep(500);
                    arma = "Esapada";
                    verboAtaque = "espadada";
                    forca = 12;
                    break;
                default:
                    Console.WriteLine("Você achou uma Adaga no chão, legal!");
                    Thread.Sleep(500);
                    arma = "Adaga";
                    verboAtaque = "adagada";
                    forca = 17;
                    break;



            }

        }

    }
}