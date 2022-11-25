package com.epam.ta.test;

import com.epam.ta.page.*;
import org.testng.Assert;
import org.testng.annotations.Test;

public class LogoСlickabilityTests extends CommonConditions {
	@Test
	public void Logofirst()
	{
		String loggedInUserName = new TitlePage(driver)
				.openPage().
				clicklogo();
		System.out.println(loggedInUserName);
		Assert.assertEquals("https://www.tesla.com/",loggedInUserName);
	}
	@Test
	public void Logosecond()
	{
		String loggedInUserName = new model3Page(driver)
				.openPage().
				clicklogo();
		System.out.println(loggedInUserName);
		Assert.assertEquals("https://www.tesla.com/",loggedInUserName);
	}
	@Test
	public void Logothird()
	{
		String loggedInUserName = new ShopPage(driver)
				.openPage().
				clicklogo();
		System.out.println(loggedInUserName);
		Assert.assertEquals("https://www.tesla.com/?redirect=no",loggedInUserName);
	}
	@Test
	public void Logofourth()
	{
		String loggedInUserName = new AuthPage(driver)
				.openPage().
				clicklogo();
		System.out.println(loggedInUserName);
		Assert.assertEquals("https://www.tesla.com/?redirect=no",loggedInUserName);
	}
	@Test
	public void Logofifth()
	{
		String loggedInUserName = new ExistingInventoryPage(driver)
				.openPage().
				clicklogo();
		System.out.println(loggedInUserName);
		Assert.assertEquals("https://www.tesla.com/",loggedInUserName);
	}
}
