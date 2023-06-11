using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class UpdateAlbumHandler
    {
        public static bool handle(int AlbumID , int AlbumStock , int AlbumPrice , string AlbumName , string AlbumDesc , string AlbumImage)
        {
            return AlbumRepository.updateAlbum(AlbumID, AlbumName, AlbumDesc,AlbumImage,AlbumPrice,AlbumStock);
        }
    }
}