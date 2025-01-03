using System.ComponentModel.DataAnnotations;

namespace Labels_KM49.Models.ViewModels
{
    public class JTransferspacketViewModel
    {
        public decimal TspId { get; set; }
        public DateTime TspTcreation { get; set; }
        public string TspStatus { get; set; } = null!;
        public string TspData { get; set; } = null!;
    }
}
