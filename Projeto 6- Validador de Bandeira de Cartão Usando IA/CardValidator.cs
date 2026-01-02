using System;
using System.Collections.Generic;
using System.Linq;

public class CardValidator
{
    // Regras das bandeiras
    private static readonly Dictionary<string, (List<string> Prefixes, List<int> Lengths)> CardRules = new()
    {
        ["Visa"] = (new List<string> { "4" }, new List<int> { 13, 16, 19 }),

        ["Visa Electron"] = (new List<string> { "4026", "417500", "4508", "4844", "4913", "4917" }, new List<int> { 16 }),

        ["Mastercard"] = (new List<string> { "51", "52", "53", "54", "55" }, new List<int> { 16 }),

        ["American Express"] = (new List<string> { "34", "37" }, new List<int> { 15 }),

        ["Discover"] = (new List<string> { "6011", "65" }, new List<int> { 16 }),

        ["Diners Club"] = (new List<string> { "300", "301", "302", "303", "304", "305", "36", "38" }, new List<int> { 14 }),

        ["JCB"] = (new List<string> { "35" }, new List<int> { 16 }),

        ["Elo"] = (new List<string>
        {
            "4011", "4312", "4389", "4514", "4576",
            "5041", "5066", "5067", "5090", "6277",
            "6362", "6363", "6500", "6504", "6505",
            "6509", "6516", "6550"
        }, new List<int> { 16 }),

        ["Hipercard"] = (new List<string> { "6062" }, new List<int> { 16 }),

        ["Maestro"] = (new List<string>
        {
            "5018", "5020", "5038", "5612", "5893",
            "6304", "6759", "6761", "6762", "6763"
        }, new List<int> { 12, 13, 14, 15, 16, 17, 18, 19 }),

        ["enRoute"] = (new List<string> { "2014", "2149" }, new List<int> { 15 }),

        ["Solo"] = (new List<string> { "6334", "6767" }, new List<int> { 16, 18, 19 }),

        ["Switch"] = (new List<string>
        {
            "4903", "4905", "4911", "4936",
            "564182", "633110", "6333", "6759"
        }, new List<int> { 16, 18, 19 }),

        ["Laser"] = (new List<string> { "6304", "6706", "6771", "6709" }, new List<int> { 16, 18, 19 })
    };

    /// <summary>
    /// Identifica a bandeira do cartão com base no número.
    /// </summary>
    public static string GetCardBrand(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber) || !cardNumber.All(char.IsDigit))
            return "Invalid";

        string bestMatch = "Unknown";
        int maxPrefixLength = 0;

        foreach (var rule in CardRules)
        {
            foreach (var prefix in rule.Value.Prefixes)
            {
                if (cardNumber.StartsWith(prefix) &&
                    rule.Value.Lengths.Contains(cardNumber.Length) &&
                    prefix.Length > maxPrefixLength)
                {
                    bestMatch = rule.Key;
                    maxPrefixLength = prefix.Length;
                }
            }
        }

        // Tratamento especial para Mastercard (2221–2720)
        if (cardNumber.Length == 16 && cardNumber.Length >= 4)
        {
            if (int.TryParse(cardNumber.Substring(0, 4), out int prefix) &&
                prefix >= 2221 && prefix <= 2720)
            {
                if (4 > maxPrefixLength)
                    bestMatch = "Mastercard";
            }
        }

        // Tratamento especial para Discover (622126–622925, 644–649)
        if (cardNumber.Length == 16)
        {
            if (cardNumber.StartsWith("622") &&
                int.TryParse(cardNumber.Substring(3, 3), out int mid) &&
                mid >= 126 && mid <= 925)
            {
                if (6 > maxPrefixLength)
                    bestMatch = "Discover";
            }

            if (cardNumber.StartsWith("64") &&
                int.TryParse(cardNumber.Substring(1, 2), out int end) &&
                end >= 4 && end <= 9)
            {
                if (3 > maxPrefixLength)
                    bestMatch = "Discover";
            }
        }

        return bestMatch;
    }

    /// <summary>
    /// Valida o número do cartão usando o algoritmo de Luhn.
    /// </summary>
    public static bool IsValidLuhn(string cardNumber)
    {
        if (string.IsNullOrWhiteSpace(cardNumber) || !cardNumber.All(char.IsDigit))
            return false;

        int sum = 0;
        bool alternate = false;

        for (int i = cardNumber.Length - 1; i >= 0; i--)
        {
            int digit = cardNumber[i] - '0';

            if (alternate)
            {
                digit *= 2;
                if (digit > 9)
                    digit -= 9;
            }

            sum += digit;
            alternate = !alternate;
        }

        return sum % 10 == 0;
    }

    /// <summary>
    /// Valida o cartão e retorna se é válido e qual bandeira.
    /// </summary>
    public static (bool IsValid, string Brand) ValidateCard(string cardNumber)
    {
        string brand = GetCardBrand(cardNumber);

        if (brand == "Invalid" || brand == "Unknown")
            return (false, brand);

        bool isValid = IsValidLuhn(cardNumber);
        return (isValid, brand);
    }
}
