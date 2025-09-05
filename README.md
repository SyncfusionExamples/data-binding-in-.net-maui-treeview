# data-binding-in-.net-maui-treeview

This repository demonstrates how to perform data binding with the .NET MAUI SfTreeView control. It provides a sample implementation that shows how to bind hierarchical data from a ViewModel to the TreeView, enabling dynamic and structured display of data in a tree format.

## Sample

### XAML

```xaml

<ContentPage.BindingContext>
    <local:FileManagerViewModel x:Name="viewModel"/>
</ContentPage.BindingContext>

<ContentPage.Content>
    <Grid>
        <syncfusion:SfTreeView x:Name="treeView" 
                                   ChildPropertyName="SubFiles"
                                   ItemsSource="{Binding ImageNodeInfo}"  
                                   AutoExpandMode="AllNodesExpanded">

            <syncfusion:SfTreeView.ItemTemplate>
                <DataTemplate>
                    <Grid x:Name="grid" RowSpacing="0">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="40" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <Grid Grid.Column="0">
                            <Image Source="{Binding ImageIcon}"
                                       VerticalOptions="Center"
                                       HorizontalOptions="Center"
                                       HeightRequest="24" 
                                       WidthRequest="24"/>
                        </Grid>
                        <Grid Grid.Column="1">
                            <Label LineBreakMode="NoWrap"
                                       Text="{Binding ItemName}"
                                       VerticalTextAlignment="Center">
                            </Label>
                        </Grid>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfTreeView.ItemTemplate>
        </syncfusion:SfTreeView>
    </Grid>
</ContentPage.Content>
```

### ViewModel:

```csharp
public class FileManagerViewModel
{
    #region Fields

    private ObservableCollection<FileManager> imageNodeInfo;

    #endregion

    #region Constructor

    public FileManagerViewModel()
    {   
        GenerateSource();
    }

    #endregion

    #region Properties

    public ObservableCollection<FileManager> ImageNodeInfo
    {
        get { return imageNodeInfo; }
        set { this.imageNodeInfo = value; }
    }   

    #endregion

    #region Generate Source

    private void GenerateSource()
    {
        var nodeImageInfo = new ObservableCollection<FileManager>();
          
        var doc = new FileManager() { ItemName = "Documents", ImageIcon = "folder.png" };
        var download = new FileManager() { ItemName = "Downloads", ImageIcon = "folder.png" };
        var mp3 = new FileManager() { ItemName = "Music", ImageIcon ="folder.png" };
        var pictures = new FileManager() { ItemName = "Pictures", ImageIcon = "folder.png" };
        var video = new FileManager() { ItemName = "Videos", ImageIcon ="folder.png" };

        var pollution = new FileManager() { ItemName = "Environmental Pollution.docx", ImageIcon = "word.png" };
        var globalWarming = new FileManager() { ItemName = "Global Warming.ppt", ImageIcon = "ppt.png" };
        var sanitation = new FileManager() { ItemName = "Sanitation.docx", ImageIcon = "word.png"};
        var socialNetwork = new FileManager() { ItemName = "Social Network.pdf", ImageIcon ="pdfimage.png" };
        var youthEmpower = new FileManager() { ItemName = "Youth Empowerment.pdf", ImageIcon = "pdfimage.png" };

           
        var tutorials = new FileManager() { ItemName = "Tutorials.zip", ImageIcon = "zip.png" };
        var typeScript = new FileManager() { ItemName = "TypeScript.7z", ImageIcon ="zip.png" };
        var uiGuide = new FileManager() { ItemName = "UI-Guide.pdf", ImageIcon = "pdfimage.png"};

        var song = new FileManager() { ItemName = "Gouttes", ImageIcon = "audio.png" };

        var camera = new FileManager() { ItemName = "Camera Roll", ImageIcon = "folder.png" };
        var stone = new FileManager() { ItemName = "Stone.jpg", ImageIcon = "image.png" };
        var wind = new FileManager() { ItemName = "Wind.jpg", ImageIcon = "image.png"};

        var img0 = new FileManager() { ItemName = "WIN_20160726_094117.JPG", ImageIcon = "people_circle23.png" };
        var img1 = new FileManager() { ItemName = "WIN_20160726_094118.JPG", ImageIcon = "people_circle2.png" };

        var video1 = new FileManager() { ItemName = "Naturals.mp4", ImageIcon = "video.png" };
        var video2 = new FileManager() { ItemName = "Wild.mpeg", ImageIcon = "video.png" };

        doc.SubFiles = new ObservableCollection<FileManager>
        {
            pollution,
            globalWarming,
            sanitation,
            socialNetwork,
            youthEmpower
        };

        download.SubFiles = new ObservableCollection<FileManager>
        {
            tutorials,
            typeScript,
            uiGuide
        };

        mp3.SubFiles = new ObservableCollection<FileManager>
        {
            song
        };

        pictures.SubFiles = new ObservableCollection<FileManager>
        {   
            camera,
            stone,
            wind
        };  
        camera.SubFiles = new ObservableCollection<FileManager>
        {
            img0,
            img1
        };

        video.SubFiles = new ObservableCollection<FileManager>
        {
            video1,
            video2
        };

        nodeImageInfo.Add(doc);
        nodeImageInfo.Add(download);
        nodeImageInfo.Add(mp3);
        nodeImageInfo.Add(pictures);
        nodeImageInfo.Add(video);
        imageNodeInfo = nodeImageInfo;
    }

    #endregion

}
```

### Model

```csharp
public class FileManager : INotifyPropertyChanged
{
    #region Fields

    private string itemName;
    private ImageSource imageIcon;
    private ObservableCollection<FileManager> subFiles;

    #endregion

    #region Constructor
    public FileManager()
    {   
    }

    #endregion

    #region Properties
    public ObservableCollection<FileManager> SubFiles
    {
        get { return subFiles; }
        set
        {
            subFiles = value;
            RaisedOnPropertyChanged("SubFiles");
        }
    }

    public string ItemName
    {
        get { return itemName; }
        set
        {
            itemName = value;
            RaisedOnPropertyChanged("ItemName");
        }
    }
    public ImageSource ImageIcon
    {
        get { return imageIcon; }
        set
        {
            imageIcon = value;
            RaisedOnPropertyChanged("ImageIcon");
        }
    }

    #endregion

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    public void RaisedOnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    #endregion
}
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
