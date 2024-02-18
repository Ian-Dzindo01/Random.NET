Console.Write("Welcome to the WolfGame. \n");

Random rnd = new Random();
int games = 0;
bool gameRunning = true;

static bool additionGame(Random random)
{   
    for (int i = 0; i < 10; i++){
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
    for (int i = 0; i < 10; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);

        Console.WriteLine($"What is the difference of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1-n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}. \n You lose. \n");
    };

    return true;
}

static bool multiplicationGame(Random random)
{   
    for (int i = 0; i < 10; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);


        Console.WriteLine($"What is the product of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1*n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}. \n You lose. \n");
        };

    return true;
}

static bool divisonGame(Random random)
{
    for (int i = 0; i < 10; i++){
        int n1 = random.Next(100);
        int n2 = random.Next(100);

        Console.WriteLine($"What is the division of {n1} and {n2}?");

        int response = int.Parse(Console.ReadLine());

        if (response != n1/n2)
            Console.WriteLine($"Incorrect response. It was {n1 + n2}.\n You lose. \n");

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
            additionGame(rnd);
            break;
        case 2:
            Console.Write("Redirecting to subtraction game... \n \n");
            subtractionGame(rnd);
            break;
        case 3:
            Console.Write("Redirecting to multiplication game...\n \n");
            multiplicationGame(rnd);
            break;
        case 4:
            Console.Write("Redirecting to division game...\n \n");
            divisonGame(rnd);
            break;
    }
}