using System;
namespace proje_son
{
    public class Rezervasyon
    {
       
        public static void Rezerve(int x)
        {
            // rezervasyon istediğini otele iletiyor.
            Otel.Rezgonder(x);

        }
        public static void Rezİp(int x)
        {
            Otel.Rezİptalgonder(x);
            // rezervasyon iptal isteğini otele iletiyor.

        }

        public static void DolulukSor()
        {

            Otel.DolulukOrani();
        }
        public static void RezGöster()
        {
            Otel.RezGöster();
        }
        public static void RezTarihiGoster()
        {
            Otel.TarihGoster();
        }
    }
     
}
