// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Validador de Bandeira de Cartão - Exemplos de Teste");
        Console.WriteLine("==================================================");

        // Exemplos de cartões válidos
        TestCard("4111111111111111", "Visa válido (16 dígitos)");
        TestCard("4000000000000002", "Visa válido (16 dígitos, outro)");
        TestCard("411111111111111", "Visa válido (13 dígitos)");
        TestCard("4111111111111111111", "Visa válido (19 dígitos)");
        TestCard("5555555555554444", "Mastercard válido");
        TestCard("2221000000000009", "Mastercard válido (prefixo 2221)");
        TestCard("2720999999999999", "Mastercard válido (prefixo 2720)");
        TestCard("378282246310005", "American Express válido");
        TestCard("371449635398431", "American Express válido");
        TestCard("6011111111111117", "Discover válido");
        TestCard("6511111111111111", "Discover válido (prefixo 65)");
        TestCard("6221261111111111", "Discover válido (prefixo 622126)");
        TestCard("6499999999999999", "Discover válido (prefixo 649)");
        TestCard("4011111111111112", "Elo válido");
        TestCard("4312123412341234", "Elo válido");
        TestCard("6062821111111111", "Hipercard válido");

        // Exemplos de cartões inválidos (não passam no Luhn)
        TestCard("4111111111111112", "Visa inválido (falha no Luhn)");
        TestCard("5555555555554443", "Mastercard inválido (falha no Luhn)");
        TestCard("378282246310004", "American Express inválido (falha no Luhn)");
        TestCard("6011111111111116", "Discover inválido (falha no Luhn)");
        TestCard("4011111111111111", "Elo inválido (falha no Luhn)");
        TestCard("6062821111111112", "Hipercard inválido (falha no Luhn)");

        // Exemplos com comprimento incorreto
        TestCard("41111111111111", "Visa com 14 dígitos (inválido)");
        TestCard("55555555555544444", "Mastercard com 17 dígitos (inválido)");
        TestCard("3782822463100051", "American Express com 16 dígitos (inválido)");

        // Exemplos de bandeiras desconhecidas
        TestCard("1234567890123456", "Número desconhecido");
        TestCard("9999999999999999", "Número desconhecido");

        // Exemplos de entrada inválida
        TestCard("", "String vazia");
        TestCard("   ", "Apenas espaços");
        TestCard("4111-1111-1111-1111", "Com hífens (será limpo)");
        TestCard("411111111111111a", "Com letra");
        TestCard("4111 1111 1111 1111", "Com espaços (será limpo)");
        TestCard(null, "Null (não aplicável, mas tratado)");
    }

    static void TestCard(string cardNumber, string description)
    {
        var result = CardValidator.ValidateCard(cardNumber ?? "");
        Console.WriteLine($"{description}:");
        Console.WriteLine($"  Número: {cardNumber ?? "null"}");
        Console.WriteLine($"  Válido: {result.IsValid}");
        Console.WriteLine($"  Bandeira: {result.Brand}");
        Console.WriteLine();
    }
}
