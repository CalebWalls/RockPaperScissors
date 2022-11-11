/*Create a rock paper scissor games that takes user input
  and does then based on the input prints out a random RPC
  and then chooses a winnder based on results.*/
using System;
using System.Collections.Generic;

namespace RockPS
{







class Program
{

   

static void Main(string[] args)
{
    string userWeapon = "";
    while(userWeapon != "invalid"){
    //First I want the user to choose a weapon
    Console.WriteLine("User Choose Your Weapon: 1.Rock, 2.Paper, or 3.Scissors");

    //Get the users input
    var tempchoice = Console.ReadLine();
    //Need input validation later a throw and catch statement
    /*
    ............
    */
    var choice = int.Parse(tempchoice);
    if((choice > 3 || choice < 1) )
    {
        break;
    }

//create a weapon object
 var Weapobj = new Weapon();



//Determine what the user choice is and store it
 userWeapon = Weapobj.DetermineWeapon(choice);
Console.WriteLine($"Computer Chose:{userWeapon}");

//Then I want the computer to choose a weapon
Random rmd = new Random();
var computerChoice = rmd.Next(1,4);
var computerWeapon = Weapobj.DetermineWeapon(computerChoice);
Console.WriteLine($"Computer Chose:{computerWeapon}");

    

    //Then I want the program to pick a winner
  Weapobj.PickWinnder(computerWeapon,userWeapon);

   
    }








}


}



}

