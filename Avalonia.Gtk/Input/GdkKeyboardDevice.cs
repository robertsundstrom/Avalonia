using Avalonia.Gtk.Interop;
using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk.Input
{
    public class GdkKeyboardDevice : KeyboardDevice
    {
        private static GdkKeyboardDevice instance = new GdkKeyboardDevice();

        private byte[] keyStates = new byte[256];

        public static GdkKeyboardDevice Instance
        {
            get { return instance; }
        }

        protected override KeyStates GetKeyStatesFromSystem(Key key)
        {
            int vk = KeyInterop.VirtualKeyFromKey(key);
            byte state = this.keyStates[vk];
            KeyStates result = 0;

            if ((state & 0x80) != 0)
            {
                result |= KeyStates.Down;
            }

            if ((state & 0x01) != 0)
            {
                result |= KeyStates.Toggled;
            }

            return result;
        }

        protected override string KeyToString(Key key)
        {
            var result = StringHelpers.Utf8PtrToString(UnmanagedMethods.gdk_keyval_name(
                (uint)KeyInterop.VirtualKeyFromKey(key)));
            return result.ToString();
        }
    }
}
