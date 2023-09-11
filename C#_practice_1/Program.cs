namespace pracice_1
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            decimal result =0;

            Console.WriteLine("Hello");

            Console.WriteLine("Enter First number : ");
            var num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter  second Number : ");
            var num2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Choose Your Operation : ");
            Console.WriteLine(" + OR - OR / OR * OR % ");


            Console.WriteLine("Enter One of them : ");
            var operation = Convert.ToString(Console.ReadLine());


            switch(operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                      result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        Console.WriteLine( "0ze gayopa ar sheidzleba");
                    }

                    result = num1 / num2;
                    break;

            }

            Console.WriteLine("Your Answer is" + result);

        }
    }

}
