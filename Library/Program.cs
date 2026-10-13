using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "BillGates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));


// Create new instances of the Member class
// These new members are created using the
// Member constructor in the Members class

//display the list of books
foreach (Book book in books)
{
    Console.WriteLine($"Book title: {book.Title}");
    Console.WriteLine($"Book author: {book.Author}");
    Console.WriteLine($"Book ISBN: {book.ISBN}");
}

//display the list of members
foreach (Member member in members)
{
    Console.WriteLine($"Member name: {member.Name}");
    Console.WriteLine($"Member address: {member.Address}");
    Console.WriteLine($"Member phone number: {member.Phone}");
}

