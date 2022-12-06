// See https://aka.ms/new-console-template for more information

using CS_Shop_3;
using csharp_oop_shop_3.Custom_Exception;


List<Prodotto> carrelloDellaSpesa = new List<Prodotto>();

try
{
    Caramella goleador = new Caramella("Goleador", "Una buona caramella", -0.10, 22, "frutta", 30);
    Prodotto.OggettiGeneratiConSuccesso++;
    carrelloDellaSpesa.Add(goleador);
    Console.WriteLine(goleador.GetNumeroKcalorie());
}
catch (ParameterCannotBeEmptyException e)
{
    Console.WriteLine(e.Message);
}

catch (CannotBeNegativeException e)
{
    Console.WriteLine(e.Message);
}

try
{
    Caramella bubblegum = new Caramella("BubbleGum", "Gomma Americana", 0.15, 22, "amarena", 45);
    Prodotto.OggettiGeneratiConSuccesso++;
    carrelloDellaSpesa.Add(bubblegum);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Videogioco Pokemon = new Videogioco("Pokémon Scarlatto", "L'ultimo gioco dei Pokemon", 60.00, 22, "GameFreak");
    Prodotto.OggettiGeneratiConSuccesso++;
    carrelloDellaSpesa.Add(Pokemon);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Sacchetto_di_frutta sacchettoArance = new Sacchetto_di_frutta("Arance", "Un sacchetto di arance", 1.60, 4, 4, 1, "Arancia");
    Prodotto.OggettiGeneratiConSuccesso++;
    carrelloDellaSpesa.Add(sacchettoArance);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Prodotto lavatriceBosch = new Prodotto("Lavatrice Bosch LD2022", 150.00, -22);
    Prodotto.OggettiGeneratiConSuccesso++;
    carrelloDellaSpesa.Add(lavatriceBosch);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


carrelloDellaSpesa.OrderBy(prodotto => prodotto.GetPrezzo());


foreach (Prodotto articolo in carrelloDellaSpesa)
{
    
    switch (articolo)
    {
        case Caramella:
            Caramella caramella = (Caramella)articolo;
            Console.WriteLine(caramella.GetNumeroKcalorie());
            break;
        case Videogioco:
            Videogioco videogioco = (Videogioco)articolo;
            Console.WriteLine(videogioco.GetStudioDiSviluppo());
            break;
    }

    Console.WriteLine(articolo);
   
}

Console.Write("Oggetti Generati con Successo: "+ Prodotto.OggettiGeneratiConSuccesso + " su " + Prodotto.GetNumeroOggetti() +" tentati");
