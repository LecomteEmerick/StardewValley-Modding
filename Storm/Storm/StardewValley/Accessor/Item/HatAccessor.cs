/*
    Copyright 2016 Cody R. (Demmonic)

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

namespace Storm.StardewValley.Accessor
{
    public interface HatAccessor
    {
        int _GetWhich();
        void _SetWhich(int val);

        System.String _GetDescription();
        void _SetDescription(System.String val);

        System.String _GetName();
        void _SetName(System.String val);

        bool _GetSkipHairDraw();
        void _SetSkipHairDraw(bool val);

        bool _GetIgnoreHairstyleOffset();
        void _SetIgnoreHairstyleOffset(bool val);
    }
}