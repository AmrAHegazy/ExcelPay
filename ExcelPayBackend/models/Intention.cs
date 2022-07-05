namespace ExcelPayBackend.models
{
    public class Intention
    {
        public int Id { get; set; }
        public ClientSecret ClientSecret { get; set; }
        public double Amount { get; set; }
        public merchant Merchant { get; set; }
    }
}
