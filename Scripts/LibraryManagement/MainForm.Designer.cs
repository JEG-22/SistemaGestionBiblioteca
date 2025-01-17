namespace SistemaGestionBiblioteca
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Controls
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtISBN;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtPublisher;
        private TextBox txtGenre;
        private TextBox txtCopies;
        private TextBox txtYearPublished;
        private Label lblISBN;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblPublisher;
        private Label lblGenre;
        private Label lblCopies;
        private Label lblYearPublished;
        private Label lblFormTitle;
        private DataGridView dgvBooks;

        // Form initialization
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new Button();
            this.btnEliminar = new Button();
            this.txtISBN = new TextBox();
            this.txtISBN.MaxLength = 10;
            this.txtTitle = new TextBox();
            this.txtAuthor = new TextBox();
            this.txtPublisher = new TextBox();
            this.txtYearPublished = new TextBox();
            this.txtGenre = new TextBox();
            this.txtCopies = new TextBox();
            this.lblISBN = new Label();
            this.lblTitle = new Label();
            this.lblAuthor = new Label();
            this.lblPublisher = new Label();
            this.lblYearPublished = new Label();
            this.lblGenre = new Label();
            this.lblCopies = new Label();
            this.dgvBooks = new DataGridView();
            this.lblFormTitle = new Label();  // New label for the title
            this.SuspendLayout();

            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFormTitle.AutoSize = true;
            // this.lblFormTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.Location = new System.Drawing.Point(30, 20);  // Positioned at the top
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(280, 22);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "Sistema de Gestión de Libros";

            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(30, 270);  // Moved buttons down
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);

            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(270, 270);  // Moved buttons down
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new EventHandler(this.btnEliminar_Click);

            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(130, 60); // Moved up
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 23);
            this.txtISBN.TabIndex = 3;

            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 90); // Moved up
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.TabIndex = 4;

            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(130, 120); // Moved up
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(200, 23);
            this.txtAuthor.TabIndex = 5;

            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(130, 150); // Moved up
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(200, 23);
            this.txtPublisher.TabIndex = 6;

            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(130, 180); // Moved up
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(100, 23);
            this.txtYearPublished.TabIndex = 7;

            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(130, 210); // Moved up
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(200, 23);
            this.txtGenre.TabIndex = 8;

            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(130, 240); // Moved up
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(100, 23);
            this.txtCopies.TabIndex = 9;

            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(30, 60); // Moved up
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 15);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "ISBN";

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 90); // Moved up
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 15);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Titulo";

            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(30, 120); // Moved up
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(47, 15);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Autor";

            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(30, 150); // Moved up
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(60, 15);
            this.lblPublisher.TabIndex = 13;
            this.lblPublisher.Text = "Editorial";

            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Location = new System.Drawing.Point(30, 180); // Moved up
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(90, 15);
            this.lblYearPublished.TabIndex = 14;
            this.lblYearPublished.Text = "Año Publicación";

            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(30, 210); // Moved up
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(42, 15);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Género";

            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(30, 240); // Moved up
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(48, 15);
            this.lblCopies.TabIndex = 16;
            this.lblCopies.Text = "# de Copias";

            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(30, 300); // Moved up closer
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(740, 200);
            this.dgvBooks.TabIndex = 17;
            this.dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.dgvBooks.ReadOnly = false;
            this.dgvBooks.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateCell);

            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 550); // Form size adjusted to fit
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblYearPublished);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtYearPublished);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblFormTitle);  // Added title label to form
            this.Name = "MainForm";
            this.Text = "Library Management";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Load += new EventHandler(this.MainForm_Load);
        }
    }
}
