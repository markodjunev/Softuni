﻿namespace MXGP.Models.Riders
{
    using System;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Utilities.Messages;


    public class Rider: IRider
    {
        private string _name;

        public Rider(string name)
        {
            this.Name = name;
            this.NumberOfWins = 0;
            this.CanParticipate = false;
        }

        public string Name
        {
            get => this._name;
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
                }

                this._name = value;
            }
        }

        public IMotorcycle Motorcycle { get; private set; }

        public int NumberOfWins { get; private set; }

        public bool CanParticipate { get; private set; }

        public void WinRace()
        {
            this.NumberOfWins++;
        }

        public void AddMotorcycle(IMotorcycle motorcycle)
        {
            if (motorcycle == null)
            {
                throw new ArgumentNullException(nameof(motorcycle),ExceptionMessages.MotorcycleInvalid);
            }

            this.Motorcycle = motorcycle;
            this.CanParticipate = true;
        }
    }
}