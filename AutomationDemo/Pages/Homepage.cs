using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationDemo.Pages
{
    internal class Homepage
    {
        IWebDriver driver = DriverSettings.Driver;
        private IWebElement Menu => driver.FindElement(By.XPath("//button[text()='Open Menu']"));
        private IWebElement AllItems => driver.FindElement(By.LinkText("All Items"));
        private IWebElement About => driver.FindElement(By.LinkText("About"));
        private IWebElement Logout => driver.FindElement(By.LinkText("Logout"));
        private IWebElement RestApp => driver.FindElement(By.LinkText("Reset App State"));
        private IWebElement ShipCart => driver.FindElement(By.XPath("//div[@id='shopping_cart_container']"));
        private IWebElement AddToCartBtn => driver.FindElement(By.XPath("//button[text()='Add to cart']"));
        private IWebElement Products => driver.FindElement(By.XPath("//span[text()='Products']"));
        private IWebElement It1Text => driver.FindElement(By.LinkText("Sauce Labs Backpack"));
        private IWebElement It2Text => driver.FindElement(By.LinkText("Sauce Labs Bike Light"));
        private IWebElement Item1 => driver.FindElement(By.XPath("//img[@data-test='inventory-item-sauce-labs-backpack-img']"));
        private IWebElement Item2 => driver.FindElement(By.XPath("//img[@data-test='inventory-item-sauce-labs-backpack-img']"));
        private ReadOnlyCollection<IWebElement> MenuItems => driver.FindElements(By.XPath("//div[@class='bm-menu']//a"));
        private IWebElement Logo => driver.FindElement(By.XPath("//div[@class= 'app_logo']"));

        private ReadOnlyCollection<IWebElement> InvItems => driver.FindElements(By.XPath("//div[@class='inventory_container']//div[@class='inventory_item']"));
        private IWebElement SortIcon => driver.FindElement(By.XPath("//span[@class='select_container']"));

        private ReadOnlyCollection<IWebElement> ItemSort => driver.FindElements(By.XPath("//select[@class='product_sort_container']//option"));
        private ReadOnlyCollection<IWebElement> ListOfItemPrices => driver.FindElements(By.XPath("//div[@class='inventory_item_price']"));
        private IWebElement SelectFilterValue => driver.FindElement(By.XPath("//select[@class='product_sort_container']"));
        private IWebElement CartIcon => driver.FindElement(By.Id("shopping_cart_container"));


        public bool ValidateProducts()
        {
            return Products.Displayed;
        }

        public void ClickOnMenuIcon()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(Menu).Click();

        }

        public bool ValidateMenuItems(List<string> expectedMenuItems)
        {
            var actualItems = MenuItems.Where(eachMenuItem => eachMenuItem.Text != null).Select(eachMenuItem => eachMenuItem.Text);
            return expectedMenuItems.Equals(actualItems);
        }

        public void RemoveAllProductsFromCart()
        {
            var allItemsInCart = driver.FindElements(By.XPath("//button[text()='Remove']"));
            if (allItemsInCart.Count() > 0)
            {
                foreach (IWebElement item in allItemsInCart)
                {
                    item.Click();
                }
            }
        }

        public void ClickOnCart()
        {
            CartIcon.Click();
        }
        public void ClickOnAddToCartBtn()
        {
            AddToCartBtn.Click();

        }

        public void ClickonSortIcon()
        {
            SortIcon.Click();
        }
        public void ClickSortItem()
        {
            foreach (IWebElement Item1 in ItemSort)
                if (Item1.Text.Equals("Name (A to Z)"))
                    Item1.Click();              
        }

        public void ClickOnSortItem()
        {
            Actions sort = new Actions(driver);

            sort.MoveToElement(CartIcon).Click().Build().Perform();
            sort.DoubleClick(CartIcon).Build().Perform();
            
        }
        public void SelectOption(string option)
        {
            SelectElement s = new SelectElement(SelectFilterValue);
            s.SelectByText(option);
        }
        public bool ValidateSortedPrices()
        {
            double ItemTextCopy = 0;
            double ItemText = 0;
            bool flag = false;
            var priceOfItems = ListOfItemPrices.Select(x=>Convert.ToDouble(x.Text)).ToList();
            var sortedPrices = priceOfItems.OrderBy(x=>x);
            return priceOfItems.Equals(sortedPrices);
            foreach (var Item in ListOfItemPrices)
            {

                ItemText =Convert.ToDouble(Item.Text);

                if (ItemText >= ItemTextCopy)
                {
                    ItemTextCopy = ItemText;
                    flag = true;

                }
                else
                {
                    flag = false;
                    throw new Exception("The sorting not workred well");
                }
                                                     
            }
            return flag;
        }
        }
    }