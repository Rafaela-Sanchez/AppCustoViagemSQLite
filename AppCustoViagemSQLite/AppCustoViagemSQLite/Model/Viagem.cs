using System;
using System.Collections.Generic;
using System.Text;

namespace AppCustoViagemSQLite.Model
{
    public class Viagem
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public decimal Distancia { get; set; }
        public decimal Consumo { get; set; }
        public decimal PrecoCombustivel { get; set; }

    }
}
