// variant - 3
using System;


namespace lb11
{

    class Patient
    {
        Random random = new Random();

        public delegate void Operation(Hospital hospi);
        public void MRIpassed(Hospital hospi) // МРТ пройдено
        {
            if (random.Next(2) == 1)
                hospi.MRI = true;
            else
                hospi.MRI = false;
        }

        public void CTscansPassed(Hospital hospi) // КТ пройдено
        {
            if (random.Next(2) == 1)
                hospi.CTscans = true;
            else
                hospi.CTscans = false;
        }

        public void XraysPassed(Hospital hospi) // Рентген пройдено
        {
            if (random.Next(2) == 1)
                hospi.Xrays = true;
            else
                hospi.Xrays = false;
        }

        public void ExaminationByENTpassed(Hospital hospi) // обслідування у ЛОР пройден
        {
            if (random.Next(2) == 1)
                hospi.ENT = true;
            else
                hospi.ENT = false;
        }

        public void TheUltrasoundpassed(Hospital hospi) // УЗИ пройдено
        {
            if (random.Next(2) == 1)
                hospi.Ultrasound = true;
            else
                hospi.Ultrasound = false;
        }

        public void RheumoTestsPassed(Hospital hospi) // ревмо-проби пройден
        { 
            if (random.Next(2) == 1)
                hospi.RheumoTests = true;
            else
                hospi.RheumoTests = false;
        }

    }

    class Hospital
    {
        public bool MRI { get; set; } = true; // МРТ
        public bool CTscans { get; set; } = true; // КТ
        public bool Xrays { get; set; } = true; // Рентген
        public bool ENT { get; set; } = true; // обслідування у ЛОР
        public bool Ultrasound { get; set; } = true; // УЗИ
        public bool RheumoTests { get; set; } = true; // ревмо-проби

        public override string ToString() =>
            $"\n MRI \t{MRI}\n CTscans: \t{CTscans}" +
            $"\nXrays: \t{Xrays}\nENT: \t{ENT}\nUltrasound: \t{Ultrasound}" +
            $"\nRheumoTests: \t{RheumoTests}\n";
    }



    class Program
    {

        static void Main(string[] args)
        {
            Patient hospital = new Patient();
            Hospital hospi = new Hospital();
            Patient.Operation operation = null;

            Console.WriteLine("Hospital.");
            while (true)
            {
                Console.WriteLine("Have you had an...");
                Console.Write("MRI?\n 1 - Yea\n 0 - No");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += hospital.MRIpassed;

                Console.Write("CTscans?\n1 - Yea\n 0 - No");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += hospital.CTscansPassed;

                Console.Write("Xrays?\n1 - Yea\n 0 - No");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += hospital.XraysPassed;

                Console.Write("ENT?\n1 - Yea\n 0 - No");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += hospital.ExaminationByENTpassed;

                Console.Write("Ultrasound?\n1 - Yea\n 0 - No");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += hospital.TheUltrasoundpassed;

                Console.Write("RheumoTests?\n1 - Yea\n 0 - No");
                if (CorrectInputIntRange(0, 1) == 1)
                    operation += hospital.RheumoTestsPassed;

                //Выполнение задач
                if (operation != null)
                    operation(hospi);
                //----------------

                Console.WriteLine(hospi);
                Console.Write("1 - Exit\n 0 - Once more");
                if (CorrectInputIntRange(0, 1) == 1)
                    break;
            }
        }
        public static int CorrectInputIntRange(int min, int max)
        {
            int number;
            while (true)
            {
                Console.Write("\nEnter the value: ");
                if (!int.TryParse(Console.ReadLine(), out number) || number < min || number > max)
                    Console.WriteLine($"\nInvalid value. Check that it is in the range from {min} to {max}.");
                else
                    return number;
            }
        }
    }
}
