namespace task2
{
    internal class PhoneBook
    {
        public Dictionary<int, string> Contacts { get; set; }
        public PhoneBook()
        {
            Contacts = new Dictionary<int, string>();
        }
        public void AddContact(int num, string contact)
        {
            Contacts.Add(num, contact);
        }
        public void RemoveContact(int num)
        {
            Contacts.Remove(num);
        }
        public void GetAllContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine($"{contact.Key} {contact.Value}");
            }
        }
        public void FindContact(int num)
        {
            foreach(var contact in Contacts)
            {
                if (contact.Key == num)
                {
                    Console.WriteLine($"{contact.Key} {contact.Value}");
                }
            }
        }
    }
}
