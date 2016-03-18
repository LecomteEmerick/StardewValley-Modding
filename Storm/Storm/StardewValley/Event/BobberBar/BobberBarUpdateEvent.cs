﻿/*
    Copyright 2016 Shane Filiatrault

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

using Microsoft.Xna.Framework;
using Storm.StardewValley.Wrapper;

namespace Storm.StardewValley.Event
{
    public class BobberBarUpdateEvent : StaticContextEvent
    {
        public BobberBarUpdateEvent(BobberBar bobberBar, GameTime time)
        {
            BobberBar = bobberBar;
            Time = time;
        }

        public BobberBar BobberBar { get; }
        public GameTime Time { get; }
    }
}
