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
            this.label1 = new System.Windows.Forms.Label();
            this.combaccion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combpista = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimedespegue = new System.Windows.Forms.DateTimePicker();
            this.dateTimeaterrizaje = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Accion";
            // 
            // combaccion
            // 
            this.combaccion.FormattingEnabled = true;
            this.combaccion.Items.AddRange(new object[] {
            "Aterrizar",
            "Despegar"});
            this.combaccion.Location = new System.Drawing.Point(153, 28);
            this.combaccion.Name = "combaccion";
            this.combaccion.Size = new System.Drawing.Size(121, 21);
            this.combaccion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de Pista";
            // 
            // combpista
            // 
            this.combpista.FormattingEnabled = true;
            this.combpista.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.combpista.Location = new System.Drawing.Point(153, 75);
            this.combpista.Name = "combpista";
            this.combpista.Size = new System.Drawing.Size(121, 21);
            this.combpista.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de Despegue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha de Aterrizaje";
            // 
            // dateTimedespegue
            // 
            this.dateTimedespegue.Location = new System.Drawing.Point(153, 128);
            this.dateTimedespegue.Name = "dateTimedespegue";
            this.dateTimedespegue.Size = new System.Drawing.Size(200, 20);
            this.dateTimedespegue.TabIndex = 6;
            // 
            // dateTimeaterrizaje
            // 
            this.dateTimeaterrizaje.Location = new System.Drawing.Point(153, 187);
            this.dateTimeaterrizaje.Name = "dateTimeaterrizaje";
            this.dateTimeaterrizaje.Size = new System.Drawing.Size(200, 20);
            this.dateTimeaterrizaje.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 36);
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
            this.dataGridView1.Location = new System.Drawing.Point(42, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // PlandeVueloForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 418);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimeaterrizaje);
            this.Controls.Add(this.dateTimedespegue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combpista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combaccion);
            this.Controls.Add(this.label1);
            this.Name = "PlandeVueloForms";
            this.Text = "PlandeVueloForms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combpista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimedespegue;
        private System.Windows.Forms.DateTimePicker dateTimeaterrizaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}