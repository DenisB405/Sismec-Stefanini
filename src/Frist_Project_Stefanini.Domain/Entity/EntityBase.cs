using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Frist_Project_Stefanini.ApplicarionCore.Entity
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
