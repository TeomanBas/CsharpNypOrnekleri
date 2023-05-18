class ogrenci
{
    public string Isim;
    public double NotOrtalamasi;
    public string Bolum;
    public ogrenci(string ısim, double notOrtalamasi, string bolum)
    {
        this.Isim = ısim;
        this.NotOrtalamasi = notOrtalamasi;
        this.Bolum = bolum;
    }

    public override string ToString()
    {
        return "isim : " + Isim + " bolum : " + Bolum + " Not Ortalaması : " + NotOrtalamasi;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        ogrenci ali = new ogrenci("ayşe", 90, "bilgisayar");
        List <ogrenci> sinif=new List<ogrenci>();
        sinif.Add(ali);
        Console.WriteLine("doğrudan obje : "+ali);
        Console.WriteLine("listeden ilk eleman"+ sinif.ElementAt(0));
        Console.WriteLine("listeden ilk eleman" + sinif[0]);
        Console.WriteLine("listenin kapasitesi" + sinif.Capacity);
        sinif.Add(new ogrenci("ahmet",80, "felsefe"));
        sinif.Add(new ogrenci("deniz",78, "bilgisayar"));
        sinif.Add(new ogrenci("cem",40, "bilgisayar"));
        sinif.Add(new ogrenci("fatma",70, "coğrafya"));
        sinif.Add(new ogrenci("berk",80, "matematik"));
        Console.WriteLine("listeden ilk eleman" + sinif.ElementAt(0));
        Console.WriteLine("listeden ilk eleman" + sinif[0]);
        Console.WriteLine("listenin kapasitesi" + sinif.Capacity);

        var sonuc =
            from x in sinif
            where x.NotOrtalamasi > 50
            orderby x.Isim descending
            select x.Isim;
        foreach ( var x in sonuc)
        {
            Console.WriteLine(x);
        }
        






    }
}