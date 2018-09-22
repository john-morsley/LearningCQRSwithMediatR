﻿namespace LearningCQRSwithMediatR.Models
{

    public class User
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{LastName}, {FirstName}";

    }

}