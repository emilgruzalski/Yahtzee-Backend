﻿namespace Yahtzee.Entities.Models
{
    public class User
    {
        public Guid UserID { get; set; }

        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public DateTime DateRegistered{ get; set; }
    }
}
