using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee.Entities.Models
{
    public class UserGame
    {
        public Guid UserGameID { get; set; }

        public Guid UserID { get; set; }

        public Guid GameID { get; set; }

        public int Score { get; set; }
    }
}
