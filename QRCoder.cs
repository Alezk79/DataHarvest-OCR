using QRCoder;
using RuFramework.Config;

namespace TextToDigitalCode
{
    public class QRCoder
    {
        AppSettings config = new AppSettings();
        public static Bitmap BuildQR(string datos, string path)
        {
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(datos, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    qrCodeImage.Save(path);
                }
                return qrCodeImage;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

    }
}
