namespace USDAApiClient
{
    public class SearchResultFood
    {
        public int FdcID { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string FoodCode { get; set; }
        public AbridgedFoodNutrient[] FoodNutrients { get; set; }
        public string PublicationDate { get; set; }
        public string ScientificName { get; set; }
        public string BrandOwner { get; set; }
        public string GtinUpc { get; set; }
        public string Ingredients { get; set; }
        public string AdditionalDescriptions { get; set; }
        public string AllHighlightFields { get; set; }
        public float Score { get; set; }
    }
}
