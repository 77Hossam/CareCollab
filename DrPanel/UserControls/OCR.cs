using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patagames.Ocr;

namespace DrPanel.UserControls
{
    public partial class OCR : UserControl
    {
        public OCR()
        {
            InitializeComponent();
        }

        private void picTaregt_Click(object sender, EventArgs e)
        {
            picTaregt.ImageLocation = @"""D:\BMD302\Test project\testOCR.jpg";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            using (var objOcr = OcrApi.Create())
            {
                objOcr.Init(Patagames.Ocr.Enums.Languages.English);
                string plainText = objOcr.GetTextFromImage(picTaregt.ImageLocation);
                btnTxtConverted.Text = plainText;
            }
        }

        private void OCR_Load(object sender, EventArgs e)
        {

        }
    }
}
