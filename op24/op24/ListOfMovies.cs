using System;
using System.Collections.Generic;
using System.Text;

namespace op24 {
    public class ListOfMovies : List<Movie> {
        public List<Movie> Filter(MovieChecker doYouLikeThis) {
            List<Movie> result = new List<Movie>();
            foreach (Movie item in this) {
                if (doYouLikeThis(item))
                    result.Add(item);
            }
            return result;
        }

        public List<Movie> FilterRatingHigherThan70() {
            List<Movie> result = new List<Movie>();
            foreach (Movie item in this) {
                if (item.Rating > 70)
                    result.Add(item);
            }
            return result;
        }

        public List<Movie> FilterTitleStartsWithA() {
            List<Movie> result = new List<Movie>();
            foreach (Movie item in this) {
                if (item.Title.StartsWith("A"))
                    result.Add(item);
            }
            return result;
        }

        public List<Movie> FilterYearLower1980() {
            List<Movie> result = new List<Movie>();
            foreach (Movie item in this) {
                if (item.Year <= 1980)
                    result.Add(item);
            }
            return result;
        }
    }
}
