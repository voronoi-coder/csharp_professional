IntroTuples();
TuplesDeconstruction();

void IntroTuples()
{
    (string AString, int Number, Book Book) tuple1 = ("magic", 42, new Book("Professional C#", "Wrox Press"));
    Console.WriteLine($"a string: {tuple1.AString}, number: {tuple1.Number}, book: {tuple1.Book}");

    var tuple2 = ("magic", 42, new Book("Professional C#", "Wrox Press"));
    Console.WriteLine($"a string: {tuple2.Item1}, number: {tuple2.Item2}, book: {tuple2.Item3}");
}

void TuplesDeconstruction()
{ 
    var tuple1 = (AString: "magic",
    Number: 42, Book: new Book("Professional C#", "Wrox Press"));
    (string aString, int number, Book book) = tuple1;

    (_, _, var book1) = tuple1;
    Console.WriteLine(book1.Title);
}

public record Book(string Title, string Publisher);
