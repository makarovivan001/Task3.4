using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public abstract class BaseArray<T> : IBaseArray
	{
		protected ValueProvider<T> generator;
		public BaseArray(bool personGet,ValueProvider<T> inputgenerator)
		{
			generator = inputgenerator;

            Create(personGet);
            
		}
		public void Create(bool personGet)
		{
			if (personGet)
			{
				GetfromPerson();
			}
			else
			{
				GetfromRandom();
			}
		}
		protected abstract void GetfromPerson();
        protected abstract void GetfromRandom();
		public abstract void Print();
        


    }
}

