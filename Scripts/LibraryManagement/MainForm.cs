using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace SistemaGestionBiblioteca;

public partial class MainForm : Form
{
    string connectionString = "Data Source=Databases/database.db";
    public MainForm()
    {
        InitializeComponent();
    }

    /// <summary>Invoca los siguintes metodos despues de que termina de cargar el Form. </summary>
    private void MainForm_Load(object sender, EventArgs e)
    {
        LoadData();
    }

    /// <summary>
    /// Agrega un Libro a la base de Datos.
    /// </summary>
    /// <param name="book"></param>
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

            try{
                command.ExecuteNonQuery();
                
                MessageBox.Show($"Se agrego el libro '{book.title}'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch (SqliteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("Este codiogo ISBN ya esta en uso. Porvafor indique el codigo ISBN correcto.", "ISBN Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    throw; // Rethrow other exceptions
                }
            }

            
        }
    }

    /// <summary>
    /// Elimina un Libro de la base de Datos.
    /// </summary>
    /// <param name="book"></param>
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

    /// <summary>
    /// Cuando Se presiona el botton, se crea una nueva instancia de la clase Book con la informacion ingresada por el usuario, Luego se utiliza el metodo <seealso cref="AddBook"/>.
    /// </summary>
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

        if ((string.IsNullOrEmpty(isbn) || isbn.Length != 10) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(publisher) || string.IsNullOrEmpty(genre) || yearPublished == 0)
        {
            MessageBox.Show("Porfavor complete los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var newBook = new Book(isbn, title, author, publisher, genre, yearPublished, copies);

        AddBook(newBook);

        ClearInputFields();
    }

    /// <summary>
    /// Elimina el Libro de la base de Datos con tan solo el ISBN code, esto es posible gracias al constructor de la clase Book.
    /// </summary>
    private void btnEliminar_Click(object sender, EventArgs e)
    {
        string isbn = txtISBN.Text;

        if (isbn.Length != 10)
        {
            MessageBox.Show("Porfavor ingrese un codigo ISBN-10 valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var bookToRemove = new Book(isbn);

        RemoveBook(bookToRemove);

        ClearInputFields();
    }

    /// <summary>
    /// Limpia los controles para poder ingresar otro libro
    /// </summary>
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

    /// <summary>
    /// Carga los Libro en el Data Grid View
    /// </summary>
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

    /// <summary>
    /// Se activa cuando una celda se modifica dentro del Data Grid View para permitir que el usuario edite la informacion en la base de datos
    /// </summary>
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
