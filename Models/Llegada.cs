using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace POST2.Models
{
    [Table("VUELOS")]
    public class Llegada
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Column("FLYNUMBER")]
        public String Fly{ get; set; }
        [Column("AIRLANE")]
        public String Airlane { get; set; }
        [Column("CITYFROM")]
        public String From { get; set; }
        [Column("CITYTO")]
        public String To { get; set; }
        [Column("GATE")]
        public int Gate{ get; set; }
        [Column("HOUR")]
        public String Hour{ get; set; }
    }
}
