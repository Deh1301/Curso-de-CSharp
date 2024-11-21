namespace fundamentosCs
{
    public class OperadorUnario
    {
        public static void opUnario()
        {
            var valorNega = 5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNega);
            Console.WriteLine(+valorNega);
            num1++;
            Console.WriteLine(num1);
            Console.WriteLine(num1++ == num2);
            num1 += 10;
            num1++;
            Console.WriteLine(num1);

            --num2;

            Console.WriteLine(num2);
            
        


        }
    }
}