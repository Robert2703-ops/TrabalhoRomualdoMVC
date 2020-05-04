using System;

namespace TrabalhoRomualdo.Models
{
    public class Usuario
    {
        public string Name{get;set;}
        public string BirthDate{get;set;}
        //Professor, botei a data como string, pq foi o único jeito que consegui tirar o horário
        public string BirthDay{get;set;}
        public float Height{get;set;}
        public float Weight{get;set;}
        public string IMC{get;set;}
    }
}