using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinicApplication.MVVM.Model
{
    class MedProcedureList
    {
        [Key]
        public int MedProcNumber { get; set; }
        public string MedProcName { get; set; }
        public int Price { get; set; }
    }
}
