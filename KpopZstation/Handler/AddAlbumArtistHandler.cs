using KpopZstation.Factory;
using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AddAlbumArtistHandler
    {
        public static bool handle(int ArtistID ,string AlbumName, string AlbumImage, int AlbumPrice, int AlbumStock, string AlbumDesc)
        {
            Album album = AlbumFactory.createAlbum(ArtistID ,AlbumName, AlbumImage, AlbumPrice, AlbumStock, AlbumDesc);
            return AlbumRepository.AddAlbum(album);
        }
    }
}