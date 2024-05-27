using System;
using System.Windows.Forms;

namespace Administracion_Hotelera.view
{
    partial class FormManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnHotels = new System.Windows.Forms.Button();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHotels = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGHotels = new System.Windows.Forms.DataGridView();
            this.lblHora = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlBookings = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DGBookings = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.Ver = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            this.pnlHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGHotels)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agente de Viajes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnReservas);
            this.panel2.Controls.Add(this.btnHotels);
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 499);
            this.panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(0, 457);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(200, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Volver";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(8, 329);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(185, 67);
            this.btnReservas.TabIndex = 1;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnHotels
            // 
            this.btnHotels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotels.FlatAppearance.BorderSize = 0;
            this.btnHotels.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotels.Location = new System.Drawing.Point(8, 214);
            this.btnHotels.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotels.Name = "btnHotels";
            this.btnHotels.Size = new System.Drawing.Size(185, 67);
            this.btnHotels.TabIndex = 0;
            this.btnHotels.Text = "Hoteles";
            this.btnHotels.UseVisualStyleBackColor = true;
            this.btnHotels.Click += new System.EventHandler(this.btnHotels_Click);
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlWelcome.Controls.Add(this.label6);
            this.pnlWelcome.Controls.Add(this.label5);
            this.pnlWelcome.Controls.Add(this.label3);
            this.pnlWelcome.Controls.Add(this.label2);
            this.pnlWelcome.Location = new System.Drawing.Point(232, 73);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(681, 443);
            this.pnlWelcome.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(677, 91);
            this.label6.TabIndex = 3;
            this.label6.Text = "*En las esquinas inferiores encontrará botones para regresar al inicio del aplica" +
    "tivo y para salir del aplicativo*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 55);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bienvenido";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(473, 91);
            this.label3.TabIndex = 1;
            this.label3.Text = "En el panel izquierdo encontrará todas las opciones que necesitará para administr" +
    "ar sus hoteles y reservas.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Inicio sesión como Agente de Viajes";
            // 
            // pnlHotels
            // 
            this.pnlHotels.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlHotels.Controls.Add(this.btnAdd);
            this.pnlHotels.Controls.Add(this.label4);
            this.pnlHotels.Controls.Add(this.DGHotels);
            this.pnlHotels.Location = new System.Drawing.Point(230, 76);
            this.pnlHotels.Name = "pnlHotels";
            this.pnlHotels.Size = new System.Drawing.Size(680, 440);
            this.pnlHotels.TabIndex = 3;
            this.pnlHotels.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(509, 160);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 39);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 55);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hoteles";
            // 
            // DGHotels
            // 
            this.DGHotels.AllowUserToAddRows = false;
            this.DGHotels.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGHotels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGHotels.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGHotels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGHotels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGHotels.ColumnHeadersHeight = 35;
            this.DGHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGHotels.GridColor = System.Drawing.SystemColors.Control;
            this.DGHotels.Location = new System.Drawing.Point(31, 202);
            this.DGHotels.Margin = new System.Windows.Forms.Padding(0);
            this.DGHotels.Name = "DGHotels";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGHotels.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGHotels.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGHotels.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGHotels.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            this.DGHotels.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.RowTemplate.Height = 40;
            this.DGHotels.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGHotels.Size = new System.Drawing.Size(618, 216);
            this.DGHotels.TabIndex = 0;
            this.DGHotels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGHotels_CellClick);
            this.DGHotels.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(872, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(99, 27);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "#Hora#";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 44);
            this.panel1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(204, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(111, 27);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "#Name#";
            // 
            // pnlBookings
            // 
            this.pnlBookings.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBookings.Controls.Add(this.label7);
            this.pnlBookings.Controls.Add(this.DGBookings);
            this.pnlBookings.Location = new System.Drawing.Point(227, 79);
            this.pnlBookings.Name = "pnlBookings";
            this.pnlBookings.Size = new System.Drawing.Size(680, 440);
            this.pnlBookings.TabIndex = 4;
            this.pnlBookings.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 55);
            this.label7.TabIndex = 1;
            this.label7.Text = "Reservas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DGBookings
            // 
            this.DGBookings.AllowUserToAddRows = false;
            this.DGBookings.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGBookings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DGBookings.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DGBookings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGBookings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGBookings.ColumnHeadersHeight = 35;
            this.DGBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ver});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGBookings.GridColor = System.Drawing.SystemColors.Control;
            this.DGBookings.Location = new System.Drawing.Point(27, 202);
            this.DGBookings.Margin = new System.Windows.Forms.Padding(0);
            this.DGBookings.Name = "DGBookings";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGBookings.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGBookings.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGBookings.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGBookings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(177)))), ((int)(((byte)(210)))));
            this.DGBookings.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.RowTemplate.Height = 40;
            this.DGBookings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGBookings.Size = new System.Drawing.Size(626, 216);
            this.DGBookings.TabIndex = 0;
            this.DGBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBookings_CellClick);
            this.DGBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGBookings_CellContentClick);
            this.DGBookings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Administracion_Hotelera.Properties.Resources.edit;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Ver";
            this.dataGridViewImageColumn3.Image = global::Administracion_Hotelera.Properties.Resources.see;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // imgExit
            // 
            this.imgExit.AccessibleDescription = "Exit";
            this.imgExit.BackColor = System.Drawing.Color.Transparent;
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Image = global::Administracion_Hotelera.Properties.Resources.exit;
            this.imgExit.Location = new System.Drawing.Point(900, 496);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(40, 40);
            this.imgExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgExit.TabIndex = 9;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.imgExit_Click);
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Image = global::Administracion_Hotelera.Properties.Resources.see;
            this.Ver.MinimumWidth = 6;
            this.Ver.Name = "Ver";
            this.Ver.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Administracion_Hotelera.Properties.Resources.edit;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Administracion_Hotelera.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(23, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 539);
            this.Controls.Add(this.imgExit);
            this.Controls.Add(this.pnlBookings);
            this.Controls.Add(this.pnlHotels);
            this.Controls.Add(this.pnlWelcome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Hoteles";
            this.panel2.ResumeLayout(false);
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            this.pnlHotels.ResumeLayout(false);
            this.pnlHotels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGHotels)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBookings.ResumeLayout(false);
            this.pnlBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHotels;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnlHotels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox imgExit;
        private DataGridViewImageColumn Editar;
        private DataGridView DGHotels;
        private Panel pnlBookings;
        private Label label7;
        private DataGridView DGBookings;
        private DataGridViewImageColumn Ver;
        private DataGridViewImageColumn dataGridViewImageColumn3;
    }
}