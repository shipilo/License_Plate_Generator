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

        public void IncreaseNumbers()
        {
            try
            {
                int buffer = Convert.ToInt32(numbers[0] + numbers[1] + numbers[2]);

                if (buffer.Equals(999))
                {
                    IncreaseLetters();
                    return;
                }

                buffer++;

                numbers[0] = Convert.ToChar(buffer / 100);
                numbers[1] = Convert.ToChar(buffer % 100 / 10);
                numbers[2] = Convert.ToChar(buffer % 10);
            }
            catch (Exception ex)
            {
                //Дописать
            }
        }

        public void IncreaseLetters()
        {
            //Проверка символов на их буквы
            if (symbols[2].Equals('х'))
            {
                if (symbols[1].Equals('х'))
                {
                    try
                    {
                        symbols[0] = symbolSet[Array.IndexOf(symbolSet, symbols[0]) + 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        //Если уже "XXX"
                        return;
                    }
                    return;
                }
                else
                {
                    symbols[1] = symbolSet[Array.IndexOf(symbolSet, symbols[1]) + 1];
                    return;
                }
            }

            //Если последний символ не 'х', то увеличиваем на 1
            symbols[2] = symbolSet[Array.IndexOf(symbolSet, symbols[2]) + 1];
        }

        public void DecreaseNumbers()
        {
            try
            {
                int buffer = Convert.ToInt32(numbers[0] + numbers[1] + numbers[2]);

                if (buffer.Equals(000))
                {
                    DecreaseLetters();
                    return;
                }

                buffer--;

                numbers[0] = Convert.ToChar(buffer / 100);
                numbers[1] = Convert.ToChar(buffer % 100 / 10);
                numbers[2] = Convert.ToChar(buffer % 10);
            }
            catch (Exception ex)
            {
                //Дописать
            }
        }

        public void DecreaseLetters()
        {
            if (symbols[2].Equals('а'))
            {
                if (symbols[1].Equals('а'))
                {
                    try
                    {
                        symbols[0] = symbolSet[Array.IndexOf(symbolSet, symbols[0]) - 1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        //Если номер уже "AAA"
                        return;
                    }
                    return;
                }
                else
                {
                    symbols[1] = symbolSet[Array.IndexOf(symbolSet, symbols[1]) - 1];
                    return;
                }
            }

            symbols[2] = symbolSet[Array.IndexOf(symbolSet, symbols[2]) - 1];
        }
    }
}
