using PdfLibCore;
using RuFramework.Config;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Globalization;
using System.Text.Json;

namespace TextToDigitalCode
{
    public partial class HarvestDesigner : Form
    {
        #region Global Variables
        private Point selectionStartPoint;
        private Rectangle selectionRectangle;
        AppSettings appSettings = new AppSettings();
        float escalaRender;
        #endregion
        public HarvestDesigner()
        {
            InitializeComponent();
            InitializePictureBoxEvents();
            appSettings = ConfigManager.Read(); // default Roaming
        }

        #region Buttons
        private void loadPDF_Click(object sender, EventArgs e)

        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf"
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                RenderPdfToPictureBox(dlg.FileName);
                txtRuta.Text = dlg.FileName; // Opcional: mostrar la ruta del archivo seleccionado
            }

        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (pdfOrigenImage.Image == null || selectionRectangle.Width <= 0 || selectionRectangle.Height <= 0) return;
            if (string.IsNullOrEmpty(tipoDoctxt.Text) || string.IsNullOrEmpty(campotxt.Text))
            {
                MessageBox.Show("Rellene los campos...");
                return;
            }
            Rectangle adjustedRect = GetAdjustedRectangle(selectionRectangle, pdfOrigenImage.Image, pdfOrigenImage);
            string rectangleFolder = Path.Combine(appSettings.MyPath, tipoDoctxt.Text.Trim() + ".json");
            RectangleDataModel rectangleData = new RectangleDataModel(adjustedRect, tipoDoctxt.Text, campotxt.Text, escalaRender);
            SaveRectangleData(rectangleData, rectangleFolder);
        }
        private void nuevoPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {

            loadPDF_Click(sender, e);

        }
        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            loadPDF_Click(sender, e);
        }

        private void opcionexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppSettingsDialog appSettingsDialog = new AppSettingsDialog(appSettings); // default Roaming
            appSettingsDialog.propertyGrid.SelectedObject = appSettings;
            appSettingsDialog.ShowDialog();
            appSettings = appSettingsDialog.AppSettingsOk;

            // Property is changed in the program, you must save
            ChangeAppSettings();
        }
        #endregion

        #region RectangleMaker
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectionStartPoint = e.Location;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            UpdateSelectionRectangle(e);
            UpdateSelectionLabels();
            pdfOrigenImage.Invalidate();
        }
        private void UpdateSelectionRectangle(MouseEventArgs e)
        {
            int x = Math.Min(selectionStartPoint.X, e.X);
            int y = Math.Min(selectionStartPoint.Y, e.Y);
            int width = Math.Abs(selectionStartPoint.X - e.X);
            int height = Math.Abs(selectionStartPoint.Y - e.Y);
            selectionRectangle = new Rectangle(x, y, width, height);
        }

        private void UpdateSelectionLabels()
        {
            labelWidth.Text = $"Width: {selectionRectangle.Width}";
            labelHeight.Text = $"Height: {selectionRectangle.Height}";
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (selectionRectangle.Width > 0 && selectionRectangle.Height > 0)
            {
                e.Graphics.DrawRectangle(Pens.Red, selectionRectangle);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"X: {selectionRectangle.X}, Y: {selectionRectangle.Y}, Width: {selectionRectangle.Width}, Height: {selectionRectangle.Height}");
        }
        private void InitializePictureBoxEvents()
        {
            pdfOrigenImage.Paint += pictureBox_Paint;
            pdfOrigenImage.MouseDown += pictureBox_MouseDown;
            pdfOrigenImage.MouseMove += pictureBox_MouseMove;
            pdfOrigenImage.MouseUp += pictureBox_MouseUp;

        }

        #endregion

        #region ImageRender
        private void RenderPdfToPictureBox(string pdfFilePath)
        {
            var pdfDocument = new PdfDocument(pdfFilePath);
            var pdfPage = pdfDocument.Pages[0];
            var scale = CalculateScale(pdfPage);
            escalaRender = scale;
            var renderWidth = (int)(scale * pdfPage.Width);
            var renderHeight = (int)(scale * pdfPage.Height);

            using (var pdfiumBitmap = new PdfiumBitmap(renderWidth, renderHeight, true))
            {
                pdfPage.Render(pdfiumBitmap);
                var bitmap = ConvertToBitmap(pdfiumBitmap);
                DisplayBitmap(bitmap);
            }
        }

        private float CalculateScale(PdfPage pdfPage)
        {
            // Usar una escala fija o configurable en lugar de basarse en ClientSize
            float escala = float.Parse(appSettings.scale);
            float scale = escala; // Ejemplo de una escala fija
                                  // Podrías hacer esta escala configurable desde la configuración de la aplicación
            return scale;
        }



        private Bitmap ConvertToBitmap(PdfiumBitmap pdfiumBitmap)
        {
            return new Bitmap(pdfiumBitmap.Width, pdfiumBitmap.Height, pdfiumBitmap.Stride, PixelFormat.Format32bppArgb, pdfiumBitmap.Scan0);
        }

        private void DisplayBitmap(Bitmap bitmap)
        {
            string tempFilePath = Path.GetTempFileName();
            bitmap.Save(tempFilePath, ImageFormat.Png);
            pdfOrigenImage.Image = Image.FromFile(tempFilePath);
        }
        #endregion

        #region CropRectangle
        private void Visualize_Click(object sender, EventArgs e)
        {
            Rectangle adjustedRect = GetAdjustedRectangle(selectionRectangle, pdfOrigenImage.Image, pdfOrigenImage);
            Image croppedImage = CropImage(pdfOrigenImage.Image, adjustedRect);
            this.croppedImage.Image = croppedImage;
        }

        private Image CropImage(Image image, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(image);
            Bitmap croppedImage = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return croppedImage;
        }
        public void SaveRectangleData(RectangleDataModel data, string filePath)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(data, options);
                File.WriteAllText(filePath, jsonString);
                MessageBox.Show("Archivo guardado con éxito");
                campotxt.Text = "";
                tipoDoctxt.Text = "";
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al guardar el archivo... " + e);
                throw;
            }
        }


        private Rectangle GetAdjustedRectangle(Rectangle selectionRect, Image image, PictureBox pictureBox)
        {
            // Calcula la escala y el desplazamiento de la imagen en el PictureBox
            float imageRatio = (float)image.Width / image.Height;
            float containerRatio = (float)pictureBox.Width / pictureBox.Height;
            float scaleX, scaleY, offsetX, offsetY;

            if (imageRatio > containerRatio)
            {
                // La imagen se ajusta a la anchura del PictureBox
                scaleX = scaleY = (float)pictureBox.Width / image.Width;
                offsetX = 0;
                offsetY = (pictureBox.Height - image.Height * scaleY) / 2;
            }
            else
            {
                // La imagen se ajusta a la altura del PictureBox
                scaleX = scaleY = (float)pictureBox.Height / image.Height;
                offsetX = (pictureBox.Width - image.Width * scaleX) / 2;
                offsetY = 0;
            }

            // Ajusta las coordenadas y dimensiones de la selección
            int adjustedX = (int)((selectionRect.X - offsetX) / scaleX);
            int adjustedY = (int)((selectionRect.Y - offsetY) / scaleY);
            int adjustedWidth = (int)(selectionRect.Width / scaleX);
            int adjustedHeight = (int)(selectionRect.Height / scaleY);

            return new Rectangle(adjustedX, adjustedY, adjustedWidth, adjustedHeight);
        }
        #endregion

        #region ToolBarSettings
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
        private void monitoreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenOrBringToFront(typeof(Monitor));
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
                //  newForm.MdiParent = this; // Si estás usando MDI, establece el formulario padre
                newForm.Show();
            }
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

        #endregion
    }
}
