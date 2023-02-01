using System.Text;

namespace TechnicalChallengeRomanNumeralsConverterService
{
    public class ConverterService
    {
        public string ConvertNumberToRomanNumerial(int numberToConvert)
        {
            StringBuilder bobTheBuilder = new StringBuilder();

            while (numberToConvert > 0)
            {
                if (numberToConvert - 100 >= 0)
                {
                    bobTheBuilder.Append("C");
                    numberToConvert = numberToConvert - 100;
                }
                else if (numberToConvert - 90 >= 0)
                {
                    bobTheBuilder.Append("XC");
                    numberToConvert = numberToConvert - 90;
                }
                else if (numberToConvert - 50 >= 0)
                {
                    bobTheBuilder.Append("L");
                    numberToConvert = numberToConvert - 50;
                }
                else if (numberToConvert - 40 >= 0)
                {
                    bobTheBuilder.Append("XL");
                    numberToConvert = numberToConvert - 40;
                }
                else if (numberToConvert - 10 >= 0)
                {
                    bobTheBuilder.Append("X");
                    numberToConvert = numberToConvert - 10;
                }
                else if (numberToConvert - 9 >= 0)
                {
                    bobTheBuilder.Append("IX");
                    numberToConvert = numberToConvert - 9;
                }
                else if (numberToConvert - 5 >= 0)
                {
                    bobTheBuilder.Append("V");
                    numberToConvert = numberToConvert - 5;
                }
                else if (numberToConvert - 4 >= 0)
                {
                    bobTheBuilder.Append("IV");
                    numberToConvert = numberToConvert - 4;
                }
                else if (numberToConvert - 1 >= -0)
                {
                    bobTheBuilder.Append("I");
                    numberToConvert = numberToConvert - 1;
                }
            }

            return bobTheBuilder.ToString();
        }
    }
}