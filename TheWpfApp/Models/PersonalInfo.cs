using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheWpfApp.Models
{
    public class PersonalInfo : INotifyPropertyChanged
    {
        public PersonalInfo() {//default constractor
            FName = string.Empty; // "\0"
            LName = string.Empty;
            Phone = string.Empty;
            Age =null;
            BirthDay = new DateTime();
            Email = string.Empty;
        }
        public PersonalInfo(string _fname, string _lname = "", string _phone = "", string _email= "")
        {//Set contractor
            FName = _fname;
            LName = _lname;
            Phone = _phone;
            Email = _email;
        }
        public PersonalInfo(string _fname, string _lname, string _phone, float _age, DateTime _birthday,string _email) {//Set contractor
            FName = _fname;
            LName = _lname;
            Phone = _phone;
            Age = _age;
            BirthDay = _birthday;
            Email = _email;

        }
        public PersonalInfo(PersonalInfo info) //copy constractor
        {
            FName = info.FName;
            LName = info.LName;
            Phone = info.Phone;
            Age = info.Age;
            BirthDay = info.BirthDay;
            Email = info.Email;
        }

        //props
        public string _FName = string.Empty;
        public string FName
        {
            get { return _FName; }
            set
            {
                _FName = value;
                OnPropertyChanged("FName");
            }
        }  
        public string _LName = string.Empty;
        public string LName
        {
            get { return _LName; }
            set
            {
                _LName = value;
                OnPropertyChanged("LName");
            }
        }
        public string _Phone = string.Empty;
        public string Phone
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
                OnPropertyChanged("Phone");
            }
        }
        public float? _Age = 0;
        public float? Age
        {
            get { return _Age; }
            set
            {
                _Age = value;
                OnPropertyChanged("Age");
            }
        }
            DateTime _BirthDay;
            public DateTime BirthDay
        {
            get { return _BirthDay; }
            set
            {
                _BirthDay = value;
                OnPropertyChanged("BirthDay");
            }
        }
        public string _Email = string.Empty;
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged("Email");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
    public class Time{
        int? H;
        int? M;

        public Time() //default
        {
            H = 0;
            M=0;
        }
        public Time(int _h, int _m) { H = _h;M = _m; }//set

        public Time(Time _t) { H = _t.H;M = _t.M; }//copy

        public void AddTime(int _h, int _m)
        {
         
            M = M + _m;
            if (M >= 60)
            {
                M = M - 60;
                H = H + 1;
            }
            H = H + _h;
            if (H >= 24)
            {
                H = H - 24;
            }
        }
        public void RemoveTime(int _h, int _m)
        {
            M =M- _m;
            if (M < 0)
            {
                H = H - 1;
                M = M + 60;
            }
            H = H - _h;
            if (H < 0)
            {
                H = H + 24;
            }
        }
       
        }
}
