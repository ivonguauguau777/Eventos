
namespace EventosApp.elementos
{
    partial class eventos
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
            this.eventitos = new System.Windows.Forms.DataGridView();
            this.codigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.volver = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.subir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.fechatx = new System.Windows.Forms.DateTimePicker();
            this.personastx = new System.Windows.Forms.NumericUpDown();
            this.decoraciontx = new System.Windows.Forms.ComboBox();
            this.musicatx = new System.Windows.Forms.ComboBox();
            this.comidatx = new System.Windows.Forms.TextBox();
            this.ubicaciontx = new System.Windows.Forms.TextBox();
            this.eventotx = new System.Windows.Forms.TextBox();
            this.codigotx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventitos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personastx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // eventitos
            // 
            this.eventitos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(170)))), ((int)(((byte)(151)))));
            this.eventitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo1,
            this.evento,
            this.NoPersonas,
            this.fecha,
            this.comida,
            this.decoracion,
            this.musica,
            this.ubicacion});
            this.eventitos.GridColor = System.Drawing.Color.White;
            this.eventitos.Location = new System.Drawing.Point(-1, 378);
            this.eventitos.Name = "eventitos";
            this.eventitos.RowHeadersWidth = 51;
            this.eventitos.RowTemplate.Height = 24;
            this.eventitos.Size = new System.Drawing.Size(1053, 301);
            this.eventitos.TabIndex = 0;
            this.eventitos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventitos_CellContentClick);
            // 
            // codigo1
            // 
            this.codigo1.HeaderText = "codigo";
            this.codigo1.MinimumWidth = 6;
            this.codigo1.Name = "codigo1";
            this.codigo1.Width = 125;
            // 
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.MinimumWidth = 6;
            this.evento.Name = "evento";
            this.evento.Width = 125;
            // 
            // NoPersonas
            // 
            this.NoPersonas.HeaderText = "Personas";
            this.NoPersonas.MinimumWidth = 6;
            this.NoPersonas.Name = "NoPersonas";
            this.NoPersonas.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // comida
            // 
            this.comida.HeaderText = "Comida";
            this.comida.MinimumWidth = 6;
            this.comida.Name = "comida";
            this.comida.Width = 125;
            // 
            // decoracion
            // 
            this.decoracion.HeaderText = "Decoracion";
            this.decoracion.MinimumWidth = 6;
            this.decoracion.Name = "decoracion";
            this.decoracion.Width = 125;
            // 
            // musica
            // 
            this.musica.HeaderText = "Musica";
            this.musica.MinimumWidth = 6;
            this.musica.Name = "musica";
            this.musica.Width = 125;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicacion";
            this.ubicacion.MinimumWidth = 6;
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.volver);
            this.groupBox1.Controls.Add(this.eliminar);
            this.groupBox1.Controls.Add(this.subir);
            this.groupBox1.Controls.Add(this.editar);
            this.groupBox1.Controls.Add(this.fechatx);
            this.groupBox1.Controls.Add(this.personastx);
            this.groupBox1.Controls.Add(this.decoraciontx);
            this.groupBox1.Controls.Add(this.musicatx);
            this.groupBox1.Controls.Add(this.comidatx);
            this.groupBox1.Controls.Add(this.ubicaciontx);
            this.groupBox1.Controls.Add(this.eventotx);
            this.groupBox1.Controls.Add(this.codigotx);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 451);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.Transparent;
            this.volver.BackgroundImage = global::EventosApp.Properties.Resources.left_arrow_2_icon_icons_com_62881;
            this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.volver.Location = new System.Drawing.Point(6, 21);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(35, 33);
            this.volver.TabIndex = 29;
            this.volver.UseVisualStyleBackColor = false;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackgroundImage = global::EventosApp.Properties.Resources.delete_remove_close_icon_181533;
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminar.Location = new System.Drawing.Point(162, 281);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(63, 54);
            this.eliminar.TabIndex = 19;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // subir
            // 
            this.subir.BackgroundImage = global::EventosApp.Properties.Resources.plus_insert_add_new_icon_181537;
            this.subir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.subir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subir.Location = new System.Drawing.Point(12, 281);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(63, 54);
            this.subir.TabIndex = 17;
            this.subir.UseVisualStyleBackColor = true;
            this.subir.Click += new System.EventHandler(this.subir_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = global::EventosApp.Properties.Resources.pen_edit_modify_pencil_icon_181536;
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editar.Location = new System.Drawing.Point(81, 281);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 54);
            this.editar.TabIndex = 16;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // fechatx
            // 
            this.fechatx.Location = new System.Drawing.Point(150, 201);
            this.fechatx.Name = "fechatx";
            this.fechatx.Size = new System.Drawing.Size(249, 25);
            this.fechatx.TabIndex = 15;
            // 
            // personastx
            // 
            this.personastx.Location = new System.Drawing.Point(150, 154);
            this.personastx.Name = "personastx";
            this.personastx.Size = new System.Drawing.Size(120, 25);
            this.personastx.TabIndex = 14;
            this.personastx.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // decoraciontx
            // 
            this.decoraciontx.FormattingEnabled = true;
            this.decoraciontx.Items.AddRange(new object[] {
            "Rústica",
            "A todo color",
            "Estilo romatico",
            "Deco glam chic",
            "shabby chic",
            "industrial",
            "campestre"});
            this.decoraciontx.Location = new System.Drawing.Point(512, 143);
            this.decoraciontx.Name = "decoraciontx";
            this.decoraciontx.Size = new System.Drawing.Size(121, 28);
            this.decoraciontx.TabIndex = 13;
            this.decoraciontx.SelectedIndexChanged += new System.EventHandler(this.decoraciontx_SelectedIndexChanged);
            // 
            // musicatx
            // 
            this.musicatx.FormattingEnabled = true;
            this.musicatx.Items.AddRange(new object[] {
            "Grupo",
            "Jazz",
            "Reggaeton",
            "Rock",
            "K-pop",
            "Balada",
            "Regional Mexicano",
            "Pop",
            "Rap",
            "Trap"});
            this.musicatx.Location = new System.Drawing.Point(512, 198);
            this.musicatx.Name = "musicatx";
            this.musicatx.Size = new System.Drawing.Size(121, 28);
            this.musicatx.TabIndex = 12;
            this.musicatx.SelectedIndexChanged += new System.EventHandler(this.musicatx_SelectedIndexChanged);
            // 
            // comidatx
            // 
            this.comidatx.Location = new System.Drawing.Point(512, 82);
            this.comidatx.Name = "comidatx";
            this.comidatx.Size = new System.Drawing.Size(100, 25);
            this.comidatx.TabIndex = 11;
            this.comidatx.TextChanged += new System.EventHandler(this.comidatx_TextChanged);
            // 
            // ubicaciontx
            // 
            this.ubicaciontx.Location = new System.Drawing.Point(512, 34);
            this.ubicaciontx.Name = "ubicaciontx";
            this.ubicaciontx.Size = new System.Drawing.Size(247, 25);
            this.ubicaciontx.TabIndex = 10;
            this.ubicaciontx.TextChanged += new System.EventHandler(this.ubicaciontx_TextChanged);
            // 
            // eventotx
            // 
            this.eventotx.Location = new System.Drawing.Point(150, 104);
            this.eventotx.Name = "eventotx";
            this.eventotx.Size = new System.Drawing.Size(100, 25);
            this.eventotx.TabIndex = 9;
            // 
            // codigotx
            // 
            this.codigotx.Location = new System.Drawing.Point(150, 42);
            this.codigotx.Name = "codigotx";
            this.codigotx.Size = new System.Drawing.Size(100, 25);
            this.codigotx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ubicacion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Musica";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Decoracion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Comida";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de personas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Evento";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(92, 42);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(54, 20);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "Codigo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::EventosApp.Properties.Resources.semifondo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 351);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::EventosApp.Properties.Resources.semifondo;
            this.pictureBox3.Location = new System.Drawing.Point(416, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(630, 351);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EventosApp.Properties.Resources.semifondo;
            this.pictureBox2.Location = new System.Drawing.Point(533, 328);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(403, 351);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EventosApp.Properties.Resources._4f357b1cdf0b1a11ec08919f83a5b9261e608b14_s2_n3_y2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1052, 584);
            this.Controls.Add(this.eventitos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "eventos";
            this.Text = "eventos";
            ((System.ComponentModel.ISupportInitialize)(this.eventitos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personastx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView eventitos;
        private System.Windows.Forms.DateTimePicker fechatx;
        private System.Windows.Forms.NumericUpDown personastx;
        private System.Windows.Forms.ComboBox decoraciontx;
        private System.Windows.Forms.ComboBox musicatx;
        private System.Windows.Forms.TextBox comidatx;
        private System.Windows.Forms.TextBox ubicaciontx;
        private System.Windows.Forms.TextBox eventotx;
        private System.Windows.Forms.TextBox codigotx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button subir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn comida;
        private System.Windows.Forms.DataGridViewTextBoxColumn decoracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn musica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}