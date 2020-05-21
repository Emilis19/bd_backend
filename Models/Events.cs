using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace scheduleris_backend.Models
{
    public partial class Events
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PlaceId { get; set; }
        [JsonIgnore]
        public Place Place { get; set; }
    }
}
