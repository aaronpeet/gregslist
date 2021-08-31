using System;
using System.ComponentModel.DataAnnotations;

namespace gregslist.Models
{
    public class Car
    {
        public string Id { get; set; }
        [Required]
        [Range(1950, 2021)]
        public int Year { get; set; }

        [Required]
        public string Make{ get; set; }
        [Required]
        public string Model{ get; set; }
        public Car(int year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
            Id = Guid.NewGuid().ToString();
        }
    }
}