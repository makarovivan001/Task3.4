using System;
using HomeWork_Makarov_Ivan_number_3;
using HomeWork_Makarov_Ivan_number_3._1;

class program
{
    
    static void Main(string[] args)
    {
        IPrinter[] printer = new IPrinter[8];
        Generate_Int generate_int = new Generate_Int();
        GenerateDouble generatedouble = new GenerateDouble();
        GenerateString generatestring = new GenerateString();
        GenerateBooleanValue generateBooleanValue = new GenerateBooleanValue();

        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
        bool personGet;
        personGet = personChoose();
        printer[0] = new OneDimensionalArray<int>(personGet, generate_int);
        printer[1] = new OneDimensionalArray<double>(personGet, generatedouble);
        printer[2] = new OneDimensionalArray<string>(personGet, generatestring);
        printer[3] = new OneDimensionalArray<bool>(personGet, generateBooleanValue);
        printer[4] = new TwoDimensionalArray<int>(personGet, generate_int);
        printer[5] = new TwoDimensionalArray<double>(personGet, generatedouble);
        printer[6] = new TwoDimensionalArray<string>(personGet, generatestring);
        printer[7] = new TwoDimensionalArray<bool>(personGet, generateBooleanValue);    
        for (int i = 0; i < printer.Length; i++)
        {
           
            Console.WriteLine("Напечатанный массив: ");
            printer[i].Print();
        }
       

        Console.ReadKey();

    }
    static bool personChoose()
    {
        bool personschoose = false;
        bool correct_or_incorrect_answer_is_incorrect = true;
        string input;
        while (correct_or_incorrect_answer_is_incorrect)
        {
            input = Console.ReadLine();
            if (input == "да")
            {
                personschoose = true;
                correct_or_incorrect_answer_is_incorrect = false;
            }
            else if (input == "нет")
            {
                personschoose = false;
                correct_or_incorrect_answer_is_incorrect = false;
            }
            else
            {
                Console.WriteLine("Ответ некорректен, ответьте по-другому");
            }
        }
        return personschoose;
    }
}