using System;


namespace ProjetoElevador3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Model.Elevador novoElevador = new Model.Elevador();

            //Pular uma linha
            Console.WriteLine();
            //Nome indicando a funcionalidade
            Console.WriteLine("Elevador");

            //Indicativo para o usuário de que ele está no térreo
            Console.WriteLine("Você está no andar térreo");
            novoElevador.Inicializar();

            //Condição para o laço de repetição
            bool continuar = true;

            do
            {
                Console.WriteLine(@"Selecione o que deseja fazer: 
                                    1 - Entrar no elevador
                                    2 - Sair do elevador
                                    3 - Subir um andar
                                    4 - Descer um andar
                                    5 - Finalizar
                    ");

                string OpcaoEscolhida = Console.ReadLine();

                //Para limpar o Console após a escolha
                Console.Clear();

                switch (OpcaoEscolhida)
                {
                    case "1": novoElevador.Entrar(); break;
                    case "2": novoElevador.Sair(); break;
                    case "3": novoElevador.Subir(); break;
                    case "4": novoElevador.Descer(); break;
                    case "5": continuar = false; break;
                    default: Console.WriteLine("Escolha uma opção válida."); break;
                    
                }


            }

            while (continuar);



        }

      
    }
}
