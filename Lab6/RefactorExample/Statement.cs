using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using RefactorExample.DTOs;

[assembly: InternalsVisibleTo("RefactorExample.Tests")]

namespace RefactorExample
{
    internal static class Statement
    {
        public static string CreateStatement(Invoice invoice, Dictionary<string, Play> plays)
        {
            var totalAmount = 0;
            var volumeCredits = 0;
            var results = $"Rachunek dla {invoice.Customer}";

            CultureInfo pl = new CultureInfo("pl-PL");

            foreach (var perf in invoice.Performances)
            {
                var play = plays[perf.PlayID];
                var thisAmount = 0;

                switch (play.Type)
                {
                    case "tragedia":
                        thisAmount = 40000;
                        if (perf.Audience > 30)
                        {
                            thisAmount += 1000 * (perf.Audience - 30);
                        }
                        break;

                    case "komedia":
                        thisAmount = 30000;
                        if (perf.Audience > 20)
                        {
                            thisAmount += 10000 + 500 * (perf.Audience - 20);
                        }
                        thisAmount += 300 * perf.Audience;
                        break;

                    default:
                        throw new ArgumentException($"Nieznany typ przedstawienia: ${play.Type}");
                }

                // Award bonus points
                volumeCredits += Math.Max(perf.Audience - 30, 0);
                // Award an additional promotional point for every 5 viewers of the comedy
                if ("komedia" == play.Type)
                {
                    volumeCredits += (int)Math.Floor((decimal)perf.Audience / 5);
                }

                // Create statement row
                results += $"{play.Name}: {(thisAmount / 100).ToString("c", pl)} (liczba miejsc: {perf.Audience}" + Environment.NewLine;
                totalAmount += thisAmount;
            }

            results += $"Naleznosc: {(totalAmount / 100).ToString("c", pl)}" + Environment.NewLine;
            results += $"Punkty promocyjne: {volumeCredits}";

            return results;
        }
    }
}