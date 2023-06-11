using KpopZstation.Controller;
using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class AlbumUpdate : System.Web.UI.Page
    {
        public Album album;
        public int AlbumID;

        protected void Page_Load(object sender, EventArgs e)
        {
            AlbumID = Convert.ToInt32(Request.QueryString["id"]);
            Customer customer = AuthController.checkSession();

            if(customer == null || customer.CustomerRole.Equals("User"))
            {
                Response.Redirect("Home.aspx");
            }

            album = AlbumController.findAlbum(AlbumID);

        }

        protected void Update_Album_Button(object sender, EventArgs e)
        {
            string AlbumName = albumNameTxtbox.Text.ToString();
            string AlbumDesc = albumDescTxtarea.InnerText.ToString();
            string AlbumImage = "/Asset/Album_Pics/" + FileUpload.FileName;
            int AlbumImageSize = FileUpload.PostedFile.ContentLength;
            int AlbumPrice;
            int.TryParse(albumPriceTxtbox.Text, out AlbumPrice);
            int AlbumStock;
            int.TryParse(albumStockTxtbox.Text, out AlbumStock);

            int validateCount = 0;

            if (AlbumValidator.albumNameValidate(AlbumName))
            {
                errorAlbumNamelbl.Visible = true;
                errorAlbumNamelbl.Text = "Must be filled and smaller than 50 characters";
                albumNameTxtbox.Style["border"] = "1px solid #DC4C64";
                albumNameTxtbox.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorAlbumNamelbl.Visible = false;
                albumNameTxtbox.Style["border"] = "1px solid black";
                albumNameTxtbox.Style["background"] = "white";
            }

            if(AlbumValidator.albumDescValidate(AlbumDesc))
            {
                errorAlbumDesclbl.Visible = true;
                errorAlbumDesclbl.Text = "Must be filled and smaller than 255 characters";
                albumDescTxtarea.Style["border"] = "1px solid #DC4C64";
                albumDescTxtarea.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorAlbumDesclbl.Visible = false;
                albumDescTxtarea.Style["border"] = "1px solid black";
                albumDescTxtarea.Style["background"] = "white";
            }

            if(AlbumValidator.albumImageValidate(AlbumImage,AlbumImageSize))
            {
                errorAlbumFileUploadlbl.Visible = true;
                errorAlbumFileUploadlbl.Text = "Must be chosen, file extension must be .png, .jpg, .jpeg, or .jfif, and file size must be lower than 2MB.";
                FileUploadBox.Style["border"] = "1px solid #DC4C64";
                FileUploadBox.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorAlbumFileUploadlbl.Visible = false;
                FileUploadBox.Style["border"] = "1px solid black";
                FileUploadBox.Style["background"] = "white";
            }

            if(AlbumValidator.albumPriceValidate(AlbumPrice)) 
            {
                errorAlbumPricelbl.Visible = true;
                errorAlbumPricelbl.Text = "Must be filled and between 100000 and 1000000";
                albumPriceTxtbox.Style["border"] = "1px solid #DC4C64";
                albumPriceTxtbox.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorAlbumPricelbl.Visible = false;
                albumPriceTxtbox.Style["border"] = "1px solid black";
                albumPriceTxtbox.Style["background"] = "white";
            }

            if(AlbumValidator.albumStockValidate(AlbumStock))
            {
                errorAlbumStocklbl.Visible = true;
                errorAlbumStocklbl.Text = "Must be filled and more than 0";
                albumStockTxtbox.Style["border"] = "1px solid #DC4C64";
                albumStockTxtbox.Style["background"] = "#ffebee";
                validateCount++;
            }
            else
            {
                errorAlbumStocklbl.Visible = false;
                albumStockTxtbox.Style["border"] = "1px solid black";
                albumStockTxtbox.Style["background"] = "white";
            }

            if(validateCount == 0)
            {
                uploadFile();
                AlbumController.updateAlbum(AlbumID,AlbumStock,AlbumPrice,AlbumName,AlbumDesc,AlbumImage);
                Response.Redirect("/View/ArtistDetail.aspx/?id=" + album.ArtistID);
            }
        }

        protected bool uploadFile()
        {
            try
            {
                string folderPath = Server.MapPath("/Asset/Album_Pics/");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string fileName = Path.GetFileName(FileUpload.FileName);
                FileUpload.SaveAs(Path.Combine(folderPath, fileName));

            }
            catch
            {
                return false;
            }

            return true;
        }



    }
}