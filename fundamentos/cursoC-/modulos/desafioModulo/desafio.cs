namespace fundamentosCs{
    public class DesafioModulo{
        public static void desafioModulo(){
            var numero = 3;
            var verificar = numero /2;
            var numeroParImpar = verificar == 0 ;
            Console.WriteLine($"o numero é par?{numeroParImpar}");
            
            //varificar contagem

            int contador = 0;
            contador++;
            Console.WriteLine($"O valor agora é: {contador}");
            contador++;
            Console.WriteLine($"O valor agora é: {contador}");
            contador--;
            Console.WriteLine($"O valor agora é: {contador}");

            //Comparação de Números

            var num1 = 2;
            var num2 = 4;
            var verificarP = num1 >= 0 && num2 >= 0;

            Console.WriteLine($"Os valores sao positivos? {verificarP}");

            var total = num1 + num2;
            var maior100 = total >= 100;
            Console.WriteLine($"A soma é maior que 100? {maior100}");
            var dividir = num2 % num1 == 0;
            Console.WriteLine($"é divisivel : {dividir}");

            
           


        }
    }
}