using RuFramework.Config;
using Tesseract;
namespace TextToDigitalCode
{
    public class DataExtractor
    {

        public static string ExtractData(Image imagen, string tipo, string nombre)
        {
            AppSettings config = new AppSettings();
            config = ConfigManager.Read();

            string imagenFilePath = GuardarBitmapEnArchivoTemporal(imagen);
            string newDate = DateTime.Now.Day+DateTime.Now.Month+DateTime.Now.Year+DateTime.Now.Minute+DateTime.Now.Second.ToString();
            string outputFilePath = config.OutputPath +tipo.Trim()+ nombre.Trim()+newDate+ ".png";
            string codigo;
            // Configurar el motor de OCR con el idioma deseado (por ejemplo, "spa" para español)
            using (var engine = new TesseractEngine(@".\tessdata", "spa", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyzáéíóú");

                // Iterar sobre todas las rutas de las imágenes
                // Cargar la imagen desde la ruta especificada
                using (var imagenn = imagen)
                {
                    // Cargar la imagen en un objeto Pix de Tesseract
                    using (var img = Pix.LoadFromFile(imagenFilePath))
                    {
                        // Realizar OCR en la imagen y obtener el texto reconocido
                        using (var pagina = engine.Process(img))
                        {
                            // Escribir el texto reconocido en el archivo de salida
                            codigo = pagina.GetText();
                            QRCoder.BuildQR(codigo, outputFilePath);
                        }
                    }
                }
            }
            return codigo;
        }
        private static string GuardarBitmapEnArchivoTemporal(Image imagen)
        {
            // Obtener un nombre de archivo temporal
            string tempFilePath = Path.GetTempFileName();

            // Cambiar la extensión a .png (opcional, pero recomendado para imágenes)
            tempFilePath = Path.ChangeExtension(tempFilePath, ".png");

            // Guardar el bitmap en el archivo temporal
            imagen.Save(tempFilePath, System.Drawing.Imaging.ImageFormat.Png);

            return tempFilePath;
        }

    }
}
