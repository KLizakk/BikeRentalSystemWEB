﻿namespace BikeRentalSystemWEB.ViewModels
{
     public enum BikeTypeModel {Male,Female,Kids}
    public class BikeDetailViewModel
    {
        public int Id { get; set; }
        public string Producer { get; set; }
        public string Model { get; set; }
        public int NumberOfGears { get; set; }
        public BikeTypeModel  bikeType { get; set; }
        public string Color { get; set; }
        public int NumberOfBikes { get; set; }
    }
}
