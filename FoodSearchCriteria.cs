

namespace USDAApiClient
{
    public class FoodSearchCriteria
    {
        public string Description { get; set; }
        public string Query { get; set; }
        public DataType[] DataTypes { get; set; }
        public int PageSize { get; set; }
        public SortBy SortBy { get; set; }
        public SortOrder SortOrder { get; set; }
        public string BrandOwner { get; set; }
        public TradeChannel[] TradeChannels { get; set; }
        public string StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public enum DataType
    {
        Branded,
        Foundation,
        Survey,
        SR_Legacy
    }

    public enum SortBy
    {
        dataType_keyword,
        lowercaseDescription_keyword,
        fdcId,
        publishedDate
    }

    public enum SortOrder
    {
        asc,
        desc
    }

    public enum TradeChannel
    {
        CHILD_NUTRITION_FOOD_PROGRAMS, DRUG, FOOD_SERVICE, GROCERY, MASS_MERCHANDISING, MILITARY, ONLINE, VENDING
    }
}
