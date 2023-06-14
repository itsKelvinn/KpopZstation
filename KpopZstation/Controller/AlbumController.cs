using KpopZstation.Handler;
using KpopZstation.Model;
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

        public static bool removeAlbum(int AlbumID)
        {
            return RemoveAlbumHandler.handle(AlbumID);
        }

        public static Album findAlbum(int AlbumID)
        {
            return GetAlbumByIDHandler.handle(AlbumID);
        }

        public static bool updateAlbum(int AlbumID, int AlbumStock, int AlbumPrice, string AlbumName, string AlbumDesc, string AlbumImage)
        {
            return UpdateAlbumHandler.handle(AlbumID, AlbumStock, AlbumPrice, AlbumName, AlbumDesc, AlbumImage);
        }

        public static void purchaseAlbum(int AlbumID , int Quantity)
        {
            Album album = findAlbum(AlbumID);
            int updatedAlbumStock = album.AlbumStock - Quantity;
            updateAlbum(AlbumID,updatedAlbumStock, album.AlbumPrice, album.AlbumName,album.AlbumDescription, album.AlbumImage);
        }


    }
}