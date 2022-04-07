using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace License_Plate_Generator
{
    public class Plate
    {
        public static List<char> symbolSet;
        public string numbers;
        public string symbols;
        public int region;
        private string fullNumber;

        private void GenerateFullNumber()
        {   
            fullNumber = ToString() + $"{region}";
        }
        public override string ToString()
        {
            //пример: "A000AA"
            return $"{symbols[0]}{numbers}{symbols[1]}{symbols[2]}".ToUpper(); 
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
            symbolSet = new List<char>(){ 'а', 'в', 'е', 'к', 'м', 'н', 'о', 'р', 'с', 'т', 'у', 'х' };
        }
        private Plate() { }
        public Plate(Plate plate)
        {
            numbers = plate.numbers;
            symbols = plate.symbols;
            region = plate.region;
            GenerateFullNumber();
        }
        public Plate(string numbers, string symbols, int region)
        {
            this.numbers = numbers;
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
                plate.symbols = string.Join("", symbolSet[rnd.Next(12)], symbolSet[rnd.Next(12)], symbolSet[rnd.Next(12)]);
                plate.numbers = $"{rnd.Next(1000)}";
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
            int numbers = Convert.ToInt32(newPlate.numbers);

            while (plates.Contains(newPlate) && numbers != 999)
            {
                numbers += 1;
                newPlate.numbers = "";
                newPlate.numbers += $"{numbers / 100}";
                newPlate.numbers += $"{numbers / 10 % 10}";
                newPlate.numbers += $"{numbers % 10}";
                newPlate.GenerateFullNumber();
            }

            return plates.Contains(newPlate) ? null : newPlate;
        }

        private static Plate IncreaseLetters(List<Plate> plates, Plate newPlate)
        {
            //12-ричное представление символов
            int symbols = 144 * symbolSet.IndexOf(newPlate.symbols[0]) + 12 * symbolSet.IndexOf(newPlate.symbols[1]) + symbolSet.IndexOf(newPlate.symbols[2]);
            Plate increased;

            do
            {
                increased = IncreaseNumbers(plates, new Plate(newPlate));
                if (increased != null || symbols == 0)
                {
                    return increased;
                }

                symbols = (symbols + 1) % 1728;
                newPlate.symbols = "";
                newPlate.symbols += symbolSet[symbols / 144];
                newPlate.symbols += symbolSet[symbols / 12 % 12];
                newPlate.symbols += symbolSet[symbols % 12];
                newPlate.numbers = "000";
                newPlate.GenerateFullNumber();
            } while (plates.Contains(newPlate));

            return newPlate;
        }

        private static Plate DecreaseNumbers(List<Plate> plates, Plate newPlate)
        {
            int numbers = Convert.ToInt32(newPlate.numbers);

            while (plates.Contains(newPlate) && numbers != 0)
            {
                numbers -= 1;
                newPlate.numbers = "";
                newPlate.numbers += $"{numbers / 100}";
                newPlate.numbers += $"{numbers / 10 % 10}";
                newPlate.numbers += $"{numbers % 10}";
                newPlate.GenerateFullNumber();
            }

            return plates.Contains(newPlate) ? null : newPlate;
        }

        private static Plate DecreaseLetters(List<Plate> plates, Plate newPlate)
        {
            //12-ричное представление символов
            int symbols = 144 * symbolSet.IndexOf(newPlate.symbols[0]) + 12 * symbolSet.IndexOf(newPlate.symbols[1]) + symbolSet.IndexOf(newPlate.symbols[2]);
            Plate decreased;

            do
            {
                decreased = DecreaseNumbers(plates, new Plate(newPlate));
                if (decreased != null || symbols == 0)
                {
                    return decreased;
                }

                symbols = (symbols + 1727) % 1728;
                newPlate.symbols = "";
                newPlate.symbols += symbolSet[symbols / 144];
                newPlate.symbols += symbolSet[symbols / 12 % 12];
                newPlate.symbols += symbolSet[symbols % 12];
                newPlate.numbers = "999";
                newPlate.GenerateFullNumber();
            } while (plates.Contains(newPlate));

            return newPlate;
        }
    }
}
