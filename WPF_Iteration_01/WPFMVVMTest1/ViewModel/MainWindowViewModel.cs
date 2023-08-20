using System.Collections.ObjectModel;
using WPFMVVMTest1.Model;

namespace WPFMVVMTest1.MVVM
{
    class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);
        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => CanSave());

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "NEW ITEM",
                SerialNumber = "XXXXX",
                Quantity = 0
            });
        }
        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }

        private void Save()
        {
            // Save to file process
        }

        private bool CanSave()
        {
            return true;
        }
    }
}
