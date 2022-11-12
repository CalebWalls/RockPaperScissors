/*Author:Caleb Walls
  Date: 11/11/2022 (Code is bug free and crash free)
  Description: Create a rock paper scissor game that takes user inputand then  
  prints out a random value being Rock, Paper, or Scissors by the Computer.
  Then chooses a winner based on results.
  */
using System;
using System.Collections.Generic;

namespace RockPS
{







class Program
{

   

static void Main(string[] args)
{
    //Created a temporary choice so it can be validated later on
    string tempchoice = "";


    //While the input is not 4 we will always cycle throught the loop
    while(tempchoice != "4")
    {
    
    //First I want the user to choose a weapon
    Console.WriteLine("User Choose Your Weapon: \n 1.Rock\n 2.Paper\n 3.Scissors\n To Quit type 4");


    //Get the users input and validates it is only a number 1-3
    tempchoice = Console.ReadLine();
    var check = new Checks();
    bool validation = check.inputValidation(tempchoice);


//if the choice is 4 we exit
  if(tempchoice == "4")
  {
    break;
  }


//if validation fails we continue and ask the user to re-enter a value
  if(validation == false)
  {
    Console.WriteLine($"Invalid Input: {tempchoice}. Please Re-enter and try again.");
    continue;
  }


 //As long as validation passes then we are safe to convert the nuumber to an int and proceed   
var choice = int.Parse(tempchoice);

//create a new weapon object
var Weapobj = new Weapon();



//Determine what the user choice is and store it
var userWeapon = Weapobj.DetermineWeapon(choice);
Console.WriteLine($"\nUser Chose:{userWeapon}");


//Create a new Random object
Random rmd = new Random();
//Let the computer pick a random number between 1 and 3 to pick it's weapon.
var computerChoice = rmd.Next(1,4);
var computerWeapon = Weapobj.DetermineWeapon(computerChoice);
Console.WriteLine($"Computer Chose:{computerWeapon}");

    

//Program picks a winner based on results
Weapobj.PickWinnder(computerWeapon,userWeapon);
Console.WriteLine("\n");

   
    }

}
}
}

