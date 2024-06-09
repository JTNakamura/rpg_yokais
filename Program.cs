using System;
using System.Runtime.Intrinsics.Arm;
using Aula_11___RPG;

class Program
{
    public static void Main(string[] args)
    {
        //= Convert.ToInt32(Console.ReadLine());

        //CRIAR NOVO PERSONAGEM E INIMIGO
        Personagem Player = new Personagem();
        Inimigo Demonio = new Inimigo();

        //USUARIO DIGITA NOME 
        Console.WriteLine("Digite seu nome Ninja: ");
        Player.nome = Console.ReadLine()!;


        Thread.Sleep(300);

        //NARRATIVA COMEÇA AQUI
        Console.WriteLine("Certo... " + Player.nome + ", nome estranho para ser Ninja, mas tudo bem");
        Thread.Sleep(1000);

        //CLASSE QUEST É CRIADA
        Quest quest = new Quest();

        //EXIBIÇÃO DO PRIMEIRO TEXTO
        quest.Texto1(Player);
        Thread.Sleep(500);


        //------------- JOGADOR FAZ PRIMEIRA ESCOLHA ------------------------

        //ESCOLHA DO CAMINHO
        quest.Caminho(Demonio);
        quest.Continuar();

        //ESCOLHA DA ARMA
        Player.ArmaEscolher();
        Thread.Sleep(300);


        //SEGUNDO TEXTO EXIBIDO
        quest.Texto2(Player, Demonio);
        Thread.Sleep(300);

        //TERCEIRO TEXTO EXIBIDO
        quest.Texto3(Player, Demonio);
        Thread.Sleep(300);


        //JOGADOR ESCOLHE ENTRE DESVIAR OU COMEÇAR A ATACAR
        quest.Escolha1(Player, Demonio);
        quest.Batalha1(Player, Demonio);

        //EXIBIDO QUANDO O JOGO TERMINA
        Console.WriteLine("------------------F I M ---------------------");





    }
}
