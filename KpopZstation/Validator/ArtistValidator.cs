using KpopZstation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Validator
{
    public class ArtistValidator
    {
        static string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".jfif" };
        static int maxFileSize = 2 * 1024 * 1024;

        public static bool artistNameValidate(string ArtistName) 
        {
            if (ArtistName == null || ArtistName.Equals(""))
            {
                return true;
            }

            return CheckArtistHandler.handle(ArtistName);
        }


        public static bool artistFileValidate(string ArtistImage, int ArtistImageSize)
        {
            bool isExtensionAllowed = allowedExtensions.Any(ext => ArtistImage.EndsWith(ext, StringComparison.OrdinalIgnoreCase));
            if (isExtensionAllowed && ArtistImageSize < maxFileSize)
            {
                return false;
            }
            return true;
        }

    }
}