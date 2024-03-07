using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public class GenerateString : ValueProvider<string>
    {
        string string_values_1 = "jrghjfniuifkrjhfkk9dewolsroeifnjdjekwejnmjmj";

        public override string Generate()
        {
            int length = 6;
            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = string_values_1[random.Next(0, string_values_1.Length)];
            }
            return new string(chars);
        }
        public override string ConvertFromString(string input_value)
        {
            return input_value;
        }
    }
}

