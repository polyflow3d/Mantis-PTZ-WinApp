using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantisPTZWinApp {
    public static class utils {
        public static string ToHex(byte[] bytes) {
            char[] c = new char[bytes.Length * 2];

            byte b;

            for (int bx = 0, cx = 0; bx < bytes.Length; ++bx, ++cx) {
                b = ((byte)(bytes[bx] >> 4));
                c[cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);

                b = ((byte)(bytes[bx] & 0x0F));
                c[++cx] = (char)(b > 9 ? b + 0x37 + 0x20 : b + 0x30);
            }

            return new string(c);
        }

        public static string ToHex(byte b) {
            char[] c = new char[2];
            byte b0 = (byte)(b >> 4);
            byte b1 = (byte)(b & 0x0F);
            c[0] = (char)(b0 > 9 ? b0 + 0x37 + 0x20 : b0 + 0x30);
            c[1] = (char)(b1 > 9 ? b1 + 0x37 + 0x20 : b1 + 0x30);
            return new string(c);

        }
    }
}
