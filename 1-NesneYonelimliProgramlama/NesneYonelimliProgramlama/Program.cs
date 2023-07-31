
namespace NesneYonelimliProgramlama
{
    internal class Program
    {

        class insan
        {
            // class ismiyle aynı isme sahip olan bir metod tanımlarsak buna constructors ismi verilir
            // return type yoktur
            // insan nesnesi ilk kez üretilirken çalışır
            public insan()
            {
                Console.WriteLine("insan oluşturuluyor");
            }
            // aşağıdaki tanımlanan constructors ile insan tanımlanırken sonradan ismini almak yerine 
            // en başta tanımlanırken isim almamıza olanak tanır.bir metodun birden fazla farklı şeklillerde
            // kullanılabilmesine polymorphism denir aynı zamanda aynı metodların farklı şekillerde tanımlanmasına overloading de denilmektedir.
            public insan(string isim)
            {
                this.isim = isim;
            }

            // access modifier tanımlaması
            public string isim;
            private int kilo;
            private int YasKontrol;
            private int Yas;


            // get set ve set metodları tanımlandığında değişken private yapılırsa değişkenlere dışarıdan sadece bu
            // metodlarla erişilebilir get ve set metodlarının kullanımına encapsulation deniliyor
            public void SetKilo(int kilo)
            {
                this.kilo=kilo;
            }
            public int GetKilo()
            {
                return kilo;
            }

            // chaspta olan bir özellik olan properties tanımlamalarında da get ve set metotları tanımlanabilir
            public  string SevdigiRenk
            {
                
                set 
                {
                    // value set tanımlarken kullanılan özel bir deyimdir set metodundan gelen parametreyi ifade eder
                    SevdigiRenk = value; 
                }
                get
                {
                    return SevdigiRenk;
                }
            }

            // set ve get ederken kontroller metod içerisinde de gerçekleştirilebilir.
            public void SetYas (int Yas)
            {
                if (Yas<0)
                {
                    this.YasKontrol = 0;
                    this.Yas = 0;
                }else
                {
                    this.YasKontrol = 1;
                    this.Yas = Yas;
                }             
            }
            public string GetYas()
            {
                if (this.Yas==0)
                {
                    return "geçersiz yaş";
                }
                else
                {
                    return $"yaşınız : {this.Yas}";
                }
            }


        }

        



        private static void Main(string[] args)
        {
            /* get set metodları yokken 
            insan ali=new insan();
            ali.isim = "ali";
            ali.kilo = 10;
            insan veli= new insan();
            veli.isim = "veli";
            veli.kilo = 20;
            Console.WriteLine("isim {0,3} kilosu {1,3}",ali.isim, ali.kilo);
            */
            insan ali = new insan();
            ali.SetKilo(10);
            var AliKilo=ali.GetKilo();
            Console.WriteLine(AliKilo);
            Console.WriteLine(new string('-',5));

            insan ihsan=new insan();
            ihsan.SetYas(0);
            var IhYas=ihsan.GetYas();
            Console.WriteLine(IhYas);

            // Dizi şeklinde birden çok nesne oluşturulabilir

            insan[] insanlar = new insan[3];
            insanlar[1] = ali;
            insanlar[2] = ihsan;
            Console.WriteLine($"alinin kilosu {insanlar[1].GetKilo()} ve ihsanın kilosu {insanlar[2].GetKilo()}");
        }
    }
}