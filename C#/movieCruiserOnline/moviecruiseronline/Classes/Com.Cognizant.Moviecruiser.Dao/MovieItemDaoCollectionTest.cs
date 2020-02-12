using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class MovieItemDaoCollectionTest
    {
        static string format = "{0,-10}{1,-20}{2,-20}{3,-10}{4,-15}{5,-15}{6}";
        static string heading = string.Format(format, "ID", "Name", "Budget", "Active", "Date of Launch", "Genre", "Has Teaser");
        public MovieItemDaoCollectionTest()
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            string choice;
            Console.WriteLine();
            l1: Console.Write("1. Get Movie Item List - Admin\n2. Get Movie Item List - Customer\n3. Modify Movie Item - Admin\n4. Get Movie Item - Admin\n\nEnter your choice: ");
            ch = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        TestGetMovieItemListAdmin(movieItemDao);
                        goto l1;
                    }
                case "2":
                    {
                        TestGetMovieItemListCustomer(movieItemDao);
                        goto l1;
                    }
                case "3":
                    {
                        TestModifyMovieItem(movieItemDao);
                        goto l1;
                    }
                case "4":
                    {
                        TestGetMovieItem(movieItemDao);
                        goto l1;
                    }
                default:
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }
            }
            Console.WriteLine();
        }
        public static void TestGetMovieItemListAdmin(MovieItemDaoCollection movieItemDao)
        {
            List<MovieItem> movieItemList = movieItemDao.GetMovieItemListAdmin();
            Console.WriteLine("\n" + heading);
            foreach (MovieItem movie in movieItemList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }
        public static void TestGetMovieItemListCustomer(MovieItemDaoCollection movieItemDao)
        {
            List<MovieItem> movieItemList = movieItemDao.GetMovieItemListCustomer();
            Console.WriteLine("\n" + heading);
            foreach (MovieItem movie in movieItemList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }
        public static void TestModifyMovieItem(MovieItemDaoCollection movieItemDao)
        {
            List<MovieItem> movieItemList = movieItemDao.GetMovieItemListAdmin();
            Console.WriteLine("\nMovies before modification:\n");
            Console.WriteLine(heading);
            foreach (MovieItem movie in movieItemList)
            {
                Console.WriteLine(movie);
            }
            Console.Write("\nEnter the Movie ID you wish to modify: ");
            long id = long.Parse(Console.ReadLine());
            Console.Write("Enter Movie Name: ");
            string movieName = Console.ReadLine();
            Console.Write("Enter Movie Budget: ");
            long movieBudget = long.Parse(Console.ReadLine());
            Console.Write("Active (Yes/No):");
            bool movieStatus = (Console.ReadLine().Equals("yes", StringComparison.InvariantCultureIgnoreCase)) == true ? true : false;
            Console.Write("Enter Date of Launch: ");
            DateTime dateOfLaunch = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Enter Movie Genre: ");
            string genre = Console.ReadLine();
            Console.Write("Has Teaser (Yes/No):");
            bool hasTeaser = (Console.ReadLine().Equals("yes", StringComparison.InvariantCultureIgnoreCase)) == true ? true : false;
            movieItemDao.ModifyMovieItem(new MenuItem(id, movieName, movieBudget, movieStatus, dateOfLaunch, genre, hasTeaser));
            Console.WriteLine("\nMovies after modification:\n");
            movieItemList = movieItemDao.GetMovieItemListAdmin();
            Console.WriteLine(list);
            foreach (MovieItem movie in movieItemList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }
        public static void TestGetMovieItem(MovieItemDaoCollection movieItemDao)
        {
            Console.Write("\nEnter Movie Item ID: ");
            long movieId = long.Parse(Console.ReadLine());
            Console.WriteLine("\n" + heading);
            Console.WriteLine(movieItemDao.GetMovieItem(movieId) + "\n");
        }
    }
}