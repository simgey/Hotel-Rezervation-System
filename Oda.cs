using System;
namespace proje_son
{
    public class Oda:Otel
    {
        public override void DenizManzarali()
        {

            Console.WriteLine("*****Odanız  4.Katta ve Deniz Manzaralıdır..*****");

        }
        public override void HavuzManzarali()
        {
            Console.WriteLine("*****Odanız 3.Katta ve Havuz Manzaralidir..*****");
        }

        public override void Manzarasiz()
        {
            Console.WriteLine("*****Odanız 2.Katta ve Manzarasızdır.*****");
        }

        public  int  RezYap(int x)  //Rezervasyon gerçekleştiriliyor.
        {

            for (int i = 0; i < 10; i++)
               //
            {
             if(TekKisilik[i]==100&&i==x)
                {
                    Console.WriteLine("Maalesef  "+  x  + ". odamız doludur... REZERVE EDİLEMEZ" );
                }

                if (x == TekKisilik[i]) //oda rezerve ediliyor. ve 100 e esitleniyor.
                {   
                    TekKisilik[i] = 100;
                    Console.WriteLine("Odamız müsait..");
                    Console.WriteLine("***Sectiginiz " + "" + i +" numaralı odayı rezerve ettiniz ***");
                    if(x>0&&x<=2)
                    {
                        Manzarasiz();
                    }
                    if (x<=6&&x>=3)
                    {
                        HavuzManzarali();
                    }
                    if(x>=7&&x<=10)
                    {
                        DenizManzarali();
                    }
                }


            }

           

            for (int j = 0; j < 10; j++)//
                {
                if (CiftKisilik[j] == 100 && j+10 == x)
                {
                    Console.WriteLine("Maalesef  " + x + ". odamız doludur... REZERVE EDİLEMEZ");
                }

                if (x == CiftKisilik[j]) //oda rezerve ediliyor. ve 100 e esitleniyor.
                {
                    CiftKisilik[j] = 100;
                    Console.WriteLine("Odamız müsait..");
                    Console.WriteLine("***Sectiginiz " + "" + x  + " numaralı odayı rezerve ettiniz ***");

                    if (x > 10 && x <=12)
                    {
                        Manzarasiz();
                    }
                    if (x < 17 && x >= 13)
                    {
                        HavuzManzarali();
                    }
                    if (x >= 17 && x <= 20)
                    {
                        DenizManzarali();
                    }
                }
            }

            return 0;

            }









        public void Rezİptal(int m)// rez iptali gerçekleştiriliyor.
        {

            for (int i = 0; i < 10; i++)
            {
                if (m == i && TekKisilik[i] == 100)
                {
                    TekKisilik[i] = i;//m ile kullanıcı kacinci odayı rezerve etmiş oldugunu giriyor.
                    Console.WriteLine("Rezervasyonunuzu iptal ettiniz..");

                }

            }
            for (int i = 11; i < 20; i++)
            {
                int a = 1;
                if (m == i && CiftKisilik[i] == 100)
                {
                    CiftKisilik[a] = i;
                    Console.WriteLine("Rezervasyonunuzu iptal ettiniz..");
                }
            }
           

        }

    }
}
