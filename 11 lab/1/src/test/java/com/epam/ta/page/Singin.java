package com.epam.ta.page;

import com.epam.ta.model.User;
import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.Logger;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;

import static java.lang.Thread.sleep;

public class Singin extends AbstractPage
{
    private final Logger logger = LogManager.getRootLogger();
    private final String PAGE_URL = "https://auth.tesla.com/oauth2/v1/authorize?redirect_uri=https%3A%2F%2Fwww.tesla.com%2Fteslaaccount%2Fowner-xp%2Fauth%2Fcallback&response_type=code&client_id=ownership&scope=offline_access%20openid%20ou_code%20email%20phone&audience=https%3A%2F%2Fownership.tesla.com%2F&locale=en-US";
    @FindBy(id = "form-input-identity")
    private WebElement email;
    @FindBy(id = "form-submit-continue")
    private WebElement btnnxt;
    public Singin(WebDriver driver)
    {
        super(driver);
        PageFactory.initElements(this.driver, this);
    }

    @Override
    public Singin openPage()
    {
        driver.navigate().to(PAGE_URL);
        logger.info("Singin 3 page opened");
        return this;
    }
    public Singin emailclick(User user) throws InterruptedException {
        email.sendKeys(user.getUsername());
        btnnxt.click();
        logger.info("emailclick");
        sleep(10000);
        return  this;
    }
}
