using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicWPF.MVVM.Model
{
    class ClientAddresse
    {
        [RegularExpression("^[0-9]{2}-[0-9]{3}")]
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}
