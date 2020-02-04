namespace ProductShop.Dtos.Export
{
    using System.Xml.Serialization;

    [XmlType("Category")]
    public class ExportCategoryDto
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("count")]
        public int Count { get; set; }

        [XmlElement("averagePrice")]
        public decimal AveragePrice { get; set; }

        [XmlElement("totalRevenue")]
        public decimal TotalRevenue { get; set; }
        //< Category >
        //< name > Adult </ name >
        //< count > 22 </ count >
        //< averagePrice > 704.41 </ averagePrice >
        //< totalRevenue > 15497.02 </ totalRevenue >
        //</ Category >
    }
}
