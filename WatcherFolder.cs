using PdfLibCore;
using System.Drawing.Imaging;

namespace TextToDigitalCode
{
    public class WatcherFolder
    {

        public static void WatchFolder(string path, string rectangleDataPath){

            if (!Directory.Exists(path))
            {
                Console.WriteLine("El directorio no existe.");
                return;
            }

            // Deserializar los datos del rectángulo
            RectangleDataModel rectangleData = LoadRectangleData(rectangleDataPath);

            // Obtener todos los archivos PDF en el directorio
            string[] pdfFiles = Directory.GetFiles(path, "*.pdf");

            foreach (var pdfFile in pdfFiles)
            {
                // Procesar cada archivo PDF
                ProcesarPDF(pdfFile, rectangleData);
                Thread.Sleep(1000);

                File.Delete(pdfFile);
            }
        }

        private static RectangleDataModel LoadRectangleData(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return RectangleDataModel.FromJson(jsonString);
        }
        private static void ProcesarPDF(string pdfFilePath, RectangleDataModel rectangleData)
        {
            var pdfDocument = new PdfDocument(pdfFilePath);
            var pdfPage = pdfDocument.Pages[0];

            int renderWidth = (int)(pdfPage.Width * rectangleData.Scale);
            int renderHeight = (int)(pdfPage.Height * rectangleData.Scale);

            using (var pdfiumBitmap = new PdfiumBitmap(renderWidth, renderHeight, true))
            {
                pdfPage.Render(pdfiumBitmap);
                var bitmap = ConvertToBitmap(pdfiumBitmap);

                // Ajustar el rectángulo con la escala almacenada
                Rectangle cropArea = new Rectangle(
                    (int)(rectangleData.X),
                    (int)(rectangleData.Y),
                    (int)(rectangleData.Width),
                    (int)(rectangleData.Height));

                var croppedImage = CropImage(bitmap, cropArea);

                string codigo = DataExtractor.ExtractData(croppedImage, rectangleData.DocumentType, rectangleData.FieldName);

        pdfDocument.Close();


            }
        }



        private static Bitmap ConvertToBitmap(PdfiumBitmap pdfiumBitmap)
        {
            return new Bitmap(pdfiumBitmap.Width, pdfiumBitmap.Height, pdfiumBitmap.Stride, PixelFormat.Format32bppArgb, pdfiumBitmap.Scan0);
        }


        private static Image CropImage(Image image, Rectangle cropArea)
        {
            // Asegurarse de que el área de recorte esté dentro de la imagen
            if (cropArea.X < 0 || cropArea.Y < 0 ||
                cropArea.Width <= 0 || cropArea.Height <= 0 ||
                cropArea.X + cropArea.Width > image.Width ||
                cropArea.Y + cropArea.Height > image.Height)
            {
                throw new ArgumentException("El área de recorte no es válida.");
            }

            Bitmap bmpImage = new Bitmap(image);
            Bitmap croppedImage = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return croppedImage;
        }


    }
}
