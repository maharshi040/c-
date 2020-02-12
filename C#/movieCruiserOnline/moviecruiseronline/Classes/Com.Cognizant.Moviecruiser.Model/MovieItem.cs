using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Model
{
    public class MovieItem
    {
        private long id;
        private string title;
        private long budget;
        private Boolean active;
        private DateTime dateOfLaunch;
        private string genre;
        private Boolean hasTeaser;
        public long ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public long Budget
        {
            get
            {
                return budget;
            }
            set
            {
                budget = value;
            }
        }
        public Boolean Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }
        public DateTime DateOfLaunch
        {
            get
            {
                return dateOfLaunch;
            }
            set
            {
                dateOfLaunch = value;
            }
        }
        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        public Boolean HasTeaser
        {
            get
            {
                return hasTeaser;
            }
            set
            {
                hasTeaser = value;
            }
        }
        public MovieItem()
        {

        }
        public MovieItem(long ID, string Name, long Budget, Boolean Active, DateTime DateOfLaunch, string Genre, Boolean HasTeaser)
        {
            this.ID = ID;
            this.Name = Name;
            this.Budget = Budget;
            this.Active = Active;
            this.DateOfLaunch = DateOfLaunch;
            this.Genre = Genre;
            this.HasTeaser = HasTeaser;
        }
        public override string ToString()
        {
            string _active = (Active) ? "Yes" : "No";
            string _hasTeaser = (FreeDelivery) ? "Yes" : "No";
            string item = string.Format("{0,-10}{1,-20}{2,-20}{3,-10}{4,-15}{5,-15}{6}", ID, Name, Budget.ToString("0.00"), _active, DateOfLaunch.ToShortDateString(), Genre, _hasTeaser);
            return item;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}