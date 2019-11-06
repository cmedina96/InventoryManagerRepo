using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManager.Data
{
    public class World : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Player> Players { get; set; }

        public World()
        {
            Players = new List<Player>();
        }
    }
}
