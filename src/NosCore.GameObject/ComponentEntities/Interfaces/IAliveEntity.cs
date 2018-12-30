﻿//  __  _  __    __   ___ __  ___ ___  
// |  \| |/__\ /' _/ / _//__\| _ \ __| 
// | | ' | \/ |`._`.| \_| \/ | v / _|  
// |_|\__|\__/ |___/ \__/\__/|_|_\___| 
// 
// Copyright (C) 2018 - NosCore
// 
// NosCore is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace NosCore.GameObject.ComponentEntities.Interfaces
{
    public interface IAliveEntity : IVisualEntity
    {
        bool IsSitting { get; set; }

        byte Speed { get; }

        int Mp { get; set; }

        int Hp { get; set; }

        short Morph { get; }

        byte MorphUpgrade { get; }

        short MorphDesign { get; }

        byte MorphBonus { get; }

        bool NoAttack { get; }

        bool NoMove { get; }

        bool IsAlive { get; }

        short MapX { get; }

        short MapY { get; }

        int MaxHp { get; }

        int MaxMp { get; }

        byte Level { get; set; }

        byte HeroLevel { get; }

        short Race { get; }
        
        void SetLevel(byte level);

        Shop Shop { get; }
    }
}