using System;
using System.Data;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca
{
    public partial class BookRentForm : Form
    {
        private string connectionString = "Data Source=Databases/database.db";
        public BookRentForm()
        {
            InitializeComponent();
        }

        /// <summary>Invoca los siguintes metodos despues de que termina de cargar el Form. </summary>
        private void BookRentForm_Load(object sender, EventArgs e)
        {
            LoadRentalData();
            LoadUserIDs();
            LoadBooks();
        }
        
        ///<summary>Limpia los combo boxes y Refresca el Data grid view. </summary>
        private void ResetFormFields()
        {
            LoadRentalData();
            cbUsers.SelectedItem = null;
            cbBooks.SelectedItem = null;
        }

        ///<summary>Pone el Table BookRental en el Data Grid View </summary>
        private void LoadRentalData()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = @"Select * FROM BookRentals";

                var dataTable = new DataTable();
                using (var reader = command.ExecuteReader())
                {
                    dataTable.Load(reader);
                }
                
                dgvRentals.DataSource = dataTable;
            }
        }

        
        ///<summary>Carga los Usuarios en el Combo Box para que sea mas facil selecionarlos al momento de utilizar la app. </summary>
        private void LoadUserIDs()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT ID, Nombre || ' ' || Apellido AS FullName FROM Users";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbUsers.Items.Add(new { ID = reader["ID"], FullName = reader["FullName"]});
                    }
                }

            }
        }

        ///<summary> Carga los Libros en el Combo Box para que sea mas facil selecionarlos al momento de utilizar la app. </summary>
        private void LoadBooks()
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT ISBN, Title || ' - ' || Author AS FullName FROM Books";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbBooks.Items.Add(new {ISBN=reader["ISBN"], FullName=reader["FullName"]});
                    }
                }

            }
        }

        /// <summary>
        /// Agrega El Alquiler de un libro con la info en los controles del UI.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var user = cbUsers.SelectedItem;
            var book = cbBooks.SelectedItem;
            var rentDate = dtpRentDate.Value;
            var returnDate = dtpReturnDate.Value;

            if (user == null || book == null)
            {
                MessageBox.Show("Seleccione un Usuario y un Libro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = 
                @"
                    INSERT INTO BookRentals (UserID, BookISBN, RentDate, ReturnDate) 
                    VALUES ($userId, $bookISBN, $rentDate, $returnDate)
                ";

                command.Parameters.AddWithValue("$userId", ((dynamic)user).ID);
                command.Parameters.AddWithValue("$bookISBN", ((dynamic)book).ISBN);
                command.Parameters.AddWithValue("$rentDate", returnDate);
                command.Parameters.AddWithValue("$returnDate", returnDate);

                command.ExecuteNonQuery();
                
                MessageBox.Show($"Alquiler exitoso del Libro: {((dynamic)book).FullName} por {((dynamic)user).FullName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ResetFormFields();
            }
        }

        /// <summary>
        /// Elimina un Alquiler que este selecionado en el Grid View.
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0)
            {
                var rentalID = dgvRentals.SelectedRows[0].Cells["RentID"].Value;

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    var command = connection.CreateCommand();
                    command.CommandText = "DELETE FROM BookRentals WHERE RentID = @id";
                    command.Parameters.AddWithValue("@id", rentalID);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Se elimino exitosamente.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetFormFields();
                }
            }
            else
            {
                MessageBox.Show("Selecione una fila en el Grid View para eliminarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
