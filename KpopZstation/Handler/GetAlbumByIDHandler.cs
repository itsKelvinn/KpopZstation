using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetAlbumByIDHandler
    {
        public static Album handle(int AlbumID)
        {
            return AlbumRepository.findAlbum(AlbumID);
        }
    }
}