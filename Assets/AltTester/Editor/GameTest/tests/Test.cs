using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;
using System.Threading;

public class Test
{
    private AltDriver altDriver;
    private StartPage startPage;
    private GamePage gamePage;
    [SetUp]
    public void Setup()
    {
        altDriver = new AltDriver();
        startPage = new StartPage(altDriver);
        startPage.Load();
        gamePage = new GamePage(altDriver);
    }

    [Test]
    public void Test_001StartPageLoadedCorrectly()
    {
        Assert.True(startPage.IsDisplayed());
    }

    [Test]
    public void Test_002StartButtonLoadGame()
    {
        startPage.ClickStartButton();
        Assert.True(gamePage.IsDisplayed());
        Assert.IsNotNull(gamePage.Player);
    }

    [Test]
    public void Test_003PlayerMoveAndWin()
    {
        gamePage.Load();
        altDriver.HoldButton(gamePage.LeftButton.GetScreenPosition(), 0.65f);
        altDriver.HoldButton(gamePage.UpButton.GetScreenPosition(), 1.5f);
        gamePage.Jump();
        altDriver.HoldButton(gamePage.UpButton.GetScreenPosition(), 1.5f);
        Assert.IsNotNull(gamePage.WinLabel);
        gamePage.Restart();
    }

    [TearDown]
    public void Dispose()
    {
        altDriver.Stop();
        Thread.Sleep(1000);
    }
}
