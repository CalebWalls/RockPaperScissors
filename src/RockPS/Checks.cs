namespace RockPS
{
    public class Checks
    {
       
//This is wehre input is validated to ensure user can not break the program
public bool inputValidation(string tempchoice)
{
//create a variable called isAstring
    bool isAstring = false;
    //if the value is able to be created into a number then isAstring will be true otherwise it will be false
    int tempNum;
    isAstring = int.TryParse(tempchoice,out tempNum);

    bool validation = true;
    //if isAstring returns false then break out of loop
    if(!isAstring)
    {
      validation = false;
    }
    
    
    if(tempNum > 3 || tempNum < 1) 
    {
        validation = false;
    }
//if it passes the above two checks then validations passes
else
{
    validation = true;
}

    return validation;
    
}

}




















}