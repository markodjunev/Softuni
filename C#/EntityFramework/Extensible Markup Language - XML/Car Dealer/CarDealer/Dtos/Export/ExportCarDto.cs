namespace CarDealer.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("car")]
    public class ExportCarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("travelled-distance")]
        public long TravelledDistance { get; set; }
        //<car>
        //<make>BMW</make>
        //<model>E67</model>
        //<travelled-distance>476830509</travelled-distance>
        //</car>
    }
}
