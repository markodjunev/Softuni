﻿namespace CarDealer.Dtos.Import
{
    using System.Xml.Serialization;

    [XmlRoot("parts")]
    public class ImportPartIdDto
    {
        [XmlAttribute("id")]
        public int PartId { get; set; }

        //<Car>
        //  <make>Opel</make>
        //  <model>Omega</model>
        //  <TraveledDistance>176664996</TraveledDistance>
        //  <parts>
        //    <partId id = "38" />
        //    < partId id="102"/>
        //    <partId id = "23" />
        //    < partId id="116"/>
        //    <partId id = "46" />
        //    < partId id="68"/>
        //    <partId id = "88" />
        //    < partId id="104"/>
        //    <partId id = "71" />
        //    < partId id="32"/>
        //    <partId id = "114" />
        //  </ parts >
        //</ Car >
    }
}
