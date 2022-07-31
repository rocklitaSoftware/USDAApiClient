namespace USDAApiClient
{
    public class AbridgedFoodItem
    {
        public string DataType { get; set; }
        public string Description { get; set; }
        public int FdcId { get; set; }
        public AbridgedFoodNutrient[] FoodNutrients { get; set; }
        public string PublicationDate { get; set; }
        public string BrandOwner { get; set; }
        public string GtinUpc { get; set; }
        public int NdbNumber { get; set; }
        public string FoodCode { get; set; }

    }
}
