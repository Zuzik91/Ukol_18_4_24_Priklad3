﻿using System;

namespace Ukol_18_4_24_Priklad3
{
/* Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo do prostred!
Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".*/

    internal class Program
    {
        static void Main(string[] args)
        {
            Lucisnik lucisnik = new Lucisnik(10);

            for (int i = 0; i < 11; i++)
            {
                lucisnik.Vystrel();
            }
            Console.ReadLine();
        }
    }
}
