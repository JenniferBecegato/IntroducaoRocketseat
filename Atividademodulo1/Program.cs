
using System.Globalization;
using System.Runtime;

public class Program
{
   public static void Mensagem()
    {
        Console.WriteLine("Escreva um nome");
        string nome = Console.ReadLine();
        Console.WriteLine($@" Olá {nome}! Seja muito bem-vindo!");

    }


    public static void Nomesobrenome()
    {
        string texto = "";
        Console.WriteLine("Digite o nome :");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o sobrenome:");
        string sobrenome = Console.ReadLine();

        texto += nome;
        texto += " " + sobrenome;

        Console.WriteLine(texto);
    }


    static double Soma(double numero1, double numero2)
    {
        return (numero1 + numero2);
        
    }
    static double Subtracao(double numero1, double numero2)
    {
        return (numero1 - numero2);

    }
    static double Multiplicacao(double numero1, double numero2)
    {
        return (numero1 * numero2);

    }
    static double Divisao(double numero1, double numero2)
    {
        if (numero2 != 0)
        {
            return (numero1 / numero2);
        }
        else
        {
            return 0;
        }

    }
    static double Media(double numero1, double numero2)
    {
        return (numero1 + numero2)/2;

    }
    public static void Doisvalores()
    {
        Console.WriteLine("Digite um numero");
        double numero1 = double.Parse (Console.ReadLine());
        Console.WriteLine("Digite um outro numero");
        double numero2 = double.Parse (Console.ReadLine());

        Console.WriteLine($@"Soma: {numero1} + {numero2} = {Soma(numero1,numero2)}");
        Console.WriteLine($@"Subtração : {numero1} -  {numero2} = {Subtracao(numero1, numero2)}");
        Console.WriteLine($@"Multiplicação: {numero1} * {numero2} = {Multiplicacao(numero1, numero2)}");
        Console.WriteLine($@"Divisão: {numero1} / {numero2} = {Divisao(numero1, numero2)}");
        Console.WriteLine($@"Média: {numero1} + {numero2} / 2 = {Media(numero1, numero2)}");
    }


    public static void Palavra()
    {   
        int letra;
        char espaco =' ';
        int contagem = 0;

        Console.WriteLine("Escreva uma palavra ou frase:");
        string texto = Console.ReadLine();
            
        for (letra = 0; letra < texto.Length; letra++)
        {
            if (texto[letra] != espaco)
            {
                contagem++;
                
            }

        }
        Console.WriteLine($@"A palavra ou frase {texto} tem {contagem} caracteres");
    }


    public static void Carro ()
    {
        Console.WriteLine(" Escreva uma placa de carro:");
        string placa = Console.ReadLine ();
        int letra;

        bool controle = true;

        if (placa.Length == 7)
        {
           for (letra = 0; letra < placa.Length && controle == true ; letra ++)
            {
                if (letra < 3 && Char.IsLetter(placa[letra]))
                {
                    controle = true;
                }
                else if (letra >= 3 && Char.IsDigit(placa[letra]))
                {
                    controle = true ;
                }
                else
                {
                    controle = false;
                }
            }
        }
        else
        {
            controle= false;
        }
        if (controle == true)
        {
            Console.WriteLine(" A placa é verdadeira ");
        }
        else
        {
            Console.WriteLine(" A placa é falsa");
        }
    }


    public static void DataHora ()
    {
        Console.WriteLine(@$" Digite qual dos formatos voce quer que exiba a data e hora do dia de hoje ?
                          1. dia da semana, dia do mês, mês, ano, hora, minutos, segundos
                          2. dd/mm/aaaa
                          3. Apenas a hora no formato de 24 horas
                          4. A data com o mês por extenso");

        int numero = int.Parse (Console.ReadLine ());

        switch (numero)
        {
            case 1:
                DateTime dataAtual = DateTime.Now;

                string formatoCompleto = dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss");

                Console.WriteLine(formatoCompleto);

                break;
            case 2:
                string formatocurto = DateTime.Now.ToString("dd/ MM/ yyyy", new CultureInfo("pt-BR"));

                Console.WriteLine(formatocurto);
                break;
            case 3:
                DateTime horaAtual = DateTime.Now;
                string horaFormato24Horas = horaAtual.ToString("HH:mm:ss");
                Console.WriteLine(horaFormato24Horas);
                break;
            case 4:
                string dataComMesExtenso = DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy");

                Console.WriteLine(dataComMesExtenso);

                break;
            default:
                Console.WriteLine("opção invalida");
                break;

                
        }
    }


}