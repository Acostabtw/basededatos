
namespace basededatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.dataGridView_fila = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_apellido = new System.Windows.Forms.Label();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.telefono_txt = new System.Windows.Forms.TextBox();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_ver = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fila)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(1098, 35);
            this.Btn_agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(78, 54);
            this.Btn_agregar.TabIndex = 3;
            this.Btn_agregar.Text = "agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.Btn_agregar_Click);
            // 
            // dataGridView_fila
            // 
            this.dataGridView_fila.AllowUserToAddRows = false;
            this.dataGridView_fila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_fila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Num_Telefono});
            this.dataGridView_fila.Location = new System.Drawing.Point(373, 209);
            this.dataGridView_fila.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_fila.Name = "dataGridView_fila";
            this.dataGridView_fila.RowHeadersWidth = 51;
            this.dataGridView_fila.RowTemplate.Height = 24;
            this.dataGridView_fila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_fila.Size = new System.Drawing.Size(606, 343);
            this.dataGridView_fila.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // Num_Telefono
            // 
            this.Num_Telefono.HeaderText = "Numero de telefono";
            this.Num_Telefono.MinimumWidth = 6;
            this.Num_Telefono.Name = "Num_Telefono";
            this.Num_Telefono.Width = 125;
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(454, 35);
            this.nombre_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(104, 20);
            this.nombre_txt.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(336, 38);
            this.label_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(47, 13);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "Nombre:";
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(336, 76);
            this.label_apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(47, 13);
            this.label_apellido.TabIndex = 4;
            this.label_apellido.Text = "Apellido:";
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(454, 73);
            this.apellido_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(104, 20);
            this.apellido_txt.TabIndex = 1;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(331, 114);
            this.label_num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(52, 13);
            this.label_num.TabIndex = 6;
            this.label_num.Text = "Telefono:";
            // 
            // telefono_txt
            // 
            this.telefono_txt.Location = new System.Drawing.Point(454, 111);
            this.telefono_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.Size = new System.Drawing.Size(104, 20);
            this.telefono_txt.TabIndex = 2;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(1098, 114);
            this.Btn_eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(78, 50);
            this.Btn_eliminar.TabIndex = 6;
            this.Btn_eliminar.Text = "eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_ver
            // 
            this.Btn_ver.Location = new System.Drawing.Point(1098, 209);
            this.Btn_ver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ver.Name = "Btn_ver";
            this.Btn_ver.Size = new System.Drawing.Size(78, 50);
            this.Btn_ver.TabIndex = 7;
            this.Btn_ver.Text = "Ver registros";
            this.Btn_ver.UseVisualStyleBackColor = true;
            this.Btn_ver.Click += new System.EventHandler(this.Btn_ver_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 585);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1302, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(131, 20);
            this.lblStatus.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 607);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Btn_ver);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.telefono_txt);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.label_apellido);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.dataGridView_fila);
            this.Controls.Add(this.Btn_agregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fila)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.DataGridView dataGridView_fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Telefono;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox telefono_txt;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_ver;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton lblStatus;
    }
}

