using System.Linq;
using FluentAssertions;
using MyLabApp.Views;
using Xamarin.Forms;
using Xunit;

namespace MyLabApp.Tests
{
    public class AppTests
    {
        public AppTests()
        {
            Xamarin.Forms.Mocks.MockForms.Init();
            Application.Current = new App();
        }
        
        [Fact]
        public void App_IsNotNull() => Assert.NotNull(Application.Current);

        [Fact]
        public void App_ValidateMainPage()
        {
            // Arrange
            var navigationStack = Application.Current.MainPage.Navigation.NavigationStack;
            
            // Act
            var currentPage = navigationStack.Last();
            var numberPages = navigationStack.Count;
            
            // Assert
            numberPages.Should().Be(1);
            currentPage.Should().BeOfType<BlankView>();
        }
    }
}