
using Day10_Assignment.Models;

namespace Day10_Assignment.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Register_ShouldSucceed_ForNewUser()
        {
            string username = "testuser1";
            string password = "pass123";

            bool result = UserService.Register(username, password);

            Assert.True(result);
        }

        [Fact]
        public void Register_ShouldFail_ForExistingUser()
        {
            string username = "testuser1";
            string password = "pass123";

            // Already registered in previous test
            bool result = UserService.Register(username, password);

            Assert.False(result);
        }

        [Fact]
        public void Authenticate_ShouldReturnTrue_ForCorrectCredentials()
        {
            string username = "testuser2";
            string password = "secret456";

            UserService.Register(username, password);
            bool result = UserService.Authenticate(username, password);

            Assert.True(result);
        }

        [Fact]
        public void Authenticate_ShouldReturnFalse_ForWrongPassword()
        {
            string username = "testuser3";
            string password = "correct";
            string wrongPassword = "wrong";

            UserService.Register(username, password);
            bool result = UserService.Authenticate(username, wrongPassword);

            Assert.False(result);
        }
    }
}