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

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.75;
            tomatoPrice = 6.50;

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 1.245;
            orangeGram = 0.957;
            strawberryGram = 1.584;
            potatoGram = 2.758;
            tomatoGram = 2.452;

            double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;
            appleTotalPrice = applePrice * appleGram;
            orangeTotalPrice = orangePrice * orangeGram;
            strawberryTotalPrice = strawberryPrice * strawberryGram;
            potatoTotalPrice = potatoPrice * potatoGram;
            tomatoTotalPrice = tomatoPrice * tomatoGram;

            double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"--- Elma Kg Fiyatı: {applePrice:0.00} TL");       
            Console.WriteLine($"--- Portakal Kg Fiyatı: {orangePrice:0.00} TL");       
            Console.WriteLine($"--- Çilek Kg Fiyatı: {strawberryPrice:0.00} TL");       
            Console.WriteLine($"--- Patates Kg Fiyatı: {potatoPrice:0.00} TL");       
            Console.WriteLine($"--- Domates Kg Fiyatı: {tomatoPrice:0.00} TL");  
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("***** Fatura *****");
            Console.WriteLine($"Satın Aldığınız Elma({appleGram} Gr) Fiyatı: {appleTotalPrice:0.00} TL");       
            Console.WriteLine($"Satın Aldığınız Portakal({orangeGram} Gr) Fiyatı: {orangeTotalPrice:0.00} TL");       
            Console.WriteLine($"Satın Aldığınız Çilek({strawberryGram} Gr) Fiyatı: {strawberryTotalPrice:0.00} TL");       
            Console.WriteLine($"Satın Aldığınız Patates({potatoGram} Gr) Fiyatı: {potatoTotalPrice:0.00} TL");       
            Console.WriteLine($"Satın Aldığınız Domates({tomatoGram} Gr) Fiyatı: {tomatoTotalPrice:0.00} TL");
            Console.WriteLine($"--- Toplam Ödeyeceğiniz Tutar: {totalPrice:0.00} TL");



            #endregion

            Console.ReadLine();
        }
    }
}
