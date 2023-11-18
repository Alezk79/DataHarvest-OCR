namespace TextToDigitalCode
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pdfOrigenImage = new PictureBox();
            panel2 = new Panel();
            lbl_scale = new Label();
            campoLabel = new Label();
            campotxt = new TextBox();
            labelTipo = new Label();
            tipoDoctxt = new TextBox();
            croppedImage = new PictureBox();
            labelWidth = new Label();
            labelHeight = new Label();
            Visualize = new Button();
            txtRuta = new Label();
            Save = new Button();
            loadPDF = new Button();
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
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pdfOrigenImage).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)croppedImage).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(845, 592);
            tableLayoutPanel1.TabIndex = 9;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pdfOrigenImage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 557);
            panel1.TabIndex = 6;
            // 
            // pdfOrigenImage
            // 
            pdfOrigenImage.Dock = DockStyle.Fill;
            pdfOrigenImage.Location = new Point(0, 0);
            pdfOrigenImage.Margin = new Padding(3, 4, 3, 4);
            pdfOrigenImage.Name = "pdfOrigenImage";
            pdfOrigenImage.Size = new Size(416, 557);
            pdfOrigenImage.SizeMode = PictureBoxSizeMode.Zoom;
            pdfOrigenImage.TabIndex = 2;
            pdfOrigenImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbl_scale);
            panel2.Controls.Add(campoLabel);
            panel2.Controls.Add(campotxt);
            panel2.Controls.Add(labelTipo);
            panel2.Controls.Add(tipoDoctxt);
            panel2.Controls.Add(croppedImage);
            panel2.Controls.Add(labelWidth);
            panel2.Controls.Add(labelHeight);
            panel2.Controls.Add(Visualize);
            panel2.Controls.Add(txtRuta);
            panel2.Controls.Add(Save);
            panel2.Controls.Add(loadPDF);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(425, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 557);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // lbl_scale
            // 
            lbl_scale.AutoSize = true;
            lbl_scale.Location = new Point(-2, 25);
            lbl_scale.Name = "lbl_scale";
            lbl_scale.Size = new Size(50, 20);
            lbl_scale.TabIndex = 13;
            lbl_scale.Text = "Escala";
            // 
            // campoLabel
            // 
            campoLabel.AutoSize = true;
            campoLabel.Location = new Point(3, 205);
            campoLabel.Name = "campoLabel";
            campoLabel.Size = new Size(119, 20);
            campoLabel.TabIndex = 12;
            campoLabel.Text = "Nombre Campo:";
            // 
            // campotxt
            // 
            campotxt.AccessibleName = "";
            campotxt.Location = new Point(120, 201);
            campotxt.Margin = new Padding(3, 4, 3, 4);
            campotxt.Name = "campotxt";
            campotxt.Size = new Size(209, 27);
            campotxt.TabIndex = 11;
            campotxt.Tag = "";
            campotxt.TextChanged += textBox1_TextChanged;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(3, 167);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(145, 20);
            labelTipo.TabIndex = 10;
            labelTipo.Text = "Tipo de Documento:";
            // 
            // tipoDoctxt
            // 
            tipoDoctxt.AccessibleName = "";
            tipoDoctxt.Location = new Point(142, 163);
            tipoDoctxt.Margin = new Padding(3, 4, 3, 4);
            tipoDoctxt.Name = "tipoDoctxt";
            tipoDoctxt.Size = new Size(209, 27);
            tipoDoctxt.TabIndex = 9;
            tipoDoctxt.Tag = "";
            tipoDoctxt.TextChanged += tipoDoctxt_TextChanged;
            // 
            // croppedImage
            // 
            croppedImage.Dock = DockStyle.Bottom;
            croppedImage.Location = new Point(0, 264);
            croppedImage.Margin = new Padding(3, 4, 3, 4);
            croppedImage.Name = "croppedImage";
            croppedImage.Size = new Size(417, 293);
            croppedImage.TabIndex = 0;
            croppedImage.TabStop = false;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(0, 0);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(139, 20);
            labelWidth.TabIndex = 3;
            labelWidth.Text = "Anchura del recorte";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(165, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(125, 20);
            labelHeight.TabIndex = 4;
            labelHeight.Text = "Altura del recorte";
            // 
            // Visualize
            // 
            Visualize.Location = new Point(102, 55);
            Visualize.Margin = new Padding(3, 4, 3, 4);
            Visualize.Name = "Visualize";
            Visualize.Size = new Size(86, 31);
            Visualize.TabIndex = 8;
            Visualize.Text = "Visualizar";
            Visualize.UseVisualStyleBackColor = true;
            Visualize.Click += Visualize_Click;
            // 
            // txtRuta
            // 
            txtRuta.AutoSize = true;
            txtRuta.Location = new Point(3, 139);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(200, 20);
            txtRuta.TabIndex = 1;
            txtRuta.Text = "Ningun archivo seleccionado";
            // 
            // Save
            // 
            Save.Location = new Point(3, 233);
            Save.Margin = new Padding(3, 4, 3, 4);
            Save.Name = "Save";
            Save.Size = new Size(86, 31);
            Save.TabIndex = 5;
            Save.Text = "Guardar";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // loadPDF
            // 
            loadPDF.Location = new Point(0, 55);
            loadPDF.Margin = new Padding(3, 4, 3, 4);
            loadPDF.Name = "loadPDF";
            loadPDF.Size = new Size(86, 31);
            loadPDF.TabIndex = 0;
            loadPDF.Text = "Subir PDF";
            loadPDF.UseVisualStyleBackColor = true;
            loadPDF.Click += loadPDF_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ControlLight;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, abrirToolStripButton, guardarToolStripButton, imprimirToolStripButton, toolStripSeparator, cortarToolStripButton, copiarToolStripButton, pegarToolStripButton, toolStripSeparator1, ayudaToolStripButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(845, 27);
            toolStrip1.TabIndex = 11;
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
            toolStripDropDownButton1.Size = new Size(34, 24);
            // 
            // nuevoPdfToolStripMenuItem
            // 
            nuevoPdfToolStripMenuItem.Name = "nuevoPdfToolStripMenuItem";
            nuevoPdfToolStripMenuItem.Size = new Size(273, 26);
            nuevoPdfToolStripMenuItem.Text = "Subir PDF";
            nuevoPdfToolStripMenuItem.Click += nuevoPdfToolStripMenuItem_Click;
            // 
            // opcionexToolStripMenuItem
            // 
            opcionexToolStripMenuItem.Name = "opcionexToolStripMenuItem";
            opcionexToolStripMenuItem.Size = new Size(273, 26);
            opcionexToolStripMenuItem.Text = "Opciones";
            opcionexToolStripMenuItem.Click += opcionexToolStripMenuItem_Click;
            // 
            // verArchivosDeRectangulosToolStripMenuItem
            // 
            verArchivosDeRectangulosToolStripMenuItem.Name = "verArchivosDeRectangulosToolStripMenuItem";
            verArchivosDeRectangulosToolStripMenuItem.Size = new Size(273, 26);
            verArchivosDeRectangulosToolStripMenuItem.Text = "Ver archivos de rectangulos";
            verArchivosDeRectangulosToolStripMenuItem.Click += verArchivosDeRectangulosToolStripMenuItem_Click;
            // 
            // monitoreoToolStripMenuItem
            // 
            monitoreoToolStripMenuItem.Name = "monitoreoToolStripMenuItem";
            monitoreoToolStripMenuItem.Size = new Size(273, 26);
            monitoreoToolStripMenuItem.Text = "Monitoreo";
            monitoreoToolStripMenuItem.Click += monitoreoToolStripMenuItem_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(29, 24);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // guardarToolStripButton
            // 
            guardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            guardarToolStripButton.Image = (Image)resources.GetObject("guardarToolStripButton.Image");
            guardarToolStripButton.ImageTransparentColor = Color.Magenta;
            guardarToolStripButton.Name = "guardarToolStripButton";
            guardarToolStripButton.Size = new Size(29, 24);
            guardarToolStripButton.Text = "&Guardar";
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(29, 24);
            imprimirToolStripButton.Text = "&Imprimir";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 27);
            // 
            // cortarToolStripButton
            // 
            cortarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cortarToolStripButton.Image = (Image)resources.GetObject("cortarToolStripButton.Image");
            cortarToolStripButton.ImageTransparentColor = Color.Magenta;
            cortarToolStripButton.Name = "cortarToolStripButton";
            cortarToolStripButton.Size = new Size(29, 24);
            cortarToolStripButton.Text = "&Cortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(29, 24);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            pegarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pegarToolStripButton.Image = (Image)resources.GetObject("pegarToolStripButton.Image");
            pegarToolStripButton.ImageTransparentColor = Color.Magenta;
            pegarToolStripButton.Name = "pegarToolStripButton";
            pegarToolStripButton.Size = new Size(29, 24);
            pegarToolStripButton.Text = "&Pegar";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // ayudaToolStripButton
            // 
            ayudaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ayudaToolStripButton.Image = (Image)resources.GetObject("ayudaToolStripButton.Image");
            ayudaToolStripButton.ImageTransparentColor = Color.Magenta;
            ayudaToolStripButton.Name = "ayudaToolStripButton";
            ayudaToolStripButton.Size = new Size(29, 24);
            ayudaToolStripButton.Text = "&Ayuda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(845, 592);
            Controls.Add(toolStrip1);
            Controls.Add(tableLayoutPanel1);
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pdfOrigenImage).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)croppedImage).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        public PictureBox pdfOrigenImage;
        private Panel panel2;
        private PictureBox croppedImage;
        private Label labelHeight;
        private Label labelWidth;
        private Button Visualize;
        private Label txtRuta;
        private Button Save;
        private Button loadPDF;
        private ToolStrip toolStrip1;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton guardarToolStripButton;
        private ToolStripButton imprimirToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cortarToolStripButton;
        private ToolStripButton copiarToolStripButton;
        private ToolStripButton pegarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ayudaToolStripButton;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem nuevoPdfToolStripMenuItem;
        private ToolStripMenuItem opcionexToolStripMenuItem;
        private Label labelTipo;
        private TextBox tipoDoctxt;
        private Label campoLabel;
        private TextBox campotxt;
        private ToolStripMenuItem verArchivosDeRectangulosToolStripMenuItem;
        private ToolStripMenuItem monitoreoToolStripMenuItem;
        private Label lbl_scale;
    }
}