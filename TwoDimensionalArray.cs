using System;
namespace HomeWork_Makarov_Ivan_number_3._1
{
	public sealed class TwoDimensionalArray<T> : BaseArray<T>
	{
        private T[,] array;

        public TwoDimensionalArray(bool personGet, ValueProvider<T> inputgenerator) : base(personGet, inputgenerator)
        {
           
        }
        public override void Print()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");

                }
                Console.Write("\n");

            }
        }
        protected override void GetfromPerson()
        {
            Console.Write("Введите длину: ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            array = new T[length, width];
            Console.WriteLine("Вводите значения: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                    array[i, j] = generator.ConvertFromString(Console.ReadLine());
                }
            }
            
        }
        protected override void GetfromRandom()
        {
            Random random = new Random();

            int length = random.Next(2, 10);
            int width = random.Next(2, 10);
            array = new T[length, width];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    array[i, j] = generator.Generate();
                }
            }
            
        }
        

       


        
    }
}

