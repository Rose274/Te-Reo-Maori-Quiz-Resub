using System;
/*
 * Display intro
 * Declare all the variables needed for this program.
 * Use all Console.Write("Enter to Continue"), Console.ReadKey() and
    Console.Clear();
 * start level 1
 * Ask user all the questions 
 * After answering a question press the enter key.
 * Do the same for level 2
*/

Intro();
string userAnswer;

// words = Maori words | answers = Correct Word | opions = filler Words
string[] words = new string[] { "Aroha", "Awa", "Tangata Whenua", "Manu", "Iwi", "Kai", "Kai Moana", "Ki", "Haki", "Whakapapa", "Whaea" };
string[] answers = new string[] { "Love", "River", "Native", "Member", "Tribe", "Food", "Seafood", "To", "Flag", "Family tree", "Mother" };
string[] options = new string[] { "Siblings", "water", "life", "parents", "Land", "Money", "Fish", "key", "Food", "Mother", };
static void Intro()
{
    Console.WriteLine("Hi, welcome to my program.This is a 2 level quiz, you have to do both levels. Please choose A, B, C or D. ");
    Console.WriteLine("After answering the questions press enter to continue.There is also no score.");
    Level1();
}
static void Level1()
{
    string userAnswer;
    Console.WriteLine("Level 1");
    Console.WriteLine("\nQuestion 1  \nWhat is Family in Maori?");
    Console.Write("\ta) Whaea \n\tb) Teina \n\tc) Whakapapa \n\td) Whanau \n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d:");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "D" || userAnswer == "d")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 2\nWhat is Tribe in Maori");
    Console.WriteLine("\ta) Iwi \n\tb) Waka \n\tc) Haki \n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d:");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "A" || userAnswer == "a")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\n Question 3 \n What is Food called in Maori");
    Console.WriteLine("\ta) Kai \n\tb) Kai Moana\n\tc) Ki\n\td) haki\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");

        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Incorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 4 \nWhat is Ocean in Maori?");
    Console.WriteLine("\t a)Awa\n\t b)Haki\n\t c)Moana\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d:");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "C" || userAnswer == "c")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 5 \n What is telephone in Moari?");
    Console.WriteLine("\ta) Hamarara \n\tb) Paihikara \n\tc) Waea \n\td) Wai\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "a" && userAnswer != "b" && userAnswer != "c" && userAnswer != "d" && userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "C" || userAnswer == "c")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 6 \n What would you catch with a pa Kahawai?");
    Console.WriteLine("\ta) Manu \n\tb) Ika \n\tc) Pukapuka \n\td) Waka\n\t ");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 7 \n If you gave a donation, gift, or contribution, you would have given a...?");
    Console.WriteLine("\ta) Kete \n\tb) Mahi \n\tc) Koha\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "C" || userAnswer == "c")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 8 \n If someone tells you kia tūpato they want you to be");
    Console.WriteLine("\ta) Quiet \n\tb) On Time \n\tc) Happy \n\td) Careful\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "D" || userAnswer == "d")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 9 \n What does Hikoi mean?");
    Console.WriteLine("\ta) Jump \n\tb) Walk \n\tc) Sing \n\td) Slide");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 10 \nWhat is Waiata?");
    Console.WriteLine("\ta) Cup \n\tb) Tree \n\tc) Road \n\td) Song");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "D" || userAnswer == "d")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }

    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 11 \n What is the Maori word for Stomach?");
    Console.WriteLine("\ta) Peke \n\tb) Rauku \n\tc) Puku \n\td) Patai\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "C" || userAnswer == "c")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("Thats's the end of level 1. Time for level 2, Enjoy!");
}

//That's the end of Level 1, Start Level 2\\
Level2();
static void Level2()
{
    string userAnswer;
    Console.WriteLine("Level 2");

    Console.WriteLine("\nQuestion 1 \n What does Mahi mean?");
    Console.WriteLine("\ta) Work  \n\tb) Treats \n\tc) Running \n\td) Grass\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "A" || userAnswer == "a")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 2 \n What is the Maori word for Wait?");
    Console.WriteLine("\ta) Aroha \n\tb) Marae \n\tc) Kauri \n\td) taihoa\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "D" || userAnswer == "d")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 3 \n If something was Nui than it would be what?");
    Console.WriteLine("\ta) Tasty \n\tb) Big \n\tc) Loud \n\td) Nice\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }

    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 4 \n Something or someone described as ataahua is ?");
    Console.WriteLine("\ta) Patient \n\tb) Arrogant \n\tc) Rich \n\td) Beautiful\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "a" && userAnswer != "b" && userAnswer != "c" && userAnswer != "d" && userAnswer != "A" && userAnswer != "B" && userAnswer != "C" && userAnswer != "D")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "D" || userAnswer == "d")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 5 \n What would be stored in a Pataka");
    Console.WriteLine("\t a) Pukapuka \n\t b) kai \n\t c) Waka\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }

    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 6 \n How do you say Please in Love?");
    Console.WriteLine("\t a) Aroha \n\t B) Maui \n\t C) Waea\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "A" || userAnswer == "a")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 7 \n  How do you say right in Maori?");
    Console.WriteLine("\t a) Matau \n\t b) Tereina \n\t c) Toru \n\t d) Maui\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();


    Console.WriteLine("\nQuestion 8 \n If someone describes their food as reka they think it is ?");
    Console.WriteLine("\t a) Stale \n\t b) Delicious \n\t c) Terrible \n\t d) Under Cooked\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 9 \n How do you say Water?");
    Console.WriteLine("\t a) Kumete \n\t b) Pereti \n\t c) Wai \n\t d) Miraka\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "C" || userAnswer == "c")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 10 \n How do you say Taxi in maori?");
    Console.WriteLine("\t a) Wakatono \n\t b) Teka \n\t c) Moenga \n\t d) Waka\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "B" || userAnswer == "b")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
    }
    Console.Write("Enter to Continue"); Console.ReadKey();
    Console.Clear();

    Console.WriteLine("\nQuestion 11 \n What is Totara in Maori?");
    Console.WriteLine("\t a) Tree \n\t b) Long \n\t c) Cozy \n\t d) Green\n\t");
    userAnswer = Console.ReadLine();
    while (userAnswer != "d" && userAnswer != "c" && userAnswer != "a" && userAnswer != "b" && userAnswer != "D" && userAnswer != "C" && userAnswer != "A" && userAnswer != "B")
    {
        Console.WriteLine("\nThe option you selected is invalid... \nPlease select either a, b, c or d: ");
        userAnswer = Console.ReadLine();
    }
    if (userAnswer == "A" || userAnswer == "a")
    {
        Console.WriteLine("\nCorrect");
    }
    else
    {
        Console.WriteLine("\nIncorrect");
        Console.Write("Enter to Continue"); Console.ReadKey();
        Console.Clear();
    }
}

Console.WriteLine("You have finished the quiz Welldone.Thank you for your time and hope you have had fun and learn't something from this quiz.");







