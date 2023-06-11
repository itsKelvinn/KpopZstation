using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZstation.Validator
{
    public class AlbumValidator
    {
        static string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".jfif" };
        static int maxFileSize = 2 * 1024 * 1024;

        public static bool albumNameValidate(string AlbumName)
        {
            if(AlbumName.Length > 50 || AlbumName.Equals(""))
            {
                return true;
            }
            return false;
        } 

        public static bool albumDescValidate(string AlbumDesc)
        {
            if(AlbumDesc.Length > 255 || AlbumDesc.Equals(""))
            {
                return true;
            }
            return false;   
        }

        public static bool albumPriceValidate(int AlbumPrice)
        {
            if(AlbumPrice > 1000000 || AlbumPrice < 100000)
            {
                return true;
            }
            return false;   
        }

        public static bool albumStockValidate(int AlbumStock)
        {
            if(AlbumStock == 0)
            {
                return true;
            }
            return false;   
        }

        public static bool albumImageValidate(string AlbumImage, int ImageSize)
        {
            bool isExtensionAllowed = allowedExtensions.Any(ext => AlbumImage.EndsWith(ext, StringComparison.OrdinalIgnoreCase));
            if (!isExtensionAllowed || ImageSize > maxFileSize)
            {
                return true;
            }
            return false;
        }

    }
}