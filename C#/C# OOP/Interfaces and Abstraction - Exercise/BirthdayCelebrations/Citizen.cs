﻿using System;

namespace BirthdayCelebrations
{
    public class Citizen : IDentifiable, IBirthdate, IName
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = DateTime.ParseExact(birthdate, "dd/mm/yyyy", null);
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public DateTime Birthdate { get; private set; }
    }
}