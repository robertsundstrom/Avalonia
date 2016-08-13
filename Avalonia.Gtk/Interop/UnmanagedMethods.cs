using System;
using System.Runtime.InteropServices;
namespace Avalonia.Gtk.Interop
{
    internal static class UnmanagedMethods
    {
        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_window_new(GtkWindowType type);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_window_set_title(IntPtr window, string title);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_window_get_title(IntPtr window);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_window_set_default_size(IntPtr window, int width, int height);

        [DllImport(Libraries.Gtk)]
        public static extern void gtk_window_resize(IntPtr window, int width, int height);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gdk_window_get_display(IntPtr window);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_window_get_screen(IntPtr window);

        [DllImport(Libraries.Gtk)]
        public static extern IntPtr gtk_get_root_window(IntPtr screen);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_screen_get_root_window(IntPtr screen);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_window_get_pointer(
            IntPtr window,
                        out int x,
                        out int y,
                        out GdkModifierType mask);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_window_get_device_position(
                IntPtr window,
                IntPtr device,
                out int x,
                out int y,
                out GdkModifierType mask);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_window_get_device_position_double(
                IntPtr window,
                IntPtr device,
                out double x,
                out double y,
                out GdkModifierType mask);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_display_get_default_seat(IntPtr display);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_seat_get_pointer(IntPtr seat);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_seat_get_keyword(IntPtr seat);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_window_get_device_position_double(
                IntPtr device,
                IntPtr screen,
                out int x,
                out int y);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_device_get_position(
              IntPtr device,
              IntPtr screen,
              out double x,
              out double y);

        [DllImport(Libraries.Gdk)]
        public static extern void gdk_device_set_key(
           IntPtr device,
           uint index_,
           uint keyval,
           GdkModifierType modifiers);

        [DllImport(Libraries.Gdk)]
        public static extern bool gdk_device_get_key(
           IntPtr device,
           uint index_,
           out uint keyval,
           out GdkModifierType modifiers);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_keyval_name(uint keyval);

        [DllImport(Libraries.Gdk)]
        public static extern GdkGrabStatus gdk_seat_grab(IntPtr seat,
               IntPtr window,
               GdkSeatCapabilities capabilities,
               bool owner_events,
               IntPtr cursor,
               out IntPtr @event,
               GdkSeatGrabPrepareFunc prepare_func,
               IntPtr prepare_func_data);

        [DllImport(Libraries.Gdk)]
        public static extern void gdk_seat_ungrab(IntPtr seat);

        [DllImport(Libraries.Gdk)]
        public static extern IntPtr gdk_cairo_create(IntPtr window);

        [DllImport(Libraries.Cairo)]
        public static extern IntPtr cairo_image_surface_create_from_png(string path);

        [DllImport(Libraries.Cairo)]
        public static extern int cairo_image_surface_get_width(IntPtr context);

        [DllImport(Libraries.Cairo)]
        public static extern int cairo_image_surface_get_height(IntPtr context);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_set_source_rgb(IntPtr cr, int r, int g, int b);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_select_font_face(IntPtr cr, string family, _cairo_font_slant slant, cairo_font_weight_t weight);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_set_font_size(IntPtr cr, double size);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_show_text(IntPtr cr, string text);

        [DllImport(Libraries.Cairo)]
        public static extern void cairo_move_to(IntPtr cr, double x, double y);
    }

    public enum GtkWindowType
    {
        GTK_WINDOW_TOPLEVEL,
        GTK_WINDOW_POPUP
    }

    internal enum GdkGrabStatus
    {
        GDK_GRAB_SUCCESS,
        GDK_GRAB_ALREADY_GRABBED,
        GDK_GRAB_INVALID_TIME,
        GDK_GRAB_NOT_VIEWABLE,
        GDK_GRAB_FROZEN,
        GDK_GRAB_FAILED
    }

    [Flags]
    internal enum GdkSeatCapabilities
    {
        GDK_SEAT_CAPABILITY_NONE,
        GDK_SEAT_CAPABILITY_POINTER,
        GDK_SEAT_CAPABILITY_TOUCH,
        GDK_SEAT_CAPABILITY_TABLET_STYLUS,
        GDK_SEAT_CAPABILITY_KEYBOARD,
        GDK_SEAT_CAPABILITY_ALL_POINTING,
        GDK_SEAT_CAPABILITY_ALL
    }

    internal delegate void GdkSeatGrabPrepareFunc(IntPtr seat,
                            IntPtr window,
                            IntPtr user_data);

    public enum _cairo_font_slant
    {
        CAIRO_FONT_SLANT_NORMAL,
        CAIRO_FONT_SLANT_ITALIC,
        CAIRO_FONT_SLANT_OBLIQUE
    }

    public enum cairo_font_weight_t
    {
        CAIRO_FONT_WEIGHT_NORMAL,
        CAIRO_FONT_WEIGHT_BOLD
    }
}
