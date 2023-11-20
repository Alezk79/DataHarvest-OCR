namespace TextToDigitalCode
{
    partial class HarvestDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarvestDesigner));
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pdfOrigenImage = new PictureBox();
            panel2 = new Panel();
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(739, 444);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pdfOrigenImage);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 418);
            panel1.TabIndex = 6;
            // 
            // pdfOrigenImage
            // 
            pdfOrigenImage.Dock = DockStyle.Fill;
            pdfOrigenImage.Location = new Point(0, 0);
            pdfOrigenImage.Name = "pdfOrigenImage";
            pdfOrigenImage.Size = new Size(363, 418);
            pdfOrigenImage.SizeMode = PictureBoxSizeMode.Zoom;
            pdfOrigenImage.TabIndex = 2;
            pdfOrigenImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.ActiveCaption;
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
            panel2.Location = new Point(372, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(364, 418);
            panel2.TabIndex = 7;
            // 
            // campoLabel
            // 
            campoLabel.AutoSize = true;
            campoLabel.Location = new Point(3, 154);
            campoLabel.Name = "campoLabel";
            campoLabel.Size = new Size(70, 15);
            campoLabel.TabIndex = 12;
            campoLabel.Text = "Field Name:";
            // 
            // campotxt
            // 
            campotxt.AccessibleName = "";
            campotxt.Location = new Point(105, 151);
            campotxt.Name = "campotxt";
            campotxt.Size = new Size(183, 23);
            campotxt.TabIndex = 11;
            campotxt.Tag = "";
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(3, 125);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(90, 15);
            labelTipo.TabIndex = 10;
            labelTipo.Text = "Template Name";
            // 
            // tipoDoctxt
            // 
            tipoDoctxt.AccessibleName = "";
            tipoDoctxt.Location = new Point(124, 122);
            tipoDoctxt.Name = "tipoDoctxt";
            tipoDoctxt.Size = new Size(183, 23);
            tipoDoctxt.TabIndex = 9;
            tipoDoctxt.Tag = "";
            // 
            // croppedImage
            // 
            croppedImage.Dock = DockStyle.Bottom;
            croppedImage.Location = new Point(0, 198);
            croppedImage.Name = "croppedImage";
            croppedImage.Size = new Size(364, 220);
            croppedImage.TabIndex = 0;
            croppedImage.TabStop = false;
            // 
            // labelWidth
            // 
            labelWidth.AutoSize = true;
            labelWidth.Location = new Point(0, 0);
            labelWidth.Name = "labelWidth";
            labelWidth.Size = new Size(111, 15);
            labelWidth.TabIndex = 3;
            labelWidth.Text = "Anchura del recorte";
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Location = new Point(144, 0);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(98, 15);
            labelHeight.TabIndex = 4;
            labelHeight.Text = "Altura del recorte";
            // 
            // Visualize
            // 
            Visualize.Location = new Point(89, 41);
            Visualize.Name = "Visualize";
            Visualize.Size = new Size(75, 23);
            Visualize.TabIndex = 8;
            Visualize.Text = "View";
            Visualize.UseVisualStyleBackColor = true;
            Visualize.Click += Visualize_Click;
            // 
            // txtRuta
            // 
            txtRuta.AutoSize = true;
            txtRuta.Location = new Point(3, 104);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(101, 15);
            txtRuta.TabIndex = 1;
            txtRuta.Text = "None file selected";
            // 
            // Save
            // 
            Save.Location = new Point(3, 175);
            Save.Name = "Save";
            Save.Size = new Size(96, 23);
            Save.TabIndex = 5;
            Save.Text = "Save Template";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // loadPDF
            // 
            loadPDF.Location = new Point(0, 41);
            loadPDF.Name = "loadPDF";
            loadPDF.Size = new Size(75, 23);
            loadPDF.TabIndex = 0;
            loadPDF.Text = "UploadPDF";
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
            toolStrip1.Size = new Size(739, 27);
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
            toolStripDropDownButton1.Size = new Size(33, 24);
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
            monitoreoToolStripMenuItem.Click += monitoreoToolStripMenuItem_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(24, 24);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // guardarToolStripButton
            // 
            guardarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            guardarToolStripButton.Image = (Image)resources.GetObject("guardarToolStripButton.Image");
            guardarToolStripButton.ImageTransparentColor = Color.Magenta;
            guardarToolStripButton.Name = "guardarToolStripButton";
            guardarToolStripButton.Size = new Size(24, 24);
            guardarToolStripButton.Text = "&Guardar";
            // 
            // imprimirToolStripButton
            // 
            imprimirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            imprimirToolStripButton.Image = (Image)resources.GetObject("imprimirToolStripButton.Image");
            imprimirToolStripButton.ImageTransparentColor = Color.Magenta;
            imprimirToolStripButton.Name = "imprimirToolStripButton";
            imprimirToolStripButton.Size = new Size(24, 24);
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
            cortarToolStripButton.Size = new Size(24, 24);
            cortarToolStripButton.Text = "&Cortar";
            // 
            // copiarToolStripButton
            // 
            copiarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copiarToolStripButton.Image = (Image)resources.GetObject("copiarToolStripButton.Image");
            copiarToolStripButton.ImageTransparentColor = Color.Magenta;
            copiarToolStripButton.Name = "copiarToolStripButton";
            copiarToolStripButton.Size = new Size(24, 24);
            copiarToolStripButton.Text = "&Copiar";
            // 
            // pegarToolStripButton
            // 
            pegarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pegarToolStripButton.Image = (Image)resources.GetObject("pegarToolStripButton.Image");
            pegarToolStripButton.ImageTransparentColor = Color.Magenta;
            pegarToolStripButton.Name = "pegarToolStripButton";
            pegarToolStripButton.Size = new Size(24, 24);
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
            ayudaToolStripButton.Size = new Size(24, 24);
            ayudaToolStripButton.Text = "&Ayuda";
            // 
            // HarvestDesigner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(739, 444);
            Controls.Add(toolStrip1);
            Controls.Add(tableLayoutPanel1);
            IsMdiContainer = true;
            Name = "HarvestDesigner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HarvestDesigner";
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
    }
}