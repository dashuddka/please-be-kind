using Avalonia.Controls.Shapes;
using CourseWork.Models;
using CourseWork.Models.SerializebleElements;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using YamlDotNet.Serialization;

namespace CourseWork.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        private int index;
        private ObservableCollection<ProjectFile> projects;

        public StartViewModel()
        {
            Projects = new ObservableCollection<ProjectFile>();
            Index = -1;
            Serialize();
        }

        private void Serialize()
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<ProjectFile>));

                using (var stream = new FileStream("../../../Assets/projects.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Projects = (ObservableCollection<ProjectFile>)formatter.Deserialize(stream);
                }
            }
            catch { }
        }

        public ObservableCollection<ProjectFile> Projects
        {
            get => projects;
            set => this.RaiseAndSetIfChanged(ref projects, value);
        }
        public int Index
        {
            get => index;
            set => this.RaiseAndSetIfChanged(ref index, value);
        }
    }
}
