﻿namespace WebApi.Models
{
    public class PatientAddress
    {
        public Guid Id { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
