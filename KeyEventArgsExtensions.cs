using SFML.Window;
using System.Collections.Generic;

namespace ZelenskiyGame.KeyEventArgsExtensions
{
    static class KeyEventArgsExtensions
    {
        public static KeyEventArgs GetContainsByVatuesKey(this KeyEventArgs[] list, KeyEventArgs arg)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (arg.Code == list[i].Code)
                {
                    return list[i];
                }
            }
            return null;
        }

    }
}
