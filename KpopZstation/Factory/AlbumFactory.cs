using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class AlbumFactory
    {
        public static Album createAlbum(int ArtistID ,string AlbumName,string AlbumImage,int AlbumPrice,int AlbumStock,string AlbumDesc)
        {
            Album album = new Album();
            album.ArtistID = ArtistID;
            album.AlbumName = AlbumName;
            album.AlbumImage = AlbumImage;
            album.AlbumPrice = AlbumPrice;
            album.AlbumStock = AlbumStock;
            album.AlbumDescription = AlbumDesc;
            return album;
        }
    }
}