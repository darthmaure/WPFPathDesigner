namespace PathDesigner
{
    public class PathDesignerItem : BaseItem
    {
        private string _data;
        public string Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _stroke;
        public string Stroke
        {
            get => _stroke;
            set
            {
                if (double.TryParse(value, out var x))
                    SetProperty(ref _stroke, value);
            }
        }

        private string _heigth;
        public string Heigth
        {
            get => _heigth;
            set
            {
                if (double.TryParse(value, out var x))
                    SetProperty(ref _heigth, value);
            }
        }

        private string _width;
        public string Width
        {
            get => _width;
            set
            {
                if (double.TryParse(value, out var x))
                    SetProperty(ref _width, value);
            }
        }
    }
}
