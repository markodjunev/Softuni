namespace ProductShop.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("Product")]
    public class ExportProductDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        //<Product>
        //<name>olio activ mouthwash</name>
        //<price>206.06</price>
        //</Product>
    }
}