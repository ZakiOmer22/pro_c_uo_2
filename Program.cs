//LAB LECTER TODAY : METHODS 

void labExample1 ()
{
    //PROGRAM THAT CALCULATES THE SUM OF TWO NUMBERS

    //1. RETURN TYPE METHOD
    int FunctionExampleOne ()
    {
        int x, y, sum;

        Console.WriteLine("Enter THe Number X");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter THe Number Y");
        y = Convert.ToInt32(Console.ReadLine());


        sum = x + y;
        Console.WriteLine($"The Sum of the Result is {sum}");
        return sum;
    }

    //2. NON RETURN TYPE METHOD
    void FunctionExampleTwo() // WITHOUT RETURN
    {
        int x, y, sum = 0;
        Console.WriteLine("Enter First Number");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        y = int.Parse(Console.ReadLine());

        sum = x + y;
        Console.WriteLine(x + " + " + y + " = " + sum);
        Console.ReadLine();
    }

    //SHOW RESULT
    Console.WriteLine(FunctionExampleOne());
}

labExample1();

//EXCERCISE
//WRITE APPLICATION THAT ASKS THE USER TO INPUT THREE NUMBERS AND RETURNS THE GREATERS NUMBER WITH FUNCTION
void labExercise1()
{
    //1. TEACHER PROCCESS
    void TeacherFucntionFindingHighestNumber()
    {
        int x, y, z, GreaterNumber = 0;
        Console.WriteLine("Enter First Number");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third Number");
        z = int.Parse(Console.ReadLine());

        if (x > y && x > z)
        {
            GreaterNumber = x;
        }
        else if (y > x && y > z)
        {
            GreaterNumber = y;
        }
        else
        {
            GreaterNumber = z;
        }
        // Console.WriteLine(GreaterNumber);
        Console.WriteLine("greater number is:" + GreaterNumber);
        Console.ReadLine();
    }


    //2. MY PROCCESS
    void MyFucntionFindingHighestNumber()
    {
        // WEYDII QOFKA SADDEX NUMBER
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double number3 = Convert.ToDouble(Console.ReadLine());

        //RAADI NUMBERKA UGU WEYN
        double greatest = FindGreatestNum(number1, number2, number3);

        // SOO MUUJI RESULTKA
        Console.WriteLine($"The Greatest number is: {greatest}");

        double FindGreatestNum(double num1, double num2, double num3)
        {
            return Math.Max(num1, Math.Max(num2, num3));
        }

    }

    //SHOWING RESULT
    TeacherFucntionFindingHighestNumber();
    MyFucntionFindingHighestNumber();
}

labExercise1();