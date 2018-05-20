using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MountainWalkerWebAPI.Models
{
    public class Trail
    {
        public int TrailID { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TrailDate { get; set; }
        public double Time { get; set; }
        public int UserID { get; set; }
        public ICollection<Point> Points { get; set; }
    }
}
