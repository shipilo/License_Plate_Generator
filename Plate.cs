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
        public char[] numbers;
        public char[] symbols;
        public int region;
        private string fullNumber;

        private void GenerateFullNumber()
        {
            fullNumber = ToString() + $"{region}";
        }
        public override string ToString()
        {
            //пример: "A000AA"
            return $"{symbols[0]}{numbers[0]}{numbers[1]}{numbers[2]}{symbols[1]}{symbols[2]}".ToUpper(); 
        }
        public override bool Equals(object obj)
        {
            return obj is Plate plate && fullNumber.Equals(plate.fullNumber);
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
            GenerateFullNumber();
        }
        public Plate(string numbers, string symbols, int region)
        {
            this.numbers = numbers.ToCharArray();
            this.symbols = symbols.ToCharArray();
            this.region = region;
            GenerateFullNumber();
        }
        public Plate(string numbers, char[] symbols, int region)
        {
            this.numbers = numbers.ToCharArray();
            this.symbols = symbols;
            this.region = region;
            GenerateFullNumber();
        }

        public static Plate GenerateRandom(List<Plate> plates, int region)
        {
            Random rnd = new Random();
            Plate plate = new Plate();
            plate.region = region;
            do
            {
                for (int i = 0; i <= 2; i++)
                {
                    plate.symbols[i] = symbolSet[rnd.Next(11)];
                    plate.numbers[i] = Convert.ToChar(rnd.Next(10).ToString());
                }
                plate.GenerateFullNumber();
            } while (plates.Contains(plate));

            return plate;
        }

        public static Plate GenerateNext(List<Plate> plates)
        {
            Plate newPlate = new Plate(plates[plates.Count - 1]);
            return IncreaseLetters(plates, newPlate);
        }

        public static Plate GeneratePrevious(List<Plate> plates)
        {
            Plate newPlate = new Plate(plates[plates.Count - 1]);
            return DecreaseLetters(plates, newPlate);
        }

        private static Plate IncreaseNumbers(List<Plate> plates, Plate newPlate)
        {
            int numbers = Convert.ToInt32(new string(newPlate.numbers));

            while (plates.Contains(newPlate) && numbers != 999)
            {
                numbers += 1;
                newPlate.numbers[0] = (char)(numbers / 100 + 48);
                newPlate.numbers[1] = (char)(numbers / 10 % 10 + 48);
                newPlate.numbers[2] = (char)(numbers % 10 + 48);
                newPlate.GenerateFullNumber();
            }

            return plates.Contains(newPlate) ? null : newPlate;
        }

        private static Plate IncreaseLetters(List<Plate> plates, Plate newPlate)
        {
            //12-ричное представление символов
            int symbols = 144 * Array.IndexOf(symbolSet, newPlate.symbols[0]) + 12 * Array.IndexOf(symbolSet, newPlate.symbols[1]) + Array.IndexOf(symbolSet, newPlate.symbols[2]);
            Plate increased;

            do
            {
                increased = IncreaseNumbers(plates, new Plate(newPlate));
                if (increased != null || symbols == 0)
                {
                    return increased;
                }

                symbols = (symbols + 1) % 1728;
                newPlate.symbols[0] = symbolSet[symbols / 144];
                newPlate.symbols[1] = symbolSet[symbols / 12 % 12];
                newPlate.symbols[2] = symbolSet[symbols % 12];
                newPlate.numbers = new char[] { '0', '0', '0' };
                newPlate.GenerateFullNumber();
            } while (plates.Contains(newPlate));

            return newPlate;
        }

        private static Plate DecreaseNumbers(List<Plate> plates, Plate newPlate)
        {
            int numbers = Convert.ToInt32(new string(newPlate.numbers));

            while (plates.Contains(newPlate) && numbers != 0)
            {
                numbers -= 1;
                newPlate.numbers[0] = (char)(numbers / 100 + 48);
                newPlate.numbers[1] = (char)(numbers / 10 % 10 + 48);
                newPlate.numbers[2] = (char)(numbers % 10 + 48);
                newPlate.GenerateFullNumber();
            }

            return plates.Contains(newPlate) ? null : newPlate;
        }

        private static Plate DecreaseLetters(List<Plate> plates, Plate newPlate)
        {
            //12-ричное представление символов
            int symbols = 144 * Array.IndexOf(symbolSet, newPlate.symbols[0]) + 12 * Array.IndexOf(symbolSet, newPlate.symbols[1]) + Array.IndexOf(symbolSet, newPlate.symbols[2]);
            Plate decreased;

            do
            {
                decreased = DecreaseNumbers(plates, new Plate(newPlate));
                if (decreased != null || symbols == 0)
                {
                    return decreased;
                }

                symbols = (symbols + 1727) % 1728;
                newPlate.symbols[0] = symbolSet[symbols / 144];
                newPlate.symbols[1] = symbolSet[symbols / 12 % 12];
                newPlate.symbols[2] = symbolSet[symbols % 12];
                newPlate.numbers = new char[] { '9', '9', '9' };
                newPlate.GenerateFullNumber();
            } while (plates.Contains(newPlate));

            return newPlate;
        }
    }
}
