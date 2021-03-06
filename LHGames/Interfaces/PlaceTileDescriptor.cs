using LHGames.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHGames.Interfaces
{
    public class PlaceTileDescriptor : IComparable<PlaceTileDescriptor>
    {
        public Tile Tile;
        public List<Tile> Path;

        public int CompareTo(PlaceTileDescriptor other)
        {
            Tile resourceTile = Tile;
            Tile otherResourceTile = other.Tile;
            double resourceScore = Path.Count;
            double otherResourceScore = other.Path.Count;

            return resourceScore.CompareTo(otherResourceScore);
        }
    }
}