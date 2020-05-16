using System.Collections.Generic;

namespace EFCoreWebApi.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<HeroiBatalha> HeroiBatalhas { get; set; }
        public List<Arma> Armas { get; set; }
    }
}
