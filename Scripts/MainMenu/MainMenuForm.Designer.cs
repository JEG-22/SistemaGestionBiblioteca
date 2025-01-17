namespace SistemaGestionBiblioteca
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBooksModule;
        private System.Windows.Forms.Button btnUsersModule;
        private System.Windows.Forms.Button btnReservationsModule;
        private System.Windows.Forms.Button btnReportsModule;
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
            this.btnBooksModule = new System.Windows.Forms.Button();
            this.btnUsersModule = new System.Windows.Forms.Button();
            this.btnReservationsModule = new System.Windows.Forms.Button();
            this.btnReportsModule = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sistema de Gestión Bibliotecaria";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnBooksModule
            // 
            this.btnBooksModule.Location = new System.Drawing.Point(50, 80);
            this.btnBooksModule.Name = "btnBooksModule";
            this.btnBooksModule.Size = new System.Drawing.Size(200, 40);
            this.btnBooksModule.TabIndex = 1;
            this.btnBooksModule.Text = "Módulo de Libros";
            this.btnBooksModule.UseVisualStyleBackColor = true;
            this.btnBooksModule.Click += new System.EventHandler(this.btnBooksModule_Click);

            // 
            // btnUsersModule
            // 
            this.btnUsersModule.Location = new System.Drawing.Point(300, 80);
            this.btnUsersModule.Name = "btnUsersModule";
            this.btnUsersModule.Size = new System.Drawing.Size(200, 40);
            this.btnUsersModule.TabIndex = 2;
            this.btnUsersModule.Text = "Módulo de Usuarios";
            this.btnUsersModule.UseVisualStyleBackColor = true;
            this.btnUsersModule.Click += new System.EventHandler(this.btnUsersModule_Click);

            // 
            // btnReservationsModule
            // 
            this.btnReservationsModule.Location = new System.Drawing.Point(50, 140);
            this.btnReservationsModule.Name = "btnReservationsModule";
            this.btnReservationsModule.Size = new System.Drawing.Size(200, 40);
            this.btnReservationsModule.TabIndex = 3;
            this.btnReservationsModule.Text = "Módulo de Reservas";
            this.btnReservationsModule.UseVisualStyleBackColor = true;
            this.btnReservationsModule.Click += new System.EventHandler(this.btnReservationsModule_Click);

            // 
            // btnReportsModule
            // 
            this.btnReportsModule.Location = new System.Drawing.Point(300, 140);
            this.btnReportsModule.Name = "btnReportsModule";
            this.btnReportsModule.Size = new System.Drawing.Size(200, 40);
            this.btnReportsModule.TabIndex = 4;
            this.btnReportsModule.Text = "Consultas y Reportes";
            this.btnReportsModule.UseVisualStyleBackColor = true;
            this.btnReportsModule.Click += new System.EventHandler(this.btnReportsModule_Click);

            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 261);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBooksModule);
            this.Controls.Add(this.btnUsersModule);
            this.Controls.Add(this.btnReservationsModule);
            this.Controls.Add(this.btnReportsModule);
            this.Name = "MainMenuForm";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
