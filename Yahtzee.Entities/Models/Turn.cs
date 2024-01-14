using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Entities.Models
{
    public class Turn
    {
        public Guid TurnID { get; set; }

        public Guid GameID { get; set; }

        public Guid UserID { get; set; }

        public int TurnNumber { get; set; }

        public string? Roll1 { get; set; }

        public string? Roll2 { get; set; }

        public string? Roll3 { get; set; }

        public string? CategoryChosen { get; set; }

        public int Score { get; set; }

        public DateTime TurnTime { get; set; }
    }
}
