using System;
using System.Windows.Forms;

namespace SistemaGestionBiblioteca
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void btnBooksModule_Click(object sender, EventArgs e)
        {
            // Abre el formulario del módulo de libros
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void btnUsersModule_Click(object sender, EventArgs e)
        {
            // Abre el formulario del módulo de usuarios
            UserForm userForm = new UserForm();
            userForm.Show();
        }

        private void btnReservationsModule_Click(object sender, EventArgs e)
        {
            // Abre el formulario del módulo de reservas
            // ReservationsForm reservationsForm = new ReservationsForm();
            // reservationsForm.Show();
            return;
        }

        private void btnReportsModule_Click(object sender, EventArgs e)
        {
            // Abre el formulario de consultas y reportes
            // ReportsForm reportsForm = new ReportsForm();
            // reportsForm.Show();
            return;
        }
    }
}