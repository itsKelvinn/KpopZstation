using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class RemoveAlbumHandler
    {
        public static bool handle(int AlbumID)
        {
            return AlbumRepository.removeAlbum(AlbumID);
        }
    }
}