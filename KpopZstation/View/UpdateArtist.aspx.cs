using KpopZstation.Controller;
using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class UpdateArtist : System.Web.UI.Page
    {
        public static int arID;
        public static string arImage;
        public static string arName;
        

        readonly string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".jfif" };
        readonly int maxFileSize = 2 * 1024 * 1024;

        protected void Page_Load(object sender, EventArgs e)
        {

            Customer customer = AuthController.checkSession();
            arID = Convert.ToInt32(Request.QueryString["id"]);

            if(customer == null || customer.CustomerRole.Equals("User"))
            {
                Response.Redirect("Home.aspx");
            }

            Artist artist = ArtistController.getArtist(arID);

            arImage = artist.ArtistImage;
            arName = artist.ArtistName;

        }

        protected void UpdateArtistBtn(object sender, EventArgs e)
        {
            string ArtistName = nameTxtbox.Text.ToString();
            string ArtistImage = "/Asset/Artist_Pics/" + FileUpload.FileName.ToString();
            int ArtistImageSizie = FileUpload.PostedFile.ContentLength;

            int validatedCount = 0;

            if(ArtistValidator.artistNameValidate(ArtistName))
            {
                errorArtistNamelbl.Text = "Must be filled and unique among the artist’s name.";
                errorArtistNamelbl.Visible = true;
                nameTxtbox.Style["border"] = "1px solid #DC4C64";
                nameTxtbox.Style["background"] = "#ffebee";
                validatedCount++;
            }
            else
            {
                errorArtistNamelbl.Visible = false;
                nameTxtbox.Style["border"] = "1px solid black";
                nameTxtbox.Style["background"] = "white";
            }

            if (ArtistValidator.artistFileValidate(ArtistImage, ArtistImageSizie))
            {
                errorArtistFilelbl.Text = "Must be chosen, file extension must be .png, .jpg, .jpeg, or .jfif, and file size must be lower than 2MB.";
                FileUploadBox.Visible = true;
                FileUploadBox.Style["border"] = "1px solid #DC4C64";
                FileUploadBox.Style["background"] = "#ffebee";
                validatedCount++;
            }
            else
            {
                FileUploadBox.Style["border"] = "1px solid white";
                FileUploadBox.Style["background"] = "white";
            }

            if(validatedCount == 0)
            {
                ArtistController.updateArtist(arID, ArtistName, ArtistImage);
                fileUploadValidate();
                Response.RedirectPermanent("/View/Home.aspx");
            }


        }

        protected bool fileUploadValidate()
        {
            try
            {
                string folderPath = Server.MapPath("/Asset/Artist_Pics/");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = Path.GetFileName(FileUpload.FileName);
                FileUpload.SaveAs(Path.Combine(folderPath, fileName));
                return true;
            }
            catch 
            {
                return false;
            }
        }


    }
}