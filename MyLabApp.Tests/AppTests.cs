using FluentAssertions;
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
            var numberPages = navigationStack.Count;
            
            // Assert
            numberPages.Should().Be(0);
            Application.Current.MainPage.Should().BeOfType<MainPage>();
        }
    }
}