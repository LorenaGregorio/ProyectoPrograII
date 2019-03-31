namespace ProyectoPrograII
{
    partial class PlandeVueloForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlandeVueloForms));
            this.label1 = new System.Windows.Forms.Label();
            this.combaccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeaterrizaje = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtlatitud = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.combtipoemer = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.combclaseavion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combemerg = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.combescala = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Accion";
            // 
            // combaccion
            // 
            this.combaccion.FormattingEnabled = true;
            this.combaccion.Items.AddRange(new object[] {
            "Aterrizar",
            "Despegar"});
            this.combaccion.Location = new System.Drawing.Point(153, 71);
            this.combaccion.Name = "combaccion";
            this.combaccion.Size = new System.Drawing.Size(121, 21);
            this.combaccion.TabIndex = 1;
            this.combaccion.SelectedIndexChanged += new System.EventHandler(this.combaccion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pista/Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Despegue";
            this.label3.Visible = false;
            // 
            // dateTimeaterrizaje
            // 
            this.dateTimeaterrizaje.Location = new System.Drawing.Point(156, 175);
            this.dateTimeaterrizaje.Name = "dateTimeaterrizaje";
            this.dateTimeaterrizaje.Size = new System.Drawing.Size(229, 20);
            this.dateTimeaterrizaje.TabIndex = 7;
            this.dateTimeaterrizaje.Visible = false;
            this.dateTimeaterrizaje.ValueChanged += new System.EventHandler(this.dateTimeaterrizaje_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Aterrizaje";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo Avion";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lugar Salida Avion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lugar Destino Avion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Red;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(779, 176);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 22);
            this.label21.TabIndex = 52;
            this.label21.Text = "Horas";
            this.label21.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Red;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(603, 133);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 18);
            this.label20.TabIndex = 51;
            this.label20.Text = "Kms.";
            this.label20.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(645, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Kms.";
            this.label19.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(645, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Kms.";
            this.label18.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(720, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 94);
            this.button2.TabIndex = 48;
            this.button2.Text = "Calcular Tiempo Estimado Llegada";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(726, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 22);
            this.label11.TabIndex = 47;
            this.label11.Text = "0";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(431, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 22);
            this.label12.TabIndex = 46;
            this.label12.Text = "Tiempo Estimado de LLegada";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Red;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(521, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 22);
            this.label13.TabIndex = 45;
            this.label13.Text = "0";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Red;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(431, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 22);
            this.label14.TabIndex = 44;
            this.label14.Text = "Distancia";
            this.label14.Visible = false;
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(538, 92);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(100, 20);
            this.txtlongitud.TabIndex = 43;
            this.txtlongitud.Text = "0";
            this.txtlongitud.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(401, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 16);
            this.label15.TabIndex = 42;
            this.label15.Text = "Longitud(Este-Oeste)";
            this.label15.Visible = false;
            // 
            // txtlatitud
            // 
            this.txtlatitud.Location = new System.Drawing.Point(538, 56);
            this.txtlatitud.Name = "txtlatitud";
            this.txtlatitud.Size = new System.Drawing.Size(100, 20);
            this.txtlatitud.TabIndex = 41;
            this.txtlatitud.Text = "0";
            this.txtlatitud.Visible = false;
            this.txtlatitud.TextChanged += new System.EventHandler(this.txtlatitud_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(401, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Latitud(Norte-Sur)";
            this.label16.Visible = false;
            // 
            // combtipoemer
            // 
            this.combtipoemer.FormattingEnabled = true;
            this.combtipoemer.Items.AddRange(new object[] {
            "Combustible Bajo",
            "Terroristas Abordo",
            "Desperfectos Mecanicos",
            "Pasajero Enfermo",
            "Emergencia de Tripulacion"});
            this.combtipoemer.Location = new System.Drawing.Point(538, 18);
            this.combtipoemer.Name = "combtipoemer";
            this.combtipoemer.Size = new System.Drawing.Size(166, 21);
            this.combtipoemer.TabIndex = 39;
            this.combtipoemer.Text = "Elija Opcion";
            this.combtipoemer.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(401, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 16);
            this.label17.TabIndex = 38;
            this.label17.Text = "Tipo de Emergencia";
            this.label17.Visible = false;
            // 
            // combclaseavion
            // 
            this.combclaseavion.FormattingEnabled = true;
            this.combclaseavion.Items.AddRange(new object[] {
            "Avion de Carga",
            "Avioneta VIP",
            "Avion Pasajeros (200)",
            "Avion Jumbo (2,000)"});
            this.combclaseavion.Location = new System.Drawing.Point(153, 45);
            this.combclaseavion.Name = "combclaseavion";
            this.combclaseavion.Size = new System.Drawing.Size(179, 21);
            this.combclaseavion.TabIndex = 54;
            this.combclaseavion.Text = "Elija Opcion";
            this.combclaseavion.SelectedIndexChanged += new System.EventHandler(this.combclaseavion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Clase de Avion";
            // 
            // combemerg
            // 
            this.combemerg.FormattingEnabled = true;
            this.combemerg.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.combemerg.Location = new System.Drawing.Point(502, 206);
            this.combemerg.Name = "combemerg";
            this.combemerg.Size = new System.Drawing.Size(126, 21);
            this.combemerg.TabIndex = 58;
            this.combemerg.Text = "Elija Opcion";
            this.combemerg.SelectedIndexChanged += new System.EventHandler(this.combemerg_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(249, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 26);
            this.label10.TabIndex = 57;
            this.label10.Text = "AVION EN EMERGENCIA";
            // 
            // combescala
            // 
            this.combescala.FormattingEnabled = true;
            this.combescala.Items.AddRange(new object[] {
            "True",
            "False"});
            this.combescala.Location = new System.Drawing.Point(106, 211);
            this.combescala.Name = "combescala";
            this.combescala.Size = new System.Drawing.Size(121, 21);
            this.combescala.TabIndex = 56;
            this.combescala.Text = "Elija Opcion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Hace Escala?";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(525, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 198);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PISTA";
            this.groupBox1.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(175, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 16);
            this.label23.TabIndex = 2;
            this.label23.Text = "HORAS.";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(109, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "0";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 66);
            this.button3.TabIndex = 0;
            this.button3.Text = "CALCULAR TIEMPO DE DESPEGUE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(153, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 17);
            this.label24.TabIndex = 60;
            this.label24.Text = "NO ASIGNADO";
            // 
            // PlandeVueloForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 466);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combemerg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combescala);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.combclaseavion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtlatitud);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.combtipoemer);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeaterrizaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combaccion);
            this.Controls.Add(this.label1);
            this.Name = "PlandeVueloForms";
            this.Text = "PlandeVueloForms";
            this.Load += new System.EventHandler(this.PlandeVueloForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeaterrizaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtlatitud;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox combtipoemer;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox combclaseavion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combemerg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combescala;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
    }
}