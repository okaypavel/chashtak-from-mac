Tablice tablica = new Tablice();
tablica.odwroc();
tablica.sortuj();
Console.WriteLine(tablica.minztab(0));
tablica.wypisz();

Console.Read();
//
// ^Main^
//
public class Tablice
{
    int[] tabl = { 2, 123, 15, 85, 5 };
    int i;
    public void odwroc()
    {
        int zmien;
        for (i = 0; i < tabl.Length / 2; i++)
        {
            zmien = tabl[i];
            tabl[i] = tabl[tabl.Length - i - 1];
            tabl[tabl.Length - i - 1] = zmien;
        }
    }
    /*public void sortuj()
    {
        int j = 1;
        int min = 0;
        for(i = 1; i < tabl.Length; i++)
        {
            for (j = tabl.Length - 1; j >= i; j--)
            {
                if (tabl[j - 1] > tabl[j])
                {
                    min = tabl[j];
                    tabl[j] = tabl[j - 1];
                    tabl[j - 1] = min;
                }
            }
        }
    }*/
    public void sortuj()
    {
        int j = minztab(i);
        int min;
        for(i = 0; i < tabl.Length; i++)
        {
            min = tabl[i];
            tabl[i] = tabl[j];
            tabl[j] = min;
        }
    }
    public int minztab(int o)
    {
        int minim = o;
        for(i = o + 1; i < tabl.Length; i++)
        {
            if (tabl[i] < tabl[minim])
            {
                minim = i;
            }
        }
        return minim;
    }
    public void wypisz()
    {
        foreach (int w in tabl)
        {
            i = w;
            Console.Write(i + " ");
        }
    }
}
