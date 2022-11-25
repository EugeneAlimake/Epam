package com.epam.ta.test;

import com.epam.ta.page.RandomproductPage;
import com.epam.ta.page.ShopPage;
import org.testng.Assert;
import org.testng.annotations.Test;

public class Find extends CommonConditions{
    @Test
    public void Findmodel() throws InterruptedException {
        boolean Find = new ShopPage(driver)
                .openRandomPage()
                .cheacfindlist();
        Assert.assertEquals(true,Find);
    }
    @Test
    public void Findathome() throws InterruptedException {
        boolean Find = new ShopPage(driver)
                .openRandomPage1()
                .cheacfindlist();
        Assert.assertEquals(true,Find);
    }
}