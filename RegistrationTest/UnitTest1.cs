using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationSystem;

namespace UserRegistrationTest
{
    //UC 10
    [TestClass]
    public class UserRegistrationTest
    {
        //UC 12
        [TestMethod]
        [DataRow("Snehal")]//Valid First Name
        [DataRow("snehal")]//InValid First Name
        public void FirstNameCheck(string fname)
        {
            try
            {
                bool value = Program.FirstNameCheck(fname);
            }
            catch (Program e)
            {
                Assert.AreEqual("Invalid First Name", e.Message);
            }
        }
        [TestMethod]
        [DataRow("Patil")]//Valid Last Name
        [DataRow("patil")]//InValid Last Name
        public void Given_Invalid_Last_Name(string lname)
        {
            try
            {
                bool value = Program.LastNameCheck(lname);
            }
            catch (Program e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
        [TestMethod]
        [DataRow("snehal@gmail.com")]//Valid Email
        [DataRow("patil")]//InValid Email
        public void Given_Invalid_Email(string mail)
        {
            try
            {
                bool value = Program.LastNameCheck(mail);
            }
            catch (Program e)
            {
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }
        [TestMethod]
        [DataRow("91 8106529025")]//Valid Mobile Number
        [DataRow("801878912")]//InValid Mobile Number
        public void Given_Invalid_MobileNumber(string number)
        {
            try
            {
                bool value = Program.LastNameCheck(number);
            }
            catch (Program e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }
        [TestMethod]
        [DataRow("Password.4")]//Valid Password
        [DataRow("password")]//InValid Password
        public void Given_Invalid_Password(string pass)
        {
            try
            {
                bool value = Program.LastNameCheck(pass);
            }
            catch (Program e)
            {
                Assert.AreEqual("Invalid PassWord", e.Message);
            }
        }

    }
}