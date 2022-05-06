## :croissant: :cake: Pierre's Patisserie (That's French for Pastry Shop) 	:bread::croissant:
#### By _**Marcus Lorenzo**_
---

![image](https://stylecaster.com/wp-content/uploads/2013/09/rodarte-instagram.png)

| **_Overview_:** |
|---|

**My individual first console app in C#; asks the user to enter what type of bread they would like and the quantity, automatically applies discount and shows shopping cart totals.**

The concept was to instantiate objects (MenuItems) and then to organize them into a Dictionary, where access via string (Key/Value) is quick albeit limited. I realize I could likely DRY the some of the methods, however I am finding the syntax difficult to abstract certain arguements needed for the methods to run. Also, I created a class wrapping my Bread and Pastry classes, attempting to create a higher level method for both to use, but it failed. I could do away with the MenuItems class I believe.


##### Technologies Used:
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![image](https://img.shields.io/badge/GIT-E44C30?style=for-the-badge&logo=git&logoColor=white)
And :butter::butter:Lots of butter :butter: Cause that's what Frenchies like.
---


| **_Description_:** |
|---|

##### **My primary objectives** outside of the prompt were:
- To apply programming concepts learned in Javascript to a strongly typed, popular language.
- Follow coding conventions to the best of my ability.
- Abstract my code sooner than later.
- Practice using Dictionaries, Lists.

##### **My ultimate objective was** to:
- Practice OOP.


---

| **_Setup & Installation_:** |
|---|

|   via CLI   |  via Download  |
|---|---|
| Download install Git Bash (Windows), use the terminal in your text editor, or open Terminal(Mac) | Simply download the ZIP via the green "Code" button to right of the "Add file" button at the main repo page. 
 Open Git Bash or Terminal and type: `cd desktop` | Go to your zip file and extract to desired location on computer. 
 Next, clone `https://github.com/marcusanthonylorenzo/pierres-bakery` | Go to specified extraction folder, and follow next steps on the left column of this table.
 Once completed, open this new directory in your text editor | 
 In the CLI, navigate to PierresBakery folder `cd PierresBakery` and type `dotnet build`, then `dotnet run` to run in your console. |


#### Running Tests:
- To view tests via MSTest, please navigate to `PierresBakery.Tests` in your terminal, and type `dotnet test`.

#### Known Bugs:
* String input on "quantity" Console.ReadLine() crashes program due to exceptions.

---

| **_Design Plan_ (Specs):** |
|---|

#### Objects/Classes, Properties:
- Shop (Dictionary fullMenu, totalCost, totalDiscounts)
- MenuItems
  - Bread (name, price, quantity)
  - Pastry (name, price, quantity)

#### Collections/Groupings:
- Dictionary fullMenu
- namespace MainBakery
- namespace Items

#### Behaviours/Interactivity:
- Shop.Welcome() - Console UI intro.
- Shop.Buy() - Console UI for user input/output, automatically uppercases the first letter. Minor error handling.
- Shop.CalcTotalCost() - gathers input for logic, utilizing other static methods.
- Bread.Deal(), Pastry.Deal() - converts order quantity to deal prices, updating Shop variables to match with invoice.

---
| **_License_:** |
|---|

[MIT]()

Copyright (c) 2022 _Marcus Lorenzo_


#### Thanks for viewing!
