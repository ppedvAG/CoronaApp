using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaApp.Data
{
    public class ZukunftAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var datum = (DateTime)value;
            if (datum > DateTime.Now)
            {

                return true;
            }
            return false;

        }
    }
}
