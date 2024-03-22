using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class GamePageUtils
{
    public static AltObject Player(AltDriver altDriver)
    {
        return altDriver.FindObject(By.NAME, "Player"); ;
    }

    public static AltObject LeftButton(AltDriver altDriver)
    {
        return altDriver.WaitForObject(By.NAME, "LeftButton", timeout: 2); ;
    }

    public static AltObject UpButton(AltDriver altDriver)
    {
        return altDriver.WaitForObject(By.NAME, "UpButton", timeout: 2); ;
    }

    public static AltObject RestartButton(AltDriver altDriver)
    {
        return altDriver.WaitForObject(By.NAME, "RestartButton", timeout: 2);
    }

    public static AltObject JumpButton(AltDriver altDriver)
    {
        return altDriver.WaitForObject(By.NAME, "JumpButton", timeout: 2);
    }


}