using System;
using HomeWork_Makarov_Ivan_number_3;   
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public sealed class OneDimensionalArray<T> : BaseArray<T>
    
    {
        
        private T[] array;

        
        public OneDimensionalArray(bool personGet,ValueProvider<T> inputgenerator) : base(personGet,inputgenerator)
        {
           
        }

        protected override void GetfromPerson()
        {
            Console.WriteLine("Введите длину массива: ");
            int inputArray = int.Parse(Console.ReadLine());
            array = new T[inputArray];
            Console.Write("Вводите значения массива: ");
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = generator.ConvertFromString(Console.ReadLine()) ;

            }
        }


        protected override void GetfromRandom()
        {
            Random random = new Random();
            int inputArray = random.Next(2, 10);
            array = new T[inputArray];
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = generator.Generate();
            }
            
        }


        public override void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }
            Console.WriteLine();
        }
        


        
        



        
    }
}

