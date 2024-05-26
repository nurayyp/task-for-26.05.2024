using task2;

public static class Program
{
    public static void Main()
    {
        PhoneBook phoneBook = new PhoneBook();
        phoneBook.AddContact(1, "Aytac");
        phoneBook.AddContact(2, "Nezrin");
        phoneBook.AddContact(3, "Leman");
        phoneBook.GetAllContacts();
        phoneBook.FindContact(2);
        phoneBook.RemoveContact(2);
        phoneBook.GetAllContacts();
    }
}