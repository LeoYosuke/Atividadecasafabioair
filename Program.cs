using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeCasaAIRCOMPANYFABIO
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome, nome2, endereco, bairro, cidade, estado;
            int viagem, viagem2;

            Console.WriteLine("Ola seja bem-vindo ao Air Company Fabio");

            Console.WriteLine("Para iniciar nos diga seu primeiro nome:");
            nome = (Console.ReadLine());

            Console.WriteLine("Agora seu segundo nome:");
            nome2 = (Console.ReadLine());

            Console.WriteLine($"Olá, Sr(a). {nome} {nome2}, vamos continuar seu cadastro.... ");

            Console.WriteLine("Para continuar nos diga seu endereço");
            endereco = (Console.ReadLine());
            Console.WriteLine("Agora nos diga seu bairro ");
            bairro = (Console.ReadLine());
            Console.WriteLine("Agora nos diga sua cidade ");
            cidade = (Console.ReadLine());
            Console.WriteLine("Agora nos diga seu estado ");
            estado = (Console.ReadLine());

            Console.WriteLine($"O Sr(a). {nome2} mora na cidade de {cidade}-{estado}, no endereço {endereco}, localizado no bairro {bairro}.");

            Console.WriteLine("Para continuar quantas viagens você fez no passado?");
            viagem = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Para continuar quantas viagens você planejou fazer neste ano?");
            viagem2 = Int32.Parse(Console.ReadLine());




            Console.WriteLine($"Ao total o Sr(a) ja fez {viagem + viagem2} no total!");
            Console.WriteLine($"E para completar 10 viagens faltam {10 - (viagem + viagem2)}!");
            Console.WriteLine($"O Sr(a) fez uma media de {(viagem + viagem2) / 2} viagens!");
            Console.WriteLine($"O Sr(a) teve um intervalo de { 12 / viagem} meses");

            Console.WriteLine($"Obrigado {nome} {nome2}, o seu cadastro foi realizado com sucesso!");

            string cupom1;


            Console.WriteLine("DIGITE SEU CUPOM DE DESCONTO:");
            cupom1 = (Console.ReadLine());
            if (cupom1 == "FABIO10")
            {
                Console.WriteLine("Parabéns, você recebeu 10% de desconto na sua próxima viagem");
            }
            else
            {
                Console.WriteLine("Este cupom não existe");

            }
            string email;

            Console.WriteLine("Você gostaria de receber promoções no seu email?");
            email = (Console.ReadLine());
            if (email == "sim")
            {
                Console.WriteLine($"Obrigado {nome} por se registrar, você receberá novos e-mails em breve.");
            }
            else
            {
                Console.WriteLine("Ok, você não receberá e-mails de promoções.");
            }
            Console.WriteLine("Obrigado, e volte sempre!");


            Console.ReadKey();
        }
    }
}
