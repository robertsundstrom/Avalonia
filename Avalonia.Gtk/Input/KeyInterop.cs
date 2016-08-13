using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk.Input
{
    using Avalonia.Input;
    using Avalonia.Interop;

    using static Avalonia.Gtk.Input.GDK_KEY;

    public static class KeyInterop
    {
        private static Dictionary<Key, int> virtualKeyFromKey = new Dictionary<Key, int>
        {
            { Key.None, VoidSymbol },
            { Key.Cancel, Cancel },
            { Key.Back, BackSpace },
            { Key.Tab, Tab },
            { Key.LineFeed, Linefeed },
            { Key.Clear, Clear },
            { Key.Return, Return },
            { Key.Pause, Pause },
            { Key.Capital, 20 },
            { Key.KanaMode, 21 },
            { Key.JunjaMode, 23 },
            { Key.FinalMode, 24 },
            { Key.HanjaMode, 25 },
            { Key.Escape, 27 },
            { Key.ImeConvert, 28 },
            { Key.ImeNonConvert, 29 },
            { Key.ImeAccept, 30 },
            { Key.ImeModeChange, 31 },
            { Key.Space, space },
            { Key.PageUp, Page_Up },
            { Key.Next, Next },
            { Key.End, End },
            { Key.Home, Home },
            { Key.Left, Left },
            { Key.Up, Up },
            { Key.Right, Right },
            { Key.Down, Down },
            { Key.Select, Select },
            { Key.Print, Print },
            { Key.Execute, Execute },
            { Key.Snapshot, 44 },
            { Key.Insert, Insert },
            { Key.Delete, Delete },
            { Key.Help, Help },
            { Key.D0, KEY_0 },
            { Key.D1, KEY_1 },
            { Key.D2, KEY_2 },
            { Key.D3, KEY_3 },
            { Key.D4, KEY_4 },
            { Key.D5, KEY_5 },
            { Key.D6, KEY_6 },
            { Key.D7, KEY_7 },
            { Key.D8, KEY_8 },
            { Key.D9, KEY_9 },
            { Key.A, A },
            { Key.B, B },
            { Key.C, C },
            { Key.D, D },
            { Key.E, E },
            { Key.F, F },
            { Key.G, G },
            { Key.H, H },
            { Key.I, I },
            { Key.J, J },
            { Key.K, K },
            { Key.L, L },
            { Key.M, M },
            { Key.N, N },
            { Key.O, O },
            { Key.P, P },
            { Key.Q, Q },
            { Key.R, R },
            { Key.S, S },
            { Key.T, T },
            { Key.U, U },
            { Key.V, V },
            { Key.W, W },
            { Key.X, X },
            { Key.Y, Y },
            { Key.Z, Z },
            { Key.LWin, 91 },
            { Key.RWin, 92 },
            { Key.Apps, 93 },
            { Key.Sleep, Sleep },
            { Key.NumPad0, KP_0 },
            { Key.NumPad1, KP_1 },
            { Key.NumPad2, KP_2 },
            { Key.NumPad3, KP_3 },
            { Key.NumPad4, KP_4 },
            { Key.NumPad5, KP_5 },
            { Key.NumPad6, KP_6 },
            { Key.NumPad7, KP_7 },
            { Key.NumPad8, KP_8 },
            { Key.NumPad9, KP_9 },
            { Key.Multiply, KP_Multiply },
            { Key.Add, KP_Add },
            { Key.Separator, KP_Separator },
            { Key.Subtract, KP_Subtract },
            { Key.Decimal, KP_Decimal },
            { Key.Divide, KP_Divide },
            { Key.F1, F1 },
            { Key.F2, F2 },
            { Key.F3, F3 },
            { Key.F4, F4 },
            { Key.F5, F5 },
            { Key.F6, F6 },
            { Key.F7, F7 },
            { Key.F8, F8 },
            { Key.F9, F9 },
            { Key.F10, F10 },
            { Key.F11, F11 },
            { Key.F12, F12 },
            { Key.F13, F13 },
            { Key.F14, F14 },
            { Key.F15, F15 },
            { Key.F16, F16 },
            { Key.F17, F17 },
            { Key.F18, F18 },
            { Key.F19, F19 },
            { Key.F20, F20 },
            { Key.F21, F21 },
            { Key.F22, F22 },
            { Key.F23, F23 },
            { Key.F24, F24 },
            { Key.NumLock, Num_Lock },
            { Key.Scroll, 159 },
            { Key.LeftShift, Control_L },
            { Key.RightShift, Control_R },
            { Key.LeftCtrl, Control_L },
            { Key.RightCtrl, Control_R },
            { Key.LeftAlt, Alt_L },
            { Key.RightAlt, Alt_R },
            { Key.BrowserBack, 166 },
            { Key.BrowserForward, 167 },
            { Key.BrowserRefresh, 168 },
            { Key.BrowserStop, 169 },
            { Key.BrowserSearch, 170 },
            { Key.BrowserFavorites, 171 },
            { Key.BrowserHome, 172 },
            { Key.VolumeMute, 173 },
            { Key.VolumeDown, 174 },
            { Key.VolumeUp, 175 },
            { Key.MediaNextTrack, 176 },
            { Key.MediaPreviousTrack, 177 },
            { Key.MediaStop, 178 },
            { Key.MediaPlayPause, 179 },
            { Key.LaunchMail, 180 },
            { Key.SelectMedia, 181 },
            { Key.LaunchApplication1, 182 },
            { Key.LaunchApplication2, 183 },
            { Key.Oem1, 186 },
            { Key.OemPlus, 187 },
            { Key.OemComma, 188 },
            { Key.OemMinus, 189 },
            { Key.OemPeriod, 190 },
            { Key.OemQuestion, 191 },
            { Key.Oem3, 192 },
            { Key.AbntC1, 193 },
            { Key.AbntC2, 194 },
            { Key.OemOpenBrackets, 219 },
            { Key.Oem5, 220 },
            { Key.Oem6, 221 },
            { Key.OemQuotes, 222 },
            { Key.Oem8, 223 },
            { Key.OemBackslash, 226 },
            { Key.ImeProcessed, 229 },
            { Key.System, 0 },
            { Key.OemAttn, 240 },
            { Key.OemFinish, 241 },
            { Key.OemCopy, 242 },
            { Key.DbeSbcsChar, 243 },
            { Key.OemEnlw, 244 },
            { Key.OemBackTab, 245 },
            { Key.DbeNoRoman, 246 },
            { Key.DbeEnterWordRegisterMode, 247 },
            { Key.DbeEnterImeConfigureMode, 248 },
            { Key.EraseEof, 249 },
            { Key.Play, 250 },
            { Key.DbeNoCodeInput, 251 },
            { Key.NoName, 252 },
            { Key.Pa1, 253 },
            { Key.OemClear, 254 },
            { Key.DeadCharProcessed, 0 },
        };

        private static Dictionary<int, Key> keyFromVirtualKey = new Dictionary<int, Key>();

        static KeyInterop()
        {
            foreach(var keyValue in virtualKeyFromKey)
            {
                keyFromVirtualKey.Add(keyValue.Value, keyValue.Key);
            }
        }

        public static Key KeyFromVirtualKey(int virtualKey)
        {
            Key result;
            keyFromVirtualKey.TryGetValue(virtualKey, out result);
            return result;
        }

        public static int VirtualKeyFromKey(Key key)
        {
            int result;
            virtualKeyFromKey.TryGetValue(key, out result);
            return result;
        }
    }
}
