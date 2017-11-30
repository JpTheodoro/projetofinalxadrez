using System;
using tabuleiro;

namespace projeto_final {
    class Tela { 

        public static void imprimirTabuleiro(Tabuleiro tab) {

         for (int i=0; i<tab; i++) {
                for(int j=0; j<tab; j++) {
                    if (tab.peca(i,j)==null) {
                        Console.Write("- ");
                    }
                    else {
                        Console.Write(tab.peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
