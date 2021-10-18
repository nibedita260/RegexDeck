using NUnit.Framework;
using RegularExpression;
namespace NUnitTest
{
    public class Tests
    {
        RegularExpressionValidation regex = new RegularExpressionValidation();
        //Test 1:- Firstname Validation Check
        [Test]
        public void Check_FirstName_Validate()
        {
            string actual=regex.FirstnameCheck("Nibedita");
            Assert.AreEqual("First Name Validated",actual);
        }
        //Test 2:- Email Validation Check
        [Test]
        public void Check_Email_Validate()
        {
            string actual = regex.EmailCheck("deepi.nibedita260@gmail.com");
            Assert.AreEqual("email is Validated", actual);
        }
        //Test 3:- Phno Validation Check
        [Test]
        public void Check_Phno_Validate()
        {
            string actual = regex.PHNoCheck("+91 7918155010");
            Assert.AreEqual("phno is Validated", actual);
        }
        //Test 4:- Password Validation Check
        [Test]
        public void Check_Password_Validate()
        {
            string actual = regex.PasswordCheck3("Abc@2021");
            Assert.AreEqual("password is Validated", actual);
        }
        //Test 5:- Invalid Firstname Exception
        [Test]
        public void Given_InvalidFirstname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck("Nibedita1");
            }
            catch(RegularExpressionCustomException ex)
            {
                Assert.AreEqual("First name starts with Cap and has minimum 3 characters", ex.Message);
            }
        }
        //Test 6:- EmpltyOrNUll Firstname Exception
        [Test]
        public void Given_NUllFirstname_ThrowException()
        {
            try
            {
                string actual = regex.FirstnameCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("FirstName Could not be Empty", ex.Message);
            }
        }
        //Test 7:- Invalid Email Exception
        [Test]
        public void Given_InvalidEmail_ThrowException()
        {
            try
            {
                string actual = regex.EmailCheck("deepi.nibedita260@");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions", ex.Message);
            }
        }
        //Test 8:- EmpltyOrNUll Email Exception
        [Test]
        public void Given_NUllEmail_ThrowException()
        {
            try
            {
                string actual = regex.EmailCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Email Could not be Empty", ex.Message);
            }
        }
        //Test 9:- Invalid PHNo Exception
        [Test]
        public void Given_InvalidPHNo_ThrowException()
        {
            try
            {
                string actual = regex.PHNoCheck("+91 9978166100");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Phone Number Should Have 10 digits and First digits Must starts from [6..9] and [+91 ] is for optional Mobile Format - E.g. 91 6919819801 - Country code follow by space and 10 digit number", ex.Message);
            }
        }
        //Test 10:- EmpltyOrNUll PHNo Exception
        [Test]
        public void Given_NUllPHNo_ThrowException()
        {
            try
            {
                string actual = regex.PHNoCheck(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Phone Number Could not be Empty", ex.Message);
            }
        }
        //Test 11:- Invalid Password Exception
        [Test]
        public void Given_InvalidPassword_ThrowException()
        {
            try
            {
                string actual = regex.PasswordCheck3("nibi@jena");
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Password Have minimum 8 Characters, Should have at least 1 Upper Case and Should have at least 1 numeric number and Has exactly 1 Special Character", ex.Message);
            }
        }
        //Test 12:- EmpltyOrNUll Password Exception
        [Test]
        public void Given_NUllPassword_ThrowException()
        {
            try
            {
                string actual = regex.PasswordCheck3(null);
            }
            catch (RegularExpressionCustomException ex)
            {
                Assert.AreEqual("Password Could not be Empty", ex.Message);
            }
        }
    }
}