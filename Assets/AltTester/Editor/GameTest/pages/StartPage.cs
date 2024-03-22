using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class StartPage : BasePage
{
    public StartPage(AltDriver driver) : base(driver)
    {
    }

    public void Load()
    {
        Driver.LoadScene("StartScene");
    }
    public AltObject StartButton
    {
        get => Driver.WaitForObject(By.NAME, "Button", timeout: 5);
    }
    public bool IsDisplayed()
    {
        if (StartButton != null)
            return true;
        return false;
    }
    public void ClickStartButton()
    {
        StartButton.Click();
    }
}
