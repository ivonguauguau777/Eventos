
namespace EventosApp.elementos
{
    partial class trabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trabajadores));
            this.japi = new System.Windows.Forms.GroupBox();
            this.volver = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.correotx = new System.Windows.Forms.TextBox();
            this.rfctx = new System.Windows.Forms.TextBox();
            this.controltx = new System.Windows.Forms.TextBox();
            this.areatx = new System.Windows.Forms.TextBox();
            this.curptx = new System.Windows.Forms.TextBox();
            this.fechatx = new System.Windows.Forms.TextBox();
            this.numerotx = new System.Windows.Forms.TextBox();
            this.nombretx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fondo = new AxWMPLib.AxWindowsMediaPlayer();
            this.chambeadores = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cumpleaños = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RFC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.japi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambeadores)).BeginInit();
            this.SuspendLayout();
            // 
            // japi
            // 
            this.japi.BackColor = System.Drawing.Color.Transparent;
            this.japi.Controls.Add(this.volver);
            this.japi.Controls.Add(this.eliminar);
            this.japi.Controls.Add(this.editar);
            this.japi.Controls.Add(this.agregar);
            this.japi.Controls.Add(this.correotx);
            this.japi.Controls.Add(this.rfctx);
            this.japi.Controls.Add(this.controltx);
            this.japi.Controls.Add(this.areatx);
            this.japi.Controls.Add(this.curptx);
            this.japi.Controls.Add(this.fechatx);
            this.japi.Controls.Add(this.numerotx);
            this.japi.Controls.Add(this.nombretx);
            this.japi.Controls.Add(this.label8);
            this.japi.Controls.Add(this.label7);
            this.japi.Controls.Add(this.label6);
            this.japi.Controls.Add(this.label5);
            this.japi.Controls.Add(this.label4);
            this.japi.Controls.Add(this.label3);
            this.japi.Controls.Add(this.label2);
            this.japi.Controls.Add(this.label1);
            this.japi.Dock = System.Windows.Forms.DockStyle.Top;
            this.japi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.japi.Location = new System.Drawing.Point(0, 0);
            this.japi.Name = "japi";
            this.japi.Size = new System.Drawing.Size(915, 288);
            this.japi.TabIndex = 0;
            this.japi.TabStop = false;
            this.japi.Text = "Trabajadores";
            this.japi.Enter += new System.EventHandler(this.japi_Enter);
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.Transparent;
            this.volver.BackgroundImage = global::EventosApp.Properties.Resources.left_arrow_2_icon_icons_com_62881;
            this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volver.Location = new System.Drawing.Point(880, 12);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(34, 34);
            this.volver.TabIndex = 29;
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackgroundImage = global::EventosApp.Properties.Resources.delete_remove_close_icon_181533;
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminar.Location = new System.Drawing.Point(510, 225);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(58, 57);
            this.eliminar.TabIndex = 18;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = global::EventosApp.Properties.Resources.pen_edit_modify_pencil_icon_181536;
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar.Location = new System.Drawing.Point(510, 137);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(58, 61);
            this.editar.TabIndex = 17;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // agregar
            // 
            this.agregar.BackgroundImage = global::EventosApp.Properties.Resources.plus_insert_add_new_icon_181537;
            this.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.agregar.Location = new System.Drawing.Point(510, 50);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(58, 63);
            this.agregar.TabIndex = 16;
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // correotx
            // 
            this.correotx.Location = new System.Drawing.Point(247, 201);
            this.correotx.Name = "correotx";
            this.correotx.Size = new System.Drawing.Size(223, 22);
            this.correotx.TabIndex = 15;
            // 
            // rfctx
            // 
            this.rfctx.Location = new System.Drawing.Point(25, 201);
            this.rfctx.Name = "rfctx";
            this.rfctx.Size = new System.Drawing.Size(177, 22);
            this.rfctx.TabIndex = 14;
            // 
            // controltx
            // 
            this.controltx.Location = new System.Drawing.Point(247, 260);
            this.controltx.Name = "controltx";
            this.controltx.Size = new System.Drawing.Size(82, 22);
            this.controltx.TabIndex = 13;
            // 
            // areatx
            // 
            this.areatx.Location = new System.Drawing.Point(25, 260);
            this.areatx.Name = "areatx";
            this.areatx.Size = new System.Drawing.Size(177, 22);
            this.areatx.TabIndex = 12;
            // 
            // curptx
            // 
            this.curptx.Location = new System.Drawing.Point(247, 143);
            this.curptx.Name = "curptx";
            this.curptx.Size = new System.Drawing.Size(223, 22);
            this.curptx.TabIndex = 11;
            // 
            // fechatx
            // 
            this.fechatx.Location = new System.Drawing.Point(25, 143);
            this.fechatx.Name = "fechatx";
            this.fechatx.Size = new System.Drawing.Size(177, 22);
            this.fechatx.TabIndex = 10;
            // 
            // numerotx
            // 
            this.numerotx.Location = new System.Drawing.Point(246, 70);
            this.numerotx.Name = "numerotx";
            this.numerotx.Size = new System.Drawing.Size(224, 22);
            this.numerotx.TabIndex = 9;
            // 
            // nombretx
            // 
            this.nombretx.Location = new System.Drawing.Point(25, 70);
            this.nombretx.Name = "nombretx";
            this.nombretx.Size = new System.Drawing.Size(177, 22);
            this.nombretx.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Image = global::EventosApp.Properties.Resources.semifondotrabajadores;
            this.label8.Location = new System.Drawing.Point(251, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(251, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "No. Control";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(27, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(251, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(251, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CURP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cumpleaños";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // fondo
            // 
            this.fondo.Enabled = true;
            this.fondo.Location = new System.Drawing.Point(-113, 294);
            this.fondo.Name = "fondo";
            this.fondo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fondo.OcxState")));
            this.fondo.Size = new System.Drawing.Size(950, 502);
            this.fondo.TabIndex = 30;
            // 
            // chambeadores
            // 
            this.chambeadores.BackgroundColor = System.Drawing.Color.White;
            this.chambeadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambeadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.numero1,
            this.Cumpleaños,
            this.CURP,
            this.RFC,
            this.Correo,
            this.Area,
            this.Control});
            this.chambeadores.Location = new System.Drawing.Point(0, 294);
            this.chambeadores.Name = "chambeadores";
            this.chambeadores.RowHeadersWidth = 51;
            this.chambeadores.RowTemplate.Height = 24;
            this.chambeadores.Size = new System.Drawing.Size(915, 287);
            this.chambeadores.TabIndex = 1;
            this.chambeadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.chambeadores_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // numero1
            // 
            this.numero1.HeaderText = "Numero";
            this.numero1.MinimumWidth = 6;
            this.numero1.Name = "numero1";
            this.numero1.Width = 125;
            // 
            // Cumpleaños
            // 
            this.Cumpleaños.HeaderText = "Cumpleaños";
            this.Cumpleaños.MinimumWidth = 6;
            this.Cumpleaños.Name = "Cumpleaños";
            this.Cumpleaños.Width = 125;
            // 
            // CURP
            // 
            this.CURP.HeaderText = "CURP";
            this.CURP.MinimumWidth = 6;
            this.CURP.Name = "CURP";
            this.CURP.Width = 125;
            // 
            // RFC
            // 
            this.RFC.HeaderText = "RFC";
            this.RFC.MinimumWidth = 6;
            this.RFC.Name = "RFC";
            this.RFC.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // Area
            // 
            this.Area.HeaderText = "Area";
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            this.Area.Width = 125;
            // 
            // Control
            // 
            this.Control.HeaderText = "Control";
            this.Control.MinimumWidth = 6;
            this.Control.Name = "Control";
            this.Control.Width = 125;
            // 
            // trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(915, 580);
            this.Controls.Add(this.fondo);
            this.Controls.Add(this.japi);
            this.Controls.Add(this.chambeadores);
            this.Name = "trabajadores";
            this.Text = "trabajadores";
            this.Load += new System.EventHandler(this.trabajadores_Load);
            this.japi.ResumeLayout(false);
            this.japi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambeadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox japi;
        private System.Windows.Forms.DataGridView chambeadores;
        private System.Windows.Forms.TextBox correotx;
        private System.Windows.Forms.TextBox rfctx;
        private System.Windows.Forms.TextBox controltx;
        private System.Windows.Forms.TextBox areatx;
        private System.Windows.Forms.TextBox curptx;
        private System.Windows.Forms.TextBox fechatx;
        private System.Windows.Forms.TextBox nombretx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.TextBox numerotx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cumpleaños;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURP;
        private System.Windows.Forms.DataGridViewTextBoxColumn RFC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn Control;
        private System.Windows.Forms.Button volver;
        private AxWMPLib.AxWindowsMediaPlayer fondo;
    }
}