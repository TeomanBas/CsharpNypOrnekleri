internal class Program
{
    private static void Main(string[] args)
    {
        Soru Soru1 = new Soru()
        {
            SoruMetni = "Aşağıdakilerden hangisi programlama dili değildir?",
            Secenekler = new string[4] { "python", "c#", "java", "django" },
            Cevap = "django"
        };
        Soru Soru2 = new Soru()
        {
            SoruMetni = "Aşağıdakilerden hangisi web programlama dilidir?",
            Secenekler = new string[4] { "python", "c#", "Asp.Net", "django" },
            Cevap = "Asp.Net"
        };

        Soru Soru3 = new Soru()
        {
            SoruMetni = "Aşağıdakilerden hangisi web programlama platformudur dilidir?",
            Secenekler = new string[4] { "python", "php", "java", "django" },
            Cevap = "django"
        };
       
        var Sorular = new Soru[3] { Soru1, Soru2, Soru3 };

        foreach (var item in Sorular)
        {
            Console.WriteLine(item.SoruMetni);
            foreach(var secenek in item.Secenekler)
            {
                Console.WriteLine("-) {0}",secenek);
            }
            Console.Write( "Cevabınız : ");
            string Cevap = Console.ReadLine();
            if (item.CevapKontrol(Cevap))
            {
                Console.WriteLine("doğru");
            }
            else
            {
                Console.WriteLine("yanlış");
            }


        }
    }
}
public class Soru
{
    public string SoruMetni { get; set; }
    public string[] Secenekler { get; set; }
    public string Cevap { get; set; }

    //methods
    public bool CevapKontrol(string Cevap)
    {
        return this.Cevap.ToLower() == Cevap.ToLower();
    }
}