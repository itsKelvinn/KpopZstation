using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class CheckArtistHandler
    {
        public static bool handle(string ArtistName)
        {
            bool checkArtist = ArtistRepository.checkArtist(ArtistName);

            if (checkArtist)
            {
                return false;
            }

            return true;

        } 
    }
}