using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Moviecruiser.Dao
{
    interface IMovieItemDao
    {
        List<MovieItem> GetMovieItemListAdmin();
        List<MovieItem> GetMovieItemListCustomer();
        void ModifyMovieItem(MovieItem movieItem);
        MovieItem GetMovieItem(long movieItemId);
    }
}
