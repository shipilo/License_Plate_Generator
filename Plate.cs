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

        public Plate()
        {
            symbolSet = new char[]{ 'а', 'в', 'е', 'к', 'м', 'н', 'о', 'р', 'с', 'т', 'у', 'х' };
            numbers = new char[3];
            symbols = new char[3];
    }
        public Plate(string numbers, string symbols, int region) : this()
        {
            this.numbers = numbers.ToCharArray();
            this.symbols = symbols.ToCharArray();
            this.region = region;
        }
        public Plate(string numbers, char[] symbols, int region) : this()
        {
            this.numbers = numbers.ToCharArray();
            this.symbols = symbols;
            this.region = region;
        }

        public void IncreaseNumbers(List<Plate> plates)
        {
            try
            {
                int index = plates.Count - 1;
                int buffer = Convert.ToInt32(new string(plates[index].numbers)) + 1;

                if (buffer == 1000)
                {
                    IncreaseLetters(plates);
                    return;
                }

                Plate examplePlate = new Plate(buffer.ToString(), plates[index].symbols, plates[index].region);
            
                if(!plates.Contains(examplePlate))
                {
                    plates.Add(examplePlate);
                }
                


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
            }
        }

        public void IncreaseLetters(List<Plate> plates)
        {
            int index = plates.Count - 1;
            char[] buffSymbols = { plates[index].symbols[0], plates[index].symbols[1], plates[index].symbols[2] };

            if (buffSymbols.ToString() == "xxx")
            {
                throw new Exception("Достигнут предел");
            }

            if (buffSymbols[2] == 'x')
            {
                if (buffSymbols[1] == 'x')
                {
                    buffSymbols[0] = symbolSet[Array.IndexOf(symbolSet, buffSymbols[0]) + 1];
                }
                else
                {
                    buffSymbols[1] = symbolSet[Array.IndexOf(symbolSet, buffSymbols[1]) + 1];
                }
            }
            else
            {
                buffSymbols[2] = symbolSet[Array.IndexOf(symbolSet, buffSymbols[2]) + 1];
            }

            Plate examplePlate = new Plate(plates[index].numbers.ToString(), buffSymbols, plates[index].region);

            if (!plates.Contains(examplePlate))
            {
                plates.Add(examplePlate);
            }

        }

        public void DecreaseNumbers(List<Plate> plates)
        {
            try
            {
                int index = plates.Count - 1;
                int buffer = Convert.ToInt32(new string(plates[index].numbers)) - 1;

                string plate = "";

                if(buffer < 0)
                {
                    DecreaseLetters(plates);
                    return;
                }

                if (buffer < 100)
                {
                    plate = "0" + buffer.ToString();
                }
                else
                {
                    plate = buffer.ToString();
                }

                Plate examplePlate = new Plate(plate, plates[index].symbols, plates[index].region);

                if (!plates.Contains(examplePlate))
                {
                    plates.Add(examplePlate);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
            }
        }

        public void DecreaseLetters(List<Plate> plates)
        {
            int index = plates.Count - 1;
            char[] buffSymbols = { plates[index].symbols[0], plates[index].symbols[1], plates[index].symbols[2] };

            if (buffSymbols.ToString() == "ааа")
            {
                throw new Exception("Достигнут предел");
            }

            if (buffSymbols[2] == 'а')
            {
                if (buffSymbols[1] == 'а')
                {
                    buffSymbols[0] = symbolSet[Array.IndexOf(symbolSet, buffSymbols[0]) - 1];
                }
                else
                {
                    buffSymbols[1] = symbolSet[Array.IndexOf(symbolSet, buffSymbols[1]) - 1];
                }
            }
            else
            {
                buffSymbols[2] = symbolSet[Array.IndexOf(symbolSet, buffSymbols[2]) - 1];
            }

            Plate examplePlate = new Plate(plates[index].numbers.ToString(), buffSymbols, plates[index].region);

            if (!plates.Contains(examplePlate))
            {
                plates.Add(examplePlate);
                
            }

        }
    }
}
