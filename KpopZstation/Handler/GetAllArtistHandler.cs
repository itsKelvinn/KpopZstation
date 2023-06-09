using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetAllArtistHandler
    {
        public static List<Artist> handle()
        {
            return ArtistRepository.getAll();
        }
    }
}