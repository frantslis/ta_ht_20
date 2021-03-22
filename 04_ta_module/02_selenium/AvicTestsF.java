package avic;

import org.openqa.selenium.By;
import org.openqa.selenium.JavascriptExecutor;
import org.openqa.selenium.Keys;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;
import org.testng.annotations.AfterMethod;
import org.testng.annotations.BeforeMethod;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

import java.util.List;
import java.util.concurrent.TimeUnit;
import java.util.concurrent.TimeUnit;

import static org.openqa.selenium.By.xpath;
import static org.openqa.selenium.Keys.ENTER;
import static org.testng.Assert.assertEquals;
import static org.testng.Assert.assertTrue;

public class AvicTestsF {
    private WebDriver driver;

    @BeforeTest
    public void profileSetUp() {
        System.setProperty("webdriver.chrome.driver", "src\\main\\resources\\chromedriver.exe");
    }

    @BeforeMethod
    public void testsSetUp() {
        driver = new ChromeDriver();
        driver.manage().window().maximize();
        driver.get("https://avic.ua/");
    }

    @Test(priority = 1)
    public void checkThatUrlContainsSearchWord() {

        driver.findElement(xpath("//input[@id='input_search']")).sendKeys("iPhone 12", ENTER);
        String expectedQuery = "query=iPhone";

        assertTrue(driver.getCurrentUrl().contains(expectedQuery));

    }

    @Test(priority = 2)
    public void checkElementsAmountOnSearchPage() {

        driver.findElement(xpath("//input[@id='input_search']")).sendKeys("iPhone 12", ENTER);

        List<WebElement> elementsList = driver.findElements(xpath("//div[@class='prod-cart__descr']"));

        int actualElementsSize = elementsList.size();
        int expectedElementsSize = 12;

        assertEquals(actualElementsSize, expectedElementsSize );

    }

    @Test(priority = 3)
    public void checkThatSearchResultsContainsSearchWord() {

        driver.findElement(xpath("//input[@id='input_search']")).sendKeys("iPhone 8", ENTER);

        List<WebElement> elementList = driver.findElements(xpath("//div[@class='prod-cart__descr']"));

        for (WebElement webElement : elementList) {
            assertTrue(webElement.getText().contains("iPhone 8"));

        }
    }

    @Test(priority = 4)
    public void checkAddToCart() {
        driver.findElement(xpath("//span[@class='sidebar-item']")).click();
        driver.findElement(xpath("//ul[contains(@class,'sidebar-list')]//a[contains(@href, 'apple-store')]")).click();
        driver.findElement(xpath("//div[@class='brand-box__title']/a[contains(@href,'iphone')]")).click();

        new WebDriverWait(driver, 30).until(
                webDriver -> ((JavascriptExecutor) webDriver).executeScript("return document.readyState").equals("complete"));

        driver.findElement(xpath("//a[@class='prod-cart__buy'][contains(@data-ecomm-cart,' Space Gray (MWD92)')]")).click();

        WebDriverWait wait = new WebDriverWait(driver, 30);

        wait.until(ExpectedConditions.visibilityOfElementLocated(By.id("js_cart")));

        driver.findElement(xpath("//div[@class='btns-cart-holder']//a[contains(@class,'btn--orange')]")).click();

        String actualProductsCountInCart =
                driver.findElement(xpath("//div[contains(@class,'header-bottom__cart')]//div[contains(@class,'cart_count')]")).getText();
        assertEquals(actualProductsCountInCart, "1");
    }

    
    @AfterMethod
    public void tearDown() {
        driver.close();
    }
}
