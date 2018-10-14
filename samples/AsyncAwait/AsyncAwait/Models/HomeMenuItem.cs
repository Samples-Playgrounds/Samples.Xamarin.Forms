using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncAwait.Models
{
    public enum MenuItemType
    {
        Browse,
        Calculator,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
