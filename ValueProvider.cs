using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public abstract class ValueProvider<T>
	{
		protected Random random = new Random();
		public abstract T Generate();
		public abstract T ConvertFromString(string input_value);
    }
}

