// variant - 6
using System;
using System.Collections.Generic;
using System.Text;



namespace sr
{

    class SmartphoneCollection
    {
        
        private readonly List<Smartphone> smartphonesCollection = new List<Smartphone>();
        public void AddSmartphones(Smartphone smartphones)
        {
            
            smartphonesCollection.Add(smartphones);
        }
        public List<int> FindSmartphone(Smartphone smartphones)
        {
            List<int> smartphonesFinded = new List<int>();
            smartphonesFinded.Clear();

            for (int i = 0; i < smartphonesCollection.Count; i++)
            {
                if (smartphones.Colors != null)
                {
                    bool colorTrue = false;
                    for (int j = 0; j < smartphonesCollection[i].Colors.Count; j++)
                    {
                        if (smartphonesCollection[i].Colors[j] == smartphones.Colors[0])
                        {
                            colorTrue = true;
                            break;
                        }
                    }
                    if (!colorTrue)
                        continue;
                }

                if (smartphones.Year != 0)
                {
                    if (smartphonesCollection[i].Year != smartphones.Year)
                        continue;
                }

                if (smartphones.Price != 0)
                {
                    if (smartphonesCollection[i].Price != smartphones.Price)
                        continue;
                }

                if (smartphones.Model != string.Empty)
                {
                    if (smartphonesCollection[i].Model != smartphones.Model)
                        continue;
                }
                smartphonesFinded.Add(i);
            }
            return smartphonesFinded;
        }
        public void PrintInfoSmartphone()
        {
            for (int i = 0; i < smartphonesCollection.Count; i++)
                Console.WriteLine(smartphonesCollection[i]);
        }
        public void PrintInfoSmartphone(List<int> smartphonesNumber)
        {
            if (smartphonesNumber.Count == 0)
                Console.WriteLine("We don't have such a phone.");
            foreach (var smartphones in smartphonesNumber)
                Console.WriteLine(smartphonesCollection[smartphones]);
        }
    }

    class Smartphone
    {
        public List<string> Colors = new List<string>();
        public int Year;
        public int Price;
        public string Model;
        public int Choice;
        public void InputInfo()
        {

           

            int numberColors = 0;
            while (true)
            {
                Console.Write("Number of phone colors: ");
                if (!int.TryParse(Console.ReadLine(), out numberColors) || numberColors < 0)
                    Console.WriteLine("Error. Try again: ");
                else
                    break;
            }

            for (int i = 0; i < numberColors; i++)
            {
                Console.Write($"Color {i + 1}: ");
                Colors.Add(Console.ReadLine());
            }

            while (true)
            {
                Console.Write("Year of issue: ");
                if (!int.TryParse(Console.ReadLine(), out Year) || Year < 1910)
                    Console.WriteLine("Error. Try again: ");
                else
                    break;
            }

            while (true)
            {
                Console.Write("Price: ");
                if (!int.TryParse(Console.ReadLine(), out Price) || Price < 1)
                    Console.WriteLine("Error. Try again: ");
                else
                    break;
            }

            Console.Write("Model: ");
            Model = Console.ReadLine();
           

        }
        public void InputInfoFind()
        {
            Console.WriteLine("Enter the phone information. If you don't have it, press 'Enter' to skip: ");
            Console.Write("Enter the color of the phone you would like: ");
            Colors.Add(Console.ReadLine());

            while (true)
            {
                Console.Write("Year of issue: ");
                string temp = Console.ReadLine();
                if (temp != string.Empty)
                {
                    if (!int.TryParse(temp, out Year) || Year < 1910)
                        Console.WriteLine("Error. Try again: ");
                    else
                        break;
                }
                else
                {
                    Year = 0;
                    break;
                }
            }

            while (true)
            {
                Console.Write("Price: ");
                string temp = Console.ReadLine();
                if (temp != string.Empty)
                {
                    if (!int.TryParse(temp, out Price) || Price < 1)
                        Console.WriteLine("Error. Try again: ");
                    else
                        break;
                }
                else
                {
                    Price = 0;
                    break;
                }
            }

            Console.Write("Model: ");
            Model = Console.ReadLine();
        }
        public override string ToString()
        {
            string smartphoneInfo = $"\nInformation about the phones: \nColors: ";
            foreach (var color in Colors)
            {
                smartphoneInfo += color + " ";
            }
            smartphoneInfo += $"\nYear of issue: {Year}\nPrice: {Price}\nModel: {Model}\n";

            return smartphoneInfo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            SmartphoneCollection smartphonesCollection = new SmartphoneCollection();
            Console.WriteLine("Welcome to the store.");
            Console.WriteLine("You need to enter information about 5 phones. ");
            for (int i = 0; i < 5; i++)
            {
                Smartphone smartphones = new Smartphone();
                Console.WriteLine($"You enter information about {i+1} phone");
                smartphones.InputInfo();
                smartphonesCollection.AddSmartphones(smartphones);
            }

            

            bool workShop = true;
            while (workShop)
            {
                Console.WriteLine(" \n[1] Find the desired phone model \n[2] Display all phone models \n[0] Exit ");
                int select;
                while (true)
                {
                    Console.Write(" Your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out select) || select > 0 || select < 2)
                        break;
                    else
                        Console.WriteLine("Error. Try again: ");
                }
                switch (select)
                {
                    case 0:
                        workShop = false;
                        break;
                    case 1:
                        Smartphone smartphonesFind = new Smartphone();
                        smartphonesFind.InputInfoFind();
                        smartphonesCollection.PrintInfoSmartphone(smartphonesCollection.FindSmartphone(smartphonesFind));

                        break;
                    case 2:
                        smartphonesCollection.PrintInfoSmartphone();
                        break;
                    default:
                        break;
                }
            }


        }
    }
}
