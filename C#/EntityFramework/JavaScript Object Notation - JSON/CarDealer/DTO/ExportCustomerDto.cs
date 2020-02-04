namespace CarDealer.DTO
{
    using Newtonsoft.Json;

    public class ExportCustomerDto
    {
        [JsonProperty("fullName")]
        public string Fullname { get; set; }

        [JsonProperty("boughtCars")]
        public int BoughtCars { get; set; }

        [JsonProperty("spentMoney")]
        public decimal SpentMoney { get; set; }
    }
}