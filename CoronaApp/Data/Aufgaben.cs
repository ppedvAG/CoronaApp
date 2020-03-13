using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoronaApp.Data
{
    public class Aufgabe
    {

        public int ID { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [MinLength(5,ErrorMessage ="mind 5 Zeichen")]
        [MaxLength(20,ErrorMessage="max 20 ")]
        public string Text { get; set; }

        [Zukunft(ErrorMessage ="muss in Zukunft leigen")]
        public DateTime ErledigtBis { get; set; }
        public Boolean Erledigt { get; set; }

   [JsonIgnore]
        public Boolean Bearbeiten { get; set; }
    }
}
