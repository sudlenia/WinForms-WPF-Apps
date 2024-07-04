using GalaSoft.MvvmLight.Command;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;

namespace ViewModel
{
    public class Logic : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string prop = " ") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        public ObservableCollection<Speciality> Specialities { get; set; } = new();
        public ObservableCollection<Student> Students { get; set; } = new() {
            new Student() { Name = "�����", Group = "Q", Speciality = "Q"},
            new Student() { Name = "������", Group = "W", Speciality = "Q"},
            new Student() { Name = "����", Group = "E", Speciality = "R"},
            new Student() { Name = "������", Group = "R", Speciality = "R"},
            new Student() { Name = "������� �����", Group = "��21-22�", Speciality = "��"}
        };

        public Logic()
        {
            UpdateHistogram();
        }

        public Student? NewStudent { get; set; } = new();
        public Student? SelectedStudent { get; set; }

        private RelayCommand? _deleteStudent;
        private RelayCommand? _addStudent;

        public RelayCommand DeleteStudent => _deleteStudent
                    ??= new RelayCommand(() =>
                    {
                        Students.Remove(SelectedStudent);
                        UpdateHistogram();
                    });

        public RelayCommand AddStudent => _addStudent
            ??= new RelayCommand(
                () =>
                {
                    if (!(string.IsNullOrEmpty(NewStudent.Name) || string.IsNullOrEmpty(NewStudent.Speciality) || string.IsNullOrEmpty(NewStudent.Group))) 
                    {
                        Students.Add(new Student() { Name = NewStudent.Name, Speciality = NewStudent.Speciality, Group = NewStudent.Group });
                    }
                    UpdateHistogram();
                });

        public void UpdateHistogram()
        {
            Specialities.Clear();
            Students
                .GroupBy(x => x.Speciality)
                .Select(x => new { Speciality = x.Key, Count = x.Count() })
                .ToList()
                .ForEach(d => Specialities.Add(
                    new Speciality() { Name = d.Speciality, Count = d.Count, Percent = d.Count * 100 / Students.Count }
                 ));
        }
    }
}
