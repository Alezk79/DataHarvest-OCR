namespace TextToDigitalCode
{
    partial class Monitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monitor));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            nuevoPdfToolStripMenuItem = new ToolStripMenuItem();
            opcionexToolStripMenuItem = new ToolStripMenuItem();
            verArchivosDeRectangulosToolStripMenuItem = new ToolStripMenuItem();
            monitoreoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripButton = new ToolStripButton();
            guardarToolStripButton = new ToolStripButton();
            imprimirToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            cortarToolStripButton = new ToolStripButton();
            copiarToolStripButton = new ToolStripButton();
            pegarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ayudaToolStripButton = new ToolStripButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            estadocolor = new Panel();
            labelEstadoServicio = new Label();
            label9 = new Label();
            cancelButton = new Button();
            startButton = new Button();
            rectanguloJson = new TextBox();
            label1 = new Label();
            LoadRectangleButton = new Button();
            Metadatos = new Panel();
            panel2 = new Panel();
            lbl_campo = new Label();
            lbl_doc = new Label();
            lbl_width = new Label();
            lbl_height = new Label();
            lbl_y = new Label();
            lbl_x = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            toolStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            Metadatos.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, abrirToolStripButton, guardarToolStripButton, imprimirToolStripButton, toolStripSeparator, cortarToolStripButton, copiarToolStripButton, pegarToolStripButton, toolStripSeparator1, ayudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(738, 25);
            toolStrip1.TabIndex = 12;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.BackColor = Color.Silver;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { nuevoPdfToolStripMenuItem, opcionexToolStripMenuItem, verArchivosDeRectangulosToolStripMenuItem, monitoreoToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            // 
            // nuevoPdfToolStripMenuItem
            // 
            nuevoPdfToolStripMenuItem.Name = "nuevoPdfToolStripMenuItem";
            nuevoPdfToolStripMenuItem.Size = new Size(218, 22);
            nuevoPdfToolStripMenuItem.Text = "Subir PDF";
            nuevoPdfToolStripMenuItem.Click += nuevoPdfToolStripMenuItem_Click;
            // 
            // opcionexToolStripMenuItem
            // 
            opcionexToolStripMenuItem.Name = "opcionexToolStripMenuItem";
            opcionexToolStripMenuItem.Size = new Size(218, 22);
            opcionexToolStripMenuItem.Text = "Opciones";
            opcionexToolStripMenuItem.Click += opcionexToolStripMenuItem_Click;
            // 
            // verArchivosDeRectangulosToolStripMenuItem
            // 
            verArchivosDeRectangulosToolStripMenuItem.Name = "verArchivosDeRectangulosToolStripMenuItem";
            verArchivosDeRectangulosToolStripMenuItem.Size = new Size(218, 22);
            verArchivosDeRectangulosToolStripMenuItem.Text = "Ver archivos de rectangulos";
            verArchivosDeRectangulosToolStripMenuItem.Click += verArchivosDeRectangulosToolStripMenuItem_Click;
            // 
            // monitoreoToolStripMenuItem
            // 
            monitoreoToolStripMenuItem.Name = "monitoreoToolStripMenuItem";
            monitoreoToolStripMenuItem.Size = new Size(218, 22);
            monitoreoToolStripMenuItem.Text = "Monitoreo";
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            // 
            // guardarToolStripButton
            // 
            guardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            guardarToolStripButton.Image = (Image)resources.GetObject("guardarToolStripButton.Image");
            guardarToolStripButton.ImageTransparentColor = Color.Magenta;
            guardarToolStripButton.Name = "guardarToolStripButton";
            guardarToolStripButton.Size = new Size(23, 22);
            guardarToolStripButton.Text = "&Guardar";
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(23, 22);
            imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // cortarToolStripButton
            // 
            cortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cortarToolStripButton.Image = (Image)resources.GetObject("cortarToolStripButton.Image");
            cortarToolStripButton.ImageTransparentColor = Color.Magenta;
            cortarToolStripButton.Name = "cortarToolStripButton";
            cortarToolStripButton.Size = new Size(23, 22);
            cortarToolStripButton.Text = "&Cortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(23, 22);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            pegarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pegarToolStripButton.Image = (Image)resources.GetObject("pegarToolStripButton.Image");
            pegarToolStripButton.ImageTransparentColor = Color.Magenta;
            pegarToolStripButton.Name = "pegarToolStripButton";
            pegarToolStripButton.Size = new Size(23, 22);
            pegarToolStripButton.Text = "&Pegar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ayudaToolStripButton
            // 
            ayudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ayudaToolStripButton.Image = (Image)resources.GetObject("ayudaToolStripButton.Image");
            ayudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ayudaToolStripButton.Name = "ayudaToolStripButton";
            ayudaToolStripButton.Size = new Size(23, 22);
            ayudaToolStripButton.Text = "&Ayuda";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.09214F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.90786F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(Metadatos, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(738, 425);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.Controls.Add(estadocolor);
            panel1.Controls.Add(labelEstadoServicio);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(startButton);
            panel1.Controls.Add(rectanguloJson);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(LoadRectangleButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 419);
            panel1.TabIndex = 0;
            // 
            // estadocolor
            // 
            estadocolor.BackColor = Color.Red;
            estadocolor.ForeColor = Color.Red;
            estadocolor.Location = new Point(117, 101);
            estadocolor.Name = "estadocolor";
            estadocolor.Size = new Size(10, 11);
            estadocolor.TabIndex = 7;
            // 
            // labelEstadoServicio
            // 
            labelEstadoServicio.AutoSize = true;
            labelEstadoServicio.Location = new Point(147, 98);
            labelEstadoServicio.Name = "labelEstadoServicio";
            labelEstadoServicio.Size = new Size(54, 15);
            labelEstadoServicio.TabIndex = 6;
            labelEstadoServicio.Text = "detenido";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(11, 99);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 5;
            label9.Text = "Estado Servicio: ";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(147, 178);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Detener";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(147, 130);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 3;
            startButton.Text = "Iniciar";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // rectanguloJson
            // 
            rectanguloJson.BackColor = SystemColors.Control;
            rectanguloJson.Enabled = false;
            rectanguloJson.Location = new Point(241, 32);
            rectanguloJson.Name = "rectanguloJson";
            rectanguloJson.ReadOnly = true;
            rectanguloJson.Size = new Size(189, 23);
            rectanguloJson.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar documento:";
            // 
            // LoadRectangleButton
            // 
            LoadRectangleButton.Location = new Point(147, 32);
            LoadRectangleButton.Name = "LoadRectangleButton";
            LoadRectangleButton.Size = new Size(75, 23);
            LoadRectangleButton.TabIndex = 0;
            LoadRectangleButton.Text = "Seleccionar";
            LoadRectangleButton.UseVisualStyleBackColor = true;
            LoadRectangleButton.Click += LoadRectangleButton_Click;
            // 
            // Metadatos
            // 
            Metadatos.BackColor = SystemColors.ControlLight;
            Metadatos.Controls.Add(panel2);
            Metadatos.Controls.Add(label2);
            Metadatos.Dock = DockStyle.Fill;
            Metadatos.Location = new Point(476, 3);
            Metadatos.Name = "Metadatos";
            Metadatos.Size = new Size(259, 419);
            Metadatos.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_campo);
            panel2.Controls.Add(lbl_doc);
            panel2.Controls.Add(lbl_width);
            panel2.Controls.Add(lbl_height);
            panel2.Controls.Add(lbl_y);
            panel2.Controls.Add(lbl_x);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(10, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 359);
            panel2.TabIndex = 1;
            // 
            // lbl_campo
            // 
            lbl_campo.AutoSize = true;
            lbl_campo.BackColor = SystemColors.ControlLight;
            lbl_campo.Location = new Point(58, 145);
            lbl_campo.Name = "lbl_campo";
            lbl_campo.Size = new Size(0, 15);
            lbl_campo.TabIndex = 11;
            // 
            // lbl_doc
            // 
            lbl_doc.AutoSize = true;
            lbl_doc.Location = new Point(108, 122);
            lbl_doc.Name = "lbl_doc";
            lbl_doc.Size = new Size(0, 15);
            lbl_doc.TabIndex = 10;
            // 
            // lbl_width
            // 
            lbl_width.AutoSize = true;
            lbl_width.Location = new Point(124, 63);
            lbl_width.Name = "lbl_width";
            lbl_width.Size = new Size(0, 15);
            lbl_width.TabIndex = 9;
            // 
            // lbl_height
            // 
            lbl_height.AutoSize = true;
            lbl_height.Location = new Point(124, 26);
            lbl_height.Name = "lbl_height";
            lbl_height.Size = new Size(0, 15);
            lbl_height.TabIndex = 8;
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new Point(29, 63);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(0, 15);
            lbl_y.TabIndex = 7;
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Location = new Point(27, 28);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(0, 15);
            lbl_x.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 145);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 5;
            label8.Text = "Campo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 120);
            label7.Name = "label7";
            label7.Size = new Size(103, 15);
            label7.TabIndex = 4;
            label7.Text = "Tipo Documento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(72, 63);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 3;
            label6.Text = "Width:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 27);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 2;
            label5.Text = "Height:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 63);
            label4.Name = "label4";
            label4.Size = new Size(16, 15);
            label4.TabIndex = 1;
            label4.Text = "y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 27);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 0;
            label3.Text = "x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 33);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Archivo";
            label2.Click += label2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Monitor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(738, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStrip1);
            ImeMode = ImeMode.Off;
            IsMdiContainer = true;
            Name = "Monitor";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Monitor";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Metadatos.ResumeLayout(false);
            Metadatos.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void txt_x_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem nuevoPdfToolStripMenuItem;
        private ToolStripMenuItem opcionexToolStripMenuItem;
        private ToolStripMenuItem verArchivosDeRectangulosToolStripMenuItem;
        private ToolStripMenuItem monitoreoToolStripMenuItem;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton guardarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton pegarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ayudaToolStripButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TextBox rectanguloJson;
        private Label label1;
        private Button LoadRectangleButton;
        private OpenFileDialog openFileDialog1;
        private Panel Metadatos;
        private Panel panel2;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label lbl_height;
        private Label lbl_y;
        private Label lbl_x;
        private Label lbl_campo;
        private Label lbl_doc;
        private Label lbl_width;
        private Button cancelButton;
        private Button startButton;
        private Label label9;
        private Label labelEstadoServicio;
        private Panel estadocolor;
    }
}