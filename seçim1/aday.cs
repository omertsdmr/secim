using System;
using System.Collections.Generic;
using System.Text;

namespace seçim1
{
    public class aday
    {
        public string adayisim;
        public string adaysoyisim;
        public string adaymeslek;
        public string adaypartisi;
        public string partiözellikler;
        public int Apartisioy;
        public int Bpartisioy;
        public int Cpartisioy;
        public  void adaybilgileri()
        {
            Console.WriteLine("aday ismi :"+ adayisim);
            Console.WriteLine("aday soyismi :"+adaysoyisim);
            Console.WriteLine("aday mesleği :"+ adaymeslek);
            Console.WriteLine("aday partisi :" + adaypartisi);
           
        }
        public aday(string _isim,string _soyisim, string _meslek, string _partisi)
        {
            adayisim = _isim;
            adaysoyisim = _soyisim;
            adaymeslek = _meslek;
            adaypartisi = _partisi;

            

        }
        public void parti()
        {
            Console.WriteLine("parti özellikleri :"+partiözellikler);
        }
        public aday(string vaatler)
        {
            partiözellikler = vaatler;
        }

        public void partiler()
        {
            Console.WriteLine("A partisi :"+Apartisioy);
            Console.WriteLine("B partisi :"+Bpartisioy);
            Console.WriteLine("C partisi :"+Cpartisioy);
        }
        public aday(int Apartisi,int Bpartisi,int Cpartisi)
        {
            Apartisioy = Apartisi;
            Bpartisioy = Bpartisi;
            Cpartisioy = Cpartisi;
             
 
        }

    }
}
