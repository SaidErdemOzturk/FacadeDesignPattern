using System;

namespace FacadeCalisma
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade f = new Facade();
            f.ParaGonder();
        }
    }
    class Kontrol
    {
        public bool KrediKullanimKontrolu()
        {
            return true;
        }
        public bool HesapBakiesiKontrolu()
        {
            return true;
        }
    }
    class EftManager
    {
        public void SendEft(Kontrol kontrol)
        {
            if (kontrol.HesapBakiesiKontrolu())
            {
                Console.WriteLine("Para transferi gerçekleşti");
            }
        }
    }
    class KrediMaanger
    {
        public void UseCredit(Kontrol kontrol)
        {
            if (kontrol.KrediKullanimKontrolu())
            {
                Console.WriteLine("Kredi çekildi");
            }
        }
    }
    class Facade
    {
        public void KrediCek()
        {
            Kontrol kontrol = new Kontrol();

            KrediMaanger kredi = new KrediMaanger();
            kredi.UseCredit(kontrol);
        }
        public void ParaGonder()
        {
            Kontrol kontrol = new Kontrol();
            EftManager eft = new EftManager();
            eft.SendEft(kontrol);
        }
    }
}
