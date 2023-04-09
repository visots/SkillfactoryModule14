namespace Task14_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
               new Contact() { Name = "Андрей", Phone = 7999945005 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
            };

            while (true)
            {
                var keychar = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (keychar)
                {
                    case '1':
                        ShowPage(contacts.Take(2).ToList());
                        break;
                    case '2':
                        ShowPage(contacts.Skip(2).Take(2).ToList());
                        break;
                    case '3':
                        ShowPage(contacts.Skip(4).Take(2).ToList());
                        break;

                }
            }


        }

        static void ShowPage(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Name + " " + contact.Phone);
            }
        }
    }
}