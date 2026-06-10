using System.Linq.Expressions;

namespace CSharpAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            // Console.WriteLine("***** Yemek Fiyatları:");
            // Console.Write("1-Çorba:");
            // Console.Write("50TL");

            // Saçma ancak en azından WriteLine() ile Write() arasındaki farkı açıklar nitelikte :D

            #endregion

            #region String Değişkenler

            // degisken_turu degisken_adi = deger;   yada    degisken-turu degisken_adi;
            // camelCase.    kabab-case.    

            // string name = "Muhammed";
            // Console.WriteLine(name);

            // string customerName;
            // string customerSurname;
            // string customerPhone;
            // string customerEmail, customerDistrict, customerCity;

            // customerName = "Ali";
            // customerSurname = "Çınar";
            // customerPhone = "+90 500 400 30 20";
            // customerEmail = "ali@email.com";
            // customerDistrict = "Kadıköy";
            // customerCity = "İstanbul";

            // Console.WriteLine("***** Rezervasyon Kartı *****");
            // Console.WriteLine();
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("İletişim: " + customerPhone);
            // Console.WriteLine("Email Adresi: " + customerEmail);
            // Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine();

            // customerName = "Ayşe";
            // customerSurname = "Kaya";
            // customerPhone = "+90 500 400 20 30";
            // customerEmail = "ayse@email.com";
            // customerDistrict = "Bağcılar";
            // customerCity = "İstanbul";

            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("İletişim: " + customerPhone);
            // Console.WriteLine("Email Adresi: " + customerEmail);
            // Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            // Console.WriteLine("------------------------------------------------");

            #endregion

            #region Integer Değişkenler

            // int number;
            // number = 24;
            // Console.WriteLine(number);

            // int burgerPrice = 300;
            // int cokePrice = 60;
            // int waterPrice = 15;
            // int friesPrice = 90;
            // int pizzaPrice = 200;
            // int lemonadePrice = 60;

            // Console.WriteLine("***** RESTAURANT MENÜ *****");
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine($"Burger: {burgerPrice} TL");
            // Console.WriteLine($"Pizza: {pizzaPrice} TL");
            // Console.WriteLine($"Patates K.: {friesPrice} TL");
            // Console.WriteLine($"Su: {waterPrice} TL");
            // Console.WriteLine($"Limonata: {lemonadePrice} TL");
            // Console.WriteLine($"Kola: {cokePrice} TL");
            // Console.WriteLine("-----------------------------------------------");
            // Console.WriteLine();

            // int burgerCount = 3;
            // int pizzaCount = 3;
            // int friesCount = 3;
            // int waterCount = 1;
            // int lemonadeCount = 0;
            // int cokeCount = 0;

            // int totalBurgerPrice = burgerPrice * burgerCount;
            // int totalPizzaPrice = pizzaPrice * pizzaCount;
            // int totalFriesPrice = friesPrice * friesCount;
            // int totalWaterPrice = waterPrice * waterCount;
            // int totalLemonadePrice = lemonadePrice * lemonadeCount;
            // int totalCokePrice = cokePrice * cokeCount;
            // int totalPrice = totalBurgerPrice + totalPizzaPrice + totalFriesPrice + totalWaterPrice + totalLemonadePrice + totalCokePrice;

            // Console.WriteLine("***** Fatura *****");
            // Console.WriteLine("***********************************************");
            // Console.WriteLine($"Burger Fiyatı: {totalBurgerPrice} TL");
            // Console.WriteLine($"Pizza Fiyatı: {totalPizzaPrice} TL");
            // Console.WriteLine($"Patates K. Fiyatı: {totalFriesPrice} TL");
            // Console.WriteLine($"Su Fiyatı: {totalWaterPrice} TL");
            // Console.WriteLine($"Limonata Fiyatı: {totalLemonadePrice} TL");
            // Console.WriteLine($"Kola Fiyatı: {totalCokePrice} TL");
            // Console.WriteLine($"----- Toplam Ödenecek Tutar: {totalPrice} TL");
            // Console.WriteLine("***********************************************");

            #endregion

            #region Double Değişkenler

            // double number = 4.85;
            // Console.WriteLine(number);

            // double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            // applePrice = 14.85;
            // orangePrice = 20.95;
            // strawberryPrice = 45;
            // potatoPrice = 9.75;
            // tomatoPrice = 6.50;

            // double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            // appleGram = 1.245;
            // orangeGram = 0.957;
            // strawberryGram = 1.584;
            // potatoGram = 2.758;
            // tomatoGram = 2.452;

            // double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;
            // appleTotalPrice = applePrice * appleGram;
            // orangeTotalPrice = orangePrice * orangeGram;
            // strawberryTotalPrice = strawberryPrice * strawberryGram;
            // potatoTotalPrice = potatoPrice * potatoGram;
            // tomatoTotalPrice = tomatoPrice * tomatoGram;

            // double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            // Console.WriteLine("***** Fiyat Listesi *****");
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine($"--- Elma Kg Fiyatı: {applePrice:0.00} TL");       
            // Console.WriteLine($"--- Portakal Kg Fiyatı: {orangePrice:0.00} TL");       
            // Console.WriteLine($"--- Çilek Kg Fiyatı: {strawberryPrice:0.00} TL");       
            // Console.WriteLine($"--- Patates Kg Fiyatı: {potatoPrice:0.00} TL");       
            // Console.WriteLine($"--- Domates Kg Fiyatı: {tomatoPrice:0.00} TL");  
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine();
            // Console.WriteLine("***** Fatura *****");
            // Console.WriteLine($"Satın Aldığınız Elma({appleGram} Gr) Fiyatı: {appleTotalPrice:0.00} TL");       
            // Console.WriteLine($"Satın Aldığınız Portakal({orangeGram} Gr) Fiyatı: {orangeTotalPrice:0.00} TL");       
            // Console.WriteLine($"Satın Aldığınız Çilek({strawberryGram} Gr) Fiyatı: {strawberryTotalPrice:0.00} TL");       
            // Console.WriteLine($"Satın Aldığınız Patates({potatoGram} Gr) Fiyatı: {potatoTotalPrice:0.00} TL");       
            // Console.WriteLine($"Satın Aldığınız Domates({tomatoGram} Gr) Fiyatı: {tomatoTotalPrice:0.00} TL");
            // Console.WriteLine($"--- Toplam Ödeyeceğiniz Tutar: {totalPrice:0.00} TL");

            #endregion

            #region Char Değişkenler

            //Şifreli Cümle: TOPLANTI SAAT 20.00'DE

            // char symbol = 'a';           //Şimdilik bu kadar. not: char değişkeni " ile değil ' ile atanır
            // Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri - String Değişkenler

            // string passengerName, passengerSurname, passengerCity, passengerDistrict, passengerIdNumber, passengerAge;

            // Console.WriteLine("***** CSharp Hava Yolları - Yolcu Kayıt *****");
            // Console.WriteLine("*********************************************");

            // Console.Write("Yolcu Adı: ");
            // passengerName = Console.ReadLine()!;

            // Console.Write("Yolcu Soyadı: ");
            // passengerSurname = Console.ReadLine()!;

            // Console.Write("Yolcu İkamet Ettiği Şehir: ");
            // passengerCity = Console.ReadLine()!;

            // Console.Write("Yolcu İkamet Ettiği İlçe: ");
            // passengerDistrict = Console.ReadLine()!;

            // Console.Write("Yolcu Kimlik No: ");
            // passengerIdNumber = Console.ReadLine()!;

            // Console.Write("Yolcu Yaşı: ");
            // passengerAge = Console.ReadLine()!;

            // Console.WriteLine("*********************************************");
            // Console.WriteLine();
            // Console.WriteLine("---------------- Yolcu Kartı ----------------");
            // Console.WriteLine($"Yolcu Ad Soyad: {passengerName} {passengerSurname}");
            // Console.WriteLine($"Yolcu İkametgah: {passengerDistrict}/{passengerCity}");
            // Console.WriteLine($"Yolcu Kimlik Numarası: {passengerIdNumber}");
            // Console.WriteLine($"Yolcu Yaşı: {passengerAge}");
            // Console.WriteLine("---------------------------------------------");

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            // int shoePrice, computerPrice, tvPrice, chairPrice;
            // shoePrice = 1000;
            // computerPrice = 20000;
            // tvPrice = 12000;
            // chairPrice = 5000;

            // int shoeCount, computerCount, tvCount, chairCount;

            // Console.WriteLine("-------------------------- Sipariş --------------------------");
            // Console.Write("Lütfen satın almak istediğiniz ayakkabı sayısını giriniz: ");
            // shoeCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen satın almak istediğiniz bilgisayar sayısını giriniz: ");
            // computerCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen satın almak istediğiniz televizyon sayısını giriniz: ");
            // tvCount = int.Parse(Console.ReadLine());

            // Console.Write("Lütfen satın almak istediğiniz koltuk sayısını giriniz: ");
            // chairCount = int.Parse(Console.ReadLine());
            // Console.WriteLine("-------------------------------------------------------------");
            // Console.WriteLine();

            // int totalPrice = shoePrice * shoeCount + computerPrice * computerCount + tvPrice * tvCount + chairPrice * chairCount;

            // Console.WriteLine("************************** Fatura **************************");
            // Console.WriteLine($"Toplam Ödemeniz: {totalPrice} TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri


            // double exam1, exam2, exam3, result;

            // Console.Write("1. Sınav notunuzu giriniz: ");
            // exam1 = double.Parse(Console.ReadLine());

            // Console.Write("2. Sınav notunuzu giriniz: ");
            // exam2 = double.Parse(Console.ReadLine());

            // Console.Write("3. Sınav notunuzu giriniz: ");
            // exam3 = double.Parse(Console.ReadLine());

            // result = (exam1 + exam2 + exam3) /3;

            // Console.WriteLine("***** Sonuç *****");
            // Console.WriteLine($"Ortalamanız: {result:0.00}");

            #endregion

            #region Klavyeden Karakter Girişleri

            // Console.Write("Cinsiyet Seçiniz[E/K]: ");
            // char gender = char.Parse(Console.ReadLine());

            // Console.WriteLine($"Seçtiğiniz Cinsiyet: {gender}");

            #endregion

            #region If Else

            // Console.Write("Lütfen şifreyi giriniz: ");
            // string passwd = Console.ReadLine()!;
            // if (passwd == "abcd")
            // {
            //     Console.WriteLine("Şifre Doğru!");
            // }
            // else
            // {
            //     Console.WriteLine("Şifre Yanlış...");
            // }


            // string country, capital;

            // Console.Write("Lütfen Ülkeyi Giriniz: ");
            // country = Console.ReadLine()!;

            // Console.Write("Lütfen Başkenti Giriniz: ");
            // capital = Console.ReadLine()!;

            // if (country == "Türkiye" & capital == "Ankara")
            // {
            //     Console.WriteLine("Veriler Doğrulandı!");
            // }
            // else
            // {
            //     Console.WriteLine("Veriler Doğrulanamadı...");
            // }


            // double exam1, exam2, exam3, average;
            // string result;

            // Console.Write("Sınav 1: ");
            // exam1 = double.Parse(Console.ReadLine()!);
            // Console.Write("Sınav 2: ");
            // exam2 = double.Parse(Console.ReadLine()!);
            // Console.Write("Sınav 3: ");
            // exam3 = double.Parse(Console.ReadLine()!);
            // average = (exam1 + exam2 + exam3) / 3;

            // if (average >= 0 & average < 45)
            // {
            //     result = "Dersten kaldınız";
            //     Console.WriteLine($"Sınav Ortalamanız: {average:0.00}");
            //     Console.WriteLine($"Sınav Sonucunuz: {result}");
            // }
            // else if (average > 46 & average < 80)
            // {
            //     result = "Dersten geçtiniz, ancak puanınız çok da iyi değil";
            //     Console.WriteLine($"Sınav Ortalamanız: {average:0.00}");
            //     Console.WriteLine($"Sınav Sonucunuz: {result}");
            // }
            // else if (average > 81 & average <= 100)
            // {
            //     result = "Dersten yüksek bir puan ile geçtiniz";
            //     Console.WriteLine($"Sınav Ortalamanız: {average:0.00}");
            //     Console.WriteLine($"Sınav Sonucunuz: {result}");
            // }
            // else
            // {
            //     result = "Sonuç yok, geçersiz değerler girilmiş";
            //     Console.WriteLine($"Sınav Ortalamanız: {average:0.00}");
            //     Console.WriteLine($"Sınav Sonucunuz: {result}");
            // }


            // Console.Write("Yaşadığınız Şehri Giriniz: ");
            // string city = Console.ReadLine()!;

            // if (city == "Söğüt" | city == "İstanbul" | city == "Bursa" | city == "Edirne")
            // {
            //     Console.WriteLine("Yaşadığınız Şehir Osmanlı İmparatorluğunun Payitahtlarından Biriydi.");
            // }
            // else
            // {
            //     Console.WriteLine("Yaşadığınız Şehir Osmanlı İmparatorluğunun Payitahtlarından Biri Değildi");
            // }


            // string username, passwd;
            // Console.Write("Kullanıcı Adınızı Giriniz: ");
            // username = Console.ReadLine()!;
            // Console.Write("Şifrenizi Giriniz: ");
            // passwd = Console.ReadLine()!;

            // if (username == "admin" & passwd == "admin")
            // {
            //     Console.WriteLine("Hoşgeldiniz Sayın Admin.");
            // }
            // else
            // {
            //     Console.WriteLine($"Hoşgeldiniz, {username}.");
            // }

            #endregion

            #region Mod İşlemleri

            // int number = 26;
            // int result = number % 5;
            // Console.WriteLine(result);


            // Console.Write("1. Sayıyı Giriniz: ");
            // int number1 = int.Parse(Console.ReadLine()!);

            // Console.Write("2. Sayıyı Giriniz: ");
            // int number2 = int.Parse(Console.ReadLine());

            // int result = number1 % number2;
            // Console.WriteLine($"1. Sayının 2. Sayıya bölümünden kalanı: {result}");


            // Console.Write("Lütfen Sayıyı Giriniz: ");
            // int number = int.Parse(Console.ReadLine()!);

            // if (number % 2 == 0)
            // {
            //     Console.WriteLine("Girdiğiniz sayı çift");
            // }
            // else
            // {
            //     Console.WriteLine("Girdiğiniz sayı tek");
            // }

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            // Console.Write("Takımın sembolünü giriniz: ");
            // char symbol = char.Parse(Console.ReadLine()!);

            // if (symbol == 'g' | symbol == 'G')
            // {
            //     Console.WriteLine("Galatasaray");
            // }
            // else if (symbol == 'f' | symbol == 'F')
            // {
            //     Console.WriteLine("Fenerbahçe");
            // }
            // else if (symbol == 'b' | symbol == 'B')
            // {
            //     Console.WriteLine("Beşiktaş");
            // }
            // else if (symbol == 't' | symbol == 'T')
            // {
            //     Console.WriteLine("Trabzonspor");
            // }
            // else
            // {
            //     Console.WriteLine("Girdiğiniz Takım Geçersiz");
            // }

            #endregion

            #region Örnek Proje Uygulamaları

            Console.WriteLine("**** C# Eğitim Kampı Restoran *****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1- Ana Yemekler");
            Console.WriteLine("2- Çorbalar");
            Console.WriteLine("3- Pizzalar");
            Console.WriteLine("4- İçecekler");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();
            Console.Write("Lütfen Seçiminizi Yapınız: ");
            string selection = Console.ReadLine()!;

            if (selection == "1")
            {
                Console.WriteLine();
                Console.WriteLine("------------ Ana Yemekler ----------");
                Console.WriteLine();
                Console.WriteLine("1- Köri Soslu Tavuk");
                Console.WriteLine("2- Pilav Üstü Tavuk Sote");
                Console.WriteLine("3- Kızartma Tabağı");
                Console.WriteLine("4- Karışık Izgara");
                Console.WriteLine("5- Kuru Fasulye");
            }
            else if (selection == "2")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- Çorbalar ------------");
                Console.WriteLine();
                Console.WriteLine("1- Ezogelin Çorbası");
                Console.WriteLine("2- Mercimek Çorbası");
                Console.WriteLine("3- İşkembe Çorbası");
                Console.WriteLine("4- Ayran Çorbası");
                Console.WriteLine("5- Düğün Çorbası");
            }
            else if (selection == "3")
            {
                Console.WriteLine();
                Console.WriteLine("-------------- Pizzalar ------------");
                Console.WriteLine();
                Console.WriteLine("1- Margaritha");
                Console.WriteLine("2- Akdeniz Pizza");
                Console.WriteLine("3- Tavuklu Pizza");
            }
            else if (selection == "4")
            {
                Console.WriteLine();
                Console.WriteLine("------------- İçecekler ------------");
                Console.WriteLine();
                Console.WriteLine("1- Su");
                Console.WriteLine("2- Çay");
                Console.WriteLine("3- Kahve");
                Console.WriteLine("4- Limonata");
                Console.WriteLine("5- Ayran");
            }
            else if (selection == "5")
            {
                Console.WriteLine();
                Console.WriteLine("------------- Tatlılar -------------");
                Console.WriteLine();
                Console.WriteLine("1- Soğuk Baklava");
                Console.WriteLine("2- Sıcak Baklava");
                Console.WriteLine("3- Kadayıf");
                Console.WriteLine("4- Künefe");
                Console.WriteLine("5- Şekerpare");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("!!!       Geçersiz Seçim        !!!");
                Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
