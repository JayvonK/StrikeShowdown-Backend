using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Strike_Showdown_Back_End.Models;
using Strike_Showdown_Back_End.Models.DTO;
using Strike_Showdown_Back_End.Services;

namespace Strike_Showdown_Back_End.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _data;
        public UserController(UserService data)
        {
            _data = data;
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login([FromBody] LoginDTO User)
        {
            return _data.Login(User);
        }

        [HttpPost]
        [Route("AddUser")]
        public bool AddUser(CreateAccountDTO UserToAdd)
        {
            return _data.AddUser(UserToAdd);
        }

        [HttpPut]
        [Route("UpdateUser/{username}")]
        public bool UpdateUser(string username, UserWithoutSaltHashDTO userToUpdate)
        {
            return _data.UpdateUser(username, userToUpdate);
        }

        [HttpPut]
        [Route("ForgotPassword/{UsernameOrEmail}/{password}")]
        public bool ForgotPassword(string UsernameOrEmail, string password)
        {
            return _data.ForgotPassword(UsernameOrEmail, password);
        }

        [HttpPut]
        [Route("SendFriendRequest/{userID}/{yourID}")]
        public bool SendFriendRequest(int userID, int yourID)
        {
            return _data.SendFriendRequest(userID, yourID);
        }

        [HttpPut]
        [Route("AcceptFriendRequest/{userID}/{yourID}")]
        public bool AcceptFriendRequest(int userID, int yourID)
        {
            return _data.AcceptFriendRequest(userID, yourID);
        }

        [HttpPut]
        [Route("DeclineFriendRequest/{userID}/{yourID}")]
        public bool DeclineFriendRequest(int userID, int yourID)
        {
            return _data.DeclineFriendRequest(userID, yourID);
        }

        [HttpPut]
        [Route("RemoveFriend/{userID}/{yourID}")]
        public bool RemoveFriend(int userID, int yourID)
        {
            return _data.RemoveFriend(userID, yourID);
        }

        [HttpPut]
        [Route("AddDM/{yourID}/{userID}")]
        public bool AddDM(int yourID, int userID) {
            return _data.AddDirectMessage(yourID, userID);
        }

        [HttpGet]
        [Route("GetSecurity/{UsernameOrEmail}/{SecurityQuestion}/{SecurityAnswer}")]
        public bool GetSecurity(string UsernameOrEmail, string SecurityQuestion, string SecurityAnswer)
        {
            return _data.GetSecurity(UsernameOrEmail, SecurityQuestion, SecurityAnswer);
        }

        [HttpGet]
        [Route("GetUserByUsernameOrEmail/{usernameOrEmail}")]
        public UserWithoutSaltHashDTO GetUserByUsername(string usernameOrEmail)
        {
            return _data.GetPublicUserInfo(usernameOrEmail);
        }

        [HttpGet]
        [Route("GetUsersByState/{state}")]
        public IEnumerable<UserModel> GetUsersByState(string state)
        {
            return _data.GetAllUsersByState(state);
        }

         [HttpGet]
        [Route("GetUsernameByID/{id}")]
        public UsernameDTO GetUsernameByID(int id)
        {
            return _data.GetUsernameByID(id);
        }

        [HttpGet]
        [Route("GetUserByID/{id}")]
        public UserWithoutSaltHashDTO GetUserByID(int id)
        {
            return _data.GetUserWithoutSaltHashByID(id);
        }

        [HttpGet]
        [Route("GetAllFriends/{id}")]
        public List<UserWithoutSaltHashDTO> GetAllFriends(int id){
            return _data.GetAllFriends(id);
        }

        [HttpGet]
        [Route("GetAllDMs/{id}")]
        public List<UserWithoutSaltHashDTO> GetAllDMs(int id) {
            return _data.GetAllDirectMessages(id);
        }

        // DeleteUser Endpoint
        [HttpDelete]
        [Route("DeleteUser/{userToDelete}")]
        public bool DeleteUser(string userToDelete)
        {
            return _data.DeleteUser(userToDelete);
        }

    }
}