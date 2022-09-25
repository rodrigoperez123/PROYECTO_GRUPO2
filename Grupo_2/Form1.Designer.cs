
namespace Grupo_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Admin = new MetroFramework.Controls.MetroGrid();
            this.dgvProcesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFisica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVirtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new MetroFramework.Controls.MetroTile();
            this.btnDetener = new MetroFramework.Controls.MetroTile();
            this.btnSalir = new MetroFramework.Controls.MetroTile();
            this.txtcontador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumProces = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Admin)).BeginInit();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AllowUserToResizeRows = false;
            this.Admin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Admin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Admin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Admin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProcesos,
            this.dgvID,
            this.dgvFisica,
            this.dgvVirtual,
            this.dgvCPU});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Admin.DefaultCellStyle = dataGridViewCellStyle2;
            this.Admin.EnableHeadersVisualStyles = false;
            this.Admin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Admin.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Admin.Location = new System.Drawing.Point(43, 82);
            this.Admin.Name = "Admin";
            this.Admin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Admin.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Admin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Admin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Admin.Size = new System.Drawing.Size(867, 509);
            this.Admin.Style = MetroFramework.MetroColorStyle.Red;
            this.Admin.TabIndex = 0;
            this.Admin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdministrador_CellContentClick);
            // 
            // dgvProcesos
            // 
            this.dgvProcesos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProcesos.HeaderText = "Proceso";
            this.dgvProcesos.Name = "dgvProcesos";
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvID.HeaderText = "ID";
            this.dgvID.Name = "dgvID";
            // 
            // dgvFisica
            // 
            this.dgvFisica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFisica.HeaderText = "Memoria Fisica";
            this.dgvFisica.Name = "dgvFisica";
            // 
            // dgvVirtual
            // 
            this.dgvVirtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvVirtual.HeaderText = "Memoria Virtual";
            this.dgvVirtual.Name = "dgvVirtual";
            // 
            // dgvCPU
            // 
            this.dgvCPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCPU.HeaderText = "CPU";
            this.dgvCPU.Name = "dgvCPU";
            // 
            // btnActualizar
            // 
            this.btnActualizar.ActiveControl = null;
            this.btnActualizar.Location = new System.Drawing.Point(600, 616);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(82, 37);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.ActiveControl = null;
            this.btnDetener.Location = new System.Drawing.Point(713, 617);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(82, 36);
            this.btnDetener.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseSelectable = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveControl = null;
            this.btnSalir.Location = new System.Drawing.Point(826, 616);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 37);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.Green;
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseSelectable = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtcontador
            // 
            this.txtcontador.AutoSize = true;
            this.txtcontador.Location = new System.Drawing.Point(72, 617);
            this.txtcontador.Name = "txtcontador";
            this.txtcontador.Size = new System.Drawing.Size(50, 13);
            this.txtcontador.TabIndex = 4;
            this.txtcontador.Text = "Contador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 652);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del proceso:";
            // 
            // txtNumProces
            // 
            this.txtNumProces.AutoSize = true;
            this.txtNumProces.Location = new System.Drawing.Point(190, 652);
            this.txtNumProces.Name = "txtNumProces";
            this.txtNumProces.Size = new System.Drawing.Size(13, 13);
            this.txtNumProces.TabIndex = 6;
            this.txtNumProces.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 120000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 695);
            this.Controls.Add(this.txtNumProces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.Admin);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Administrador_De_Tareas";
            ((System.ComponentModel.ISupportInitialize)(this.Admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid Admin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProcesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFisica;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVirtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCPU;
        private MetroFramework.Controls.MetroTile btnActualizar;
        private MetroFramework.Controls.MetroTile btnDetener;
        private MetroFramework.Controls.MetroTile btnSalir;
        private System.Windows.Forms.Label txtcontador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNumProces;
        private System.Windows.Forms.Timer timer1;
    }
}

