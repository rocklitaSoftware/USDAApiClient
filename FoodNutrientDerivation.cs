
namespace USDAApiClient
{
    public class FoodNutrientDerivation
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public FoodNutrientSource FoodNutrientSource { get; set; }
    }
}
