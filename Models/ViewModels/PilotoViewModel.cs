using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labels_KM49.Models.ViewModels
{
    public class PilotoViewModel
    {
        public DateTime Creation { get; set; }
        public string? Vin { get; set; }
        public string? type { get; set; }
        [Key]
        public long Sequence { get; set; }
        public string? FullVin { get; set; }
        public string? Color { get; set; }

        public string? Enviado { get; set; }

        public int? Nempleado { get; set; }
        public string FrtLwrFascia { get; set; }

        public string RrLwrFascia { get; set; }

        public string FrUppEyeBrow { get; set; }
        public string Bpart { get; set; }
    }
}
