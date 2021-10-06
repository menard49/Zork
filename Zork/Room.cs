using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zork
{
    public class Room 
    {
        [JsonProperty]
        public string Name { get; private set; }

        [JsonProperty]
        public string Description { get; private set; }

        [JsonProperty(PropertyName ="Neighbors")]
        public Dictionary<Directions, string> NeighborNames { get; set; }

        [JsonIgnore]
        public Dictionary<Directions, Room> Neighbors { get; set; } //IReadOnly

      // public static bool operator ==(Room lhs, Room rhs)
      // {
      //     if (ReferenceEquals(lhs, rhs))
      //     {
      //         return true;
      //     }
      //     if (lhs is null || rhs is null)
      //     {
      //         return false;
      //     }
      //     return lhs.Name == rhs.Name;
      // }

      //  public static bool operator !=(Room lhs, Room rhs) => (lhs == rhs);
      //  public override bool Equals(object obj) => obj is Room room ? this == room : false;
      //
      //  public bool Equals(Room other) => this == other;

        public override string ToString() => Name;

      //  public override int GetHashCode() => Name.GetHashCode();

      //  public void UpdateNeighbors(World world) => Neighbors = (from entry in NeighborNames
      //                                                           let room = world.RoomsByName.GetValueOrDefault(entry.Value)
      //                                                           where room != null
      //                                                           select (Direction: entry.Key, Room: room))
      //                                                           .ToDictionary(pair => pair.Direction, pair => pair.Room);
       
        public void UpdateNeighbors(World world)
        {
            Neighbors = new Dictionary<Directions, Room>();
            foreach (var (direction, name) in NeighborNames)
            {

                Neighbors.Add(direction, world.RoomsByName[name]);
              //  Room room = null;
              // foreach (Room r in world.Rooms)
              // {
              //     if(r.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
              //     {
              //          Neighbors.Add(direction, r);
              //         break;
              //
              //     }
              // }
            } 
        }

        
    }
}
