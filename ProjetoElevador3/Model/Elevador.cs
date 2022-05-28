using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador3.Model
{
    internal class Elevador
    {

        //Atributos da classe
        //public = indica que o atributo ou método pode ser usado em outros arquivos
        public int qtdePessoas { get; set; }
        public int andar { get; set; }
        //const = indica que o atributo não pode ser alterado (recebe valor fixo)
        public const int capElevador = 9;
        public const int totAndares = 6;

        // Método Inicializar : deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
        //int = tipo de retorno que o método retorna, neste caso um número inteiro
        //Se não retornar nada colocar void
        //Inicializar é o nome do método (sempre começar com letra maiúscula)
        //() lista de parâmetros do método
        //{} corpo do método

        public void Inicializar()
        {
            andar = 0;
            qtdePessoas = 0;
        }

        // Método Entrar : deve acrescentar uma pessoa no elevador
        // (só deve acrescentar se ainda houver espaço);

        public void Entrar()
        {
            if (qtdePessoas < capElevador)
            {
                qtdePessoas += 1;

            }
            else
            {
                Console.WriteLine("Elevador cheio! Aguarde o próximo.");
            }
            Console.WriteLine("Entrou uma pessoa no Elevador. Total de pessoas: " + qtdePessoas);
            Console.WriteLine("Andar: " + andar);

        }

        // Método Sair : deve remover uma pessoa do elevador
        // (só deve remover se houver alguém dentro dele);
        public void Sair()
        {
            if (qtdePessoas > 0)
            {
                qtdePessoas -= 1;

            }
            else
            {
                Console.WriteLine("Elevador vazio");
            }

            Console.WriteLine("Entrou uma pessoa no Elevador. Total de pessoas: " + qtdePessoas);
            Console.WriteLine("Andar: " + andar);
        }

        // Método Subir : deve subir um andar
        // (não deve subir se já estiver no último andar);
        public void Subir()
        {
            if (andar < totAndares)
            {
                andar += 1;

            }
            else
            {
                Console.WriteLine("Você está no último andar do prédio.");
            }
            Console.WriteLine("Entrou uma pessoa no Elevador. Total de pessoas: " + qtdePessoas);
            Console.WriteLine("Andar: " + andar);
        }

        // Método Descer : deve descer um andar (não deve descer se já estiver no térreo);
        public void Descer()
        {
            if (andar > 0)
            {
                andar -= 1;
            }
            else
            {
                Console.WriteLine("Você já está no térreo.");
            }
            Console.WriteLine("Entrou uma pessoa no Elevador. Total de pessoas: " + qtdePessoas);
            Console.WriteLine("Andar: " + andar);
        }

    }
}
