using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.Sqlite;


namespace SistemaGestionBiblioteca
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            PopulateGenres();
        }

        // Method to show available books
        private void btnViewAvailableBooks_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection("Data Source=Databases/library_books.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT *
                    FROM Books
                    WHERE Copies > 0
                ";

                var dataTable = new DataTable();
            
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                
                dgvReports.DataSource = dataTable;
            }
        }

        // Method to show books by genre
        private void btnViewBooksByGenre_Click(object sender, EventArgs e)
        {
            if (comboBoxGenres.SelectedItem == null)
            {
                MessageBox.Show("Please select a genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SqliteConnection("Data Source=Databases/library_books.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =@"SELECT * FROM Books WHERE Genre = $genre";
                command.Parameters.AddWithValue("$genre", comboBoxGenres.SelectedItem);

                var dataTable = new DataTable();
            
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                
                dgvReports.DataSource = dataTable;
            }
        }

        private void PopulateGenres()
        {
            using (var connection = new SqliteConnection("Data Source=Databases/library_books.db"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT DISTINCT Genre FROM Books";
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        comboBoxGenres.Items.Add(reader["Genre"].ToString());
                    }
                }

            }
            if (comboBoxGenres.Items.Count > 0)
                comboBoxGenres.SelectedIndex = 0; // Set default selection
        }

        // Method to show most reserved books
        private void btnMostReservedBooks_Click(object sender, EventArgs e)
        {
            // Logic to display most reserved books in the DataGridView
            var mockData = new[] {
                new { ISBN = "13579", Title = "Most Reserved Book 1", Author = "Author 5", Year = 2021, Genre = "Fiction", Copies = 10 },
                new { ISBN = "24680", Title = "Most Reserved Book 2", Author = "Author 6", Year = 2018, Genre = "Non-Fiction", Copies = 7 }
            };

            dgvReports.DataSource = mockData;
        }

        // Method to show most active users
        private void btnMostActiveUsers_Click(object sender, EventArgs e)
        {
            // Logic to display most active users in the DataGridView
            var mockData = new[] {
                new { UserID = 1, Name = "User 1", ReservedBooks = 5 },
                new { UserID = 2, Name = "User 2", ReservedBooks = 3 }
            };

            dgvReports.DataSource = mockData;
        }
    }
}
