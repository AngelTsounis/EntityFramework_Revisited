using Application.Contracts.Response;

namespace Application.Interfaces;

public interface ITrainerRepository
{
    Task<TrainerResponse?> GetTrainerWithDetailsAsync(int trainerId);
}
