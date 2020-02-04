namespace ProductShop.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("User")]
    public class ExportUserDto
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlArray("soldProducts")]
        public ExportProductDto[] ProductsSold { get; set; }

        //<firstName>Almire</firstName>
        //<lastName>Ainslee</lastName>
        //<soldProducts>

    }
}
