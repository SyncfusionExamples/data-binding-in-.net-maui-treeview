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

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.
