using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Model
{
    public class Student : INotifyPropertyChanged
    {
        private string? name;
        private string? speciality;
        private string? group;

        public string? Name 
        {
            get 
            {
                return name;
            }
            set 
            { 
                name = value; 
                NotifyPropertyChanged("Name"); 
            } 
        }
        public string? Speciality 
        {
            get
            {
                return speciality;
            }
            set  
            { 
                speciality = value; 
                NotifyPropertyChanged("Speciality"); 
            } 
        }
        public string? Group 
        {
            get
            {
                return group;
            }
            set 
            { 
                group = value; 
                NotifyPropertyChanged("Group"); 
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string prop = " ") 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
            
    }

}
