using System;

using System.Collections.Generic;

namespace lb8_1
{
    
    class DiscPhone
    {
        public DiscPhone()
        {
        }

        public DiscPhone(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public string PhoneNumber { get; set; }

        public virtual List<char> AllowedSymbs => new List<char>
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
        };

        protected string EnterNumber()
        {
            
            Console.Write("Enter the subscriber's number: ");
            while (true)
            {
                var invalid = false;
                PhoneNumber = Console.ReadLine();
                if (PhoneNumber != null)
                {
                    foreach (var symbol in PhoneNumber)
                        if (!AllowedSymbs.Contains(symbol))
                        {
                            invalid = true;
                            break;
                        }

                    if (invalid)
                    {
                        Console.Write("Error. Try again: ");
                        continue;
                    }

                    return PhoneNumber;
                }

                Console.Write("Error. Try again: ");
            }
        }

        public virtual void Call()
        {
            Console.WriteLine($"Calling a number {EnterNumber()}");
        }

        public virtual void TakeCall(string callingNum)
        {
            Console.WriteLine("Incoming call");
        }
    }
     class ButtonPhone : DiscPhone
    {
        public ButtonPhone(string phoneNum) : base(phoneNum)
        {
        }

        public override List<char> AllowedSymbs => new List<char>
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#'
        };

        public override void TakeCall(string callingNum)
        {
            Console.WriteLine($"Incoming call from {callingNum}");
        }
    }
    class ColorlessPhone : ButtonPhone
    {
        public ColorlessPhone(string phoneNum, int screenWidth, int screenHeight, int screenResolution,
            string phoneColor) : base(phoneNum)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
            ScreenResolution = screenResolution;
            PhoneColor = phoneColor;
        }

        public override List<char> AllowedSymbs => new List<char>
        {
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '*', '#',
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '+'
        };

        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int ScreenResolution { get; set; }
        public string PhoneColor { get; set; }

        public void SendSms(string sms, string recipientNumber)
        {
            Console.WriteLine($"A message has been sent to the subscriber: {recipientNumber}  \"{sms}\"");
        }

        public void GetSms(string sms, string senderNumber)
        {
            Console.WriteLine($" Received message from {senderNumber} \"{sms}\" ");
        }
    }
    class ColorfulPhone : ColorlessPhone
    {
        public ColorfulPhone(string phoneNum, int screenWidth, int screenHeight, int screenResolution,
            string phoneColor,
            int colorAmount, bool isTwoSim, string secondPhoneNumber = null)
            : base(phoneNum, screenWidth, screenHeight, screenResolution, phoneColor)
        {
            ColorAmount = colorAmount;
            IsTwoSim = isTwoSim;
            SecondPhoneNumber = secondPhoneNumber;
        }

        public int ColorAmount { get; set; }
        public bool IsTwoSim { get; set; }
        public string SecondPhoneNumber { get; set; }

        public void SendMms(string recipientNumber)
        {
            Console.WriteLine($"MMS message was sent. To: {recipientNumber} ");
        }

        public void GetMms(string senderNumber)
        {
            Console.WriteLine($"Received MMS from {senderNumber}");
        }
    }
    class SmartPhone : ColorfulPhone
    {
        public SmartPhone(string phoneNum, int screenWidth, int screenHeight, int screenResolution, string phoneColor,
            int colorAmount, bool isTwoSim, bool touchScreen, int touchCounter, int cameraQuantity,
            string secondPhoneNumber)
            : base(phoneNum, screenWidth, screenHeight, screenResolution, phoneColor, colorAmount, isTwoSim,
                secondPhoneNumber)
        {
        }

        public bool TouchScreen { get; set; }
        public int TouchCounter { get; set; }
        public int CameraQuantity { get; set; }

        public void TakePhoto()
        {
            Console.WriteLine("Photo taken.");
        }

        public void RecordVideo()
        {
            Console.WriteLine("Recorded video.");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Hi! This is program about phones. ");
            Console.WriteLine("Disc Phone:");
            var discPhone = new DiscPhone("111");

            Console.Write("Available symbols: ");
            foreach (var sym in discPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Number: {discPhone.PhoneNumber}");
            discPhone.Call();
            discPhone.TakeCall("111");

            Console.WriteLine(new string('_', 20));

            Console.WriteLine("A push-button phone:");
            var bPhone = new ButtonPhone("222");

            Console.Write("Available symbols: ");
            foreach (var sym in bPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Number: {bPhone.PhoneNumber}");
            bPhone.Call();
            bPhone.TakeCall("222");

            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Phone with a black and white screen:");
            var colorlessPhone = new ColorlessPhone("333", 50, 100, 2, "Black");

            Console.Write("Available symbols: ");
            foreach (var sym in colorlessPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Number: {colorlessPhone.PhoneNumber}");
            Console.WriteLine($"Screen width (pixels): {colorlessPhone.ScreenWidth}");
            Console.WriteLine($"Screen height (pixels): {colorlessPhone.ScreenHeight}");
            Console.WriteLine($"Screen size (inches): {colorlessPhone.ScreenResolution}");
            Console.WriteLine($"Phone Color: {colorlessPhone.PhoneColor}");
            colorlessPhone.Call();
            colorlessPhone.TakeCall("111");
            colorlessPhone.SendSms("Welcome!", "068");
            colorlessPhone.GetSms("How are u?", "111");


            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Phone with a color screen:");
            var colorPhone = new ColorfulPhone("444", 200, 456, 5, "Black", 16000000, true, "666");

            Console.Write("Available symbols: ");
            foreach (var sym in colorPhone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Number: {colorPhone.PhoneNumber}");
            Console.WriteLine($"Screen width (pixels): {colorPhone.ScreenWidth}");
            Console.WriteLine($"Screen height (pixels): {colorPhone.ScreenHeight}");
            Console.WriteLine($"Screen size (inches): {colorPhone.ScreenResolution}");
            Console.WriteLine($"Phone Color: {colorPhone.PhoneColor}");
            Console.WriteLine($"Number of SIM cards: {(colorPhone.IsTwoSim ? 2 : 1)}");
            Console.WriteLine($"Number two: {(colorPhone.IsTwoSim ? colorPhone.SecondPhoneNumber : "-")}");
            colorPhone.Call();
            colorPhone.TakeCall("111");
            colorPhone.SendSms("Welcome!", "068");
            colorPhone.GetSms("How are u?", "111");
            colorPhone.SendMms("123123");
            colorPhone.GetMms("111");


            Console.WriteLine(new string('_', 20));

            Console.WriteLine("Smartphone: ");
            var smartphone = new SmartPhone("555", 1080, 1920, 6, "Black", 16777216, true, true, 10, 3, "102");

            Console.Write("Available symbols: ");
            foreach (var sym in smartphone.AllowedSymbs)
                Console.Write(sym + " ");
            Console.WriteLine();
            Console.WriteLine($"Number: {smartphone.PhoneNumber}");
            Console.WriteLine($"Screen width (pixels): {smartphone.ScreenWidth}");
            Console.WriteLine($"Screen height (pixels): {smartphone.ScreenHeight}");
            Console.WriteLine($"Screen size (inches): {smartphone.ScreenResolution}");
            Console.WriteLine($"Phone Color: {smartphone.PhoneColor}");
            Console.WriteLine($"Number of SIM cards: {(smartphone.IsTwoSim ? 2 : 1)}");
            Console.WriteLine($"Number two: {(smartphone.IsTwoSim ? smartphone.SecondPhoneNumber : "-")}");
            Console.WriteLine($"Touch Screen: {(smartphone.TouchScreen ? "yes" : "no")}");
            Console.WriteLine($"Maximum number of touches: {smartphone.TouchCounter}");
            Console.WriteLine($"Number of cameras: {smartphone.CameraQuantity}");
            colorPhone.Call();
            colorPhone.TakeCall("111");
            colorPhone.SendSms("Welcome!", "068");
            colorPhone.GetSms("How are u?", "111");
            colorPhone.SendMms("123123");
            colorPhone.GetMms("111");
            smartphone.TakePhoto();
            smartphone.RecordVideo();
            Console.Write("Thank you! ");
            Console.ReadLine();
        }
    }
}

