using CourseWork.Models;
using CourseWork.Models.LogicalElements;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Xml.Linq;
using CourseWork.Views;
using CourseWork.Models.SerializebleElements;
using System.IO;
using YamlDotNet.Serialization;
using Avalonia.Controls.Shapes;
using System.Linq;
using System.Xml.Serialization;

namespace CourseWork.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private object content;
        private MainUserControlViewModel mainModel;
        private StartViewModel startModel;
        public MainWindowViewModel()
        {
            mainModel = new MainUserControlViewModel();
            startModel = new StartViewModel();
            Content = startModel;
        }
        public object Content
        {
            get => content;
            set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public void CreateNewProject()
        {
            mainModel.Project = new Project();
            Content = mainModel;
        }
        public void AddNewProjectPath(string name, string path)
        {
            ProjectFile file = new ProjectFile { Name = name, Path = path};
            ProjectFile find = null;
            foreach (ProjectFile item in startModel.Projects)
            {
                if (item.Path == path) { find = item; break; }
            }
            if (find != null)
            {
                startModel.Projects.Remove(find);
                startModel.Projects.Insert(0, file);
            }
            else
            {
                startModel.Projects.Insert(0, file);
            }
            XmlSerializer formatter = new XmlSerializer(typeof(ObservableCollection<ProjectFile>));

            using (var stream = new FileStream("../../../Assets/projects.xml", FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                formatter.Serialize(stream, startModel.Projects);
            }
        }
        public void OpenProject(string path)
        {
            if (File.Exists(path))
            {
                Content = mainModel;
                mainModel.Index = 0;
                mainModel.ChangeElements = true;
                mainModel.Project = CourseWork.Models.Serializer.Load(path);
                mainModel.ChangeElements = false;
                mainModel.Index = 0;
            }
            else
            {
                startModel.Projects.RemoveAt(startModel.Index);
            }
        }
    }
}
