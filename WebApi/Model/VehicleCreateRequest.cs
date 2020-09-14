using Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Validation;

namespace WebApi.Model
{
    public class VehicleCreateRequest
    {
        public string Name { get; set; }
        
        [Required]
        [MinLength(3, ErrorMessage = "Min lenght is violated")]
        public string Make { get; set; }

        [Required]
        [MinLength(3)]
        public string Model { get; set; }

        [Required]
        [VinValidator(ErrorMessage = "Expects valid VIN")]
        public string Vin { get; set; }

        [JsonProperty(PropertyName = "Class")]
        public string MyFancyProperty { get; }

        internal Vehicle ToDomain()
        {
            return new Vehicle(Make, Model, Name);
        }
    }
}
