using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Avalonia.Gtk.Input;
    using Avalonia.Gtk.Interop;
    //using Avalonia.Gtk.Media;
    //using Avalonia.Gtk.Media.Imaging;
    using Avalonia.Input;
    using Avalonia.Media;
    using Avalonia.Media.Imaging;
    using Avalonia.Platform;

    public class GtkPlatformInterface : PlatformInterface
    {
        public GtkPlatformInterface()
        {
            this.Dispatcher = null; //new WindowMessageDispatcher();
        }

        public static new GtkPlatformInterface Instance
        {
            get { return (GtkPlatformInterface)PlatformInterface.Instance; }
        }

        public override TimeSpan CaretBlinkTime
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IPlatformDispatcher Dispatcher
        {
            get
            {
                throw new NotImplementedException();
            }

            protected set
            {
                throw new NotImplementedException();
            }
        }

        public override KeyboardDevice KeyboardDevice
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override MouseDevice MouseDevice
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override IPlatformBitmapDecoder CreateBitmapDecoder(BitmapContainerFormat format)
        {
            throw new NotImplementedException();
        }

        public override IPlatformBitmapDecoder CreateBitmapDecoder(Stream stream, BitmapCacheOption cacheOption)
        {
            throw new NotImplementedException();
        }

        public override IPlatformBitmapEncoder CreateBitmapEncoder(BitmapContainerFormat format)
        {
            throw new NotImplementedException();
        }

        public override IPlatformFormattedText CreateFormattedText(string textToFormat, Typeface typeface, double fontSize)
        {
            throw new NotImplementedException();
        }

        public override PlatformPresentationSource CreatePopupPresentationSource()
        {
            throw new NotImplementedException();
        }

        public override PlatformPresentationSource CreatePresentationSource()
        {
            return new Window();
        }

        public override IPlatformRenderTargetBitmap CreateRenderTargetBitmap(int pixelWidth, int pixelHeight, double dpiX, double dpiY, PixelFormat pixelFormat)
        {
            throw new NotImplementedException();
        }

        public override IPlatformStreamGeometry CreateStreamGeometry()
        {
            throw new NotImplementedException();
        }

        public override void KillTimer(object handle)
        {
            throw new NotImplementedException();
        }

        public override object StartTimer(TimeSpan interval, Action callback)
        {
            throw new NotImplementedException();
        }
    }
}
