using System.Drawing.Text;

namespace RuFramework.Config
{
    public partial class AppSettingsDialog : Form
    {
        string ConfigPath = null;
        public AppSettings AppSettingsOk = new AppSettings();

        private static AppSettingsDialog instance = null;


        public static AppSettingsDialog unic_window(AppSettings appSettings, AppDataPath appDataPath = AppDataPath.Roaming)
        {
            if (instance == null)
            {
                instance = new AppSettingsDialog(appSettings);
                return instance;
            }
            return instance;
        }
        /// <summary>
        /// Open the dialog with the Propertygrid.
        /// Select the Propertygrid on the config data.
        /// Remember the storage path of the config, default is Roaming.
        /// </summary>
        /// <param name="appSettings">The config data</param>
        /// <param name="configPath">The storage path of the config</param>
        public AppSettingsDialog(AppSettings appSettings, AppDataPath appDataPath = AppDataPath.Roaming)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            propertyGrid.SelectedObject = appSettings;
            ConfigPath = ConfigManager.GetAppDataPath(appDataPath);


        }

        /// <summary>
        /// The menu Ok/Cancel clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.ToString())
            {
                // The changed config data is saved
                case "Ok":
                    ConfigManager.Save((AppSettings)this.propertyGrid.SelectedObject, AppDataPath.Roaming);
                    break;
                // The changes are canceld
                case "Cancel":
                    break;
                default:
                    break;
            }
            this.Close();
        }
        /// <summary>
        /// The config is reread.
        /// For Ok, it's the changed data.
        /// At Cancel, the source data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppSettingsDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This data is returned
            AppSettingsOk = ConfigManager.Read(AppDataPath.Roaming);
        }

        private void toolStripMenuItemOK_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemCancel_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid_Click(object sender, EventArgs e)
        {

        }
    }
}
