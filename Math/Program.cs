Console.Write("Welcome to the WolfGame. \n");

Random rnd = new Random();
int games = 0;
bool gameRunning = true;

static bool additionGame(Random random)
{   
    Console.WriteLine("How many questions would you like? \n");

    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < num; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);

        Console.WriteLine($"What is the sum of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1+n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}. \n");
    };

    return true;
}

static bool subtractionGame(Random random)
{   
    Console.WriteLine("How many questions would you like? \n");

    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < num; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);

        Console.WriteLine($"What is the difference of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1-n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}. \n");
    };

    return true;
}

static bool multiplicationGame(Random random)
{   
    Console.WriteLine("How many questions would you like? \n");

    int num = int.Parse(Console.ReadLine());

    for (int i = 0; i < num; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);


        Console.WriteLine($"What is the product of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1*n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}. \n");
        };

    return true;
}

static bool divisonGame(Random random)
{   
    Console.WriteLine("How many questions would you like? \n");

    int num = int.Parse(Console.ReadLine());
    
    for (int i = 0; i < num; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);

        Console.WriteLine($"What is the division of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1/n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}. \n");

    };

    return true;
}

while (gameRunning)
{
    Console.Write("1: Addition \n");
    Console.Write("2: Subtraction \n");
    Console.Write("3: Multiplication \n");
    Console.Write("4: Division \n");
    Console.Write("Please choose: \n");

    int choice = int.Parse(Console.ReadLine());

    switch(choice)
    {
        case 1:
            Console.Write("Redirecting to addition game...\n \n");
            games++;
            additionGame(rnd);
            break;
        case 2:
            Console.Write("Redirecting to subtraction game... \n \n");
            games++;
            subtractionGame(rnd);
            break;
        case 3:
            Console.Write("Redirecting to multiplication game...\n \n");
            games++;
            multiplicationGame(rnd);
            break;
        case 4:
            Console.Write("Redirecting to division game...\n \n");
            games++;
            divisonGame(rnd);
            break;
        case 5:
            Console.Write("Or would you like to play a random game? \n");
            games++;
            break;

    }
}