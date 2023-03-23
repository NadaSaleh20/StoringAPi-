using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HTTPClientProject.Db
{
    public class Emoloyee
    {

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
    
       public string employee_name { get; set; }
       public int employee_salary { get; set; }
     public int employee_age { get; set; }
    }
}
