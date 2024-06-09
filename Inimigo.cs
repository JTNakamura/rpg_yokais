using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Classe Inimigo: Desenvolva uma classe para os inimigos que o personagem enfrentará. Esta classe deve herdar da classe Personagem, podendo ter atributos e métodos adicionais específicos dos inimigos.


namespace Aula_11___RPG
{

    //INIMIGO HERDA PERSONAGE,
    public class Inimigo : Personagem
    {
        public string arma_inimigo;

        public Inimigo()
        {

            nome = "Oni";
            classe = "Yokai";
            saude = 60;
            forca = 13;
            habitat = "Floresta";
            habitat2 = "Floresta";
            vivo = true;
            arma_inimigo = "porrte";


        }

        //TIPO DE ATAQUE DO INIMIGO É ALTERADO A CADA ATAQUE.
        public void tipoArmaInimigo(int novaArma)
        {
            switch (novaArma)
            {
                case 1:
                    arma_inimigo = "Assopro tenebroso";
                    forca = 12;
                    break;
                case 2:
                    arma_inimigo = "Garras de sangue";
                    forca = 9;
                    break;
                case 3:
                    arma_inimigo = "Grito agudo";
                    forca = 14;
                    break;
                case 4:
                    arma_inimigo = "Ventos Uivantes";
                    forca = 2;
                    break;
                case 5:
                    arma_inimigo = "Raios de Gelo";
                    forca = 8;
                    break;


            }
        }
    }
}