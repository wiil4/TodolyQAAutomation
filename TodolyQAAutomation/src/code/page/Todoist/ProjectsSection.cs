using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YopmailAndTodoist.src.code.control;

namespace YopmailAndTodoist.src.code.page.Todoist
{
    public class ProjectsSection
    {
        public Button projectsButton = new Button(By.XPath("//div[@id='left_menu_inner']//a[contains(@href,'projects')]"));
        public Button addProjectButton = new Button(By.XPath("(//div[@id='left_menu_inner']//div/button)[1]"));
        public TextBox projectNameTxtbox = new TextBox(By.Id("edit_project_modal_field_name"));
        public Button submitButton = new Button(By.XPath("//form//button[@type='submit']"));

        //UPDATING PROJECT NAME
        public Button optionsButton = new Button(By.XPath("(//ul[@id='projects_list']/li//button)[last()]"));
        public Button editProjectButton = new Button(By.XPath("//ul[@role='menu']/li[4]"));

        //DELETING PROJECT
        public Button deleteButton = new Button(By.XPath("(//ul[@role='menu']/li)[last()]"));

        public void ClickCreatedProject(string pjName)
        {
            Button newProject = new Button(By.XPath($"(//ul[@id='projects_list']/li//span[text()='{pjName}'])[last()]"));
        }      
        public bool ProjectNameDisplayed(string pjName)
        {
            Label pjLabel = new Label(By.XPath($"(//ul[@id='projects_list']/li//span[text()='{pjName}'])[last()]"));
            return pjLabel.IsControlDisplayed();
        }
        public string GetProjectId()
        {
            Label pjLabel = new Label(By.XPath($"(//ul[@id='projects_list']/li)[last()]//a"));
            string hrefValue = pjLabel.GetAttribute("href");
            return hrefValue.Substring(hrefValue.LastIndexOf('/') + 1);
        }
        
    }
}
