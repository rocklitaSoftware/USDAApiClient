
namespace USDAApiClient
{
    public class NutrientAnalysisDetails
    {
        public int SubSampleId { get; set; }
        public float Amount { get; set; }
        public int NutrientId { get; set; }
        public string LabMethodDescription { get; set; }
        public string LabMethodOriginalDescription { get; set; }
        public string LabMethodLink { get; set; }
        public string LabMethodTechnique { get; set; }
        public NutrientAcquisitionDetails[] NutrientAcquisitionDetails { get; set; }

    }
}
