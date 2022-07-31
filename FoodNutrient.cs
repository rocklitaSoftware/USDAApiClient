
namespace USDAApiClient
{
    public class FoodNutrient
    {
        public int Id { get; set; }
        public float Amount { get; set; }
        public int DataPoints { get; set; }
        public float Min { get; set; }
        public float Max { get; set; }
        public float Median { get; set; }
        public string Type { get; set; }
        public Nutrient Nutrient { get; set; }
        public FoodNutrientDerivation FoodNutrientDerivation { get; set; }
        public NutrientAnalysisDetails NutrientAnalysisDetails { get; set; }
    }
}
