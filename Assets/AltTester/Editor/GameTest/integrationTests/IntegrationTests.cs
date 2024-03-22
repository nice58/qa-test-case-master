using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class IntegrationTests
{
    public AltDriver altDriver;

    [OneTimeSetUp]
    public void SetUp()
    {
        altDriver = new AltDriver();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        altDriver.Stop();
    }

    [Test]
    public void Test()
    {
        StartPageUtils.StartButton(altDriver).Click();
        Assert.IsNotNull(GamePageUtils.Player(altDriver));
        altDriver.HoldButton(GamePageUtils.LeftButton(altDriver).GetScreenPosition(), 0.65f);
        AltObject UpButton = GamePageUtils.UpButton(altDriver);
        altDriver.HoldButton(UpButton.GetScreenPosition(), 1.5f);
        GamePageUtils.JumpButton(altDriver).Click();
        altDriver.HoldButton(UpButton.GetScreenPosition(), 1.5f);
        AltObject RestartButton = GamePageUtils.RestartButton(altDriver);
        Assert.IsNotNull(RestartButton);
        RestartButton.Click();
    }
}