using cassetta;
using System;

Cassetta cas146 = new Cassetta("12345");
Cassetta cas287 = new Cassetta("67890");
Cassetta cas324 = new Cassetta("69470");
Gioiello gioiello = new Gioiello();
Doc documento = new Doc();
Chiave chiave = new Chiave();

gioiello.ValDic = 10000;
documento.ValDic = 70;
chiave.ValDic = 500;

Console.WriteLine("inserire 1 per modificare la cassetta 147, 2 per la cassetta 287 oppure 3 per la cassetta 324 \n");
string numCas = Console.ReadLine();

if (numCas == "1")
{
    Console.WriteLine("inserire il pin di sblocco: ");
    cas146.UPin = Console.ReadLine();

    cas146.Inserire(gioiello);
    Console.WriteLine(cas146.ValAss());
    Console.WriteLine(cas146.Tipologia1());
    Console.WriteLine(cas146.Tipologia2());
}
else if (numCas == "2")
{
    Console.WriteLine("inserire il pin di sblocco: ");
    cas287.UPin = Console.ReadLine();

    if (cas287.UPin == cas287.Pin)
    {
        cas287.Inserire(documento);
        Console.WriteLine(cas287.ValAss());
        Console.WriteLine(cas287.Tipologia1());
        Console.WriteLine(cas287.Tipologia2());
    }
}

else if (numCas == "3")
{
    Console.WriteLine("inserire il pin di sblocco: ");
    cas324.UPin = Console.ReadLine();

    if (cas324.UPin == cas324.Pin)
    {
        cas324.Inserire(chiave);
        Console.WriteLine(cas324.ValAss());
        Console.WriteLine(cas324.Tipologia1());
        Console.WriteLine(cas324.Tipologia2());
    }
}

else
{
    Console.WriteLine("il numero inserito non corrisponde a nessuna cassetta!");
}