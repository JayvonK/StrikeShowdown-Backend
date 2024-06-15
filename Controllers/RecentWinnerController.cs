using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Strike_Showdown_Back_End.Models;
using Strike_Showdown_Back_End.Services;

namespace Strike_Showdown_Back_End.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecentWinnerController : ControllerBase
    {
        private readonly RecentWinnerService _recentWinner;
        public RecentWinnerController(RecentWinnerService recentWinner)
        {
            _recentWinner = recentWinner;
        }

        [HttpGet] 
        [Route("GetRecentWinnerModelsByState/{state}")]
        public IEnumerable<RecentWinnerModel> GetRecentWinnerModelsByState(string state)
        {
            return _recentWinner.GetRecentWinnerModelsByState(state);
        }

        [HttpPost] 
        [Route("AddRecentWinner/{username}")]
        public bool AddRecentWinner(string username)
        {
            return _recentWinner.AddRecentWinner(username);
        }

        
    }
}