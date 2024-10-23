﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;

namespace WebApp.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisac imię!")]
    [MaxLength(length:20, ErrorMessage = "Imie nie moze być dłuższe niz 20 znaków")]
    [MinLength(length:2, ErrorMessage = "Imię musi miec conajmnije 2 znaki")]
    
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisac nazwisko!")]
    [MaxLength(length:50, ErrorMessage = "Nazwisko nie moze być dłuższe niz 50 znaków")]
    [MinLength(length:2, ErrorMessage = "Nazwisko musi miec conajmnije 2 znaki")]
    
    public string LastName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    [Phone]
    [RegularExpression(pattern:"\\d{3} \\d{3} \\d{3}", ErrorMessage = "Wpisz numer według wzoru: xxx xxx xxx")]
    public string PhoneNumber { get; set; }

    [DataType(DataType.Date)]
    public DateOnly BirthDate { get; set; }
}