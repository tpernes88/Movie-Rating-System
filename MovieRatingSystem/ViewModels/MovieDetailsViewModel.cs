using MovieRatingSystem.Models;

namespace MovieRatingSystem.ViewModels
{
    public class MovieDetailsViewModel
    {
        //DEVERIA COLOCAR AS PROPRIEDADES DO MOVIE AQUI INVES DE PASSAR A CLASSE? POR RAZOES DE DEPENDENCIA. CRIAR UM METHOD QUE ME RETORNE A STRING DE ACTORS?


        public Movie Movie { get; set; }
        public string ActorsString { get; set; }
    }
}
