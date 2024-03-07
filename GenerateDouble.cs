using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public class  GenerateDouble : ValueProvider<double>
    {
        public override double Generate()
        {
            return random.NextDouble();
        }
        public override double ConvertFromString(string input_value)
        {
            return double.Parse(input_value);
        } 
    }
}

