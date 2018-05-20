using System;
namespace MountainWalkerWebAPI.Models
{
    public class UserAchivements
    {
		public int UserID { get; set; }
        public int AchivementID { get; set; }
        public DateTime Date { get; set; }
    }
}
