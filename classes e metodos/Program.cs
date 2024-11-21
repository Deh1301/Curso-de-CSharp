using System;

namespace ClassesMetodos;

public class Classes{
    public static void Main(string[] args){
        Console.WriteLine("\nOla esse é o modulo de classes deseja Continuar? S/N\n");
        string entrada = Console.ReadLine();
        var entradaConfirmar = entrada.ToLower() == "s" ? "Bem Vindo seu exercicio sera executado" : "Voce não Acesso, encerrando";
        Console.WriteLine($"\n{entradaConfirmar}\n");

        ClassesXobjeto.classeXobjeto();
    }
       
}