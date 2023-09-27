﻿namespace WebApplication1.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public GenderModel Gender { get; set; } = new GenderModel();
    }
}
