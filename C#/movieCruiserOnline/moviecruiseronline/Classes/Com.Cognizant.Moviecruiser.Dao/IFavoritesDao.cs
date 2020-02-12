using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Moviecruiser.Dao
{
    interface IFavoritesDao
    {
        void AddFavoriteMovie(long userId, long movieItemId);
        Cart GetAllFavoriteMovies(long userId);
        void RemoveFavoriteMovie(long userId, long movieItemId);
    }
}
