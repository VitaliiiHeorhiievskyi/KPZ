﻿namespace WebApi.Models;

public class Patient
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string? Sex { get; set; }
    public virtual Guid AddressId { get; set; }
    public virtual PatientAddress? Address { get; set; }
    public virtual List<Notification>? Notifications { get; set; }
    public virtual List<Document>? Documents { get; set; }
}

public enum Sex { Male = 0, Female = 1 }
