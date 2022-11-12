
namespace RockPS
{






    public class Weapon
    {
        //This is where weapons will be chosen by the user and the computer
        public string DetermineWeapon(int choice)
        {
            //Initalized my weapons in an array
            string[] weap = {"Rock", "Paper", "Scissors"};
            string result = "";

            switch(choice)
        {
            case 1:
            //I want this to be rock
            result = weap[0];
            break;

            case 2:
            //Paper
            result = weap[1];
            break;

            case 3:
            //Scissors
            result = weap[2];
            break;

            default:
            throw new ArgumentException("Invalid");
            




        }


return result;



        }







public void PickWinnder(string computerWeap, string userWeap)
{

//Ties
if(computerWeap == "Rock" && userWeap == "Rock")
{
    Console.WriteLine("DRAW");
}
if(computerWeap == "Scissors" && userWeap == "Scissors")
{
    Console.WriteLine("DRAW");
}
if(computerWeap == "Paper" && userWeap == "Paper")
{
    Console.WriteLine("DRAW");
}



//Computer Wins
if(computerWeap == "Rock" && userWeap == "Scissors")
{
    Console.WriteLine("Computer WIN!!");
}
if(computerWeap == "Scissors" && userWeap == "Paper")
{
    Console.WriteLine("Computer WIN!!");
}
if(computerWeap == "Paper" && userWeap == "Rock")
{
    Console.WriteLine("Computer WIN!!");
}


//User Wins
if(computerWeap == "Paper" && userWeap == "Scissors")
{
    Console.WriteLine("YOU WIN!!");
}
if(computerWeap == "Rock" && userWeap == "Paper")
{
    Console.WriteLine("YOU WIN!!");
}
if(computerWeap == "Scissors" && userWeap == "Rock")
{
    Console.WriteLine("YOU WIN!!");
}



}
    }




















}