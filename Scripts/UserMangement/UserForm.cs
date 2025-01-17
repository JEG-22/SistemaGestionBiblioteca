using System;
using System.Data;
using Microsoft.Data.Sqlite;

namespace SistemaGestionBiblioteca;

public partial class UserForm : Form
{
    private string connectionString = @"Data Source=Databases/database.db";
    public UserForm()
    {
        InitializeComponent();
    }


    private void UserForm_Load(object sender, EventArgs e)
    {
        //Carga la Data en el Data Grid View cuando termine de Cargar el Form
        LoadData();
    }

    /// <summary>
    /// Guarda la informacion del nuevo usuario a la base de datos
    /// </summary>
    private void btnSave_Click(object sender, EventArgs e)
    {
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string email = txtEmail.Text;
        string phone = txtPhone.Text;

        bool badinput = false;

        if((string.IsNullOrEmpty(firstName) || firstName.Any(char.IsDigit)) || (string.IsNullOrEmpty(lastName) || lastName.Any(char.IsDigit)))
        {
            MessageBox.Show("Porfavor complete los campos correctamente. Los nombres no pueden llevar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            badinput = true;
        }
        if(string.IsNullOrEmpty(email))
        {
            MessageBox.Show("Porfavor complete los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            badinput = true;
        }
        if(string.IsNullOrEmpty(phone) || (!long.TryParse(phone, out long ignoreMe)) || (phone.Length < 10))
        {
            MessageBox.Show("Porfavor complete los campos correctamente. Solo 10 numeros en el Telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            badinput = true;
        }

        if (badinput) return;


        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText =
            @"
                INSERT INTO Users (Nombre, Apellido, Email, Telefono)
                Values ($name, $lasName, $email, $phone)
            ";

            command.Parameters.AddWithValue("$name", firstName);
            command.Parameters.AddWithValue("$lasName", lastName);
            command.Parameters.AddWithValue("$email", email);
            command.Parameters.AddWithValue("$phone", phone);

            command.ExecuteNonQuery();

            MessageBox.Show($"Se agrego el usuario '{firstName} {lastName}'!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearInputFields();
        }
    }

    
    private void btnCancel_Click(object sender, EventArgs e)
    {
        //Limpia los campos 
        ClearInputFields();
    }

    /// <summary>
    /// Limpia los campos 
    /// </summary>
    private void ClearInputFields()
    {
        txtUserID.Clear();
        txtFirstName.Clear();
        txtLastName.Clear();
        txtEmail.Clear();
        txtPhone.Clear();
        LoadData();
    }

    /// <summary>
    /// Carga la Data de los usuarios en el Data Grid View
    /// </summary>
    public void LoadData()
    {
         using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM users";

            var dataTable = new DataTable();
            
            using (var reader = command.ExecuteReader())
            {
                dataTable.Load(reader);
            }
            
            dgvUsers.DataSource = dataTable;
        }
    }

    /// <summary>
    /// Permite que el usuario edite la informacion que ya esta en la base de Datos
    /// </summary>
    public void UpdateCell(object sender, DataGridViewCellEventArgs e)
    {
        if(dgvUsers.DataSource != null)
        {
            var changedVal = dgvUsers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            
            string columnName = dgvUsers.Columns[e.ColumnIndex].HeaderText;
            string? rowId = dgvUsers.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = $"UPDATE Users SET {columnName} = @value WHERE ID = @id";
                command.Parameters.AddWithValue("@value", changedVal);
                command.Parameters.AddWithValue("@id", rowId);

                command.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// Elimina a un usario con us ID
    /// </summary>
    public void btnDeleteByID_Click(object sender, EventArgs e)
    {
        int userID = int.TryParse(txtUserID.Text, out int result) ? result : -1;
        if (userID < 0)
        {
            MessageBox.Show($"USER ID Incorrecto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        using (var connection = new SqliteConnection(connectionString))
        {
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = 
            @"
                DELETE FROM Users 
                WHERE ID = $id
            ";

            command.Parameters.AddWithValue("$id", userID);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show($"El Usuario #{userID} se elimino exitosamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        ClearInputFields();       
    }
}
