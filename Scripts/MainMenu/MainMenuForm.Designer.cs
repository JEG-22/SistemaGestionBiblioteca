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
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBoxUserInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStudentID;

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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();   
            this.groupBoxUserInfo = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
         
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
            this.lblTitle.Text = "Sistema de Gestión\nBibliotecario";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnBooksModule
            // 
            this.btnBooksModule.Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, 110);
            this.btnBooksModule.Name = "btnBooksModule";
            this.btnBooksModule.Size = new System.Drawing.Size(200, 50);
            this.btnBooksModule.TabIndex = 1;
            this.btnBooksModule.Text = "📚 Módulo de Libros";
            this.btnBooksModule.UseVisualStyleBackColor = true;
            this.btnBooksModule.Click += new System.EventHandler(this.btnBooksModule_Click);

            // 
            // btnUsersModule
            // 
            this.btnUsersModule.Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, 170);
            this.btnUsersModule.Name = "btnUsersModule";
            this.btnUsersModule.Size = new System.Drawing.Size(200, 50);
            this.btnUsersModule.TabIndex = 2;
            this.btnUsersModule.Text = "👤 Módulo de Usuarios";
            this.btnUsersModule.UseVisualStyleBackColor = true;
            this.btnUsersModule.Click += new System.EventHandler(this.btnUsersModule_Click);

            // 
            // btnReservationsModule
            // 
            this.btnReservationsModule.Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, 230);
            this.btnReservationsModule.Name = "btnReservationsModule";
            this.btnReservationsModule.Size = new System.Drawing.Size(200, 50);
            this.btnReservationsModule.TabIndex = 3;
            this.btnReservationsModule.Text = "📝 Módulo de Reservas";
            this.btnReservationsModule.UseVisualStyleBackColor = true;
            this.btnReservationsModule.Click += new System.EventHandler(this.btnReservationsModule_Click);

            // 
            // btnReportsModule
            // 
            this.btnReportsModule.Location = new System.Drawing.Point((this.ClientSize.Width - 200) / 2, 290);
            this.btnReportsModule.Name = "btnReportsModule";
            this.btnReportsModule.Size = new System.Drawing.Size(200, 50);
            this.btnReportsModule.TabIndex = 4;
            this.btnReportsModule.Text = "📊 Consultas y Reportes";
            this.btnReportsModule.UseVisualStyleBackColor = true;
            this.btnReportsModule.Click += new System.EventHandler(this.btnReportsModule_Click);

            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(300, 80);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Image = System.Drawing.Image.FromFile(@"Scripts\MainMenu\stack-of-books.png");

            // 
            // groupBoxUserInfo
            // 
            this.groupBoxUserInfo.Controls.Add(this.lblName);
            this.groupBoxUserInfo.Controls.Add(this.lblStudentID);
            this.groupBoxUserInfo.Location = new System.Drawing.Point(300, 0);
            this.groupBoxUserInfo.Name = "groupBoxUserInfo";
            this.groupBoxUserInfo.Size = new System.Drawing.Size(250, 80);
            this.groupBoxUserInfo.TabIndex = 6;
            this.groupBoxUserInfo.TabStop = false;
            this.groupBoxUserInfo.Text = "Información del Estudiante";

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre: [Jose Emilio Garcia]";

            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(20, 50);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(160, 15);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "ID de Estudiante: [1127936]";

            // 
            // MainMenuForm
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBooksModule);
            this.Controls.Add(this.btnUsersModule);
            this.Controls.Add(this.btnReservationsModule);
            this.Controls.Add(this.btnReportsModule);
            this.Controls.Add(this.pictureBoxLogo);      
            this.Controls.Add(this.groupBoxUserInfo);      
            this.Name = "MainMenuForm";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
