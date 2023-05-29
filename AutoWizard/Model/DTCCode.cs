using System.Text.Json.Serialization;

namespace AutoWizard.Model
{
    public class DTCCode
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string PossibleCauses { get; set; }
        public string Solutions { get; set; }
    }
}
