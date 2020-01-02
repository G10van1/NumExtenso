using System;
using System.Collections.Generic;

namespace CERTIDesafio
{
    public class Numero
    {
        // Propiedade que recebe o valor por extenso
        public string Extenso { get; set;}

        //**********************************************************************************
        // Construtor
        // Parâmetros:  int NumeroDecimal
        //              Número inteiro entre -99999 e 99999 que será escrito por extenso
        //**********************************************************************************
        public Numero(int NumeroDecimal) => FormatarExtenso(NumeroDecimal);

        //**********************************************************************************
        // Formatação de um número decimal inteiro por extenso, armazena string formatado na
        // Propriedade Extenso.
        // Parâmetros:  int Decimal
        //              Número inteiro entre -99999 e 99999 que será escrito por extenso
        //**********************************************************************************
        private void FormatarExtenso(int Decimal)
        {
            Extenso = "";
            // Vetor de números básicos (0 a 19) por extenso 
            var NumerosBasicos = new List<string>() {"zero", "um", "dois", "três", "quatro", "cinco",
                "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze",
                "dezesseis", "dezessete", "dezoito", "dezenove"};

            // Vetor de dezenas (0 a 90) por extenso 
            var Dezenas = new List<string>() {"zero", "dez", "vinte", "trinta", "quarenta", "cinquenta",
                "sessenta", "setenta", "oitenta", "noventa"};
            
            // Vetor de centenas (0 a 900) por extenso 
            var cem = (Decimal % 100) == 0 ? "cem" : "cento";
            var Centenas = new List<string>() {"zero", cem, "duzentos", "trezentos", "quatrocentos", "quinhentos",
                "seiscentos", "setecentos", "oitocentos", "novecentos"};

            // Caso seja zero
            if (Decimal == 0)
            {
                Extenso = "zero";
                return;
            }

            // Caso esteja fora de intervalo válido
            if (Decimal > 99999 || Decimal < -99999) 
            {
                Extenso = "Erro: Número fora do limite permitido [-99999,99999]";
                return;
            }

            // Tratamento do sinal negativo
            // Número deve ser positivo para cálculos na formatação
            if (Decimal < 0)
            {
                Extenso = "menos ";
                Decimal *= -1;
            }

            // Cálculo dos índices dos vetores
            int milhar = (Decimal / 1000);
            int centena = (Decimal % 1000)/100;
            int dezena = (Decimal % 100) / 10;
            int unidade = (Decimal % 10);
            unidade += dezena == 1 ? 10 : 0;// incluir números de 10 a 19 se for o caso

            // Formatar milhar
            if (milhar >= 20)// Acima de 19999
            {
                Extenso += Dezenas[milhar / 10];

                if (milhar % 10 != 0)//Dezena não terminada com 0, deve escrever a unidade
                    Extenso += " e " + NumerosBasicos[milhar % 10];

                Extenso += " mil";
            }
            else
            {
                if (milhar % 20 > 1)// Se é um número acima de 1999
                    Extenso += NumerosBasicos[milhar] + " ";

                if (milhar % 20 != 0)// Se está acima de 999
                    Extenso += "mil";
            }

            // Formatar centena
            if (centena > 0)// Se está acima de 99
                Extenso += ConcatenaE() + Centenas[centena];

            // Formatar dezena
            if (dezena > 1)// Se está acima de 19
                Extenso += ConcatenaE() + Dezenas[dezena];

            // Formatar unidade
            if (unidade > 0)// Se não é zero
                Extenso += ConcatenaE() + NumerosBasicos[unidade];
        }

        //**********************************************************************************
        // Testa se deve concatenar letra "e" no contexto atual do número por extenso
        // Retorna:  string 
        //           valor " e " ou ""
        //**********************************************************************************
        private string ConcatenaE()
        {
            // Se já escreveu algum número, retorna " e " senão retorna nada
            return ((Extenso != "" && Extenso != "menos " ? " e " : ""));
        }
    }
}
