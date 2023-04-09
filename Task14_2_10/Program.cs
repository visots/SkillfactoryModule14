namespace Task14_2_10
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            while (true)
            {
                var keyChar = Console.ReadKey().KeyChar;
                Console.Clear();


                if (!Char.IsDigit(keyChar))
                {
                    Console.WriteLine("Ошибка ввода, введите число");
                }
                else
                {
                    IEnumerable<Contact> page = null;

                    switch (keyChar)
                    {
                        case ('1'):
                            page = phoneBook.Take(2);
                            break;
                        case ('2'):
                            page = phoneBook.Skip(2).Take(2);
                            break;
                        case ('3'):
                            page = phoneBook.Skip(4).Take(2);
                            break;
                    }

                    if (page == null)
                    {
                        Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
                        continue;
                    }

                    foreach (var contact in page)
                        Console.WriteLine(contact.Name + " " + contact.LastName +" "+ contact.PhoneNumber +" "+contact.Email);
                }
            }

        }
    }
}