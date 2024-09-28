using Domain.Entities.Movie;

namespace Logic.Interfaces;

public interface IMovieLogic
{
    public MovieTicket PurchaseTicket(int theaterId, int movieId, DateTime showingTime);
    public bool CheckTicket(int ticketId);
}