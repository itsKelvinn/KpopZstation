using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class InsertArtist : System.Web.UI.Page
    {
        public string artistName;
        public string imagePath;

        static readonly string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".jfif" };
        static readonly int maxFileSize = 2 * 1024 * 1024;


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
            this.artistName = nameTxtbox.ToString();
            this.imagePath = "/Asset/Artist_Profile_Pic/" + FileUpload.FileName.ToString();

            if (fileUploadValidate())
            {
                ArtistController.addArtist(artistName, imagePath);
            }
            else
            {
                lblStatus.Text = "Please select a file to upload.";
            }

        }

        protected bool fileUploadValidate()
        {
            if (FileUpload.HasFile && allowedExtensions.Contains(imagePath.ToLower()) && FileUpload.PostedFile.ContentLength <= maxFileSize)
            {
                try
                {
                    string folderPath = Server.MapPath("/Asset/Artist_Profile_Pic/");

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    string fileName = Path.GetFileName(FileUpload.FileName);
                    FileUpload.SaveAs(Path.Combine(folderPath, fileName));


                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Error: " + ex.Message;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}