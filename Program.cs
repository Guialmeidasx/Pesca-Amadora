﻿const double LimiteAguasContinentais = 10;
const double LimiteAguasMarinhas = 15;

const decimal MultaBase = 1000;
const decimal MultaExcesso = 20;

Console.WriteLine("--- Pesca Amadora ---\n");

Console.Write("Peso (em kg)...: ");
double pesoPescado = Convert.ToDouble(Console.ReadLine());

Console.Write("Águas [c]ontinentais ou [m]arinhas? ");
string localPesca = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();

Console.WriteLine();

if (localPesca != "C" && localPesca != "M")
{
    Console.WriteLine("Local não reconhecido.");
    return;
}

if (localPesca == "C" && pesoPescado <= LimiteAguasContinentais ||
    localPesca == "M" && pesoPescado <= LimiteAguasMarinhas)
{
    Console.WriteLine("Pescaria dentro dos limites legais.");
    return;
}

double pesoPermitido = localPesca == "C" ? LimiteAguasContinentais : LimiteAguasMarinhas;
double pesoExcesso = pesoPescado - pesoPermitido;
decimal multa = MultaBase + MultaExcesso * Convert.ToDecimal(pesoExcesso);

Console.WriteLine($"Pescaria excede os limites legais em {pesoExcesso}kg.\nSujeito a multa de {multa:C}.");