using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PlayingWithListViews.BusinessEntities;
using Xplat_Core;

namespace PlayingWithListViews.ViewModels
{
    public class ExampleViewModel : ViewModelBase
    {

        public ExampleViewModel()
        {
            
            Jobs = new ObservableCollection<Job>()
            {
                new Job() { JobId = "3672", JobName = "Big Job", Hours = 2},
                new Job() { JobId = "6289", JobName = "Smaller Job", Hours = 2},
                new Job() { JobId = "3672-41", JobName = "Add On Job", Hours = 23},                
            };            
        }

        public ObservableCollection<Job> Jobs { get; set; }


        public ICommand AddOneCommand
        {
            get
            {
                if (addOneCommand == null)
                {
                    addOneCommand = new DelegateCommand(obj =>
                    {
                        Jobs.Add(new Job(){JobId = "1234", JobName = "add one", Hours = 12});                        
                    }, obj => !IsBusy);
                }
                return addOneCommand;
            }
        }
        ICommand addOneCommand;

        public ICommand AddTwoCommand
        {
            get
            {
                if (addTwoCommand == null)
                {
                    addTwoCommand = new DelegateCommand(obj =>
                    {
                        
                        Jobs.Add(new Job() { JobId = "9999", JobName = "add two", Hours = 12 });
                        Jobs.Add(new Job() { JobId = "8888", JobName = "add two", Hours = 12 });
                    }, obj => !IsBusy);
                }
                return addTwoCommand;
            }
        }
        ICommand addTwoCommand;
        
        public void GetHours()
        {

            //var results = await hoursController.Get(Date);
            // Jobs.RemoveAt(0);

            var results = new ObservableCollection<Job>()
            {
                new Job() { JobId = "3672", JobName = "RADO", Hours = 2},
                new Job() { JobId = "6289", JobName = "MGA Life Cycle Flexible Test System", Hours = 2},
                //new EnterTime() { JobId = "3672-41", JobName = "MGA Life Cycle Flexible Test System", Hours = 23},
                //new EnterTime() { JobId = "3672", JobName = "RADO", Hours = 24},
                //new EnterTime() { JobId = "3672", JobName = "RADO", Hours = 6},
                //new EnterTime() { JobId = "3672", JobName = "RADO", Hours = 4},
                //new EnterTime() { JobId = "3672", JobName = "RADO", Hours = 19},
            };
            foreach (var x in results)
                Jobs.Add(x);
            //Jobs.Clear();
            //Jobs.Add(new EnterTime()
            //{
            //    JobId = "3672",
            //    JobName = "RADO",
            //    Hours = 2
            //});
            //new Job() { JobId = "6289", JobName = "MGA Life Cycle Flexible Test System", Hours = 2},
            //new Job() { JobId = "3672-41", JobName = "MGA Life Cycle Flexible Test System", Hours = 23.75},
            //new Job() { JobId = "3672", JobName = "RADO", Hours = 24},
            //new Job() { JobId = "3672", JobName = "RADO", Hours = 6},
            //new Job() { JobId = "3672", JobName = "RADO", Hours = 4.75},
            //new Job() { JobId = "3672", JobName = "RADO", Hours = 19.25},

        }
    }
}