
//Lag en metode som tar inn to int verdier. Dersom en av de, eller summen til int verdiene blir 30,
//skal metoden returnere true. Ellers returnerer metoden false

int insertNum, insertNum2, insertSum;
insertNum = 0;
insertNum2 = 0;
insertSum = 0;   
bool insertTrue = true;
ThirtyFunc();
bool ThirtyFunc(){

    Console.WriteLine("Insert a Number");
    insertNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert a Number");
    insertNum2 = Convert.ToInt32(Console.ReadLine());


    insertSum = insertNum + insertNum2;
    if (insertSum == 30)
    {
        Console.WriteLine("The value is 30!");
        return true;    
    }
    else 
    { 
        Console.WriteLine("wrong input");
        return false;
    }
} 