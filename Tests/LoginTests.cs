using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Windows.Forms;

namespace Hotel_Management_System.Tests
{
    [TestClass]
    public class LoginFormTests
    {
        [TestMethod]
        public void Test_Login_With_Valid_Manager_Credentials_Should_Show_MainForm()
        {
            LoginForm loginForm = new LoginForm();
            TextBox textBoxUsername = new TextBox();
            textBoxUsername.Text = "Manager1";
            TextBox textBoxPassword = new TextBox();
            textBoxPassword.Text = "Manager1";

            loginForm.TextBox_username = textBoxUsername;
            loginForm.TextBox_password = textBoxPassword;
            loginForm.Button_login_Click(null, null);

            Assert.IsTrue(loginForm.IsDisposed); 
        }
      [TestMethod]
      public void Test_Login_With_Invalid_Manager_Credentials_Should_Show_Error_Message()
      {
        LoginForm loginForm = new LoginForm();
        TextBox textBoxUsername = new TextBox();
        textBoxUsername.Text = "Manager";
        TextBox textBoxPassword = new TextBox();
        textBoxPassword.Text = "invalidPassword";

        loginForm.TextBox_username = textBoxUsername;
        loginForm.TextBox_password = textBoxPassword;
        loginForm.Button_login_Click(null, null);

        Assert.IsFalse(loginForm.IsDisposed);
        MessageBoxAssert.PopsUp("Wrong Login Information");
    }
      [TestMethod]
      public void Test_Login_With_Valid_Username_And_Invalid_Password_Should_Show_Error_Message()
{
    LoginForm loginForm = new LoginForm();
    TextBox textBoxUsername = new TextBox();
    textBoxUsername.Text = "client";
    TextBox textBoxPassword = new TextBox();
    textBoxPassword.Text = "InvalidPassword";

    loginForm.TextBox_username = textBoxUsername;
    loginForm.TextBox_password = textBoxPassword;
    loginForm.Button_login_Click(null, null);

    Assert.IsFalse(loginForm.IsDisposed);
    MessageBoxAssert.PopsUp("Wrong Login Information");
}


        [TestMethod]
        public void Test_Login_With_Invalid_Credentials_Should_Show_Error_Message()
        {
            // Arrange
            LoginForm loginForm = new LoginForm();
            TextBox textBoxUsername = new TextBox();
            textBoxUsername.Text = "InvalidUser";
            TextBox textBoxPassword = new TextBox();
            textBoxPassword.Text = "InvalidPassword";

            loginForm.TextBox_username = textBoxUsername;
            loginForm.TextBox_password = textBoxPassword;
            loginForm.Button_login_Click(null, null);

            Assert.IsFalse(loginForm.IsDisposed);
            MessageBoxAssert.PopsUp("Wrong Login Information");
        }

      [TestMethod]
      public void Test_Login_With_Valid_Credentials_Should_Show_MainFormClient()
{
    LoginForm loginForm = new LoginForm();
    TextBox textBoxUsername = new TextBox();
    textBoxUsername.Text = "client";
    TextBox textBoxPassword = new TextBox();
    textBoxPassword.Text = "client1";

    loginForm.TextBox_username = textBoxUsername;
    loginForm.TextBox_password = textBoxPassword;
    loginForm.Button_login_Click(null, null);
        
    Assert.IsTrue(loginForm.IsDisposed);
}

      [TestMethod]
      public void Test_Login_With_Empty_Username_And_Password_Should_Show_Error_Message()
    {
        LoginForm loginForm = new LoginForm();
        TextBox textBoxUsername = new TextBox();
        textBoxUsername.Text = "";
        TextBox textBoxPassword = new TextBox();
        textBoxPassword.Text = "";

        loginForm.TextBox_username = textBoxUsername;
        loginForm.TextBox_password = textBoxPassword;
        loginForm.Button_login_Click(null, null);

        Assert.IsFalse(loginForm.IsDisposed);
        MessageBoxAssert.PopsUp("Missing Login Information");
      }
    }
}
