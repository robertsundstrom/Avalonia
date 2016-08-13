using Avalonia.Media;
using Avalonia.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk.Media
{
    public class CairoDrawingContext : DrawingContext
    {
        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void DrawGeometry(Brush brush, Pen pen, Geometry geometry)
        {
            throw new NotImplementedException();
        }

        public override void DrawGeometry(Brush brush, Pen pen, Geometry geometry, Matrix transform)
        {
            throw new NotImplementedException();
        }

        public override void DrawImage(ImageSource imageSource, Rect rectangle)
        {
            BitmapSource bitmapSource = imageSource as BitmapSource;

            if (bitmapSource == null)
            {
                throw new NotSupportedException("Cannot draw ImageSource that is not a BitmapSource.");
            }

            throw new NotImplementedException();
        }

        public override void DrawImage(ImageSource imageSource, double opacity, Rect sourceRectangle, Rect destinationRectangle)
        {
            BitmapSource bitmapSource = imageSource as BitmapSource;

            if (bitmapSource == null)
            {
                throw new NotSupportedException("Cannot draw ImageSource that is not a BitmapSource.");
            }

            throw new NotImplementedException();
        }

        public override void DrawLine(Pen pen, Point point0, Point point1)
        {
            throw new NotImplementedException();
        }

        public override void DrawRectangle(Brush brush, Pen pen, Rect rectangle)
        {
            throw new NotImplementedException();
        }

        public override void DrawRoundedRectangle(Brush brush, Pen pen, Rect rectangle, double radiusX, double radiusY)
        {
            throw new NotImplementedException();
        }

        public override void DrawText(FormattedText formattedText, Point origin)
        {
            throw new NotImplementedException();
        }

        public override void Pop()
        {
            throw new NotImplementedException();
        }

        public override void PushOpacity(double opacity)
        {
            throw new NotImplementedException();
        }

        public override void PushTransform(Transform transform)
        {
            throw new NotImplementedException();
        }
    }
}
