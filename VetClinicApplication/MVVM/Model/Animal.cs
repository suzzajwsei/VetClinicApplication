using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicApplication.MVVM.Model
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        public string Species { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
    }
}
