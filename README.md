# Selenium helper
Wrapper functions for easy and fluid use of Selenium webdriver in C#.
This can be used as a starter template for any C# Selenium project.

## Examples
As you can see code required is reduced.

`Driver.Navigate().GoToUrl(url)` ->  `Goto(url)`

`Driver.FindElement(By.Id(id))` -> `Id(id)`

`wait.Until(ExpectedConditions.ElementIsVisible(By.Id(identifier)))` -> `WaitId(identifier)`

