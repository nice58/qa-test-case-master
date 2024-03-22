using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class GamePage : BasePage
{
    public GamePage(AltDriver driver) : base(driver)
    {
    }

    public void Load()
    {
        Driver.LoadScene("GameScene");
    }

    public AltObject Player
    {
        get => Driver.FindObject(By.NAME, "Player");
    }
    public AltObject LeftButton
    {
        get => Driver.WaitForObject(By.NAME, "LeftButton", timeout: 10);
    }
    public AltObject UpButton
    {
        get => Driver.WaitForObject(By.NAME, "UpButton", timeout: 5);
    }
    public AltObject JumpButton
    {
        get => Driver.WaitForObject(By.NAME, "JumpButton", timeout: 5);
    }
    public AltObject RestartButton
    {
        get => Driver.WaitForObject(By.NAME, "RestartButton", timeout: 5);
    }
    public AltObject WinLabel
    {
        get => Driver.FindObjectWhichContains(By.NAME, "WinLabel");
    }

    public bool IsDisplayed()
    {
        if (Player != null && LeftButton != null && UpButton != null && JumpButton != null)
            return true;
        return false;
    }
    public void Jump()
    {
        JumpButton.Click();
    }

    public void Restart()
    {
        RestartButton.Click();
    }
}

