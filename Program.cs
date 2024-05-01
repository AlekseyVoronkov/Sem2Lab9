using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using NLog;

namespace CSharpLab8
{
    interface IView
    {
        string SourceDirectory();
        string TargetDirectory();

        void TryToSynchronize(List<string> message);

        event EventHandler<EventArgs> SyncronizeDirectoriesEvent;
    }

    class Model
    {
        public List<string> SynchronizeDirectories(string sourceDirectory, string targetDirectory)
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            DirectoryInfo source = new DirectoryInfo(sourceDirectory);
            DirectoryInfo target = new DirectoryInfo(targetDirectory);
            List<string> resultOfSynchronization = InnerSynchronizeDirectory(source, target);

            logger.Info($"Synchronizing directory {target} with directory {source}");
            return resultOfSynchronization;
        }

        private List<string> InnerSynchronizeDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info($"Synchronizing directory {target} with directory {source}");
            bool isNeedToSynchronize = false;
            List<string> innerResultOfSynchronization = new List<string>();

            foreach (FileInfo file in source.GetFiles())
            {
                FileInfo otherDirectoryFile = new FileInfo(Path.Combine(target.FullName, file.Name));

                if (!otherDirectoryFile.Exists || otherDirectoryFile.LastWriteTime < file.LastWriteTime)
                {
                    File.Copy(file.FullName, otherDirectoryFile.FullName, true);
                    innerResultOfSynchronization.Add($"File {file.Name} changed");
                    logger.Info($"Result of synchronization: file {file.Name} in directory {target} changed");
                    isNeedToSynchronize = true;
                }
            }

            foreach (FileInfo file in target.GetFiles())
            {
                FileInfo mainDirectoryFile = new FileInfo(Path.Combine(source.FullName, file.Name));

                if (!mainDirectoryFile.Exists)
                {
                    file.Delete();
                    innerResultOfSynchronization.Add($"File {file.Name} deleted");
                    logger.Info($"Result of synchronization: file {file.Name} is deleted from directory {target}");
                    isNeedToSynchronize = true;
                }
            }

            if (!isNeedToSynchronize)
            {
                innerResultOfSynchronization.Add("Seems like there is no need in synchronization");
                logger.Info($"Result of synchronization: Seems like there is no need in synchronization");
            }

            return innerResultOfSynchronization;
        }
    }

    class Presenter
    {
        private IView _view;
        private Model _model;


        public Presenter(IView inputView)
        {
            _view = inputView;
            _model = new Model();

            _view.SyncronizeDirectoriesEvent += new EventHandler<EventArgs>(Synchronize);
        }

        private void Synchronize(object sender, EventArgs inputEvent)
        {
            List<string> resultOfSynchronization = _model.SynchronizeDirectories(_view.SourceDirectory(), _view.TargetDirectory());

            _view.TryToSynchronize(resultOfSynchronization);
        }
    }
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
