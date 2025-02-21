
using System;
class Program
{
    static void Main()
    {
        // 1. calculadora basica
        Console.Write("Ingrese el primer numero: ");
        double.TryParse(Console.ReadLine(), out double num1);

        Console.Write("Ingrese el segundo numero: ");
        double.TryParse(Console.ReadLine(), out double num2);

        Console.Write("Ingrese operacion (+, -, *, /): ");
        string? op = Console.ReadLine();

        double resultado = op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => num2 != 0 ? num1 / num2 : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine(double.IsNaN(resultado) ? "Operacion no valida." : $"Resultado: {resultado}");

        // 2. validacion de contraseña
        string? pass;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            pass = Console.ReadLine();
        } while (pass != "edgar");

        Console.WriteLine("contraseña correcta");

        // 3. Números Primos
        Console.Write("Ingrese un numero: ");
        int.TryParse(Console.ReadLine(), out int num);

        bool esPrimo = num > 1;
        for (int i = 2; i * i <= num && esPrimo; i++)
            if (num % i == 0) esPrimo = false;

        Console.WriteLine(esPrimo ? "Es primo." : "No es primo.");

        // 4. suma de numeros pares
        int suma = 0, n;
        do
        {
            Console.Write("Ingrese un numero (0 para salir): ");
            int.TryParse(Console.ReadLine(), out n);
            if (n % 2 == 0) suma += n;
        } while (n != 0);

        Console.WriteLine($"Suma de numeros pares: {suma}");

        // 5. conversion de temperatura
        Console.Write("Ingrese la temperatura: ");
        double.TryParse(Console.ReadLine(), out double temp);

        Console.Write("Convertir a (C/F): ");
        string? opcion = Console.ReadLine()?.ToUpper();

        double tempConvertida = opcion == "C" ? (temp - 32) * 5 / 9 :
                                opcion == "F" ? (temp * 9 / 5) + 32 :
                                double.NaN;

        Console.WriteLine(double.IsNaN(tempConvertida) ? "opcion no valida." : $"Temperatura convertida: {tempConvertida}");

        // 6. contador de vocales
        Console.Write("Ingrese una frase: ");
        string? texto = Console.ReadLine();
        int contadorVocales = 0;
        if (texto != null)
        {
            foreach (char c in texto.ToLower())
                if ("aeiou".Contains(c)) contadorVocales++;
        }

        Console.WriteLine($"Número de vocales: {contadorVocales}");

        // 7. calculo de factorial
        Console.Write("Ingrese un numero: ");
        int.TryParse(Console.ReadLine(), out int numFactorial);

        long factorial = 1;
        for (int i = 1; i <= numFactorial; i++)
            factorial *= i;

        Console.WriteLine($"Factorial: {factorial}");

        // 8. juego de adivinanza
        Random rand = new Random();
        int secreto = rand.Next(1, 101);
        int intento;
        do
        {
            Console.Write("adivine el numero (1-100): ");
            int.TryParse(Console.ReadLine(), out intento);

            if (intento > secreto) Console.WriteLine("Demasiado alto.");
            else if (intento < secreto) Console.WriteLine("Demasiado bajo.");
        } while (intento != secreto);

        Console.WriteLine("¡Felicidades, acertaste!");

        // 9. paso por referencia
        Console.Write("Ingrese el primer numero: ");
        int.TryParse(Console.ReadLine(), out int a);

        Console.Write("Ingrese el segundo numero: ");
        int.TryParse(Console.ReadLine(), out int b);

        Console.WriteLine($"antes: A={a}, B={b}");
        int tempVar = a;
        a = b;
        b = tempVar;
        Console.WriteLine($"despues: A={a}, B={b}");

        // 10. tabla de multiplicar
        Console.Write("Ingrese un numero para la tabla de multiplicar: ");
        int.TryParse(Console.ReadLine(), out int numTabla);

        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{numTabla} x {i} = {numTabla * i}");

        Console.WriteLine("\n¡Programa finalizado!");
    }
}
