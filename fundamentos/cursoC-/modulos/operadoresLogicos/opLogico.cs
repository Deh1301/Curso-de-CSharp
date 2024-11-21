namespace fundamentosCs{
    public class OperadorLogico{
        public static void opLogico(){
            var comprar = true;
            var trabalhar = false;

            var comprarTv = comprar || trabalhar; //retorna true se uma pelo for true se ambas for true ele ainda retorna true
            var trabalharProgramar = comprar && trabalhar; // retorna true se amabbas forem true
            var comprarCel = comprar ^ trabalhar; // retornar true se uma pelo menos for true se todas for false ou true retorna false
            Console.WriteLine("vai comprar o celular? {0}",comprarCel);
            Console.WriteLine("vai comprar ? {0}",comprarTv);
            Console.WriteLine("vai trabalhar?{0}",trabalharProgramar);
        }
    }
}