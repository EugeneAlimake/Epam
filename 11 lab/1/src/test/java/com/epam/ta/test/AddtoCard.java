package com.epam.ta.test;

import com.epam.ta.page.RandomproductPage;
import com.epam.ta.page.ShopPage;
import com.epam.ta.page.TitlePage;
import org.testng.Assert;
import org.testng.annotations.Test;

public class AddtoCard extends CommonConditions{
    @Test
    public void AddtoCard() throws InterruptedException {
        boolean addtocart = new RandomproductPage(driver)
                .openPage()
                .clicktoadd()
                .openCart()
                .checkCart();
       Assert.assertEquals(true,addtocart);
    }
}
