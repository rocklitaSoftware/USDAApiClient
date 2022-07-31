namespace USDAApiClient
{
    public class FoodUpdateLog
    {
        public int FdcId { get; set; }
        public string AvailableDate { get; set; }
        public string BrandOwner { get; set; }
        public string DataSource { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string FoodClass { get; set; }
        public string GtinUpc { get; set; }
        public string HouseHoldServingsFullText { get; set; }
        public string Ingredients { get; set; }
        public string ModifiedDate { get; set; }
        public string PublicationDate { get; set; }
        public int ServingSize { get; set; }
        public string ServingSizeUnit { get; set; }
        public string BrandedFoodCategory { get; set; }
        public string Changes { get; set; }
        public FoodAttribute[] FoodAttributes {get; set;}
    }
}
