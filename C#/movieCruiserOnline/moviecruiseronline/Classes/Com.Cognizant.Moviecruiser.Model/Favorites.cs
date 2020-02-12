using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Model
{
    public class Favorites
    {
        private List<MovieItem> movieItemList;
        public List<MovieItem> MovieItemList
        {
            get
            {
                return movieItemList;
            }
            set
            {
                movieItemList = value;
            }
        }
        public Favorites()
        {

        }
        public Favorites(List<MovieItem> MovieItemList)
        {
            this.MovieItemList = MovieItemList;
        }
    }
}