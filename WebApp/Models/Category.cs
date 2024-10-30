using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace WebApp.Models;

public enum Category
{
    [Display(Name = "Rodzina", Order =1)]
    Family,
    [Display(Name = "Znajomi", Order =3)]
    Friends,
    [Display(Name = "Kontakt Zawodowy", Order =2)]
    Business
}