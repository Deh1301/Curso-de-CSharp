namespace fundamentosCs{
    public class OperadorAtribuir{
        public static void opAtribuir(){
            var numero = 10; 
            
            numero *= 10;
           
            var constanteValor = 20;
            constanteValor += 20;
            var total= numero + constanteValor;
            // numero &= 2;
            Console.WriteLine(total);

            total -= 20;
            var novoValor = total *= 20;
            Console.WriteLine(novoValor);
            
            var dividir = total /= 20;
            Console.WriteLine(dividir);
            var num1= 10;
            num1= 7;
            num1 +=10;
            num1 -= 20;
            num1 *=10;
            num1 /= 2;
            Console.WriteLine(num1);
            var situacaoValor = num1 <= 0;
            Console.WriteLine(situacaoValor);
            num1++;
            Console.WriteLine(num1);
            
        }
    }
}