using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TreeViewMaui;

namespace TreeViewMaui  
{
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
}
