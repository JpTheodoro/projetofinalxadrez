﻿
namespace tabuleiro {
   abstract class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantMovi { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.quantMovi = 0;
        }

        public void incrementarQuantMovi() {
            quantMovi++;
        }

        public abstract bool[,] movimentosPossiveis(); 

    }
}
