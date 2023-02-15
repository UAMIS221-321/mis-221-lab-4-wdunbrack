

Random rnd = new Random();
int number = rnd.Next(3, 9);


static void GetFull(int number){
    for(int i = 0; i < number; i++){
        for(int a = 0; a <= i; a++){
            System.Console.Write("o ");
        }
        System.Console.WriteLine("");
    }
}


static void GetPartial(int number){
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
    }






System.Console.WriteLine($"Number={number}");
GetPartial(number);

