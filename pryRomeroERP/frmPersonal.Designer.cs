namespace pryRomeroERP
{
    partial class frmPersonal
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpUsuario = new System.Windows.Forms.GroupBox();
            this.tbcPersonal = new System.Windows.Forms.TabControl();
            this.tbpDomicilio = new System.Windows.Forms.TabPage();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpContacto = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.chbActivo = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRedes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpUsuario.SuspendLayout();
            this.tbcPersonal.SuspendLayout();
            this.tbpDomicilio.SuspendLayout();
            this.tbpContacto.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(291, 338);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 338);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(555, 338);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 320);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpUsuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auditoria";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpUsuario
            // 
            this.grpUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpUsuario.Controls.Add(this.tbcPersonal);
            this.grpUsuario.Controls.Add(this.txtNombre);
            this.grpUsuario.Controls.Add(this.txtApellido);
            this.grpUsuario.Controls.Add(this.txtDNI);
            this.grpUsuario.Controls.Add(this.lblNombre);
            this.grpUsuario.Controls.Add(this.lblApellido);
            this.grpUsuario.Controls.Add(this.lblDNI);
            this.grpUsuario.Location = new System.Drawing.Point(0, 3);
            this.grpUsuario.Name = "grpUsuario";
            this.grpUsuario.Size = new System.Drawing.Size(612, 285);
            this.grpUsuario.TabIndex = 11;
            this.grpUsuario.TabStop = false;
            // 
            // tbcPersonal
            // 
            this.tbcPersonal.Controls.Add(this.tbpDomicilio);
            this.tbcPersonal.Controls.Add(this.tbpContacto);
            this.tbcPersonal.Location = new System.Drawing.Point(6, 121);
            this.tbcPersonal.Name = "tbcPersonal";
            this.tbcPersonal.SelectedIndex = 0;
            this.tbcPersonal.Size = new System.Drawing.Size(615, 193);
            this.tbcPersonal.TabIndex = 12;
            // 
            // tbpDomicilio
            // 
            this.tbpDomicilio.Controls.Add(this.comboBox3);
            this.tbpDomicilio.Controls.Add(this.comboBox2);
            this.tbpDomicilio.Controls.Add(this.textBox4);
            this.tbpDomicilio.Controls.Add(this.textBox3);
            this.tbpDomicilio.Controls.Add(this.lblLocalidad);
            this.tbpDomicilio.Controls.Add(this.lblProvincia);
            this.tbpDomicilio.Controls.Add(this.label2);
            this.tbpDomicilio.Controls.Add(this.label1);
            this.tbpDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDomicilio.Location = new System.Drawing.Point(4, 22);
            this.tbpDomicilio.Name = "tbpDomicilio";
            this.tbpDomicilio.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDomicilio.Size = new System.Drawing.Size(607, 167);
            this.tbpDomicilio.TabIndex = 0;
            this.tbpDomicilio.Text = "Domicilio";
            this.tbpDomicilio.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(413, 12);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 63);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Location = new System.Drawing.Point(413, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(122, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 22);
            this.textBox3.TabIndex = 4;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(299, 20);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(10, 71);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(66, 16);
            this.lblProvincia.TabIndex = 2;
            this.lblProvincia.Text = "Provincia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "GEO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección:";
            // 
            // tbpContacto
            // 
            this.tbpContacto.Controls.Add(this.groupBox1);
            this.tbpContacto.Controls.Add(this.chbActivo);
            this.tbpContacto.Controls.Add(this.comboBox1);
            this.tbpContacto.Controls.Add(this.lblRedes);
            this.tbpContacto.Location = new System.Drawing.Point(4, 22);
            this.tbpContacto.Name = "tbpContacto";
            this.tbpContacto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContacto.Size = new System.Drawing.Size(607, 167);
            this.tbpContacto.TabIndex = 1;
            this.tbpContacto.Text = "Contacto";
            this.tbpContacto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(138, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 3;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(0, 56);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 16);
            this.lblTelefono.TabIndex = 1;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(0, 16);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 16);
            this.lblMail.TabIndex = 0;
            this.lblMail.Text = "Mail:";
            // 
            // chbActivo
            // 
            this.chbActivo.AutoSize = true;
            this.chbActivo.Location = new System.Drawing.Point(14, 122);
            this.chbActivo.Name = "chbActivo";
            this.chbActivo.Size = new System.Drawing.Size(56, 17);
            this.chbActivo.TabIndex = 6;
            this.chbActivo.Text = "Activo";
            this.chbActivo.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(476, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedes.Location = new System.Drawing.Point(348, 18);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(107, 16);
            this.lblRedes.TabIndex = 2;
            this.lblRedes.Text = "Redes Sociales:";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(92, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.Location = new System.Drawing.Point(92, 54);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDNI.Location = new System.Drawing.Point(92, 20);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(15, 58);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(15, 24);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "DNI:";
            // 
            // frmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(650, 373);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmPersonal";
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.frmPersonal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpUsuario.ResumeLayout(false);
            this.grpUsuario.PerformLayout();
            this.tbcPersonal.ResumeLayout(false);
            this.tbpDomicilio.ResumeLayout(false);
            this.tbpDomicilio.PerformLayout();
            this.tbpContacto.ResumeLayout(false);
            this.tbpContacto.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grpUsuario;
        private System.Windows.Forms.TabControl tbcPersonal;
        private System.Windows.Forms.TabPage tbpDomicilio;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpContacto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.CheckBox chbActivo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TabPage tabPage2;
    }
}