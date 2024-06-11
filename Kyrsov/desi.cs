using System.Drawing;
using System.Drawing.Drawing2D;

namespace Kyrsov
{
    internal class desi
    {
        public static GraphicsPath RoundedRectangle(Rectangle rect, int RoundSize)
        {
            GraphicsPath gp = new GraphicsPath();

            gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X,+ rect.Width - RoundSize,rect.Y, RoundSize, 270, 90);
            gp.AddArc(rect.X + rect.Width - RoundSize,rect.Y + rect.Height - RoundSize,RoundSize, RoundSize, 180, 90);
            gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 180, 90);

            gp.CloseFigure();
            return gp;

        }
    }
}
