using System;
namespace proje_son
{
    public abstract class Otel
    {

       public  static int[] TekKisilik = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public static int[] CiftKisilik = { 0, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        public static int[] Giris = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0,0,0,0,0,0,0,0,0,0,0};
        public static int[] Cikis = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0,0,0,0,0,0,0,0,0,0,0};
        public int GirisTarihi;
        public int CikisTarihi;

        public int giristarihi
        {
            get { return GirisTarihi; }
            set { GirisTarihi = value; }
        }
        public int cikistarihi
        {
            get { return CikisTarihi; }
            set { CikisTarihi = value; }
        }

        abstract public  void DenizManzarali();

        abstract public void HavuzManzarali();

        abstract public void Manzarasiz();


        public static void Rezgonder(int x)  //Rezervasyon oda classına  gönderiliyor.
        {
            Oda o = new Oda();
            o.RezYap(x);


        }
        public static int Rezİptalgonder(int m)//rez iptali oda classına gönderiliyor.(m hangi oda oldugu)
        {
            Oda o1 = new Oda();
            o1.Rezİptal(m);
            return 0;
        }

        public static int DolulukOrani()
        {
            int sayac = 0; //tek yataklı dolu oda sayısı
            int sayac2 = 0;//cift
            double oran1=0;//toplam doluluk oranı
            double oran2=0;//tek kisilik
            double oran3=0;//cift kisilik
            for (int i = 1; i < 11; i++)
            {

                if (TekKisilik[i] == 100)   //oda dolu ise
                {
                    sayac++; // tek kisilik odalardan kaç tanesinin dolu olduğunu tutuyor

                }


            }
            oran2 = (sayac/10.0)*100;
            for (int i = 1; i < 11 ; i++)
            {
                if (CiftKisilik[i] == 100)
                {
                    sayac2++; // cift kisilik odalardan kaç tanesinin dolu olduğunu tutuyor

                }

            }

           oran3 = (sayac2/10.0)*100;
            oran1 =(sayac+sayac2)/20.0*100;

            Console.WriteLine("Oteldeki genel doluluk orani:%" +oran1);
            Console.WriteLine("Tek kisilik odalardaki doluluk orani:%" +oran2);
            Console.WriteLine("Cift kisilik odalardaki doluluk orani:%" +oran3);
            return 0;
        }
        public static int RezGöster()
        {
            Console.WriteLine("-----TEK KİSİLİK ODALAR-----");
            for(int i=1;i<11;i++)
            {
                if(TekKisilik[i]==100)
                {
                    Console.WriteLine( i+".DOLU  ");
                }
                else
                {
                    Console.WriteLine(i+ ".*  ");
                }
            }
            Console.WriteLine("-----CİFT KİSİLİK ODALAR-----");
            for(int j=1;j<11;j++)
            {
                if(CiftKisilik[j]==100)
                {
                    Console.WriteLine(j+10 + ".DOLU ");

                }
                else
                {
                    Console.WriteLine(j+10 + ".* ");
                }
            }
            return 0;
        }
        public static int Tarih(int giris,int cikis,int s)
        {
            Giris[s] = giris;
            Cikis[s] = cikis;
            return 0;
        }
        public static void TarihGoster()
        {   for (int i = 1; i < 21;i++)
            {
                if (Giris[i] != 0 && Cikis[i]!=0)
                {
                    Console.WriteLine(i + ". Odanın giris tarihi:" + Giris[i]);
                    Console.WriteLine(i +". Odanın cikis tarihi:" + Cikis[i]);
                }
                else
                {
                    Console.WriteLine(i+ " - ");
                }

            }

        }
    }
   
   
        }






