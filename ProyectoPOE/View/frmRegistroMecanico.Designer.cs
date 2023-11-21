namespace GestorMantenimientosTaller.View
{
    partial class frmRegistroMecanico
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
            lbNombreMecanico = new Label();
            txtNombreMecanico = new TextBox();
            txtApellidoMecanico = new TextBox();
            lbApellidoMecanico = new Label();
            lbCedulaMecanico = new Label();
            txtCedulaMecanico = new TextBox();
            txtTelefonoMecanico = new TextBox();
            lbTelefonoMecanico = new Label();
            txtCorreoMecanico = new TextBox();
            lbCorreoMecanico = new Label();
            btnGuardarMecanico = new Button();
            gBoxContactarMecanico = new GroupBox();
            gBoxIdentificarMecanico = new GroupBox();
            lbIntrucción = new Label();
            gBoxContactarMecanico.SuspendLayout();
            gBoxIdentificarMecanico.SuspendLayout();
            SuspendLayout();
            // 
            // lbNombreMecanico
            // 
            lbNombreMecanico.AutoSize = true;
            lbNombreMecanico.Location = new Point(6, 48);
            lbNombreMecanico.Name = "lbNombreMecanico";
            lbNombreMecanico.Size = new Size(67, 20);
            lbNombreMecanico.TabIndex = 0;
            lbNombreMecanico.Text = "Nombre:";
            // 
            // txtNombreMecanico
            // 
            txtNombreMecanico.Location = new Point(78, 45);
            txtNombreMecanico.Name = "txtNombreMecanico";
            txtNombreMecanico.Size = new Size(218, 27);
            txtNombreMecanico.TabIndex = 1;
            txtNombreMecanico.TextChanged += txtNombreMecanico_TextChanged;
            // 
            // txtApellidoMecanico
            // 
            txtApellidoMecanico.Location = new Point(403, 45);
            txtApellidoMecanico.Name = "txtApellidoMecanico";
            txtApellidoMecanico.Size = new Size(232, 27);
            txtApellidoMecanico.TabIndex = 2;
            txtApellidoMecanico.TextChanged += txtApellidoMecanico_TextChanged;
            // 
            // lbApellidoMecanico
            // 
            lbApellidoMecanico.AutoSize = true;
            lbApellidoMecanico.Location = new Point(324, 48);
            lbApellidoMecanico.Name = "lbApellidoMecanico";
            lbApellidoMecanico.Size = new Size(73, 20);
            lbApellidoMecanico.TabIndex = 3;
            lbApellidoMecanico.Text = "Apelllido:";
            // 
            // lbCedulaMecanico
            // 
            lbCedulaMecanico.AutoSize = true;
            lbCedulaMecanico.Location = new Point(688, 48);
            lbCedulaMecanico.Name = "lbCedulaMecanico";
            lbCedulaMecanico.Size = new Size(58, 20);
            lbCedulaMecanico.TabIndex = 4;
            lbCedulaMecanico.Text = "Cédula:";
            // 
            // txtCedulaMecanico
            // 
            txtCedulaMecanico.Location = new Point(752, 45);
            txtCedulaMecanico.Name = "txtCedulaMecanico";
            txtCedulaMecanico.Size = new Size(125, 27);
            txtCedulaMecanico.TabIndex = 5;
            txtCedulaMecanico.TextChanged += txtCedulaMecanico_TextChanged;
            // 
            // txtTelefonoMecanico
            // 
            txtTelefonoMecanico.Location = new Point(160, 54);
            txtTelefonoMecanico.Name = "txtTelefonoMecanico";
            txtTelefonoMecanico.Size = new Size(275, 27);
            txtTelefonoMecanico.TabIndex = 7;
            txtTelefonoMecanico.TextChanged += txtTelefonoMecanico_TextChanged;
            // 
            // lbTelefonoMecanico
            // 
            lbTelefonoMecanico.AutoSize = true;
            lbTelefonoMecanico.Location = new Point(84, 57);
            lbTelefonoMecanico.Name = "lbTelefonoMecanico";
            lbTelefonoMecanico.Size = new Size(70, 20);
            lbTelefonoMecanico.TabIndex = 6;
            lbTelefonoMecanico.Text = "Teléfono:";
            // 
            // txtCorreoMecanico
            // 
            txtCorreoMecanico.Location = new Point(582, 54);
            txtCorreoMecanico.Name = "txtCorreoMecanico";
            txtCorreoMecanico.Size = new Size(275, 27);
            txtCorreoMecanico.TabIndex = 9;
            txtCorreoMecanico.TextChanged += txtCorreoMecanico_TextChanged;
            // 
            // lbCorreoMecanico
            // 
            lbCorreoMecanico.AutoSize = true;
            lbCorreoMecanico.Location = new Point(510, 57);
            lbCorreoMecanico.Name = "lbCorreoMecanico";
            lbCorreoMecanico.Size = new Size(57, 20);
            lbCorreoMecanico.TabIndex = 8;
            lbCorreoMecanico.Text = "Correo:";
            lbCorreoMecanico.Click += lbCorreoMecanico_Click;
            // 
            // btnGuardarMecanico
            // 
            btnGuardarMecanico.Location = new Point(825, 268);
            btnGuardarMecanico.Name = "btnGuardarMecanico";
            btnGuardarMecanico.Size = new Size(94, 29);
            btnGuardarMecanico.TabIndex = 10;
            btnGuardarMecanico.Text = "Guardar";
            btnGuardarMecanico.UseVisualStyleBackColor = true;
            // 
            // gBoxContactarMecanico
            // 
            gBoxContactarMecanico.Controls.Add(txtTelefonoMecanico);
            gBoxContactarMecanico.Controls.Add(lbTelefonoMecanico);
            gBoxContactarMecanico.Controls.Add(txtCorreoMecanico);
            gBoxContactarMecanico.Controls.Add(lbCorreoMecanico);
            gBoxContactarMecanico.Location = new Point(12, 166);
            gBoxContactarMecanico.Name = "gBoxContactarMecanico";
            gBoxContactarMecanico.Size = new Size(907, 96);
            gBoxContactarMecanico.TabIndex = 11;
            gBoxContactarMecanico.TabStop = false;
            gBoxContactarMecanico.Text = "Medios de Contacto";
            // 
            // gBoxIdentificarMecanico
            // 
            gBoxIdentificarMecanico.Controls.Add(lbNombreMecanico);
            gBoxIdentificarMecanico.Controls.Add(txtNombreMecanico);
            gBoxIdentificarMecanico.Controls.Add(lbApellidoMecanico);
            gBoxIdentificarMecanico.Controls.Add(txtCedulaMecanico);
            gBoxIdentificarMecanico.Controls.Add(txtApellidoMecanico);
            gBoxIdentificarMecanico.Controls.Add(lbCedulaMecanico);
            gBoxIdentificarMecanico.Location = new Point(12, 47);
            gBoxIdentificarMecanico.Name = "gBoxIdentificarMecanico";
            gBoxIdentificarMecanico.Size = new Size(907, 96);
            gBoxIdentificarMecanico.TabIndex = 12;
            gBoxIdentificarMecanico.TabStop = false;
            gBoxIdentificarMecanico.Text = "Datos de Identificación";
            // 
            // lbIntrucción
            // 
            lbIntrucción.AutoSize = true;
            lbIntrucción.Location = new Point(12, 9);
            lbIntrucción.Name = "lbIntrucción";
            lbIntrucción.Size = new Size(281, 20);
            lbIntrucción.TabIndex = 13;
            lbIntrucción.Text = "A continuación, complete la información:";
            // 
            // frmRegistroMecanico
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 309);
            Controls.Add(lbIntrucción);
            Controls.Add(gBoxIdentificarMecanico);
            Controls.Add(gBoxContactarMecanico);
            Controls.Add(btnGuardarMecanico);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "frmRegistroMecanico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Nuevo Mecánico";
            gBoxContactarMecanico.ResumeLayout(false);
            gBoxContactarMecanico.PerformLayout();
            gBoxIdentificarMecanico.ResumeLayout(false);
            gBoxIdentificarMecanico.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNombreMecanico;
        private TextBox txtNombreMecanico;
        private TextBox txtApellidoMecanico;
        private Label lbApellidoMecanico;
        private Label lbCedulaMecanico;
        private TextBox txtCedulaMecanico;
        private TextBox txtTelefonoMecanico;
        private Label lbTelefonoMecanico;
        private TextBox txtCorreoMecanico;
        private Label lbCorreoMecanico;
        private Button btnGuardarMecanico;
        private GroupBox gBoxContactarMecanico;
        private GroupBox gBoxIdentificarMecanico;
        private Label lbIntrucción;
    }
}