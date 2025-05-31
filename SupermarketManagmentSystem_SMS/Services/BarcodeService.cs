using SupermarketManagmentSystem_SMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Common;
using ZXing;

//namespace SupermarketManagmentSystem_SMS.Services
//{
//    internal class BarcodeService
//    {
//        private readonly BarcodeWriter writer;
//        private readonly BarcodeReader reader;

//        public BarcodeService()
//        {
//            writer = new BarcodeWriter
//            {
//                Format = BarcodeFormat.CODE_128,
//                Options = new EncodingOptions
//                {
//                    Width = 300,
//                    Height = 100,
//                    Margin = 2,
//                    PureBarcode = false
//                }
//            };

//            reader = new BarcodeReader();
//        }

//        // Generate barcode image from string (e.g., Product ID)
//        public Bitmap GenerateBarcodeImage(string barcodeValue)
//        {
//            return writer.Write(barcodeValue);
//        }

//        // Decode barcode image to string
//        public string DecodeBarcodeFromImage(Bitmap image)
//        {
//            var result = reader.Decode(image);
//            return result?.Text;
//        }

//        // Auto-generate a barcode value for a new product
//        public string GenerateBarcodeValue(Product product)
//        {
//            // For example: CAT-000123
//            return $"{product.Category.?.ToUpper().Substring(0, 3)}-{product.ProductID:D6}";
//        }
//    }
//}
