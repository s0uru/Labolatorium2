namespace WebApp.Models.Services;

public class MemoryContactService : IContactService
{
    private static Dictionary<int, ContactModel> _contacts = new()
    {
        {
            1, new ContactModel()
            {
                Category = Category.Business,
                Id = 1,
                FirstName = "Jakub",
                LastName = "kowalczyk",
                Email = "adasdad@wp.pl",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(year: 2000, month: 12, day: 3)
            }
        },
        {
            2, new ContactModel()
            {
                Category = Category.Family,
                Id = 2,
                FirstName = "Mateusz",
                LastName = "kowalski",
                Email = "adasdad@wp.pl",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(year: 2000, month: 12, day: 3)
            }

        },
        {
            3, new ContactModel()
            {
                Category = Category.Friends,
                Id = 3,
                FirstName = "maciek",
                LastName = "kowal",
                Email = "adasdad@wp.pl",
                PhoneNumber = "111 222 333",
                BirthDate = new DateOnly(year: 2000, month: 12, day: 3)
            }
        }
    };

    private static int _currentId = 3;
    
    public void Add(ContactModel model)
    {
        model.Id = ++_currentId;
        _contacts.Add(model.Id, model);
    }

    public void Update(ContactModel contact)
    {
        if (_contacts.ContainsKey(contact.Id))
        {
            _contacts[contact.Id] = contact;
        }
    }

    public void Delete(int id)
    {
        _contacts.Remove(id);
    }

    public List<ContactModel> GetAll()
    {
        return _contacts.Values.ToList();
    }

    public ContactModel GetById(int id)
    {
        return _contacts[id];
    }
}