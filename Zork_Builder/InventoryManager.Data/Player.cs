using System.Collections.Generic;
using System.ComponentModel;

namespace InventoryManager.Data
{
    public class Player : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string Description { get; set; }

        public Item Inventory { get; set; }

        public Player()
        {
            Inventory = new Item();
        }

        public override string ToString() => Name;
    }
}
