using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public class Generate_Int : ValueProvider<int>
    {
        public override int Generate()
        {
            int randomy = random.Next(0, 51);
            return randomy;
        }
        public override int ConvertFromString(string input_value)
        {
            return int.Parse(input_value);
        }
    }
}

