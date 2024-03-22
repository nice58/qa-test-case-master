using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;

public class StartPageUtils
{
    public static AltObject StartButton(AltDriver altDriver)
    { 
        return altDriver.WaitForObject(By.NAME, "Button", timeout: 2);
    }

}