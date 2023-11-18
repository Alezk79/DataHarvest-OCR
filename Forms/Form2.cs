using RuFramework.Config;
using System.ComponentModel;
using System.Diagnostics;

namespace TextToDigitalCode
{
    public partial class Form2 : Form
    {
        AppSettings appSettings = new AppSettings();
        public Form2()
        {
            InitializeComponent();
            appSettings = ConfigManager.Read();
        }

        private Form CheckIfFormIsOpen(Type formType)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.GetType() == formType)
                {
                    return openForm;
                }
            }
            return null;
        }
        private void OpenOrBringToFront(Type formType)
        {
            Form existingForm = CheckIfFormIsOpen(formType);
            if (existingForm != null)
            {
                // El formulario ya está abierto, lo traemos al frente
                existingForm.BringToFront();
            }
            else
            {
                // El formulario no está abierto, lo creamos y mostramos
                Form newForm = (Form)Activator.CreateInstance(formType);
                newForm.MdiParent = this; // Si estás usando MDI, establece el formulario padre
                newForm.Show();
            }
        }


        private void nuevoPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(typeof(Form1));
        }

        private void opcionexToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //AppSettingsDialog appSettingsDialog = new AppSettingsDialog(appSettings, AppDataPath.Roaming);
            AppSettingsDialog appSettingsDialog = new AppSettingsDialog(appSettings); // default Roaming
            appSettingsDialog.propertyGrid.SelectedObject = appSettings;
            appSettingsDialog.ShowDialog();
            appSettings = appSettingsDialog.AppSettingsOk;

            // Property is changed in the program, you must save
            ChangeAppSettings();
        }
        private void ChangeAppSettings()
        {
            // appSettings.MyString = "Property MyString changed";
            // ConfigManager.Save(appSettings, AppDataPath.Roaming);
            // or
            ConfigManager.Save(appSettings); // default Roaming
        }

        private void verArchivosDeRectangulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string folderPath = appSettings.MyPath;
            // Verifica si la carpeta existe
            if (System.IO.Directory.Exists(folderPath))
            {
                // Abre la carpeta usando el explorador de archivos
                Process.Start("explorer.exe", folderPath);
            }
            else
            {
                // Manejar el caso en que la carpeta no exista
                // Por ejemplo, mostrando un mensaje de error
                MessageBox.Show($"La carpeta no fue encontrada: {folderPath}", "Carpeta no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rectanguloJson_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string folderPath = appSettings.MyPath;
                       OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                InitialDirectory = folderPath
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                rectanguloJson.Text = dlg.FileName; // Opcional: mostrar la ruta del archivo seleccionado

            }
            try
            {
                RectangleDataModel rectanguloProporciones = LoadRectangleData(dlg.FileName);
                lbl_x.Text = rectanguloProporciones.X.ToString();
                lbl_y.Text = rectanguloProporciones.Y.ToString();
                lbl_height.Text = rectanguloProporciones.Height.ToString();
                lbl_width.Text = rectanguloProporciones.Width.ToString();
                lbl_doc.Text = rectanguloProporciones.DocumentType.ToString();
                lbl_campo.Text = rectanguloProporciones.FieldName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir el archivo.. " + ex.ToString());
                throw;
            }
        }
        public RectangleDataModel LoadRectangleData(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return RectangleDataModel.FromJson(jsonString);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            while (!backgroundWorker1.CancellationPending)
            {
                // Esperar X tiempo antes de la siguiente iteración
                int delay = 5000; // Retraso en milisegundos, ajusta según sea necesario

                System.Threading.Thread.Sleep(delay);
                UpdateLabelSafe("En Ejecución...");
                estadocolor.BackColor = Color.Green;
                // Tu lógica de procesamiento aquí
                MonitorearCarpeta.MonitorearFolder(appSettings.InputPath, rectanguloJson.Text);



                // Reportar progreso si es necesario
                backgroundWorker1.ReportProgress(0 /* porcentaje de progreso */);


            }

            // Si la cancelación fue solicitada, establecer e.Cancel a true
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
                estadocolor.BackColor = Color.Red;
                UpdateLabelSafe("Detenido");
            }

        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                estadocolor.BackColor = Color.Red;
                UpdateLabelSafe("Detenido");

            }
            else
            {
                UpdateLabelSafe("Completado");
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
            labelEstadoServicio.Text = "Iniciando...";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation)
                backgroundWorker1.CancelAsync();
            labelEstadoServicio.Text = "Deteniendo...";
        }
        private void UpdateLabelSafe(string text)
        {
            if (labelEstadoServicio.InvokeRequired)
            {
                labelEstadoServicio.Invoke(new Action(() => labelEstadoServicio.Text = text));
            }
            else
            {
                labelEstadoServicio.Text = text;
            }
        }

        private void labelEstadoServicio_Click(object sender, EventArgs e)
        {

        }
    }
}
