using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Logics : INotifyPropertyChanged
    {
        public ObservableCollection<Subject> Subjects { set; get; } = new ObservableCollection<Subject>();
        List<Subject> All = new List<Subject>();
        static string path = @"F:\C#\2 semester\lab5\lab.txt";

        public event PropertyChangedEventHandler? PropertyChanged;
        public Subject NewSubject { set; get; } = new Subject();
        public Subject SelectedSubject { set; get; } = new Subject();

        private RelayCommand addSubjectCommand, deleteSubjectCommand, changeStatusCommand, failStatusCommand, successStatusCommand, allStatusCommand, readFileCommand,
            saveFileCommand;

        public RelayCommand AddCommand
        {
            get
            {
                return addSubjectCommand ??
                    (addSubjectCommand = new RelayCommand(() =>
                    {
                        Subject toadd = new Subject { Name = NewSubject.Name, Status = NewSubject.Status };
                        bool fl = true;

                        foreach (Subject s in Subjects)
                        {
                            if (toadd.Name == s.Name)
                            {
                                fl = false;
                            }
                        }
                        if (fl && toadd.Name != null)
                        {
                            All.Add(toadd);
                            Subjects.Add(toadd);

                        }
                    }
                    ));
            }
        }
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteSubjectCommand ??
                    (deleteSubjectCommand = new RelayCommand(() =>
                    {
                        All.Remove(SelectedSubject);
                        Subjects.Remove(SelectedSubject);
                    }
                    ));
            }
        }
        public RelayCommand ChangeCommand
        {
            get
            {
                return changeStatusCommand ??
                    (changeStatusCommand = new RelayCommand(() =>
                    {
                        if (SelectedSubject != null)
                        {
                            SelectedSubject.Status = !SelectedSubject.Status;
                        }
                    }
                    ));
            }
        }
        public RelayCommand FailCommand
        {
            get
            {
                return failStatusCommand ??
                    (failStatusCommand = new RelayCommand(() =>
                    {
                        Subjects.Clear();
                        ShowFail();
                    }
                    ));
            }
        }
        public RelayCommand SuccesCommand
        {
            get
            {
                return successStatusCommand ??
                    (successStatusCommand = new RelayCommand(() =>
                    {
                        Subjects.Clear();
                        ShowSucces();
                    }
                    ));
            }
        }
        public RelayCommand AllCommand
        {
            get
            {
                return allStatusCommand ??
                    (allStatusCommand = new RelayCommand(() =>
                    {
                        Subjects.Clear();
                        ShowAll();
                    }
                    ));
            }
        }
        public void ShowAll()
        {
            foreach (Subject s in All)
            {
                Subjects.Add(s);
            }
        }
        public void ShowFail()
        {
            foreach (Subject s in All)
            {
                if (!s.Status) { Subjects.Add(s); }

            }
        }
        public void ShowSucces()
        {
            foreach (Subject s in All)
            {
                if (s.Status) { Subjects.Add(s); }
            }
        }
        public RelayCommand ReadCommand
        {
            get
            {
                return readFileCommand ??
                    (readFileCommand = new RelayCommand(() =>
                    {
                        ReadFile();
                    }
                    ));
            }
        }
        public RelayCommand SaveCommand
        {
            get
            {
                return saveFileCommand ??
                    (saveFileCommand = new RelayCommand(() =>
                    {
                        SaveFile();
                    }
                    ));
            }
        }
        public void ReadFile()
        {
            string[] text = File.ReadAllLines(path);
            Subjects.Clear();
            All.Clear();
            foreach (string s in text)
            {
                string[] temp = s.Split(',');
                string name = temp[0];
                bool status = Convert.ToBoolean(temp[1]);

                if (name != null)
                {
                    All.Add(new Subject { Name = name, Status = status });
                    Subjects.Add(new Subject { Name = name, Status = status });

                }
            }
        }
        public void SaveFile()
        {
            string tosave = string.Empty;
            foreach (Subject s in Subjects)
            {
                string name = s.Name;
                string stat = s.Status.ToString();
                tosave += $"{name},{stat}\n";
            }
            File.WriteAllTextAsync(path, tosave);

        }

    }
}
