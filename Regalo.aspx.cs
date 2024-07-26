using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegaloLaura
{
    public partial class Regalo : System.Web.UI.Page
    {
        private readonly List<string> images = new List<string>
        {
            "~/Content/Laura1.jpg",
            "~/Content/Laura2.jpg",
            "~/Content/Laura3.jpg",
            "~/Content/Laura4.jpg",
            "~/Content/Laura5.jpg",
            "~/Content/Laura6.jpg",
            "~/Content/Laura7.jpg",
            "~/Content/Laura8.jpg",
            "~/Content/Laura9.jpg",
            "~/Content/Laura10.jpg",
            "~/Content/Laura11.jpg",
            "~/Content/Laura12.jpg",
            "~/Content/Laura13.jpg"
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowImage(0);
            }
        }

        protected void PrevButton_Click(object sender, EventArgs e)
        {
            int currentIndex = int.Parse(CurrentIndex.Value);
            currentIndex = (currentIndex - 1 + images.Count) % images.Count;
            ShowImage(currentIndex);
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            int currentIndex = int.Parse(CurrentIndex.Value);
            currentIndex = (currentIndex + 1) % images.Count;
            ShowImage(currentIndex);
        }
        private void ShowImage(int index)
        {
            ImageControl.ImageUrl = images[index];
            CurrentIndex.Value = index.ToString();
        }
    }
}