using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	
	
	public class  GenerateBooleanValue : ValueProvider<bool>
	{
		public override bool Generate()
		{
			if (random.Next(0, 2) == 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
        public override bool ConvertFromString(string input_value)
        {
            return bool.Parse(input_value);
        }

    }
	
}

