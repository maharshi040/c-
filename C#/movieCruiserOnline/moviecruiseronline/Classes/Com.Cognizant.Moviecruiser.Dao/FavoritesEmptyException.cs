using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class FavoritesEmptyException : Exception
    {
        string output;
        public FavoritesEmptyException() : base("favorites is Empty")
        {

        }
        public FavoritesEmptyException(string message) : base(message)
        {
            output = message;
        }
    }
}