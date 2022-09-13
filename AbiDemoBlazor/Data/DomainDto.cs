using System.ComponentModel.DataAnnotations;

namespace AbiDemoBlazor.Data
{
    public class DomainDto
    {
        [Required]
        public string Domain { get; set; }
        public string CheckType { get; set; }
        public bool ForTransfer { get; set; }
    }
}
