namespace USDAApiClient
{
    public class BrandedFoodItem
    {
        public int FdcId { get; set; }
        public string AvailableDate { get; set; }
        public string BrandOwner { get; set; }
        public string DataSource { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string FoodClass { get; set; }
        public string GtinUpc { get; set; }
        public string HouseholdServingFullText { get; set; }
        public string Ingredients { get; set; }
        public string ModifiedDate { get; set; }
        public string PublicationDate { get; set; }
        public float ServingSize { get; set; }
        public string ServingSizeUnit { get; set; }
        public string PreparationStateCode { get; set; }
        public string BrandedFoodCategory { get; set; }
        //trade channel string or enum?
        public int GpcClassCode { get; set; }
        public FoodNutrient[] FoodNutrients { get; set; }
        public FoodUpdateLog[] FoodUpdateLogs { get; set; }
        public Dictionary<LabelNutrientTypes, float> LabelNutrients = new Dictionary<LabelNutrientTypes, float>(); //TODO: research if this is the best way to do this 
    }

    public enum LabelNutrientTypes
    {
        saturatedFat,
        transFat,
        cholesterol,
        sodium,
        carbohydrates,
        fiber,
        sugars,
        protein,
        calcium,
        iron,
        potassium,
        calories
    }
}
