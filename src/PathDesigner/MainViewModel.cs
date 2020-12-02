using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PathDesigner
{
    public class MainViewModel : BaseItem
    {
        public MainViewModel()
        {
            AddNewItemCommand = new RelayCommand(x => true,
                x =>
                {
                    var newItem = new PathDesignerItem { Name = "new item", Stroke = "1.0", Heigth = "80", Width = "80" };
                    Items.Add(newItem);
                    SelectedItem = newItem;
                });
        }


        private ObservableCollection<PathDesignerItem> _items = new ObservableCollection<PathDesignerItem>();

        public ObservableCollection<PathDesignerItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private PathDesignerItem _selectedItem;

        public PathDesignerItem SelectedItem
        {
            get => _selectedItem;
            set => SetProperty(ref _selectedItem, value);
        }
        
        
        public ICommand AddNewItemCommand { get; set; }
    }
}
