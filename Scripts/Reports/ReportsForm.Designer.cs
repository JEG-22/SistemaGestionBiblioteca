namespace SistemaGestionBiblioteca
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnViewAvailableBooks;
        private System.Windows.Forms.CheckBox chkViewBooksByGenre;
        private System.Windows.Forms.Button btnMostReservedBooks;
        private System.Windows.Forms.Button btnMostActiveUsers;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.ComboBox comboBoxGenres;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnViewAvailableBooks = new System.Windows.Forms.Button();
            this.chkViewBooksByGenre = new System.Windows.Forms.CheckBox();
            this.comboBoxGenres = new System.Windows.Forms.ComboBox();
            this.btnMostReservedBooks = new System.Windows.Forms.Button();
            this.btnMostActiveUsers = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consultas y Reportes";

            // Dynamically center the title based on form width
            this.lblTitle.Location = new System.Drawing.Point(
                (this.ClientSize.Width - this.lblTitle.Width) / 2, // Centering on the X-axis
                20); // Keep the Y position at 20

            // 
            // btnViewAvailableBooks
            // 
            this.btnViewAvailableBooks.Location = new System.Drawing.Point(20, 70);
            this.btnViewAvailableBooks.Name = "btnViewAvailableBooks";
            this.btnViewAvailableBooks.Size = new System.Drawing.Size(180, 40);
            this.btnViewAvailableBooks.TabIndex = 1;
            this.btnViewAvailableBooks.Text = "Ver Libros Disponibles";
            this.btnViewAvailableBooks.UseVisualStyleBackColor = true;
            this.btnViewAvailableBooks.Click += new System.EventHandler(this.btnViewAvailableBooks_Click);

            // 
            // chkViewBooksByGenre
            // 
            this.chkViewBooksByGenre.Location = new System.Drawing.Point(20, 120);
            this.chkViewBooksByGenre.Name = "chkViewBooksByGenre";
            this.chkViewBooksByGenre.Size = new System.Drawing.Size(180, 40);
            this.chkViewBooksByGenre.TabIndex = 2;
            this.chkViewBooksByGenre.Text = "Ver Libros por Género";
            this.chkViewBooksByGenre.UseVisualStyleBackColor = true;
            this.chkViewBooksByGenre.CheckedChanged += new System.EventHandler(this.chkViewBooksByGenre_CheckedChanged);

            // 
            // comboBoxGenres
            // 
            this.comboBoxGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenres.FormattingEnabled = true;
            this.comboBoxGenres.Location = new System.Drawing.Point(30, 160);
            this.comboBoxGenres.Name = "comboBoxGenres";
            this.comboBoxGenres.Size = new System.Drawing.Size(160, 23);
            this.comboBoxGenres.TabIndex = 1;
            this.comboBoxGenres.Enabled = false;
            this.comboBoxGenres.SelectedIndexChanged += new EventHandler(this.btnViewBooksByGenre_Click);

            // 
            // btnMostReservedBooks
            // 
            this.btnMostReservedBooks.Location = new System.Drawing.Point(20, 190);
            this.btnMostReservedBooks.Name = "btnMostReservedBooks";
            this.btnMostReservedBooks.Size = new System.Drawing.Size(180, 40);
            this.btnMostReservedBooks.TabIndex = 3;
            this.btnMostReservedBooks.Text = "Libros Más Reservados";
            this.btnMostReservedBooks.UseVisualStyleBackColor = true;
            this.btnMostReservedBooks.Click += new System.EventHandler(this.btnMostReservedBooks_Click);

            // 
            // btnMostActiveUsers
            // 
            this.btnMostActiveUsers.Location = new System.Drawing.Point(20, 240);
            this.btnMostActiveUsers.Name = "btnMostActiveUsers";
            this.btnMostActiveUsers.Size = new System.Drawing.Size(180, 40);
            this.btnMostActiveUsers.TabIndex = 4;
            this.btnMostActiveUsers.Text = "Usuarios Más Activos";
            this.btnMostActiveUsers.UseVisualStyleBackColor = true;
            this.btnMostActiveUsers.Click += new System.EventHandler(this.btnMostActiveUsers_Click);

            // 
            // dgvReports
            // 
            this.dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.Location = new System.Drawing.Point(220, 70);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(540, 200);
            this.dgvReports.TabIndex = 5;
            this.dgvReports.ReadOnly = true;
            this.dgvReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            // 
            // ReportsForm
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnMostActiveUsers);
            this.Controls.Add(this.btnMostReservedBooks);
            this.Controls.Add(this.chkViewBooksByGenre);
            this.Controls.Add(this.comboBoxGenres);
            this.Controls.Add(this.btnViewAvailableBooks);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportsForm";
            this.Text = "Consultas y Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new System.EventHandler(this.ReportsForm_Load);
        }
    }
}
