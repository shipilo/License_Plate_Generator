using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace License_Plate_Generator
{
    public class Plate
    {
        public static char[] symbolSet;
        private char[] numbers;
        private char[] symbols;
        private int region;

        public char[] Symbols
        {
            get { return symbols; }
            set { symbols = value; }
        }
        public char[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public int Region
        {
            get { return region; }
            set { region = value; }
        }
        public string FullNumber
        {
            get { return ToString() + $"{region}"; }
        }

        public override string ToString()
        {
            //пример: "A000AA"
            return $"{symbols[0]}{numbers[0]}{numbers[1]}{numbers[2]}{symbols[1]}{symbols[2]}".ToUpper(); 
        }
        public override bool Equals(object obj)
        {
            return obj is Plate plate && FullNumber.Equals(plate.FullNumber);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        static Plate()
        {
            symbolSet = new char[] { 'а', 'в', 'е', 'к', 'м', 'н', 'о', 'р', 'с', 'т', 'у', 'х' };
        }
        public Plate()
        {
            numbers = new char[3];
            symbols = new char[3];
    }
        public Plate(Plate plate)
        {
            numbers = (char[])plate.numbers.Clone();
            symbols = (char[])plate.symbols.Clone();
            region = plate.region;
        }
        public Plate(string numbers, string symbols, int region)
        {
            this.numbers = numbers.ToCharArray();
            this.symbols = symbols.ToCharArray();
            this.region = region;
        }
        public Plate(string numbers, char[] symbols, int region)
        {
            this.numbers = numbers.ToCharArray();
            this.symbols = symbols;
            this.region = region;
        }

        public static Plate GenerateRandom(List<Plate> plates, int region)
        {
            Random rnd = new Random();
            Plate plate = new Plate();
            do
            {
                for (int i = 0; i <= 2; i++)
                {
                    plate.Symbols[i] = symbolSet[rnd.Next(11)];
                    plate.Numbers[i] = Convert.ToChar(rnd.Next(10).ToString());
                }
                plate.Region = region;
            } while (plates.Contains(plate));

            return plate;
        }

        public static Plate GenerateNext(List<Plate> plates)
        {
            return IncreaseLetters(plates);
        }

        public static Plate GeneratePrevious(List<Plate> plates)
        {
            return DecreaseLetters(plates);
        }

        private static Plate IncreaseNumbers(List<Plate> plates)
        {
            Plate lastPlate = new Plate(plates[plates.Count - 1]);
            int numbers = Convert.ToInt32(new string(lastPlate.numbers));

            do {
                numbers = (numbers + 1) % 1000;
                lastPlate.numbers[0] = (char)(numbers / 100 + 48);
                lastPlate.numbers[1] = (char)(numbers / 10 % 10 + 48);
                lastPlate.numbers[2] = (char)(numbers % 10 + 48);
            } while (numbers != 0 && plates.Contains(lastPlate));

            return numbers == 0 ? null : lastPlate;
        }

        private static Plate IncreaseLetters(List<Plate> plates)
        {
            Plate lastPlate = new Plate(plates[plates.Count - 1]);
            //12-ричное представление символов
            int symbols = 144 * Array.IndexOf(symbolSet, lastPlate.symbols[0]) + 12 * Array.IndexOf(symbolSet, lastPlate.symbols[1]) + Array.IndexOf(symbolSet, lastPlate.symbols[2]);
            Plate increased;

            do
            {
                increased = IncreaseNumbers(plates);
                if (increased != null)
                {
                    return increased;
                }

                symbols = (symbols + 1) % 1728;
                lastPlate.symbols[0] = symbolSet[symbols / 144];
                lastPlate.symbols[1] = symbolSet[symbols / 12 % 12];
                lastPlate.symbols[2] = symbolSet[symbols % 12];
            } while (symbols != 0 && plates.Contains(lastPlate));

            return symbols == 0 ? null : lastPlate;
        }

        private static Plate DecreaseNumbers(List<Plate> plates)
        {
            Plate lastPlate = new Plate(plates[plates.Count - 1]);
            int numbers = Convert.ToInt32(new string(lastPlate.numbers));

            do
            {
                numbers = numbers - 1;
                lastPlate.numbers[0] = (char)(numbers / 100 + 48);
                lastPlate.numbers[1] = (char)(numbers / 10 % 10 + 48);
                lastPlate.numbers[2] = (char)(numbers % 10 + 48);
            } while (numbers != -1 && plates.Contains(lastPlate));

            return numbers == -1 ? null : lastPlate;
        }

        private static Plate DecreaseLetters(List<Plate> plates)
        {
            Plate lastPlate = new Plate(plates[plates.Count - 1]);
            //12-ричное представление символов
            int symbols = 144 * Array.IndexOf(symbolSet, lastPlate.symbols[0]) + 12 * Array.IndexOf(symbolSet, lastPlate.symbols[1]) + Array.IndexOf(symbolSet, lastPlate.symbols[2]);
            Plate decreased;

            do
            {
                decreased = DecreaseNumbers(plates);
                if (decreased != null)
                {
                    return decreased;
                }

                symbols = (symbols + 1727) % 1728;
                lastPlate.symbols[0] = symbolSet[symbols / 144];
                lastPlate.symbols[1] = symbolSet[symbols / 12 % 12];
                lastPlate.symbols[2] = symbolSet[symbols % 12];
            } while (symbols != 1727 && plates.Contains(lastPlate));

            return symbols == 1727 ? null : lastPlate;
        }
    }
}
