using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Zork
{
    public class World
    {
        public Room[] Rooms { get; set; }

        [JsonIgnore]
        public Dictionary<string, Room> RoomsByName; //IReadOnly

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {

           RoomsByName = new Dictionary<string, Room>();
           foreach (Room room in Rooms)
           {
               RoomsByName.Add(room.Name, room);
           }

            foreach (Room room in Rooms)
            {
                room.UpdateNeighbors(this);
            }
        }

    }
}
