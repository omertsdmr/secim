using System;
using System.Collections.Generic;
using System.Text;

namespace seçim1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            bool kontrol2 = true;

            aday aday1 = new aday("ali", "buldu", "doktor", "A partisi");
            aday aday2 = new aday("enis", "mesut", "tekstil mühendis", "A partisi");
            aday aday3 = new aday("gül berin", "can", "psikolog", "B partisi");
            aday aday4 = new aday("mustafa", "güçlü", "futbolcu", "B partisi");
            aday aday5 = new aday("mehmet ", "mutlu", "ekonomist", "C partisi");
            aday aday6 = new aday("burak", "hızlı", "çiftçi", "C partisi");
            aday parti = new aday("A partisi");
            aday partiler = new aday("");

            Console.WriteLine("SEÇİMLERE HOŞGELDİNİZ.. SIRASIYLA ADINIZI , SOYADINIZI VE YAŞINIZI GİRİNİZ...");


            
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine("lütfen adınızı giriniz :");
            string isim = Console.ReadLine();


            Console.WriteLine("Lütfen soyadınızı girin :");
            string soyİsim = Console.ReadLine();


            Console.WriteLine("Lütfen yaşınızı girin :");
            int yas = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("isim : " + isim);
            Console.WriteLine("soyisim : " + soyİsim);
            Console.WriteLine("yaş : " + yas);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            if (yas < 18)
            {
                Console.WriteLine("Oy kullanmaya yaşınız yetmiyor 18 yaşını doldurduktan sonra oy kullanabilirsiniz..");
                Console.ReadLine();

            }
            else { 
            
                while (kontrol)
                {
                    işlemlerigöster();

                    string seçim = Console.ReadLine();
                    switch (seçim)
                    {
                        case "1":
                            Console.WriteLine("1. ADAY :");
                            aday1.adaybilgileri();
                            Console.WriteLine(" ");
                            Console.WriteLine("2. ADAY :");
                            aday2.adaybilgileri();
                            Console.WriteLine(" ");
                            Console.WriteLine("3. ADAY :");
                            aday3.adaybilgileri();
                            Console.WriteLine(" ");
                            Console.WriteLine("4. ADAY :");
                            aday4.adaybilgileri();
                            Console.WriteLine(" ");
                            Console.WriteLine("5. ADAY :");
                            aday5.adaybilgileri();
                            Console.WriteLine(" ");
                            Console.WriteLine("6. ADAY :");
                            aday6.adaybilgileri();
                            Console.WriteLine(" ");

                            break;
                        case "2":

                            partiözellikleri();
                            break;
                        case "3":
                            oykullan();

                            break;

                            

                        case "4":
                            kontrol = false;
                            break;
                            

                    }



                }


            }
            void işlemlerigöster()
            {
                Console.WriteLine("1- aday bilgilerini göster");
                Console.WriteLine("2-parti bilgilerini göster");
                Console.WriteLine("3-oy kullan");
                Console.WriteLine("4-çıkış yap");

            }
            void partiözellikleri()
            {
                Console.WriteLine("A partisinin açıklamaları");
                Console.WriteLine("A Partisi idealist bir partidir ve teknoloji gelişimini destekler..");
                Console.WriteLine("A Partsisinin vaatleri ülkede büyüyk bir teknoloji reformu gerçekleştirmektir.");
                Console.WriteLine(" ");
                Console.WriteLine("B partisinin aöıklamaları");
                Console.WriteLine("B Partisi halkçı bir partidir ve tarımı destekler");
                Console.WriteLine("B Partisinin amacı gelişmiş bir Tarım ülkesi olmasıdır.");
                Console.WriteLine("B Partisi tarım alanında yaptığı reformlarla çiftçiyide destekleyecek");
                Console.WriteLine(" ");
                Console.WriteLine("C partisinin açıklamaları ");

                Console.WriteLine("C Partisi devletçi bir partidir sanayi alanında reform yaparak saniyiyi güçlendirme fikrini benimsiyor.");
                Console.WriteLine("C Partisinin amacı sanayiyi savunma alanında ağırlıklı olarak güçlendirip devleti daha güçlü bir konuma getirmektir.");
                Console.WriteLine("C Partisi bu gelişme sonucu ekonimiyide güçlendirmeyi hedeflemektedir. ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }

           
            void oykullan()
            {

                int Apartisi = 0;
                int Bpartisi = 0;
                int Cpartisi = 0;

                while (kontrol2)
                {
                    
                    partilerigöster();
                    string kosul = Console.ReadLine();
                    switch (kosul)
                    {
                        case "1":
                            Console.WriteLine("A partisi");
                            Apartisi += 1;
                            
                            Console.WriteLine("A PARTİSİNİN OY SAYISI :"+ Apartisi );
                            break;
                        case "2":
                            Console.WriteLine("B partisi");
                            Bpartisi += 1;
                            Console.WriteLine("B PARTSİNİN OY SAYISI :" + Bpartisi);
                            break;
                        case "3":
                            Console.WriteLine("C partisi");
                            Cpartisi += 1;
                            Console.WriteLine("C partisinin oy sayısı :"+Cpartisi);
                         Console.WriteLine("");
                            break;
                        case "4":
                            Console.WriteLine(" ");
                            Console.WriteLine("HANGİ PARTİNİN ŞUANA KADAR KAÇ OY ALDIĞINI GÖRMEKTESİNİZ.");
                            Console.WriteLine("A partisinin oy sayısı :" + Apartisi);
                            Console.WriteLine("B partisinin oy sayısı :" + Bpartisi);
                            Console.WriteLine("C partisinin oy sayısı :" + Cpartisi);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            break;

                        case "5":
                            
                            if (Apartisi > Bpartisi && Apartisi>Cpartisi) 
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("KAZANAN A PARTİSİ");
                                Console.WriteLine(" ");
                            }
                            else if (Bpartisi > Apartisi && Bpartisi>Cpartisi)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("KAZANAN B PARTİSİ");
                                Console.WriteLine(" ");
                            }
                            else if (Cpartisi>Apartisi && Cpartisi>Bpartisi)
                            {
                                Console.WriteLine(" ");
                                Console.WriteLine("KAZANAN C PARTİSİ");
                                Console.WriteLine(" ");
                            }
                            break;
                        case "6":
                            kontrol2 = false;
                            break;

                            
                     }
                }
            }
            void partilerigöster()
            {
                Console.WriteLine("1-A PARTİSİNİ OY VER");
                Console.WriteLine("2-B PARTİSİNE OY VER");
                Console.WriteLine("3-C PARTİSİNE OY VER");
                Console.WriteLine("4-GÜNCEL OY SAYILARINI GÖR");
                Console.WriteLine("5-HANGİ PARTİNİN KAZANDIĞINI GÖR");
                Console.WriteLine("6-ÇIKIŞ YAP");
            }
            
        }
    }
}
