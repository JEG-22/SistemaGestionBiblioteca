using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace SistemaGestionBiblioteca;

public partial class MainForm : Form
{
    string connectionString = "Data Source=Databases/library_books.db";
    public MainForm()
    {
        // AddBook(new Book("The Invisible Man", "H.G. Wells", "Science Fiction", 1897, true));
        // RemoveBook(new Book(9));
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    public void AddBook(Book book)
    {
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                INSERT INTO Books (ISBN, Title, Author, Publisher, Genre, YearPublished, Copies)
                VALUES ($isbn, $title, $author, $publisher, $genre, $yearPublished, $copies)
            ";
            command.Parameters.AddWithValue("$isbn", book.ISBN);
            command.Parameters.AddWithValue("$title", book.title);
            command.Parameters.AddWithValue("$author", book.author);
            command.Parameters.AddWithValue("$publisher", book.publisher);
            command.Parameters.AddWithValue("$genre", book.genre);
            command.Parameters.AddWithValue("$yearPublished", book.yearPublished);
            command.Parameters.AddWithValue("$copies", book.Copies);

            command.ExecuteNonQuery();

            MessageBox.Show($"Se agrego el libro '{book.title}'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    public void RemoveBook(Book book)
    {
        if (book.ISBN == null)
        {
            MessageBox.Show($"Book not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = 
            @"
                DELETE FROM Books 
                WHERE ISBN = $isbn
            ";

            command.Parameters.AddWithValue("$isbn", book.ISBN);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show($"El libro: {book.title} se elimino exitosamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

    // Event handler for the Add Book button
    private void btnAgregar_Click(object sender, EventArgs e)
    {
        // Retrieve input data from TextBox controls
        string isbn = txtISBN.Text;
        string title = txtTitle.Text;
        string author = txtAuthor.Text;
        string publisher = txtPublisher.Text;
        string genre = txtGenre.Text;
        int copies = int.TryParse(txtCopies.Text, out int copiesResult) ? copiesResult : 0;
        int yearPublished = int.TryParse(txtYearPublished.Text, out int yearResult) ? yearResult : 0;
        // Validate that all fields are filled
        if ((string.IsNullOrEmpty(isbn) || isbn.Length != 10) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(genre) || yearPublished == 0)
        {
            MessageBox.Show("Porfavor complete los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Create a new Book object with the provided data
        var newBook = new Book(isbn, title, author, publisher, genre, yearPublished, copies);

        // Call the AddBook method to add the book to the database
        AddBook(newBook);

        // Optionally, clear input fields after adding
        ClearInputFields();
    }

    // Event handler for the Remove Book button
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        // Retrieve the Book ID from the TextBox control
        string isbn = txtISBN.Text;

        // Validate the Book ID
        if (isbn.Length != 10)
        {
            MessageBox.Show("Porfavor ingrese un codigo ISBN-10 valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Create a new Book object with the provided ISBN code
        var bookToRemove = new Book(isbn);

        // Call the RemoveBook method to delete the book from the database
        RemoveBook(bookToRemove);

        // Optionally, clear input fields after removing
        txtISBN.Clear();
    }

    // Method to clear input fields
    private void ClearInputFields()
    {
        txtISBN.Clear();
        txtTitle.Clear();
        txtAuthor.Clear();
        txtPublisher.Clear();
        txtYearPublished.Clear();
        txtGenre.Clear();
        txtCopies.Clear();
        LoadData();
    }
    public void LoadData()
    {
         using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Books";

            var dataTable = new DataTable();
            
            using (var reader = command.ExecuteReader())
            {
                dataTable.Load(reader);
            }
            
            dgvBooks.DataSource = dataTable;
        }
    }

    public void UpdateCell(object sender, DataGridViewCellEventArgs e)
    {
        if(dgvBooks.DataSource != null)
        {
            var changedVal = dgvBooks.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            
            string columnName = dgvBooks.Columns[e.ColumnIndex].HeaderText;
            string? rowId = dgvBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"UPDATE Books SET {columnName} = @value WHERE ISBN = @isbn";
                command.Parameters.AddWithValue("@value", changedVal);
                command.Parameters.AddWithValue("@isbn", rowId);

                command.ExecuteNonQuery();
            }
        }
    }


}
