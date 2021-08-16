namespace TourismPlatform.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using TourismPlatform.Common;
    using TourismPlatform.Services.Data;
    using TourismPlatform.Web.ViewModels.Votes;

    [Route("api/[controller]")]
    [ApiController]
    public class VotesController : BaseController
    {
        private readonly IVotesService votesService;

        public VotesController(IVotesService votesService)
        {
            this.votesService = votesService;
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<PostVoteResponseModel>> Post(PostVoteInputModel model)
        {
            var applicationUserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            await this.votesService.SetVoteAsync(model.OffertId, applicationUserId, model.Value);
            var averagevotes = this.votesService.GetAverageVotes(model.OffertId);
            return new PostVoteResponseModel { AverageVote = averagevotes };
        }
    }
}
