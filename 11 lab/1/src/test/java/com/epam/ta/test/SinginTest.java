package com.epam.ta.test;
import com.epam.ta.model.User;
import com.epam.ta.page.Singin;
import com.epam.ta.service.UserCreator;
import org.testng.Assert;
import org.testng.annotations.Test;

public class SinginTest extends CommonConditions{

    @Test
    public void Singin() throws InterruptedException {
        User testUser = UserCreator.withCredentialsFromProperty();
        Singin Singin = new Singin(driver)
                .openPage()
                .emailclick(testUser);
    }
}
