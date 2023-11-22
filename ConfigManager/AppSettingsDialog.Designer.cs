
namespace RuFramework.Config
{
    partial class AppSettingsDialog
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
            propertyGrid = new PropertyGrid();
            menuStrip = new MenuStrip();
            toolStripMenuItemOK = new ToolStripMenuItem();
            toolStripMenuItemCancel = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // propertyGrid
            // 
            propertyGrid.Dock = DockStyle.Fill;
            propertyGrid.Location = new Point(0, 24);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(800, 426);
            propertyGrid.TabIndex = 0;
            propertyGrid.Click += propertyGrid_Click;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemOK, toolStripMenuItemCancel });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(800, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            menuStrip.ItemClicked += menuStrip_ItemClicked;
            // 
            // toolStripMenuItemOK
            // 
            toolStripMenuItemOK.Name = "toolStripMenuItemOK";
            toolStripMenuItemOK.Size = new Size(34, 20);
            toolStripMenuItemOK.Text = "Ok";
            toolStripMenuItemOK.Click += toolStripMenuItemOK_Click;
            // 
            // toolStripMenuItemCancel
            // 
            toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            toolStripMenuItemCancel.Size = new Size(55, 20);
            toolStripMenuItemCancel.Text = "Cancel";
            toolStripMenuItemCancel.Click += toolStripMenuItemCancel_Click;
            // 
            // AppSettingsDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(propertyGrid);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "AppSettingsDialog";
            Text = "AppSettingsDialog";
            FormClosed += AppSettingsDialog_FormClosed;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolStripMenuItemOK;
        private ToolStripMenuItem toolStripMenuItemCancel;
        public PropertyGrid propertyGrid;
    }
}