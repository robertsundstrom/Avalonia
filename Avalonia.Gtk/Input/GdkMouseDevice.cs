using Avalonia.Gtk.Interop;
using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk.Input
{
    public class GdkMouseDevice : MouseDevice
    {
        private static GdkMouseDevice instance = new GdkMouseDevice();

        int x, y;

        public static GdkMouseDevice Instance
        {
            get { return instance; }
        }

        public override IInputElement Target
        {
            get
            {
                if (this.Captured != null)
                {
                    return this.Captured;
                }
                else
                {
                    Point p = this.GetClientPosition();
                    UIElement ui = this.ActiveSource.RootVisual as UIElement;
                    return ui.InputHitTest(p);
                }
            }
        }

        public override void Capture(IInputElement element)
        {
            IntPtr window = ((Window)ActiveSource).Handle;
            IntPtr screen = UnmanagedMethods.gdk_window_get_display(window);
            IntPtr seat = UnmanagedMethods.gdk_display_get_default_seat(screen);

            if (element != null && this.ActiveSource != null)
            {
                IntPtr ev = IntPtr.Zero;
                GdkSeatGrabPrepareFunc func = null;
                IntPtr data = IntPtr.Zero;

                UnmanagedMethods.gdk_seat_grab(seat, window, GdkSeatCapabilities.GDK_SEAT_CAPABILITY_POINTER, true, IntPtr.Zero, out ev, func, data);
            }
            else
            {
                UnmanagedMethods.gdk_seat_ungrab(seat);
            }

            base.Capture(element);
        }

        protected override Point GetClientPosition()
        {
            IntPtr handle = ((Window)ActiveSource).Handle;
            handle = UnmanagedMethods.gtk_window_get_screen(handle);
            handle = UnmanagedMethods.gdk_screen_get_root_window(handle);
            GdkModifierType modifier;
            UnmanagedMethods.gdk_window_get_pointer(handle, out x, out y, out modifier);
            return new Point(x, y);
        }

        protected override Point GetScreenPosition()
        {
            return new Point(this.x, this.y);
        }
    }
}
