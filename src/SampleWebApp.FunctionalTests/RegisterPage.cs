using OpenQA.Selenium;
using SampleWebApp.Models;
using TestStack.Seleno.PageObjects;

namespace SampleWebApp.FunctionalTests
{
    public class RegisterPage : Page<RegisterModel>
    {
        public HomePage Register(RegisterModel model)
        {
            FillWithModel(model);
            return NavigateTo<HomePage>(By.Id("register"));
        }
    }
}