using System;
using atividade01;

class Program
{
    static void Main(string[] args)
    {

        Dinossauro dinossauro = new Dinossauro();
        dinossauro.Comer();
        dinossauro.Dormir();
        dinossauro.Respirar();
        dinossauro.Morrer();

        Trem trem = new Trem();
        trem.Ligar();
        trem.Desligar();
        trem.Abastecer();
        trem.Alerta();

        Helicoptero helicoptero = new Helicoptero();
        helicoptero.Ligar();
        helicoptero.Decolar();
        helicoptero.Pairar();
        helicoptero.Pousar();
        helicoptero.Desligar();

        Passaro passaro = new Passaro();
        passaro.Decolar();
        passaro.Comer();

        Aviao aviao = new Aviao();
        aviao.Ligar();
        aviao.Desligar();
        aviao.Decolar();
        aviao.Abastecer();

        Fantasma fantasma = new Fantasma();
        fantasma.Pairar();

        Superman superman = new Superman();
        superman.Decolar();
        superman.Comer();

        Gato gato = new Gato();
        gato.Comer();
        gato.Morrer();

        Carro carro = new Carro();
        carro.Ligar();
        carro.Abastecer();

        Cachorro cachorro = new Cachorro();
        cachorro.Comer();
        cachorro.Dormir();

        OVNI ovni = new OVNI();
        ovni.Decolar();
        ovni.Alerta();

        Beijaflor beijaflor = new Beijaflor();
        beijaflor.Decolar();
        beijaflor.nascer();

        Zumbi zumbi = new Zumbi();
        zumbi.nascer();
        zumbi.Comer();

        Piterodaptero piterodaptero = new Piterodaptero();
        piterodaptero.Decolar();
        piterodaptero.nascer();
    }
}
