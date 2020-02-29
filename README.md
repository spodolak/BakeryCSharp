# C# Bakery

#### A console application for a bakery

#### **By Stephanie Podolak**

## Description

Created with C#, this console application is built to mimic a bakery. The application takes the users order for either bread or pastry and returns the total cost of the order.  2.28.2020


### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **User starts program and a welcome message is prompted** | dotnet run | Welcome to The Bakery!<br/>Would you like to buy a loaf of bread or pastry? (Press 1 or 2) <br/>1)Bread $5.00   2) Pastry $2.00 |
| **User chooses what they would like to order (bread or pastry)** | 1) Bread <br/> 2) Pastry | How many loaves of bread would you like to purchase? <br/> How many pastries would you like to purchase? |
| **User chooses how many items they would like to order** | 2 loaves of bread <br/> 2 pastries | Total: $14.00 <br/> Would you like to purchase anything else? |
|**Menu pricing includes deals: <br/>Bread- buy 2 get 1 free.<br/>Pastry- Buy 3 for $5**|  3 loaves of bread <br/> 3 pastries | Order Total: $15.00| 
| **User is able to continue ordering OR checkout after each item is added to total** | Order <br/> Checkout <br/> | Order: How many loaves of bread/pastry would you like to purchase?<br/> Total: $13.00. Thank you! Come again.


## Setup/Installation Requirements
(_please note that C# and .NET must be installed on your system for this program to run_)



1. Clone this repository to your desktop using your prefered terminal. If using git bash type: "git clone https://github.com/spodolak/C#-Bakery.git" into your command line while in desktop directory.
2. Navigate inside project directory by entering "cd C#-Bakery" in your terminal.
3. Compile program by typing "dotnet build" in the console. 
4. Start program by typing "dotnet run" in the console.


## Known Bugs
* No known bugs at this time.

## Technologies Used
* C#
* .NET

## Support and Contact Details

_For any questions or comments please contact:_ Stephanie Podolak


### License

*This software is licensed under the MIT license*

Copyright (c) 2020 **_Stephanie Podolak_**