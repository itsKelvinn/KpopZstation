﻿using KpopZstation.Controller;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class NewAlbum : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Entar di isi 
        }

        protected void addAlbumBtn(object sender, EventArgs e)
        {
            string AlbumName = AlbumNameTxtbox.Text.ToString();
            int ArtistID = int.Parse(Request.QueryString["id"]);
            int AlbumPrice;
            
            try
            {
                AlbumPrice = int.Parse(AlbumPriceTxtbox.Text);
            }
            catch
            {
                AlbumPrice = 0;
            }

            int AlbumStock ;
            try
            {
                AlbumStock = int.Parse(AlbumStockTxtbox.Text);
            }
            catch { AlbumStock = 0; }

            string AlbumPicFileName = "/Asset/Album_Pics/" + FileUpload.FileName.ToString();
            string AlbumDesc = albumDescTextArea.Value.ToString();  
            int AlbumPicSize = FileUpload.PostedFile.ContentLength;

            int validateCountCheck = 0;

            if (AlbumValidator.albumNameValidate(AlbumName))
            {
                errorAlbumNameLabel.Visible = true;
                errorAlbumNameLabel.Text = "Must be filled and smaller than 50 characters";
                AlbumNameTxtbox.Style["border"] = "1px solid #DC4C64";
                AlbumNameTxtbox.Style["background"] = "#ffebee";
                validateCountCheck++;
            }
            
            if (AlbumValidator.albumPriceValidate(AlbumPrice))
            {
                errorAlbumPriceLabel.Visible = true;
                errorAlbumPriceLabel.Text = "Must be filled and between 100000 and 1000000";
                AlbumPriceTxtbox.Style["border"] = "1px solid #DC4C64";
                AlbumPriceTxtbox.Style["background"] = "#ffebee";
                validateCountCheck++;
            }

            if (AlbumValidator.albumStockValidate(AlbumStock))
            {
                errorAlbumStockLabel.Visible = true;
                errorAlbumStockLabel.Text = "Must be filled and more than 0";
                AlbumStockTxtbox.Style["border"] = "1px solid #DC4C64";
                AlbumStockTxtbox.Style["background"] = "#ffebee";
                validateCountCheck++;
            }

            if (AlbumValidator.albumDescValidate(AlbumDesc))
            {
                errorAlbumDescLabel.Visible = true;
                errorAlbumDescLabel.Text = "Must be filled and more than 0";
                albumDescTextArea.Style["border"] = "1px solid #DC4C64";
                albumDescTextArea.Style["background"] = "#ffebee";
                validateCountCheck++;
            }

            if (AlbumValidator.albumImageValidate(AlbumPicFileName, AlbumPicSize))
            {
                errorAlbumFileLabel.Visible = true;
                errorAlbumFileLabel.Text = "Must be chosen, file extension must be .png, .jpg, .jpeg, or .jfif, and file size must be lower than 2MB";
                uploadFileBorder.Style["border"] = "1px solid #DC4C64";
                uploadFileBorder.Style["background"] = "#ffebee";
                validateCountCheck++;
            }

            if(validateCountCheck == 0)
            {
                AlbumController.AddAlbum(ArtistID,AlbumName, AlbumPicFileName, AlbumPrice, AlbumStock, AlbumDesc);
                uploadFile();
                Response.Redirect("/View/ArtistDetail.aspx/?id=" + ArtistID);
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