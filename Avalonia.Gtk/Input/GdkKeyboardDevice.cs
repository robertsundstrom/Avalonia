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
        protected override KeyStates GetKeyStatesFromSystem(Key key)
        {
            throw new NotImplementedException();
        }

        protected override string KeyToString(Key key)
        {
            throw new NotImplementedException();
        }
    }
}
