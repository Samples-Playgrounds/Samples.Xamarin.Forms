using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace QuickUIDemo.Android.Core
{
    public class DataViewModel : MvxViewModel
    {
        public class Person
            : MvxNotifyPropertyChanged
        {
            private string _name;
            public string Name 
            {   
                get { return _name; }
                set { _name = value; RaisePropertyChanged(() => Name); }
            }

            private string _title;
            public string Title 
            {   
                get { return _title; }
                set { _title = value; RaisePropertyChanged(() => Title); }
            }

            public Person()
            {
            }

            public Person(string name, string title)
            {
                Name = name;
                Title = title;
            }
        }

        private List<Person> _people;
        public List<Person> People 
        {   
            get { return _people; }
            set { _people = value; RaisePropertyChanged(() => People); }
        }

        public DataViewModel()
        {
            People = new List<Person>()
                {
                    new Person { Name = "Jason Smith", Title = "Engineer" },
                    new Person { Name = "Seth Rosetter", Title ="Jr. Engineer" },
                    new Person { Name = "Eric M", Title = "Engineer" },
                    new Person { Name = "David S", Title = "Designer" },
                    new Person  { Name = "Vinny D", Title = "Designer" },
                    new Person { Name = "Nat Friedman", Title = "CEO" },
                    new Person { Name = "Miguel de Icaza", Title =  "CTO" }
                };
            }
    }
}