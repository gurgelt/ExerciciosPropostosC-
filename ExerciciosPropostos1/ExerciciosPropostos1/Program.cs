using System.Globalization;

namespace ExerciciosPropostos1 
{
    internal class Program {
        static void Main(string[] args) {

            // Ex 1: Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa:

            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("A soma entre o número " + n1 + " e o número " + n2 + " é: " + soma);

            // Ex 2: Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais 
            // Exemplo: Fórmula da área = área = pi.raio * raio
            // Considere o valro de pi = 3.14159

            Console.WriteLine("Digite o valor do raio de um círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pi = 3.14159;

            double area = pi * (raio * raio);

            Console.WriteLine("O valor da área do círculo é: " + area.ToString("F4", CultureInfo.InvariantCulture));

            //  Ex 3: Fazer um programa para ler quatro valores inteiros A,B,C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula.
            // DIFERENCA = (A * B - C * D)

            Console.WriteLine("Digite o primeiro valor inteiro A: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro B: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor inteiro C: ");
            int valor3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor inteiro D: ");
            int valor4 = int.Parse(Console.ReadLine());

            int diferenca = (valor1 * valor2 - valor3 * valor4);

            Console.WriteLine("A diferença do produto entre o valor A e B pelo produto de C e D é: " + diferenca);

            // Ex 4: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe
            // por hora e calcule o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas
            // casas decimais.

            Console.WriteLine("Digite o número do funcionário: ");
            int numero_funcionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite as horas trabalhadas: ");
            double horas_trabalhadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor ganho por hora: ");
            double valor_hora = double.Parse(Console.ReadLine());

            double salario = horas_trabalhadas * valor_hora;

            Console.WriteLine("O seu número é: " + numero_funcionario);
            Console.WriteLine("O seu salário é: " + salario, "F:2");

            // Ex 5: Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
            // o código de uma peça 2, o número de peças 2 e valor unitário de cada peça 2. Calcule e mostre o valor a ser pago

            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            Console.WriteLine("Digite o código de uma peça 1, número de peças 1 e valor unitário da peça 1");
            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código de uma peça 2, número de peças 2 e valor unitário da peça 2");
            string[] valores2 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores2[0]);
            qte2 = int.Parse(valores2[1]);
            preco2 = double.Parse(valores2[2]);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("O valor a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

            // Ex 6: Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida
            // calcule e mostre:

            double v1, v2, v3;

            Console.WriteLine("Digite três valores com ponto flutuante de dupla precisão: ");
            string[] valores3 = Console.ReadLine().Split(' ');

            v1 = double.Parse(valores3[0], CultureInfo.InvariantCulture);
            v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            // a) a área do triângulo retângulo que tem A por base e C por altura.
            double triangulo_retangulo = (v1 * v3) / 2.0;

            // b) a área do círculo de raio C. (pi = 3.14159).
            double area_circulo_c = 3.14159 * (v3 * v3);

            // c) a área do trapézio que tem A e B por bases e C por altura.
            double area_trapezio = (v1 + v2) / 2.0 * v3;

            // d) a área do quadrado que tem lado B.
            double area_quadrado = v2 * v2;

            // e) a área do retângulo que tem lados A e B.
            double area_retangulo = v1 * v2;

            Console.WriteLine("TRIÂNGULO: " + triangulo_retangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + area_circulo_c.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + area_trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + area_retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}