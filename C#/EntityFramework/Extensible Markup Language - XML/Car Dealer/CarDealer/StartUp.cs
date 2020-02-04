namespace CarDealer
{
    using CarDealer.Data;
    using System;
    using System.Xml.Serialization;
    using System.Linq;
    using System.IO;
    using System.Collections.Generic;
    using CarDealer.Models;
    using CarDealer.Dtos.Import;
    using AutoMapper;
    using CarDealer.Dtos.Export;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Mapper.Initialize(m =>
            {
                m.AddProfile<CarDealerProfile>();
            });
            using (var context = new CarDealerContext())
            {
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();

                //var xmlSuppliers = File.ReadAllText("./../../../Datasets/suppliers.xml");
                //var xmlParts = File.ReadAllText("./../../../Datasets/parts.xml");
                //var xmlCars = File.ReadAllText("./../../../Datasets/cars.xml");
                //var xmlCustomers = File.ReadAllText("./../../../Datasets/customers.xml");
                //var xmlSales = File.ReadAllText("./../../../Datasets/sales.xml");

                Console.WriteLine(GetTotalSalesByCustomer(context));
            }
        }

        //problem9
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var xmlSerialization = new XmlSerializer(typeof(ImportSupplierDto[]), new XmlRootAttribute("Suppliers"));
            var suppliersDto = (ImportSupplierDto[])xmlSerialization.Deserialize(new StringReader(inputXml));

            var suppliers = new List<Supplier>();

            foreach (var supplierDto in suppliersDto)
            {
                var supplier = Mapper.Map<Supplier>(supplierDto);

                suppliers.Add(supplier);
            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }

        //problem10
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var xmlSerialization = new XmlSerializer(typeof(ImportPartDto[]), new XmlRootAttribute("Parts"));
            var partsDto = (ImportPartDto[])xmlSerialization.Deserialize(new StringReader(inputXml));

            var parts = new List<Part>();

            foreach (var partDto in partsDto)
            {
                if (context.Suppliers.Any(s => s.Id == partDto.SupplierId))
                {
                    var part = Mapper.Map<Part>(partDto);
                    parts.Add(part);
                }
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }

        //problem11
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var xmlSerialization = new XmlSerializer(typeof(ImportCarDto[]), new XmlRootAttribute("Cars"));
            var carsDto = (ImportCarDto[])xmlSerialization.Deserialize(new StringReader(inputXml));

            var cars = new List<Car>();

            foreach (var carDto in carsDto)
            {
                var car = Mapper.Map<Car>(carDto);

                context.Cars.Add(car);

                foreach (var part in carDto.Parts.PartsId)
                {
                    if (car.PartCars.FirstOrDefault(p => p.PartId == part.PartId) == null
                         && context.Parts.Find(part.PartId) != null)
                    {
                        var partCar = new PartCar()
                        {
                            PartId = part.PartId,
                            CarId = car.Id
                        };

                        car.PartCars.Add(partCar);
                    }
                }

                cars.Add(car);
            }

            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        //problem12
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            var xmlSerialization = new XmlSerializer(typeof(ImportCustomerDto[]), new XmlRootAttribute("Customers"));
            var customersDto = (ImportCustomerDto[])xmlSerialization.Deserialize(new StringReader(inputXml));

            var customers = new List<Customer>();

            foreach (var customerDto in customersDto)
            {
                var customer = Mapper.Map<Customer>(customerDto);
                customers.Add(customer);
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";
        }

        //problem13
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            var xmlSerialization = new XmlSerializer(typeof(ImportSaleDto[]), new XmlRootAttribute("Sales"));
            var salesDto = (ImportSaleDto[])xmlSerialization.Deserialize(new StringReader(inputXml));

            var sales = new List<Sale>();

            foreach (var saleDto in salesDto)
            {
                if (context.Cars.Any(c => c.Id == saleDto.CarId))
                {
                    var sale = Mapper.Map<Sale>(saleDto);
                    sales.Add(sale);
                }
            }

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";
        }

        //problem14
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.TravelledDistance > 2000000)
                .Select(c => new ExportCarDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportCarDto[]),
                new XmlRootAttribute("cars"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            xmlSerializer.Serialize(new StringWriter(sb), cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        //problem15
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "BMW")
                .Select(c => new ExportCarsBmwDto
                {
                    Id = c.Id,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportCarsBmwDto[]),
                new XmlRootAttribute("cars"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            xmlSerializer.Serialize(new StringWriter(sb), cars, namespaces);

            return sb.ToString().TrimEnd();
        }

        //problem16
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var localSuppliers = context.Suppliers
                .Where(ls => ls.IsImporter == false)
                .Select(ls => new ExportLocalSuppliersDto
                {
                    Id = ls.Id,
                    Name = ls.Name,
                    PartCount = ls.Parts.Count()
                })
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportLocalSuppliersDto[]),
                new XmlRootAttribute("suppliers"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            xmlSerializer.Serialize(new StringWriter(sb), localSuppliers, namespaces);

            return sb.ToString().TrimEnd();
        }

        //problem17
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsParts = context.Cars
                .Select(c => new ExportCarsDto
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    Parts = c.PartCars
                    .Select(p => new ExportPartsDto
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price

                    })
                    .OrderByDescending(p => p.Price)
                    .ToArray()

                })
                .OrderByDescending(c => c.TravelledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportCarsDto[]),
                new XmlRootAttribute("cars"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            xmlSerializer.Serialize(new StringWriter(sb), carsParts, namespaces);

            return sb.ToString().TrimEnd();
        }

        //problem18
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Count >= 1)
                .Select(c => new ExportCustomerDto
                {
                    Name = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = c.Sales.Sum(s => s.Car.PartCars.Sum(p => p.Part.Price))
                })
                .OrderByDescending(c => c.SpentMoney)
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportCustomerDto[]),
                new XmlRootAttribute("customers"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            xmlSerializer.Serialize(new StringWriter(sb), customers, namespaces);

            return sb.ToString().TrimEnd();
        }

        //problem 19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new ExportSaleDto
                {
                    Car = new ExportCarsDto
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },

                    Discount = s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(p => p.Part.Price),
                    PriceWithDiscount = s.Car.PartCars.Sum(p => p.Part.Price) -
                    s.Car.PartCars.Sum(p => p.Part.Price) * s.Discount / 100
                })
                .ToArray();

            var xmlSerializer = new XmlSerializer(typeof(ExportSaleDto[]),
                new XmlRootAttribute("sales"));

            var sb = new StringBuilder();

            var namespaces = new XmlSerializerNamespaces();

            namespaces.Add(string.Empty, string.Empty);

            xmlSerializer.Serialize(new StringWriter(sb), sales, namespaces);

            return sb.ToString().TrimEnd();
        }
    }
}