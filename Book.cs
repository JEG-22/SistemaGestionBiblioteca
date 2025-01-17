using Microsoft.Data.Sqlite;


namespace SistemaGestionBiblioteca;

public class Book
{
    public Book(string isbn, string title, string author, string publisher, string genre, int yearPublished, int copies)
    {
        // make new book
        this.ISBN = isbn;
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.genre = genre;
        this.yearPublished = yearPublished;
        this.Copies = copies;
    }

    public Book(string ISBN)
    {
        //get book from ISBN
        using (var connection = new SqliteConnection("Data Source=Databases/library_books.db"))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                SELECT ISBN, Title, Author, Publisher, Genre, YearPublished, Copies
                FROM Books
                WHERE ISBN = $isbn
            ";

            command.Parameters.AddWithValue("$isbn", ISBN);
            
            using (var reader = command.ExecuteReader())
            {
                if(reader.Read())
                {
                    this.ISBN = reader.GetString(0);
                    this.title = reader.GetString(1);
                    this.author = reader.GetString(2);
                    this.publisher = reader.GetString(3);
                    this.genre = reader.GetString(4);
                    this.yearPublished = reader.GetInt32(5);
                    this.Copies = reader.GetInt32(6);
                }
            }
        }
    }

    public string? title, author, publisher, genre;
    public int yearPublished;

    private string? _isbn;
    public string? ISBN
    {
        get {return _isbn;}
        private set {_isbn = value;}
    }

    private int _copies;
    public int Copies
    {
        get {return _copies;}
        private set {_copies = value;}
    }
}