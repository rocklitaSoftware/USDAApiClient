using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDAApiClient
{
    public class SearchResult
    {
        public FoodSearchCriteria FoodSearchCriteria { get; set; }
        public int TotalHits { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public SearchResultFood[] SearchResultFoods { get; set; }
    }
}
