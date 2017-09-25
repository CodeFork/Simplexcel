namespace Simplexcel {
    /// <summary>
    /// Specify a Color, as System.Drawing.Color isn't used.
    /// </summary>
    public struct Color {

        /// <summary>
        /// The Red component of the Color
        /// </summary>
        public readonly byte R;

        /// <summary>
        /// The Green component of the Color
        /// </summary>
        public readonly byte G;

        /// <summary>
        /// The Blue component of the Color
        /// </summary>
        public readonly byte B;

        /// <summary>
        /// The Alpha component of the Color (0 = Fully Transparent)
        /// </summary>
        public readonly byte A;

        private Color(byte alpha, byte red, byte green, byte blue) {
            A = alpha;
            R = red;
            G = green;
            B = blue;
        }

        /// <summary>
        /// Create a <see cref="Color"/> from the given values
        /// </summary>
        /// <param name="alpha"></param>
        /// <param name="red"></param>
        /// <param name="green"></param>
        /// <param name="blue"></param>
        /// <returns></returns>
        public static Color FromArgb(byte alpha, byte red, byte green, byte blue)
        {
            return new Color(alpha, red, green, blue);
        }

        /// <summary>
        /// Output the Color as a Hex String in ARGB order, e.g., "FFFF0000"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{A:X2}{R:X2}{G:X2}{B:X2}";
        }

        public static readonly Color AliceBlue = Color.FromArgb(255, 240, 248, 255);
        public static readonly Color AntiqueWhite = Color.FromArgb(255, 250, 235, 215);
        public static readonly Color Aqua = Color.FromArgb(255, 0, 255, 255);
        public static readonly Color Aquamarine = Color.FromArgb(255, 127, 255, 212);
        public static readonly Color Azure = Color.FromArgb(255, 240, 255, 255);
        public static readonly Color Beige = Color.FromArgb(255, 245, 245, 220);
        public static readonly Color Bisque = Color.FromArgb(255, 255, 228, 196);
        public static readonly Color Black = Color.FromArgb(255, 0, 0, 0);
        public static readonly Color BlanchedAlmond = Color.FromArgb(255, 255, 235, 205);
        public static readonly Color Blue = Color.FromArgb(255, 0, 0, 255);
        public static readonly Color BlueViolet = Color.FromArgb(255, 138, 43, 226);
        public static readonly Color Brown = Color.FromArgb(255, 165, 42, 42);
        public static readonly Color BurlyWood = Color.FromArgb(255, 222, 184, 135);
        public static readonly Color CadetBlue = Color.FromArgb(255, 95, 158, 160);
        public static readonly Color Chartreuse = Color.FromArgb(255, 127, 255, 0);
        public static readonly Color Chocolate = Color.FromArgb(255, 210, 105, 30);
        public static readonly Color Coral = Color.FromArgb(255, 255, 127, 80);
        public static readonly Color CornflowerBlue = Color.FromArgb(255, 100, 149, 237);
        public static readonly Color Cornsilk = Color.FromArgb(255, 255, 248, 220);
        public static readonly Color Crimson = Color.FromArgb(255, 220, 20, 60);
        public static readonly Color Cyan = Color.FromArgb(255, 0, 255, 255);
        public static readonly Color DarkBlue = Color.FromArgb(255, 0, 0, 139);
        public static readonly Color DarkCyan = Color.FromArgb(255, 0, 139, 139);
        public static readonly Color DarkGoldenrod = Color.FromArgb(255, 184, 134, 11);
        public static readonly Color DarkGray = Color.FromArgb(255, 169, 169, 169);
        public static readonly Color DarkGreen = Color.FromArgb(255, 0, 100, 0);
        public static readonly Color DarkKhaki = Color.FromArgb(255, 189, 183, 107);
        public static readonly Color DarkMagenta = Color.FromArgb(255, 139, 0, 139);
        public static readonly Color DarkOliveGreen = Color.FromArgb(255, 85, 107, 47);
        public static readonly Color DarkOrange = Color.FromArgb(255, 255, 140, 0);
        public static readonly Color DarkOrchid = Color.FromArgb(255, 153, 50, 204);
        public static readonly Color DarkRed = Color.FromArgb(255, 139, 0, 0);
        public static readonly Color DarkSalmon = Color.FromArgb(255, 233, 150, 122);
        public static readonly Color DarkSeaGreen = Color.FromArgb(255, 143, 188, 139);
        public static readonly Color DarkSlateBlue = Color.FromArgb(255, 72, 61, 139);
        public static readonly Color DarkSlateGray = Color.FromArgb(255, 47, 79, 79);
        public static readonly Color DarkTurquoise = Color.FromArgb(255, 0, 206, 209);
        public static readonly Color DarkViolet = Color.FromArgb(255, 148, 0, 211);
        public static readonly Color DeepPink = Color.FromArgb(255, 255, 20, 147);
        public static readonly Color DeepSkyBlue = Color.FromArgb(255, 0, 191, 255);
        public static readonly Color DimGray = Color.FromArgb(255, 105, 105, 105);
        public static readonly Color DodgerBlue = Color.FromArgb(255, 30, 144, 255);
        public static readonly Color Firebrick = Color.FromArgb(255, 178, 34, 34);
        public static readonly Color FloralWhite = Color.FromArgb(255, 255, 250, 240);
        public static readonly Color ForestGreen = Color.FromArgb(255, 34, 139, 34);
        public static readonly Color Fuchsia = Color.FromArgb(255, 255, 0, 255);
        public static readonly Color Gainsboro = Color.FromArgb(255, 220, 220, 220);
        public static readonly Color GhostWhite = Color.FromArgb(255, 248, 248, 255);
        public static readonly Color Gold = Color.FromArgb(255, 255, 215, 0);
        public static readonly Color Goldenrod = Color.FromArgb(255, 218, 165, 32);
        public static readonly Color Gray = Color.FromArgb(255, 128, 128, 128);
        public static readonly Color Green = Color.FromArgb(255, 0, 128, 0);
        public static readonly Color GreenYellow = Color.FromArgb(255, 173, 255, 47);
        public static readonly Color Honeydew = Color.FromArgb(255, 240, 255, 240);
        public static readonly Color HotPink = Color.FromArgb(255, 255, 105, 180);
        public static readonly Color IndianRed = Color.FromArgb(255, 205, 92, 92);
        public static readonly Color Indigo = Color.FromArgb(255, 75, 0, 130);
        public static readonly Color Ivory = Color.FromArgb(255, 255, 255, 240);
        public static readonly Color Khaki = Color.FromArgb(255, 240, 230, 140);
        public static readonly Color Lavender = Color.FromArgb(255, 230, 230, 250);
        public static readonly Color LavenderBlush = Color.FromArgb(255, 255, 240, 245);
        public static readonly Color LawnGreen = Color.FromArgb(255, 124, 252, 0);
        public static readonly Color LemonChiffon = Color.FromArgb(255, 255, 250, 205);
        public static readonly Color LightBlue = Color.FromArgb(255, 173, 216, 230);
        public static readonly Color LightCoral = Color.FromArgb(255, 240, 128, 128);
        public static readonly Color LightCyan = Color.FromArgb(255, 224, 255, 255);
        public static readonly Color LightGoldenrodYellow = Color.FromArgb(255, 250, 250, 210);
        public static readonly Color LightGray = Color.FromArgb(255, 211, 211, 211);
        public static readonly Color LightGreen = Color.FromArgb(255, 144, 238, 144);
        public static readonly Color LightPink = Color.FromArgb(255, 255, 182, 193);
        public static readonly Color LightSalmon = Color.FromArgb(255, 255, 160, 122);
        public static readonly Color LightSeaGreen = Color.FromArgb(255, 32, 178, 170);
        public static readonly Color LightSkyBlue = Color.FromArgb(255, 135, 206, 250);
        public static readonly Color LightSlateGray = Color.FromArgb(255, 119, 136, 153);
        public static readonly Color LightSteelBlue = Color.FromArgb(255, 176, 196, 222);
        public static readonly Color LightYellow = Color.FromArgb(255, 255, 255, 224);
        public static readonly Color Lime = Color.FromArgb(255, 0, 255, 0);
        public static readonly Color LimeGreen = Color.FromArgb(255, 50, 205, 50);
        public static readonly Color Linen = Color.FromArgb(255, 250, 240, 230);
        public static readonly Color Magenta = Color.FromArgb(255, 255, 0, 255);
        public static readonly Color Maroon = Color.FromArgb(255, 128, 0, 0);
        public static readonly Color MediumAquamarine = Color.FromArgb(255, 102, 205, 170);
        public static readonly Color MediumBlue = Color.FromArgb(255, 0, 0, 205);
        public static readonly Color MediumOrchid = Color.FromArgb(255, 186, 85, 211);
        public static readonly Color MediumPurple = Color.FromArgb(255, 147, 112, 219);
        public static readonly Color MediumSeaGreen = Color.FromArgb(255, 60, 179, 113);
        public static readonly Color MediumSlateBlue = Color.FromArgb(255, 123, 104, 238);
        public static readonly Color MediumSpringGreen = Color.FromArgb(255, 0, 250, 154);
        public static readonly Color MediumTurquoise = Color.FromArgb(255, 72, 209, 204);
        public static readonly Color MediumVioletRed = Color.FromArgb(255, 199, 21, 133);
        public static readonly Color MidnightBlue = Color.FromArgb(255, 25, 25, 112);
        public static readonly Color MintCream = Color.FromArgb(255, 245, 255, 250);
        public static readonly Color MistyRose = Color.FromArgb(255, 255, 228, 225);
        public static readonly Color Moccasin = Color.FromArgb(255, 255, 228, 181);
        public static readonly Color NavajoWhite = Color.FromArgb(255, 255, 222, 173);
        public static readonly Color Navy = Color.FromArgb(255, 0, 0, 128);
        public static readonly Color OldLace = Color.FromArgb(255, 253, 245, 230);
        public static readonly Color Olive = Color.FromArgb(255, 128, 128, 0);
        public static readonly Color OliveDrab = Color.FromArgb(255, 107, 142, 35);
        public static readonly Color Orange = Color.FromArgb(255, 255, 165, 0);
        public static readonly Color OrangeRed = Color.FromArgb(255, 255, 69, 0);
        public static readonly Color Orchid = Color.FromArgb(255, 218, 112, 214);
        public static readonly Color PaleGoldenrod = Color.FromArgb(255, 238, 232, 170);
        public static readonly Color PaleGreen = Color.FromArgb(255, 152, 251, 152);
        public static readonly Color PaleTurquoise = Color.FromArgb(255, 175, 238, 238);
        public static readonly Color PaleVioletRed = Color.FromArgb(255, 219, 112, 147);
        public static readonly Color PapayaWhip = Color.FromArgb(255, 255, 239, 213);
        public static readonly Color PeachPuff = Color.FromArgb(255, 255, 218, 185);
        public static readonly Color Peru = Color.FromArgb(255, 205, 133, 63);
        public static readonly Color Pink = Color.FromArgb(255, 255, 192, 203);
        public static readonly Color Plum = Color.FromArgb(255, 221, 160, 221);
        public static readonly Color PowderBlue = Color.FromArgb(255, 176, 224, 230);
        public static readonly Color Purple = Color.FromArgb(255, 128, 0, 128);
        public static readonly Color Red = Color.FromArgb(255, 255, 0, 0);
        public static readonly Color RosyBrown = Color.FromArgb(255, 188, 143, 143);
        public static readonly Color RoyalBlue = Color.FromArgb(255, 65, 105, 225);
        public static readonly Color SaddleBrown = Color.FromArgb(255, 139, 69, 19);
        public static readonly Color Salmon = Color.FromArgb(255, 250, 128, 114);
        public static readonly Color SandyBrown = Color.FromArgb(255, 244, 164, 96);
        public static readonly Color SeaGreen = Color.FromArgb(255, 46, 139, 87);
        public static readonly Color SeaShell = Color.FromArgb(255, 255, 245, 238);
        public static readonly Color Sienna = Color.FromArgb(255, 160, 82, 45);
        public static readonly Color Silver = Color.FromArgb(255, 192, 192, 192);
        public static readonly Color SkyBlue = Color.FromArgb(255, 135, 206, 235);
        public static readonly Color SlateBlue = Color.FromArgb(255, 106, 90, 205);
        public static readonly Color SlateGray = Color.FromArgb(255, 112, 128, 144);
        public static readonly Color Snow = Color.FromArgb(255, 255, 250, 250);
        public static readonly Color SpringGreen = Color.FromArgb(255, 0, 255, 127);
        public static readonly Color SteelBlue = Color.FromArgb(255, 70, 130, 180);
        public static readonly Color Tan = Color.FromArgb(255, 210, 180, 140);
        public static readonly Color Teal = Color.FromArgb(255, 0, 128, 128);
        public static readonly Color Thistle = Color.FromArgb(255, 216, 191, 216);
        public static readonly Color Tomato = Color.FromArgb(255, 255, 99, 71);
        public static readonly Color Transparent = Color.FromArgb(0, 255, 255, 255);
        public static readonly Color Turquoise = Color.FromArgb(255, 64, 224, 208);
        public static readonly Color Violet = Color.FromArgb(255, 238, 130, 238);
        public static readonly Color Wheat = Color.FromArgb(255, 245, 222, 179);
        public static readonly Color White = Color.FromArgb(255, 255, 255, 255);
        public static readonly Color WhiteSmoke = Color.FromArgb(255, 245, 245, 245);
        public static readonly Color Yellow = Color.FromArgb(255, 255, 255, 0);
        public static readonly Color YellowGreen = Color.FromArgb(255, 154, 205, 50);
    }
}