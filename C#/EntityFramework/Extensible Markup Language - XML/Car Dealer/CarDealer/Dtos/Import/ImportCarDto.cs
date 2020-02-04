namespace CarDealer.Dtos.Import
{
    using System.Xml.Serialization;

    [XmlType("Car")]
    public class ImportCarDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("TraveledDistance")]
        public long TravelledDistance { get; set; }

        [XmlElement("parts")]
        public ImportPartsDto Parts { get; set; }
        //<Car>
        //<make>Opel</make>
        //<model>Omega</model>
        //<TraveledDistance>176664996</TraveledDistance>
        //<parts>
    }
}
