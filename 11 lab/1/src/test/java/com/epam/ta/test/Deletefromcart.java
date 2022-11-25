package com.epam.ta.test;

import com.epam.ta.page.RandomproductPage;
import org.testng.Assert;
import org.testng.annotations.Test;

import java.util.Optional;

public class Deletefromcart  extends CommonConditions{
    @Test
    public void DeletefromCard() throws InterruptedException {
        Boolean deletefromcart = new RandomproductPage(driver)
                .openPage()
                .clicktoadd()
                .openCart()
                .DeleteCart();
        Assert.assertEquals((boolean) deletefromcart, true);
    }
}
