using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBases
{
    public class help
    {

        public void imageLoad(PictureBox pBox, String url)
        {
            try { 
                pBox.Load(url);
            } catch (Exception e) {
                pBox.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
                Console.WriteLine("La imagen no fue encontrada.");
                throw e; }
        }


    }
}
