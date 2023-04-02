using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Yazar : BaseEntity
    {
        public string Ad { get; set; } = null!;
        public List<Kitap> Kitaplar { get; set; } = new();
    }
}
