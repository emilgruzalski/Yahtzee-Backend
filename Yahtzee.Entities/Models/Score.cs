using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Entities.Models
{
    public class Score
    {
        public Guid ScoreID { get; set; }

        public Guid UserGameID { get; set; }

        public string? Category { get; set; }

        public int Points { get; set; }
    }
}
