using KpopZstation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class AlbumController
    {
        public static bool AddAlbum(int ArtistID,string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDesc)
        {
            return AddAlbumArtistHandler.handle(ArtistID , AlbumName, AlbumImage, AlbumPrice, AlbumStock , AlbumDesc); 
        }
    }
}