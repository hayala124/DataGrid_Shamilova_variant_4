using DataGrid_Shamilova_variant_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid_Shamilova_variant_4
{
    internal class DateGenerate
    {
        public static Tour CreateTour(Action<Tour> settings = null)
        {
            var result = new Tour()
            {
                Id = Guid.NewGuid(),
                Direction = Direction.France,
                DepartureDate = DateTime.Now.AddDays(15),
                NumberOfNights = 2,
                CostVacationer = 2,
                NumberOfVacationer = 5,
                WiFi = true,
                Surcharges = 0,
            };

            settings?.Invoke(result);

            return result;
        }
    }
}
