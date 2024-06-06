using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaRecuperacao.ConversaoMoedas
{
    public abstract class Recuperacao
    {
        public enum ConversaoMoedas
        {
            Real,
            Dolar,
            Euro,
            Iene,
            LibraEsterlina
        }
        static void Main(string[]args)
        {

            double precoReal = 5.30;
            double taxa = 0.19;
            double conversao = 27;

            //Converter o valor Dolar para o real
            Console.WriteLine("Digite o número [1]: Euro");
            Console.WriteLine("Digite o número [2]: Iene");
            Console.WriteLine("Digite o número [3]: Libra esterlina");
            Console.WriteLine("Digite o número [4]: Dólar");
            Console.WriteLine("Digite o número [5]: Real");
            Console.WriteLine("Digite um dos números para converter o {} para o {}: ");

            conversao = precoReal / taxa;

            Console.WriteLine("O preço do R$5.30 foi convertido em " + conversao + " da moeda");
            taxa = Convert.ToDouble(Console.ReadLine());

            //Classe Math
            Math.Pow(10, taxa);
            Console.WriteLine("A taxa do valor é: " + conversao.ToString() + "é: " + precoReal.ToString());
            Console.ReadKey();

            //Conversão de string para moedas

            double valor = 0.19;

            Console.WriteLine("\n--------- Valores das moedas ---------------\n");


            Console.WriteLine(valor.ToString("Euro: 5,77", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("Iene: 0,034", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("Libra esterlina: 6,78", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("Dólar: 0,19", CultureInfo.CurrentCulture));
            Console.WriteLine(valor.ToString("Real: 5,30", CultureInfo.CurrentCulture));

            //Conversões implícitas e explicitas

            double valorDecimal = 5.30;
            int valorInteiro = (int)valorDecimal;

            int valorDolar = 19;
            double valorConvertido = valorDolar;
        }
    }
}
