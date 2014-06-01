using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xplat_Core;

namespace PlayingWithListViews.BusinessEntities
{
    public class Job : ViewModelBase
    {

        public string JobId
        {
            get
            {
                return GetProperty<string>();
            }
            set
            {
                SetProperty(value);
            }
        }

        public string JobName
        {
            get
            {
                return GetProperty<string>();
            }
            set
            {
                SetProperty(value);
            }
        }
        public double? Hours
        {
            get
            {
                return GetProperty<double?>();
            }
            set
            {
                SetProperty(value);

            }
        }

        public bool Locked
        {
            get
            {
                return GetProperty<bool>();
            }
            set
            {
                SetProperty(value);

            }
        }
    }
}