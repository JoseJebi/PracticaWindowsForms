namespace PracticaWForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpgDatosPers = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbDirecc = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.rbtHombre = new System.Windows.Forms.RadioButton();
            this.rbtMujer = new System.Windows.Forms.RadioButton();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.clnfechaNac = new System.Windows.Forms.MonthCalendar();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDirecc = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpgDatosPers.SuspendLayout();
            this.gbxGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(738, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseHover += new System.EventHandler(this.btnCerrar_MouseHover);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Haettenschweiler", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(185, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(418, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestión avanzada de información personal";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpgDatosPers);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(27, 73);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(747, 280);
            this.tabControl.TabIndex = 2;
            // 
            // tpgDatosPers
            // 
            this.tpgDatosPers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tpgDatosPers.Controls.Add(this.lblEdad);
            this.tpgDatosPers.Controls.Add(this.lblFechaNac);
            this.tpgDatosPers.Controls.Add(this.lblEmail);
            this.tpgDatosPers.Controls.Add(this.lblDirecc);
            this.tpgDatosPers.Controls.Add(this.lblNombre);
            this.tpgDatosPers.Controls.Add(this.nudEdad);
            this.tpgDatosPers.Controls.Add(this.clnfechaNac);
            this.tpgDatosPers.Controls.Add(this.gbxGender);
            this.tpgDatosPers.Controls.Add(this.txbEmail);
            this.tpgDatosPers.Controls.Add(this.txbDirecc);
            this.tpgDatosPers.Controls.Add(this.txbNombre);
            this.tpgDatosPers.Location = new System.Drawing.Point(4, 22);
            this.tpgDatosPers.Name = "tpgDatosPers";
            this.tpgDatosPers.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDatosPers.Size = new System.Drawing.Size(739, 254);
            this.tpgDatosPers.TabIndex = 0;
            this.tpgDatosPers.Text = "Datos personales";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(80, 24);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(198, 20);
            this.txbNombre.TabIndex = 0;
            // 
            // txbDirecc
            // 
            this.txbDirecc.Location = new System.Drawing.Point(80, 61);
            this.txbDirecc.Name = "txbDirecc";
            this.txbDirecc.Size = new System.Drawing.Size(198, 20);
            this.txbDirecc.TabIndex = 1;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(80, 100);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(198, 20);
            this.txbEmail.TabIndex = 2;
            // 
            // rbtHombre
            // 
            this.rbtHombre.AutoSize = true;
            this.rbtHombre.Location = new System.Drawing.Point(6, 19);
            this.rbtHombre.Name = "rbtHombre";
            this.rbtHombre.Size = new System.Drawing.Size(62, 17);
            this.rbtHombre.TabIndex = 0;
            this.rbtHombre.TabStop = true;
            this.rbtHombre.Text = "Hombre";
            this.rbtHombre.UseVisualStyleBackColor = true;
            // 
            // rbtMujer
            // 
            this.rbtMujer.AutoSize = true;
            this.rbtMujer.Location = new System.Drawing.Point(6, 42);
            this.rbtMujer.Name = "rbtMujer";
            this.rbtMujer.Size = new System.Drawing.Size(51, 17);
            this.rbtMujer.TabIndex = 1;
            this.rbtMujer.TabStop = true;
            this.rbtMujer.Text = "Mujer";
            this.rbtMujer.UseVisualStyleBackColor = true;
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(6, 65);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // gbxGender
            // 
            this.gbxGender.Controls.Add(this.rbtHombre);
            this.gbxGender.Controls.Add(this.rbtOtro);
            this.gbxGender.Controls.Add(this.rbtMujer);
            this.gbxGender.Location = new System.Drawing.Point(28, 137);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(102, 100);
            this.gbxGender.TabIndex = 3;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "Género";
            // 
            // clnfechaNac
            // 
            this.clnfechaNac.BackColor = System.Drawing.SystemColors.Window;
            this.clnfechaNac.Location = new System.Drawing.Point(380, 57);
            this.clnfechaNac.MaxSelectionCount = 1;
            this.clnfechaNac.Name = "clnfechaNac";
            this.clnfechaNac.TabIndex = 4;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(664, 137);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(50, 20);
            this.nudEdad.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDirecc
            // 
            this.lblDirecc.AutoSize = true;
            this.lblDirecc.Location = new System.Drawing.Point(7, 68);
            this.lblDirecc.Name = "lblDirecc";
            this.lblDirecc.Size = new System.Drawing.Size(52, 13);
            this.lblDirecc.TabIndex = 7;
            this.lblDirecc.Text = "Dirección";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 107);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(423, 27);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(106, 13);
            this.lblFechaNac.TabIndex = 9;
            this.lblFechaNac.Text = "Fecha de nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(606, 143);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl.ResumeLayout(false);
            this.tpgDatosPers.ResumeLayout(false);
            this.tpgDatosPers.PerformLayout();
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpgDatosPers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbDirecc;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtMujer;
        private System.Windows.Forms.RadioButton rbtHombre;
        private System.Windows.Forms.MonthCalendar clnfechaNac;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDirecc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechaNac;
    }
}