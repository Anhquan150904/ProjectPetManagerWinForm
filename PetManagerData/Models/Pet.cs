namespace PetManagerData.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
    }
}
