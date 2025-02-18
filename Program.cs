using System;
using System.Text;
using System.Collections.Generic;
using Hotelaria.models;


class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Lista para armazenar os hóspedes
        List<Pessoa> Hospedes = new List<Pessoa>();

        Console.WriteLine("Olá, quantas pessoas irão se cadastrar em nosso hotel?");
        int Quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine($"Perfeito, então serão {Quantidade} em nosso hotel.");

        // Loop para coletar os nomes e idades dos hóspedes
        for (int i = 1; i <= Quantidade; i++)
        {
            Console.WriteLine($"Nome da pessoa {i}: ");
            string NomeHospede = Console.ReadLine();

            Console.WriteLine($"Idade da pessoa {i}: ");
            int IdadeHospede = int.Parse(Console.ReadLine());

            // Adiciona à lista
            Hospedes.Add(new Pessoa { Nome = NomeHospede, Idade = IdadeHospede });
        }

        // Exibindo os hóspedes cadastrados
        Console.WriteLine("\nHóspedes cadastrados:");
        foreach (var Hospede in Hospedes)
        {
            Console.WriteLine($"Nome: {Hospede.Nome}, Idade: {Hospede.Idade}");
        }

        // Criando uma suíte
        Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

        // Criando uma reserva e cadastrando suíte e hóspedes
        Reserva reserva = new Reserva(diasReservados: 5);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(Hospedes); // Correção: Usar 'Hospedes' com H maiúsculo

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"\nHóspedes na reserva: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria()}");
    }
}
