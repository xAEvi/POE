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
            lbNombreMecanico.Location = new Point(5, 36);
            lbNombreMecanico.Name = "lbNombreMecanico";
            lbNombreMecanico.Size = new Size(54, 15);
            lbNombreMecanico.TabIndex = 0;
            lbNombreMecanico.Text = "Nombre:";
            // 
            // txtNombreMecanico
            // 
            txtNombreMecanico.Location = new Point(68, 34);
            txtNombreMecanico.Margin = new Padding(3, 2, 3, 2);
            txtNombreMecanico.Name = "txtNombreMecanico";
            txtNombreMecanico.Size = new Size(191, 23);
            txtNombreMecanico.TabIndex = 1;
            txtNombreMecanico.TextChanged += txtNombreMecanico_TextChanged;
            // 
            // txtApellidoMecanico
            // 
            txtApellidoMecanico.Location = new Point(353, 34);
            txtApellidoMecanico.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMecanico.Name = "txtApellidoMecanico";
            txtApellidoMecanico.Size = new Size(204, 23);
            txtApellidoMecanico.TabIndex = 2;
            txtApellidoMecanico.TextChanged += txtApellidoMecanico_TextChanged;
            // 
            // lbApellidoMecanico
            // 
            lbApellidoMecanico.AutoSize = true;
            lbApellidoMecanico.Location = new Point(284, 36);
            lbApellidoMecanico.Name = "lbApellidoMecanico";
            lbApellidoMecanico.Size = new Size(57, 15);
            lbApellidoMecanico.TabIndex = 3;
            lbApellidoMecanico.Text = "Apelllido:";
            // 
            // lbCedulaMecanico
            // 
            lbCedulaMecanico.AutoSize = true;
            lbCedulaMecanico.Location = new Point(602, 36);
            lbCedulaMecanico.Name = "lbCedulaMecanico";
            lbCedulaMecanico.Size = new Size(47, 15);
            lbCedulaMecanico.TabIndex = 4;
            lbCedulaMecanico.Text = "Cédula:";
            // 
            // txtCedulaMecanico
            // 
            txtCedulaMecanico.Location = new Point(658, 34);
            txtCedulaMecanico.Margin = new Padding(3, 2, 3, 2);
            txtCedulaMecanico.Name = "txtCedulaMecanico";
            txtCedulaMecanico.Size = new Size(110, 23);
            txtCedulaMecanico.TabIndex = 5;
            txtCedulaMecanico.TextChanged += txtCedulaMecanico_TextChanged;
            // 
            // txtTelefonoMecanico
            // 
            txtTelefonoMecanico.Location = new Point(140, 40);
            txtTelefonoMecanico.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoMecanico.Name = "txtTelefonoMecanico";
            txtTelefonoMecanico.Size = new Size(241, 23);
            txtTelefonoMecanico.TabIndex = 7;
            txtTelefonoMecanico.TextChanged += txtTelefonoMecanico_TextChanged;
            // 
            // lbTelefonoMecanico
            // 
            lbTelefonoMecanico.AutoSize = true;
            lbTelefonoMecanico.Location = new Point(74, 43);
            lbTelefonoMecanico.Name = "lbTelefonoMecanico";
            lbTelefonoMecanico.Size = new Size(55, 15);
            lbTelefonoMecanico.TabIndex = 6;
            lbTelefonoMecanico.Text = "Teléfono:";
            // 
            // txtCorreoMecanico
            // 
            txtCorreoMecanico.Location = new Point(509, 40);
            txtCorreoMecanico.Margin = new Padding(3, 2, 3, 2);
            txtCorreoMecanico.Name = "txtCorreoMecanico";
            txtCorreoMecanico.Size = new Size(241, 23);
            txtCorreoMecanico.TabIndex = 9;
            txtCorreoMecanico.TextChanged += txtCorreoMecanico_TextChanged;
            // 
            // lbCorreoMecanico
            // 
            lbCorreoMecanico.AutoSize = true;
            lbCorreoMecanico.Location = new Point(446, 43);
            lbCorreoMecanico.Name = "lbCorreoMecanico";
            lbCorreoMecanico.Size = new Size(46, 15);
            lbCorreoMecanico.TabIndex = 8;
            lbCorreoMecanico.Text = "Correo:";
            lbCorreoMecanico.Click += lbCorreoMecanico_Click;
            // 
            // btnGuardarMecanico
            // 
            btnGuardarMecanico.Location = new Point(722, 201);
            btnGuardarMecanico.Margin = new Padding(3, 2, 3, 2);
            btnGuardarMecanico.Name = "btnGuardarMecanico";
            btnGuardarMecanico.Size = new Size(82, 22);
            btnGuardarMecanico.TabIndex = 10;
            btnGuardarMecanico.Text = "Guardar";
            btnGuardarMecanico.UseVisualStyleBackColor = true;
            btnGuardarMecanico.Click += btnGuardarMecanico_Click_1;
            // 
            // gBoxContactarMecanico
            // 
            gBoxContactarMecanico.Controls.Add(txtTelefonoMecanico);
            gBoxContactarMecanico.Controls.Add(lbTelefonoMecanico);
            gBoxContactarMecanico.Controls.Add(txtCorreoMecanico);
            gBoxContactarMecanico.Controls.Add(lbCorreoMecanico);
            gBoxContactarMecanico.Location = new Point(10, 124);
            gBoxContactarMecanico.Margin = new Padding(3, 2, 3, 2);
            gBoxContactarMecanico.Name = "gBoxContactarMecanico";
            gBoxContactarMecanico.Padding = new Padding(3, 2, 3, 2);
            gBoxContactarMecanico.Size = new Size(794, 72);
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
            gBoxIdentificarMecanico.Location = new Point(10, 35);
            gBoxIdentificarMecanico.Margin = new Padding(3, 2, 3, 2);
            gBoxIdentificarMecanico.Name = "gBoxIdentificarMecanico";
            gBoxIdentificarMecanico.Padding = new Padding(3, 2, 3, 2);
            gBoxIdentificarMecanico.Size = new Size(794, 72);
            gBoxIdentificarMecanico.TabIndex = 12;
            gBoxIdentificarMecanico.TabStop = false;
            gBoxIdentificarMecanico.Text = "Datos de Identificación";
            // 
            // lbIntrucción
            // 
            lbIntrucción.AutoSize = true;
            lbIntrucción.Location = new Point(10, 7);
            lbIntrucción.Name = "lbIntrucción";
            lbIntrucción.Size = new Size(227, 15);
            lbIntrucción.TabIndex = 13;
            lbIntrucción.Text = "A continuación, complete la información:";
            // 
            // frmRegistroMecanico
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 232);
            Controls.Add(lbIntrucción);
            Controls.Add(gBoxIdentificarMecanico);
            Controls.Add(gBoxContactarMecanico);
            Controls.Add(btnGuardarMecanico);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
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