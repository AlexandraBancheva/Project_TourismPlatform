namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public interface IVotesService
    {
        Task SetVoteAsync(string offertId, string applicationUserId, byte value);

        double GetAverageVotes(string offertId);
    }
}
