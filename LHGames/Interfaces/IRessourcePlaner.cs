﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LHGames.Helper;

namespace LHGames.Interfaces
{
    public interface IRessourcePlaner
    {
        List<ResourceTileDescriptor> GetRessourcesPaths();

        ResourceTileDescriptor GetBestRessourcePath();
    }
}
