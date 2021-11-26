using System;
using System.Collections.Generic;
using System.Linq;




namespace dotnetcore
{
    class Program
    {
        const float MAIORIDADE = 18;

        static void Main(string[] args)
        {
            var pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Adaleberto", 10));
            pessoas.Add(new Pessoa("Cleitin Gameplays", 16));
            pessoas.Add(new Pessoa("Sasuke Naruto", 19));
            
            Console.WriteLine("---- SENSO 2021 ----");
            Console.WriteLine("- Participantes: ");
            foreach (var pessoa in  pessoas) {
                Console.WriteLine($"> {pessoa.Nome}, Idade {pessoa.Idade}.");
            }

            int quantidadePessoasMaiorIdade = QuantidadePessoasMaioresDeIdade(pessoas);
            Pessoa pessoaMaisVelha = PessoaMaisVelha(pessoas);
            Pessoa pessoaMaisNova = PessoaMaisNova(pessoas);
            Console.WriteLine("\n----- DADOS -----");
            Console.WriteLine($"- Media de idade do grupo: {CalcularMediaIdades(pessoas)}");   
            Console.WriteLine($"- Pessoa mais velha: {pessoaMaisVelha.Nome}, com {pessoaMaisVelha.Nome}");
            Console.WriteLine($"- Pessoa mais velha: {pessoaMaisNova.Nome}, com {pessoaMaisNova.Idade}");
            Console.WriteLine($"- Quantidade de Pessoas Maiores de Idade: {quantidadePessoasMaiorIdade}\n");
        }

        private static int CalcularMediaIdades(List<Pessoa> pPessoas) {
            return (int)pPessoas.Average(p => p.Idade);
        }

        private static Pessoa PessoaMaisVelha(List<Pessoa> pPessoas) {
            return pPessoas.OrderBy(p => p.Idade).First();
        }

        private static Pessoa PessoaMaisNova(List<Pessoa> pPessoas) {
            return pPessoas.OrderBy(p => p.Idade).Last();
        }

        private static int QuantidadePessoasMaioresDeIdade(List<Pessoa> pPessoas) {
            return pPessoas.Where(p => p.Idade > MAIORIDADE).Count(); 
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }      

        public Pessoa(string pNome, int pIdade)
        {
            Nome = pNome;
            Idade = pIdade;                
        }
    }
}
