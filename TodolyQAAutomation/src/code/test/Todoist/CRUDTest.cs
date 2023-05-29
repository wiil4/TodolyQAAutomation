using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.page.Todoist;

namespace YopmailAndTodoist.src.code.test.Todoist
{
    [TestClass]
    public class CRUDTest : BaseTest
    {
        MainPage mainPage = new MainPage();
        LogInPage logInPage = new LogInPage();
        ProjectsSection projectsSection = new ProjectsSection();

        private readonly string email = "willcorreos@gmail.com";
        private readonly string password = "todoisttest";

        [TestMethod]
        public void CrudOperationsTestMethod()
        {
            
            //LOGIN
            mainPage.logInButton.Click();
            logInPage.LogIn(email, password);
            Assert.IsTrue(logInPage.IsInboxDisplayed(), "ERROR! login was not successful");
            
            //PROJECT CREATION
            projectsSection.projectsButton.Click();
            projectsSection.addProjectButton.Click();
            Thread.Sleep(1000);

            projectsSection.projectNameTxtbox.SetText("mojix");
            Assert.IsTrue(projectsSection.submitButton.IsEnabled(), "ERROR! Lost Data");
            projectsSection.submitButton.Click();
            Assert.IsTrue(projectsSection.ProjectNameDisplayed("mojix"), "ERROR! project not created correctly");

            //UPDATING PROJECT NAME
            projectsSection.ClickCreatedProject("mojix");
            projectsSection.optionsButton.RightClick();
            projectsSection.editProjectButton.Click();
            projectsSection.projectNameTxtbox.SetText("Mojix1234");
            projectsSection.submitButton.Click();
            Assert.IsTrue(projectsSection.ProjectNameDisplayed("Mojix1234"), "ERROR! project name was not changed");

            //DELETING PROJECT
            
            projectsSection.ClickCreatedProject("Mojix1234");
            //string pjId = projectsSection.GetProjectId();
            projectsSection.optionsButton.RightClick();
            projectsSection.deleteButton.Click();
            Thread.Sleep(2000);
            projectsSection.submitButton.Click();
            
            Assert.IsFalse(projectsSection.ProjectNameDisplayed("Mojix1234"), "ERROR! project was not deleted");
        }
    }
}
