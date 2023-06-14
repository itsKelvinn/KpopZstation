using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class getArtistByNameHandler
    {
        public static Artist handle(string name)
        {
            return ArtistRepository.GetArtistByName(name);
        }
    }
}