using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public interface IGraphics
    {
        void DrawEllipse(
            Pen colorPen,
            int locationX,
            int locationY,
            int width,
            int height);
        void FillEllipse(
            Brush colorBrush,
            int locationX,
            int locationY,
            int width,
            int height);
    }
}
