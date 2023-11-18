﻿using QRCoder;
using RuFramework.Config;

namespace TextToDigitalCode
{
    public class QRCoder
    {
        AppSettings config = new AppSettings();
        public static Bitmap GenerarQR(string datos, string path)
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

    }
}