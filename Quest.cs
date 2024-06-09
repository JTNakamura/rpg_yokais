using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Classe Quest: Implemente uma classe que contenha no mínimo duas funções que 
//representem missões ou desafios que o jogador deve superar.
//Essas funções devem influenciar o curso do jogo.
namespace Aula_11___RPG
{
    public class Quest
    {
        int novaArmaInimigo;
        bool batalha;

        //USADA SEMPRE QUE O JOGADOR PRECISAR APERTAR PARA CONTINUAR
        public void Continuar()
        {
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Thread.Sleep(500);
        }



        //PRIMEIRA ESCOLHA DO PERSONAGEM DE CAMINHO, DESVIAR OU ATACAR
        public void Escolha1(Personagem jogador, Inimigo inimigo)
        {
            Thread.Sleep(500);
            Console.WriteLine("O que você deseja fazer agora? tenha calma...");
            Thread.Sleep(500);
            Console.WriteLine("[1] Desviar do " + inimigo.nome);
            Console.WriteLine("[2] Acho que atacar o " + inimigo.nome);

            int escolha1 = Convert.ToInt32(Console.ReadLine());

            //CONDICIONAIS DE ESOLHA
            switch (escolha1)
            {
                //CASO ESCOLHA DESVIAR
                case 1:
                    Console.WriteLine("Você vai desviar, mas andando pela " + inimigo.habitat + " seus passos fazem barulho... Seus pé é muito grande!, " + jogador.nome);
                    Thread.Sleep(500);
                    break;

                //CASO ESOLHA ATACAR
                case 2:
                    Console.WriteLine(jogador.nome + ", você vai atacar, prepare sua " + jogador.arma);
                    Thread.Sleep(500);
                    break;

                //CASO NÃO ESOLHA NADA
                default:
                    Console.WriteLine("É melhor você ir pra cima então... Pegue sua " + jogador.arma);
                    Thread.Sleep(500);
                    break;

            }

            Thread.Sleep(500);
            Console.WriteLine(". . . ?");
            Thread.Sleep(500);


            //LIMPA O CÓDIGO 
            Console.Clear();
            Console.WriteLine("Ah não! O " + inimigo.nome + " viu você, " + jogador.nome + "...");
            Thread.Sleep(500);

        }
        public void Texto1(Personagem jogador)
        {
            //PRIMEIRO TEXTO DA NARRATIVA QUE SERA EXIBIDO
            Console.WriteLine("Você acabou de se tornar mestre Ninja");
            Thread.Sleep(200);
            Console.WriteLine("Você precisa ir ao castelo de Kyoto para receber as honras da Família Yukimaru");
            Thread.Sleep(200);
            Console.WriteLine("Dizem que agora que você é ninja, você consegue ver os Yokais, os Demônios Japoneses.");
            Thread.Sleep(200);
            Console.WriteLine("Tenha cuidado no caminho e derrote os Yokais caso eles apareçam. ");
            Thread.Sleep(200);
            Console.WriteLine("Cada caminho possui criaturas diferentes e você terá a chance de escolher uma arma");
            Thread.Sleep(200);
            Console.WriteLine("Pense bem na sua arma, pois não poderá ser trocada, caso algum Yokai te derrote");
            Console.WriteLine("Você pode tentar novamente com uma arma diferente. Boa viagem, " + jogador.nome + "...");
        }



        public void Texto2(Personagem jogador, Inimigo inimigo)
        {
            //SEGUNDO TEXTO DA NARRATIVA QUE SERA EXIBIDO
            Console.WriteLine("Você vai passar pela " + inimigo.habitat + "...");
            Thread.Sleep(500);
            Console.WriteLine("Deixe sua " + jogador.arma + " por perto, você vai precisar logo.");
            Thread.Sleep(500);
        }

        public void Texto3(Personagem jogador, Inimigo inimigo)
        {
            //SEGUNDO TEXTO DA NARRATIVA QUE SERA EXIBIDO
            Console.WriteLine("Você caminha calmanete. Lá Lá Lá lá");
            Thread.Sleep(500);
            Console.WriteLine(". . .");
            Thread.Sleep(500);
            Console.WriteLine("Espere! Você consegue ver?");
            Thread.Sleep(500);
            Console.WriteLine("Um YOKAI! Parece uma especie de... " + inimigo.classe + "!");
            Thread.Sleep(500);
            Console.WriteLine("Um " + inimigo.nome + "!");
            Thread.Sleep(500);
            Console.WriteLine("Você está com sua " + jogador.arma + " nas mãos?");
            Console.WriteLine("[1] SIM, Claro!");
            Console.WriteLine("[2] NÃO, e agora?");
            int resposta1 = Convert.ToInt32(Console.ReadLine());
            if (resposta1 == 1)
            {
                Thread.Sleep(500);
                Console.WriteLine("Você continua sua caminhada em silêncio...");
                Thread.Sleep(500);
                Console.WriteLine("Mas é melhor deixar sua " + jogador.arma + " em mãos.");
                Thread.Sleep(500);
            }
            else if (resposta1 == 2)
            {
                Thread.Sleep(500);
                Console.WriteLine("Você pega sua " + jogador.arma + " e continua a sua caminhada, em silêncio.... Você tem um pé muito grande, cuidado com barulhos, " + jogador.nome + ".");
                Thread.Sleep(500);
            }
            // else{

            // }


        }

        //======== B A T A L H A =========
        public void Batalha1(Personagem jogador, Inimigo inimigo)
        {
            {
                batalha = true;
                Console.WriteLine("Se prepare!");

                while (batalha == true)
                {

                    //LISTA DE ESOCOLHAS
                    Thread.Sleep(500);
                    Console.WriteLine("O que vai fazer agora?");
                    //ESCOLHA 1
                    Console.WriteLine("[1] Quero ver o meu status");
                    //ESCOLHA 2
                    Console.WriteLine("[2] Atacar com minha " + jogador.arma);
                    //ESCOLHA 3
                    Console.WriteLine("[3] Sair da Batalha ");

                    int escolha2 = Convert.ToInt32(Console.ReadLine());

                    //SE ESCOLHER 1
                    if (escolha2 == 1)
                    {
                        //Console.Clear();
                        //Thread.Sleep(200);  
                        Console.WriteLine("--------------STATUS--------------");
                        jogador.Status();
                        Thread.Sleep(200);

                    }
                    //SE ESCOLHER 2
                    if (escolha2 == 2)
                    {

                        Thread.Sleep(200);
                        Console.WriteLine("Você ataca com uma " + jogador.verboAtaque + " no " + inimigo.nome);
                        inimigo.saude -= jogador.forca;
                        Thread.Sleep(200);
                        Console.WriteLine("Seu inimigo tem agora " + inimigo.saude + " de saude...");
                        Thread.Sleep(500);

                        if (inimigo.saude > 0)
                        {

                            Thread.Sleep(500);
                            Console.WriteLine("O " + inimigo.nome + " te ataca com " + inimigo.arma_inimigo);
                            Console.WriteLine("-------------------------------");
                            Thread.Sleep(500);

                            //RETIRA SAUDE DO JOGADOR
                            jogador.saude -= inimigo.forca;

                            //CRIA NOVA ARMA DE ATAQUE PARA O INIMIGO
                            novaArmaInimigo = novaArmaInimigo + 1;
                            //ATRIBUI A NOVA ARMA PARA O INIMIGO
                            inimigo.tipoArmaInimigo(novaArmaInimigo);
                        }

                        //SE O INIMIGO MORRER
                        if (inimigo.saude <= 0)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("O " + inimigo.nome + " foi derrotado e você conseguiu chegar ao Castelo de kyoto!");
                            Console.WriteLine("Não é para qualquer pessoa derrotar um " + inimigo.nome + ".");
                           
                           batalha = false;
                        }
                        //SE O JOGADOR MORRER
                        else if (jogador.saude <= 0)
                        {
                            Thread.Sleep(500);
                            Console.WriteLine("Não foi dessa vez, " + jogador.nome + ", o " + inimigo.nome + " te derrotou.");
                            Console.WriteLine("Uma " + jogador.arma + " não é a melhor arma para derrotar um " + inimigo.nome + ".");
                            Console.WriteLine("Tente mais uma vez e escolha um novo caminho ou tente uma nova arma.");
                           
                            //FIM DA BATALHA
                            batalha = false;
                        }
                    }
                    //SE ESCOLHER 3
                    if (escolha2 == 3)
                    {
                        Thread.Sleep(500);
                        Console.WriteLine("Voce optou por sair da batalha, mas infelizmente dessa forma você não poderá seguir o seu caminho.");
                        //FIM DA BATALHA
                        batalha = false;
                    }


                }
                Thread.Sleep(500);
                Console.WriteLine("FIM DA BATALHA");

                //torna batalha falsa

            }


        }



        public void Caminho(Inimigo inimigo)
        {

            Console.WriteLine("Qual caminho você quer seguir? Pense bem... ");
            Thread.Sleep(300);
            Console.WriteLine("[1]: Lagoa escura ");
            Console.WriteLine("[2]: Floresta da Montanha ");
            Console.WriteLine("[3]: Montanha Congelada ");
            Console.WriteLine("[4]: Áreas Rurais ");
            int caminho = Convert.ToInt32(Console.ReadLine());
            switch (caminho)
            {
                case 1:
                    Console.WriteLine("Você está indo pela lagoa escura ");
                    Thread.Sleep(1000);
                    inimigo.classe = "Espírito da água";
                    inimigo.nome = "Kappa";
                    inimigo.forca = 50;
                    inimigo.habitat = "lagoa escura";
                    inimigo.arma_inimigo = "Lançador de água pressurizada";
                    Console.WriteLine("Dizem que na lagoa existe um Yokai chamado  " + inimigo.nome + ", tenha cuidado");
                    Thread.Sleep(1000);
                    break;
                case 2:
                    Console.WriteLine("Você está indo para as florestas das montanhas ");
                    Thread.Sleep(1000);
                    inimigo.classe = "Ogro";
                    inimigo.nome = "Oni";
                    inimigo.forca = 59;
                    inimigo.saude = 60;
                    inimigo.habitat = "floresta";
                    inimigo.habitat2 = "montanha";
                    inimigo.arma_inimigo = "Clava demoníaca";
                    Console.WriteLine("Dizem que na montanha existe um Yokai chamado  " + inimigo.nome + ", tenha cuidado");
                    Thread.Sleep(1000);

                    break;
                case 3:
                    Console.WriteLine("Você está a caminho das montanhas geladas ");
                    Thread.Sleep(1000);
                    inimigo.classe = "Espírito da neve";
                    inimigo.nome = "Yuki-Onna";
                    inimigo.forca = 40;
                    inimigo.saude = 70;
                    inimigo.habitat = "montanha gelada";
                    inimigo.arma_inimigo = "Lança de gelo";
                    Console.WriteLine("Nas montanhas geladas existe um Yokai chamado  " + inimigo.nome + ", tenha cuidado");
                    Thread.Sleep(1000);
                    break;
                case 4:
                    Console.WriteLine("Você escolheu as áreas rurais ");
                    Thread.Sleep(1000);
                    inimigo.classe = "Espírito da floresta";
                    inimigo.nome = "Tanuki";
                    inimigo.habitat = "área rural";
                    inimigo.forca = 37;
                    inimigo.saude = 90;
                    inimigo.arma_inimigo = "Bastão mágico de transformação";
                    Console.WriteLine("Dizem que nas áreas rutais existe um Yokai chamado  " + inimigo.nome + ", tenha cuidado");
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("Você não sabe para onde ir, não é mesmo?");
                    Console.WriteLine("Vá pelas Florestas e Montanhas, os Yokais por lá são mais amigáveis");
                    Thread.Sleep(1000);
                    inimigo.classe = "Ogro";
                    inimigo.nome = "Oni";
                    inimigo.forca = 59;
                    inimigo.saude = 100;
                    inimigo.habitat = "floresta";
                    inimigo.habitat2 = "montanha";
                    inimigo.arma_inimigo = "Clava demoníaca";
                    Console.WriteLine("Dizem que nas ontanhas existe um Yokai chamado  " + inimigo.nome + ", um tipo de Ogro, tenha cuidado mesmo assim");
                    Thread.Sleep(1000);

                    break;

            }

        }
    }
}



