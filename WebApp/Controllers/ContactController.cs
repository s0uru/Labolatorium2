using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ContactController : Controller
{

    private static Dictionary<int, ContactModel> _contacts = new()
    {
        {
            1, new ContactModel()
            {
                Id = 1,
                FirstName = "Jakub",
                LastName = "Pietrusiak",
                Email = "adasdad@wp.pl",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(year: 2000, month: 12, day: 3)
            }
        },
        {
            2, new ContactModel()
            {
                Id = 2,
                FirstName = "Jakub",
                LastName = "kowalski",
                Email = "adasdad@wp.pl",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(year: 2000, month: 12, day: 3)
            }

        },
        {
            3, new ContactModel()
            {
                Id = 3,
                FirstName = "maciek",
                LastName = "Pietrusiak",
                Email = "adasdad@wp.pl",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(year: 2000, month: 12, day: 3)
            }
        }
    };

    private static int _currentId = 3;
    
    // Lista kontaktów
    public IActionResult Index()
    {
        return View(_contacts);
    }
    
    //zwraca formularz dodania kontaktow
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    //odebranie danych z formularza zapisa kontakty i powrot do listy kontaktow
    [HttpPost]
    public IActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        model.Id = ++_currentId;
        _contacts.Add(model.Id, model);
        return View("Index", _contacts);
    }

    public IActionResult Delete(int id)
    {
        _contacts.Remove(id);
        return View("Index", _contacts);
    }

    public IActionResult Details(int id)
    {
        return View(_contacts[id]);
    }
}