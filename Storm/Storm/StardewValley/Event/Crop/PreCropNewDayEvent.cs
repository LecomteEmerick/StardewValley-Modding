﻿/*
    Copyright 2016 Andrew Zah (Mr. Slowly)

    Storm is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Storm is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Storm.  If not, see <http://www.gnu.org/licenses/>.
 */

using Storm.StardewValley.Wrapper;

namespace Storm.StardewValley.Event
{
    public class PreCropNewDayEvent : StaticContextEvent
    {
        public PreCropNewDayEvent(Crop crop, int state, int fertilizer, int xTile, int yTile, GameLocation environment)
        {
            Crop = crop;
            State = state;
            Fertilizer = fertilizer;
            TileX = xTile;
            TileY = yTile;
            Environment = environment;
        }

        public Crop Crop { get; }
        public int State { get; }
        public int Fertilizer { get; }
        public int TileX { get; }
        public int TileY { get; }
        public GameLocation Environment { get; }
    }
}