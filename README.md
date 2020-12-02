# WPFPathDesigner
This is a very simple application writter in WPF MVVM to visualize Path Data. It uses simple base class that implements `INotifyPropertyChanged` interface and exposes SetProperty method for creating properties in simple way.
`MainViewModel` contains collection of items, selected item and one command to add new item. Each item contains properties for path Data, Width, Height and StrokeThickness. User can manipulate these properties to see how the path looks like.
There is also super-simple implementation on `ICommand` interface to enable command usage in `MainViewModel`.

Feel free to download or fork and modify this simple app :)

![Application](https://github.com/darthmaure/WPFPathDesigner/blob/main/images/wpfpathdesigner.PNG "Application")
