using AutoWizard.Model;
using System.Text.Json.Serialization;

namespace AutoWizardAPI.DTO
{
    public class DTCCodeDto : DTCCode
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string PossibleCauses { get; set; }
        public string Solutions { get; set; }
    }
}
