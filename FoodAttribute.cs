namespace USDAApiClient
{
    public class FoodAttribute
    {
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public string Value { get; set; }
        public FoodAttributeType FoodAttributeType { get; set; }
    }
}
