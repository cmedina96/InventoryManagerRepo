using System.ComponentModel;
using InventoryManager.Data;

namespace InventoryManager.WinForms.ViewModels
{
    // Encapsulates a World
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }
        public World World { get; set; }
    }
}
