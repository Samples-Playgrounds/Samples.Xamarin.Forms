using System;
using System.ComponentModel;
using System.Windows.Input;

using Xamarin.Forms;

namespace AsyncAwait.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        public CalculatorViewModel()
        {
            Title = "Calculator";
            Number = "1000000000";

            CalculateSynchronousCommand = new Command(CalculateSynchronousCommandHandleAction);
            CalculateAsynchronousTaskRunCommand = new Command(CalculateAsynchronousTaskRunCommandHandleAction);
            CalculateAsynchronousReturnTaskWithoutTaskRunCommand = new Command(CalculateAsynchronousReturnTaskWithoutTaskRunCommandHandleAction);

            return;
        }

        string number;
        public string Number
        {
            get => number;
            set => SetProperty(ref number, value);
        }

        double result;
        public double Result
        {
            get => result;
            set => SetProperty(ref result, value);
        }

        string status;
        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

                public ICommand CalculateSynchronousCommand 
        { 
            get; 
        }

        public ICommand CalculateAsynchronousTaskRunCommand 
        { 
            get; 
        }
        public ICommand CalculateAsynchronousReturnTaskWithoutTaskRunCommand 
        { 
            get; 
        }

        void CalculateSynchronousCommandHandleAction(object obj)
        {
            if (IsBusy)
            {
                return;
            }

            Result = double.NaN;
            IsBusy = true;

            try
            {
                long n = long.Parse(number);
                Models.Calculator c = new Models.Calculator();
                Result = c.Calculate(n);
            }
            catch (Exception e)
            {
                Status = $"Calculator failed {e.Message}";
                System.Diagnostics.Debug.WriteLine(status);
            }
            finally
            {
                IsBusy = false;
            }

            return;
        }


        void CalculateAsynchronousTaskRunCommandHandleAction(object obj)
        {
            if (IsBusy)
            {
                return;
            }

            Result = double.NaN;
            IsBusy = true;

            try
            {
                long n = long.Parse(number);
                Models.Calculator c = new Models.Calculator();
                Result = await c.CalculateAsync(n);
            }
            catch (Exception e)
            {
                Status = $"Calculator failed {e.Message}";
                System.Diagnostics.Debug.WriteLine(status);
            }
            finally
            {
                IsBusy = false;
            }

            return;
        }

        void CalculateAsynchronousReturnTaskWithoutTaskRunCommandHandleAction(object obj)
        {
        }

    }
}