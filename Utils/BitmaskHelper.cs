﻿namespace BowieCode {

    // http://stackoverflow.com/questions/3261451/using-a-bitmask-in-c-sharp

    /// <summary>
    /// Util for checking if bits are set in a bitmask.
    /// </summary>
    public static class BitmaskHelper {
        public static bool IsSet<T> ( T flags, T flag ) where T : struct {
            int flagsValue = (int)(object)flags;
            int flagValue = (int)(object)flag;
            return ( flagsValue & flagValue ) != 0;
        }

        public static void Set<T> ( ref T flags, T flag ) where T : struct {
            int flagsValue = (int)(object)flags;
            int flagValue = (int)(object)flag;
            flags = (T)(object)( flagsValue | flagValue );
        }

        public static void Unset<T> ( ref T flags, T flag ) where T : struct {
            int flagsValue = (int)(object)flags;
            int flagValue = (int)(object)flag;
            flags = (T)(object)( flagsValue & ( ~flagValue ) );
        }
    }
}
