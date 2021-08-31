using System;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Services
{
    public class CarsService
    {
        internal IEnumerable<Car> Get()
        {
            return FakeDB.Cars;
        }
    }
}