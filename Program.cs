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

            // Console.WriteLine("***** Reservation Card *****");
            // Console.WriteLine();
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            // Console.WriteLine("Contact: " + customerPhone);
            // Console.WriteLine("Email Address: " + customerEmail);
            // Console.WriteLine("Address: " + customerDistrict + "/" + customerCity);
            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine();

            // customerName = "Ayşe";
            // customerSurname = "Kaya";
            // customerPhone = "+90 500 400 20 30";
            // customerEmail = "ayse@email.com";
            // customerDistrict = "Bağcılar";
            // customerCity = "İstanbul";

            // Console.WriteLine("------------------------------------------------");
            // Console.WriteLine("Customer: " + customerName + " " + customerSurname);
            // Console.WriteLine("Contact: " + customerPhone);
            // Console.WriteLine("Email Address: " + customerEmail);
            // Console.WriteLine("Address: " + customerDistrict + "/" + customerCity);
            // Console.WriteLine("------------------------------------------------");

            #endregion

            #region Integer Değişkenler

            // int number;
            // number = 24;
            // Console.WriteLine(number);

            int burgerPrice = 300;
            int cokePrice = 60;
            int waterPrice = 15;
            int friesPrice = 90;
            int pizzaPrice = 200;
            int lemonadePrice = 60;

            Console.WriteLine("***** RESTAURANT MENU *****");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Burger: " + burgerPrice + " TL");
            Console.WriteLine("Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("Fries: " + friesPrice + " TL");
            Console.WriteLine("Water: " + waterPrice + " TL");
            Console.WriteLine("Lemonade: " + lemonadePrice + " TL");
            Console.WriteLine("Coke: " + cokePrice + " TL");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            int burgerCount = 3;
            int pizzaCount = 3;
            int friesCount = 3;
            int waterCount = 1;
            int lemonadeCount = 0;
            int cokeCount = 0;

            int totalBurgerPrice = burgerPrice * burgerCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
	        int totalFriesPrice = friesPrice * friesCount;
            int totalWaterPrice = waterPrice * waterCount;
	        int totalLemonadePrice = lemonadePrice * lemonadeCount;
	        int totalCokePrice = cokePrice * cokeCount;
	        int totalPrice = totalBurgerPrice + totalPizzaPrice + totalFriesPrice + totalWaterPrice + totalLemonadePrice + totalCokePrice;

            Console.WriteLine("***** RECEIPT *****");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Burger Price: " + totalBurgerPrice + " TL");
            Console.WriteLine("Pizza Price: " + totalPizzaPrice + " TL");
            Console.WriteLine("Fries Price: " + totalFriesPrice + " TL");
            Console.WriteLine("Water Price: " + totalWaterPrice + " TL");
            Console.WriteLine("Lemonade Price: " + totalLemonadePrice + " TL");
            Console.WriteLine("Coke Price: " + totalCokePrice + " TL");
            Console.WriteLine("----- Total Price to Pay: " + totalPrice + " TL");
            Console.WriteLine("***********************************************");

            #endregion

            Console.ReadLine();
        }
    }
}
