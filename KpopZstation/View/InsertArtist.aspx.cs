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
        string artistName;
        string imagePath;

        readonly string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".jfif" };
        readonly int maxFileSize = 2 * 1024 * 1024;


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
            artistName = nameTxtbox.Text.ToString();
            imagePath = "/Asset/Artist_Pics/" + FileUpload.FileName.ToString();

            if (fileUploadValidate())
            {
                ArtistController.addArtist(artistName, imagePath);
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblStatus.Text = "Gagal";
            }

        }

        protected bool fileUploadValidate()
        {
            bool isExtensionAllowed = allowedExtensions.Any(ext => imagePath.EndsWith(ext, StringComparison.OrdinalIgnoreCase));

            if (FileUpload.HasFile && isExtensionAllowed && FileUpload.PostedFile.ContentLength <= maxFileSize)
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