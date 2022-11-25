package com.epam.ta.test;

import com.epam.ta.page.RandomproductPage;
import org.testng.Assert;
import org.testng.annotations.Test;

public class Countandprice  extends CommonConditions{

    @Test
    public void Countandprice() throws InterruptedException {
        Boolean deletefromcart = new RandomproductPage(driver)
                .openPage()
                .clicktoadd()
                .openCart()
                .Editcount();
        Assert.assertEquals((boolean) deletefromcart, true);
    }
}
