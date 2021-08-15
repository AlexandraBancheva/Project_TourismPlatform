namespace TourismPlatform.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;

    public class VotesService : IVotesService
    {
        private readonly IRepository<Vote> votesRepository;

        public VotesService(IRepository<Vote> votesRepository)
        {
            this.votesRepository = votesRepository;
        }

        public double GetAverageVotes(string offertId)
        {
            return this.votesRepository.All().Where(x => x.OffertId == offertId).Average(x => x.Value);
        }

        public async Task SetVoteAsync(string offertId, string applicationUserId, byte value)
        {
            var vote = this.votesRepository.All().FirstOrDefault(x => x.OffertId == offertId && x.ApplicationUserId == applicationUserId);
            if (vote == null)
            {
                vote = new Vote
                {
                    OffertId = offertId,
                    ApplicationUserId = applicationUserId,
                };

                await this.votesRepository.AddAsync(vote);
            }

            vote.Value = value;
            await this.votesRepository.SaveChangesAsync();
        }
    }
}
