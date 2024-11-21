namespace fundamentosCs{
    public class OperadorTernario{
        public static void OpTernario(){
            int idade = 10;
            var verificarIdade = idade >= 18 ? "Maior de idade" : "Mneor de idade";
            Console.WriteLine(verificarIdade);
            idade += 12;
            var novaIdade = idade >= 18 ? "Ele agora e maior de idade": "Ele ainda e menor de idade";
            Console.WriteLine(novaIdade);
            int num = 11;
            string numero = num % 2 == 0 ? "Par" : "Impar";
            Console.WriteLine(numero);
        }
    }
}