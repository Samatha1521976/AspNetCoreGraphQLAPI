using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechConference.Api.Data.Entities
{
    public class Session
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Room { get; set; }

        public string Day { get; set; }

        public string Format { get; set; }


        public string Level { get; set; }
    }
}
