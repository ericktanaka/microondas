using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Microwave
{
    public class ListaAquecimentos
    {
        public List<NovoAquecimento> Aquecimentos = new List<NovoAquecimento>();
    }

    public class NovoAquecimento
    {
        public Guid Id { get; set; }
        public string Nome {  get; set; }
        public string Alimento { get; set; }
        public string Potencia { get; set; }
        public string Tempo { get; set; }
        public string Instrucaodeuso { get; set; }

        public string JsonSerializar(NovoAquecimento novoAquecimento)
        {
            return JsonConvert.SerializeObject(novoAquecimento);
        }
    }
}
