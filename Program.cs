

static void GetFull(int number){
    System.Console.WriteLine("");
    for(int i = 0; i < number; i++){
        for(int a = 0; a <= i; a++){
            System.Console.Write("o ");
        }
        System.Console.WriteLine("");
    }
    System.Console.WriteLine("");
}


static void GetPartial(int number){
    System.Console.WriteLine("");
    for(int i = 0; i < number; i ++){
        for(int a = 0; a <= i; a++){
            Random rnd1 = new Random();
            int ifMissing = rnd1.Next(6);
            if(ifMissing != 1){
                Console.Write("o  ");
           }
            else{
                Console.Write("   ");
            }
            }
            System.Console.WriteLine("");
        }
        System.Console.WriteLine("");
    }

//---------------------------------------------------------
while(1 == 1){
    Random rnd = new Random();
    int number = rnd.Next(3, 9);

    System.Console.WriteLine("Please enter your selection number:");
    System.Console.WriteLine("Enter 1 to display full triangle");
    System.Console.WriteLine("Enter 2 to display partial traingle");
    System.Console.WriteLine("Enter 3 to exit");

    string selectionNumString = Console.ReadLine();
    int selectionNum = int.Parse(selectionNumString);


    if(selectionNum == 1){
        GetFull(number);
    } else if(selectionNum == 2){
      GetPartial(number);
    } else if(selectionNum == 3){
        break;
    } else{
        System.Console.WriteLine("Invalid Choice.");
    }
}
