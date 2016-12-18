﻿/*
 * This file is part of Soulworker Patcher.
 * Copyright (C) 2016 Miyu
 * 
 * Soulworker Patcher is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * Soulworker Patcher is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with Soulworker Patcher. If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace SWPatcher.General
{
    public class Language
    {
        public string Lang { get; private set; }
        public DateTime LastUpdate { get; private set; }

        public Language(string lang, DateTime lastUpdate)
        {
            this.Lang = lang;
            this.LastUpdate = lastUpdate;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Language language = obj as Language;
            return this.Lang == language.Lang;
        }

        public override int GetHashCode()
        {
            return this.Lang.GetHashCode();
        }

        public override string ToString()
        {
            return this.Lang;
        }
    }
}
