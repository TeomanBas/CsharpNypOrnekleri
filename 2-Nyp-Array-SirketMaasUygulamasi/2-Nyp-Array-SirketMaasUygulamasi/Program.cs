class calisan
{
    //getter
    string isim { get; }
    public double maas { get; set; }
    // const
    public calisan(string isim, int maas)
    {
        this.isim = isim;
        this.maas = maas;
    }
    public void zam(double oran)
    {
        maas = maas * ( 1 + oran);
    }

    // ToString metodu normalde tüm objelerin metodudur her objenin ToString metodu vardır.bunun için daha önce olan 
    // ToString metodunun üzerinde override etmek durumundayız
    override public string ToString()
    {
        return "calisan ismi : " + isim + " | maas : " + maas;
    }
}
internal class Program
{
    static void zam(calisan[]s, double oran)
    {
        for (int i = 0;i< s.Length; i++)
        {
            s[i].zam(oran);
        }
    }
    static void EkranaBas(calisan[] s)
    {
        foreach(calisan x in s)
        {
            Console.WriteLine(x);
        }
    }

    private static void Main(string[] args)
    {
        calisan[] sirket = new calisan[5];
        sirket[0] = new calisan("ali", 1000);
        sirket[1] = new calisan("veli", 230);
        sirket[2] = new calisan("fatma", 3000);
        sirket[3] = new calisan("ahmet", 2000);
        sirket[4] = new calisan("deniz", 1500);
        EkranaBas(sirket);
        zam(sirket, 0.2);
        Console.WriteLine("---------------------------");
        EkranaBas(sirket);
        zam(sirket, 0.2);
        Console.WriteLine("---------------------------");
        EkranaBas(sirket);

    }
}