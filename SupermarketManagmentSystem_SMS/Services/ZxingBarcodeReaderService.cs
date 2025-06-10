using System.Drawing;                           
using ZXing;                                    
using ZXing.Windows.Compatibility;              


namespace SupermarketManagmentSystem_SMS.Services
{
    public interface IBarcodeReaderService
    {
        /// <summary>
        /// Scans the bitmap for any barcode (1D or QR) and returns the text, or null if none found.
        /// </summary>
        string Decode(Bitmap image);
    }

    public class ZxingBarcodeReaderService : IBarcodeReaderService
    {
        private readonly BarcodeReader _reader;

        public ZxingBarcodeReaderService()
        {
        _reader = new BarcodeReader
        {
            AutoRotate = true,
            TryInverted = true,
            Options = new ZXing.Common.DecodingOptions
            {
                TryHarder = true,
                PossibleFormats = new[]
                {
                    BarcodeFormat.CODE_128,
                    BarcodeFormat.EAN_13,
                    BarcodeFormat.EAN_8,
                    BarcodeFormat.QR_CODE,
                }
            }
        };
        }
        public string Decode(Bitmap image)
        {
            var result = _reader.Decode(image);
            return result?.Text;
        }
    }
}
