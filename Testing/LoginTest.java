package testcases;

import basetests.BaseTests;
import org.json.simple.parser.ParseException;
import org.testng.annotations.Test;

import java.io.IOException;

public class LoginTest extends BaseTests {

    @Test
    public void loginTest() throws IOException, ParseException {
        qa_login.enterName("userName","Ahmeed")
                .enterPassword("password","Mo123456")
                .clickOnLogin("login").clickOnView("view")
                .clickOnAboutUs("//button[@type='button']");
    }
}
