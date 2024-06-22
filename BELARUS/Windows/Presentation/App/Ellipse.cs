using System.Drawing;

namespace BELARUS.App
{
    internal class Ellipse
    {
        public int PenWidth;
        public Color Color;
        public Rectangle Rectangle;

        // Paint ourselves with the specified Graphics object
        public void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(Color, PenWidth))
                graphics.DrawEllipse(pen, Rectangle);
        }
    }
}