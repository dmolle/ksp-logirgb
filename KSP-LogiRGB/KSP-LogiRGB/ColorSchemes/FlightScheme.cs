﻿using UnityEngine;

namespace KSP_LogiRGB.ColorSchemes
{
    /// <summary>
    ///     The base color scheme for all flight related game scenes.
    /// </summary>
    internal class FlightScheme : ColorScheme
    {
        /// <summary>
        ///     Overlays the defined keys over a black base layout.
        /// </summary>
        public FlightScheme()
        {
            

            KeyCode[] redkeys =
            {
                GameSettings.THROTTLE_FULL.primary.code, GameSettings.THROTTLE_CUTOFF.primary.code,
                GameSettings.THROTTLE_UP.primary.code, GameSettings.THROTTLE_DOWN.primary.code
            };
            SetKeysToColor(redkeys, Color.red);

            KeyCode[] bluekeys = {GameSettings.FOCUS_NEXT_VESSEL.primary.code, GameSettings.FOCUS_PREV_VESSEL.primary.code };
            SetKeysToColor(bluekeys, Color.blue);
        }
    }
}