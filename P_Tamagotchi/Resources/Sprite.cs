using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Resources
{
    public class Sprite
    {
        private int _x;
        private int _y;
        private int _width = 7;
        private int _height = 10;

        private Bitmap sheet;

        public Sprite(int x, int y, int width = 7, int height = 10)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
            sheet = new Bitmap(P_Tamagotchi.Properties.Resources.LCD_Handhelds___Tamagotchi_Original_P1_P2___General_Sprites);
        }

        public Image GetSprite()
        {
            Rectangle cropRect = new Rectangle(_x, _y, _width, _height);
            Bitmap croppedImage = sheet.Clone(cropRect, sheet.PixelFormat);
            return croppedImage;
        }

        public void Change(int x, int y, int width = 7, int height = 10)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
    }

}
