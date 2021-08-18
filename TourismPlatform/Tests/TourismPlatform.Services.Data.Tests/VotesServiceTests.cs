namespace TourismPlatform.Services.Data.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Moq;
    using TourismPlatform.Data.Common.Repositories;
    using TourismPlatform.Data.Models;
    using Xunit;

    public class VotesServiceTests
    {
        [Fact]
        public async Task WhenUserVitesTwoTimesOnlyOneVoteShoukdBeCounted()
        {
            var list = new List<Vote>();
            var mockRepo = new Mock<IRepository<Vote>>();
            mockRepo.Setup(x => x.All()).Returns(list.AsQueryable());
            mockRepo.Setup(x => x.AddAsync(It.IsAny<Vote>())).Callback((Vote vote) => list.Add(vote));
            var service = new VotesService(mockRepo.Object);

            await service.SetVoteAsync("1", "01", 1);
            await service.SetVoteAsync("1", "01", 2);
            await service.SetVoteAsync("1", "01", 5);
            await service.SetVoteAsync("1", "01", 3);
            await service.SetVoteAsync("1", "01", 4);

            Assert.Equal(1, list.Count);
            Assert.Equal(4, list.First().Value);

        }

        [Fact]
        public async Task WhenTwoUsersVoteForTheSameOfferTheAverageVoteShouldBeCorrect()
        {
            var list = new List<Vote>();
            var mockRepo = new Mock<IRepository<Vote>>();
            mockRepo.Setup(x => x.All()).Returns(list.AsQueryable());
            mockRepo.Setup(x => x.AddAsync(It.IsAny<Vote>())).Callback((Vote vote) => list.Add(vote));
            var service = new VotesService(mockRepo.Object);

            await service.SetVoteAsync("5", "Alex", 5);
            await service.SetVoteAsync("5", "Ivan", 3);
            await service.SetVoteAsync("5", "Alex", 4);

            Assert.Equal(2, list.Count);
            Assert.Equal(3.5, service.GetAverageVotes("5"));
        }
    }
}
