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
            pessoas.Add(new Pessoa("Adaleberto", 34));
            pessoas.Add(new Pessoa("Cleitin Gameplays", 18));
            pessoas.Add(new Pessoa("Sasuke Naruto", 55));
            pessoas.Add(new Pessoa("Cleitin Gameplays", 8));
            pessoas.Add(new Pessoa("Boku no hero academia", 3));
            pessoas.Add(new Pessoa("Roberto NooN", 82));
            pessoas.Add(new Pessoa("Sasuke Naruto", 13));
            
            var quantidadePessoasMaiorIdade = QuantidadePessoasMaioresDeIdade(pessoas);
            var pessoaMaisVelha = PessoaMaisVelha(pessoas);
            var pessoaMaisNova = PessoaMaisNova(pessoas);
            var mediaIdades = CalcularMediaIdades(pessoas);

            Console.WriteLine("---- SENSO 2021 ----");
            Console.WriteLine("- Participantes: ");
            foreach (var pessoa in  pessoas) 
            {
                Console.WriteLine($"> {pessoa.Nome}, Idade {pessoa.Idade}.");
            }

            Console.WriteLine("\n----- DADOS -----");
            Console.WriteLine($"- Media de idade do grupo: {mediaIdades} anos");   
            Console.WriteLine($"- Pessoa mais velha: {pessoaMaisVelha.Nome}, com {pessoaMaisVelha.Idade} anos");
            Console.WriteLine($"- Pessoa mais nova: {pessoaMaisNova.Nome}, com {pessoaMaisNova.Idade} anos");
            Console.WriteLine($"- Quantidade de Pessoas Maiores de Idade: {quantidadePessoasMaiorIdade}\n");
        }

        private static int CalcularMediaIdades(List<Pessoa> pPessoas) 
        {
            return (int)pPessoas.Average(p => p.Idade);
        }

        private static Pessoa PessoaMaisVelha(List<Pessoa> pPessoas) 
        {
            return pPessoas.OrderByDescending(p => p.Idade).First();
        }

        private static Pessoa PessoaMaisNova(List<Pessoa> pPessoas) 
        {
            return pPessoas.OrderByDescending(p => p.Idade).Last();
        }

        private static int QuantidadePessoasMaioresDeIdade(List<Pessoa> pPessoas) 
        {
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
