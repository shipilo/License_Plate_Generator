using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace License_Plate_Generator
{
    public class Plate
    {
        private readonly char[] symbolSet = {'а','в','е','к','м','н','о','р','с','т','у','х' };
        private char[] numbers = new char[3];
        private char[] symbols = new char[3];

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
        public char[] SymbolSet
        {
            get { return symbolSet; }
        }


        public override string ToString()
        {
            //пример: "A000AA"
            return $"{symbols[0]}{numbers[0]}{numbers[1]}{numbers[2]}{symbols[1]}{symbols[2]}"; 
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
