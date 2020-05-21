using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace scheduleris_backend.Models
{
    public partial class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public IList<Events> Events { get; set; }
    }
}
