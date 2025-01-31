namespace SistemaGestionBiblioteca
{
    partial class BookRentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.ComboBox cbBooks;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTitle;

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
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.cbBooks = new System.Windows.Forms.ComboBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.MaximumSize = new System.Drawing.Size(this.ClientSize.Width + 100, 110);
            this.lblTitle.AutoSize = true;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Gestión de Reservas";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // dgvRentals
            // 
            this.dgvRentals.Location = new System.Drawing.Point(20, 200);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.Size = new System.Drawing.Size(600, 200);
            this.dgvRentals.TabIndex = 0;
            this.dgvRentals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            // 
            // cbUsers
            // 
            this.cbUsers.Location = new System.Drawing.Point(120, 70);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.Size = new System.Drawing.Size(400, 23);
            this.cbUsers.TabIndex = 1;

            // 
            // cbBooks
            // 
            this.cbBooks.Location = new System.Drawing.Point(120, 100); 
            this.cbBooks.Name = "cbBooks";
            this.cbBooks.Size = new System.Drawing.Size(400, 23);
            this.cbBooks.TabIndex = 2;

            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Location = new System.Drawing.Point(120, 130); 
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(400, 23);
            this.dtpRentDate.TabIndex = 3;

            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(120, 160); 
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(400, 23);
            this.dtpReturnDate.TabIndex = 4;

            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 70); 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 15);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "Usuario";

            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Location = new System.Drawing.Point(20, 100); 
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(36, 15);
            this.lblBook.TabIndex = 6;
            this.lblBook.Text = "Libro";

            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Location = new System.Drawing.Point(20, 130); 
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(76, 15);
            this.lblRentDate.TabIndex = 7;
            this.lblRentDate.Text = "Fecha Alquiler";

            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(20, 160); 
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(79, 15);
            this.lblReturnDate.TabIndex = 8;
            this.lblReturnDate.Text = "Fecha Retorno";

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(530, 70); 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(530, 100); 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // BookRentForm
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpRentDate);
            this.Controls.Add(this.cbBooks);
            this.Controls.Add(this.cbUsers);
            this.Name = "BookRentForm";
            this.Text = "Gestión de Reservas y Préstamos";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new EventHandler(BookRentForm_Load);
        }
    }
}
