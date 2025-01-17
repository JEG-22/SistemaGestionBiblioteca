using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.Sqlite;


namespace SistemaGestionBiblioteca
{
    public partial class ReportsForm : Form
    {
        private string connectionString = @"Data Source=Databases/database.db";
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            PopulateGenres();
        }

        private void btnViewAvailableBooks_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"  SELECT * FROM Books b
                    WHERE b.Copies > COALESCE((
                        SELECT COUNT(*)
                        FROM BookRentals br
                        WHERE br.BookISBN = b.ISBN
                        GROUP BY br.BookISBN
                    ), 0)";

                if (chkViewBooksByGenre.Checked)
                {
                    command.CommandText += "AND Genre = $genre";
                    command.Parameters.AddWithValue("$genre", comboBoxGenres.SelectedItem);
                }

                var dataTable = new DataTable();
            
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                
                dgvReports.DataSource = dataTable;
            }
        }

        private void chkViewBooksByGenre_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxGenres.Enabled = chkViewBooksByGenre.Checked;
        }

        private void btnViewBooksByGenre_Click(object sender, EventArgs e)
        {
            if (comboBoxGenres.SelectedItem == null)
            {
                MessageBox.Show("Please select a genre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
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
            using (var connection = new SqliteConnection(connectionString))
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

        private void btnMostReservedBooks_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT r.Repetitions, b.Title, b.Author, b.ISBN
                    FROM (
                        SELECT COUNT(*) AS Repetitions, BookISBN
                        FROM BookRentals 
                        GROUP BY BookISBN
                    ) r
                    INNER JOIN Books b ON b.ISBN=r.BookISBN
                    ORDER BY r.Repetitions DESC
                ";

                var dataTable = new DataTable();
            
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                
                dgvReports.DataSource = dataTable;
            }
        }

        private void btnMostActiveUsers_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @"
                    SELECT r.Repeticiones, u.Nombre, u.Apellido, u.ID
                    FROM (
                        SELECT COUNT(*) AS Repeticiones, UserID
                        FROM BookRentals
                        GROUP BY UserID
                    ) r
                    INNER JOIN Users u ON r.UserID=u.ID
                    ORDER BY r.Repeticiones DESC
                ";

                var dataTable = new DataTable();
            
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                
                dgvReports.DataSource = dataTable;
            }
        }
    }
}
