using KpopZstation.Controller;
using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = AuthController.checkSession();

            if (customer == null || customer.CustomerRole.Equals("User"))
            {
                Response.Redirect("Home.aspx");
            }
        }

        protected void insertArtistBtn(object sender, EventArgs e)
        {
            string ArtistName = nameTxtbox.Text.ToString();
            string ArtistImage = "/Asset/Artist_Pics/" + FileUpload.FileName.ToString();
            int ArtistImageSize = FileUpload.PostedFile.ContentLength;

            int validateCount = 0;

            if (ArtistValidator.artistNameValidate(ArtistName))
            {
                errorNamelbl.Visible = true;
                errorNamelbl.Text = "Must be filled and unique among the artist’s name.";
                nameTxtbox.Style["border"] = "1px solid #DC4C64";
                nameTxtbox.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorNamelbl.Visible = false;
                nameTxtbox.Style["border"] = "1px solid black";
                nameTxtbox.Style["background"] = "white";
            }

            if(ArtistValidator.artistFileValidate(ArtistImage,ArtistImageSize))
            {
                errorFileUploadlbl.Visible = true;
                errorFileUploadlbl.Text = "Must be chosen, file extension must be .png, .jpg, .jpeg, or .jfif, and file size must be lower than 2MB.";
                FileUploadBox.Style["border"] = "1px solid #DC4C64";
                FileUploadBox.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorFileUploadlbl.Visible = false;
                FileUploadBox.Style["border"] = "1px solid black";
                FileUploadBox.Style["background"] = "white";
            }

            if(validateCount == 0)
            {
                ArtistController.addArtist(ArtistName, ArtistImage);
                fileUploadValidate();
                Response.Redirect("Home.aspx");
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