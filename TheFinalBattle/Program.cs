Console.WriteLine("Please enter the true programmers name");
string name = Console.ReadLine();

TrueProgrammer programmer = new TrueProgrammer(name, 25, "friendly");
Skeleton skeleton = new Skeleton("Skeleton1", 5, "enemy");
Skeleton skeleton2 = new Skeleton("Skeleton2", 5, "enemy 2");
Skeleton skeleton3 = new Skeleton("Skeleton3", 5, "enemy 2");
TheUncodedOne TheUncodedOne = new TheUncodedOne("The Uncoded One", 15, "enemy 3");

Console.WriteLine("What type of game would you like: ");
Console.WriteLine("1) Computer vs Computer ");
Console.WriteLine("2) Player vs Computer");
Console.WriteLine("3) Player vs Player ");
int choice = int.Parse(Console.ReadLine());
switch (choice)
{
    case 1: AiGame(); break;
    case 2: PvE(); break;
    case 3: PvP(); break;
};

void AiGame()
{
    while (true)
    {
        while (Party.FriendlyParty.Count() > 0 || Party.EnemyParty.Count() > 0)
        {
            Party.FriendlyAttack();

            if (Party.EnemyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Party 1 defeated");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.EnemyAttack();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        Console.WriteLine();

        while (Party.EnemyParty2.Count() > 0)
        {

            Party.FriendlyAttack();

            if (Party.EnemyParty2.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Party 2 defeated");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.EnemyAttack2();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }

        if (Party.EnemyParty2.Count() == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All enemy parties defeated");
            Console.WriteLine("You proceed on to face the uncoded one...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        Thread.Sleep(2000);

        while (Party.EnemyParty3.Count() > 0)
        {
            Party.FriendlyAttack();

            if (Party.EnemyParty3.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Uncoded One has been slain");
                Console.WriteLine("You win");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.EnemyAttack3();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        break;
    }

}

void PvE()
{
    while (true)
    {
        while (Party.FriendlyParty.Count() > 0 || Party.EnemyParty.Count() > 0)
        {
            Party.PlayerFriendlyAttack();

            if (Party.EnemyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Party 1 defeated");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.EnemyAttack();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        Console.WriteLine();

        while (Party.EnemyParty2.Count() > 0)
        {

            Party.PlayerFriendlyAttack();

            if (Party.EnemyParty2.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Party 2 defeated");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.EnemyAttack2();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }

        if (Party.EnemyParty2.Count() == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All enemy parties defeated");
            Console.WriteLine("You proceed on to face the uncoded one...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        Thread.Sleep(2000);

        while (Party.EnemyParty3.Count() > 0)
        {
            Party.PlayerFriendlyAttack();

            if (Party.EnemyParty3.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Uncoded One has been slain");
                Console.WriteLine("You win");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.EnemyAttack3();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        break;
    }

}

void PvP()
{
    while (true)
    {
        while (Party.FriendlyParty.Count() > 0 || Party.EnemyParty.Count() > 0)
        {
            Party.PlayerFriendlyAttack();

            if (Party.EnemyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Party 1 defeated");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.PlayerEnemyAttack();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        Console.WriteLine();

        while (Party.EnemyParty2.Count() > 0)
        {

            Party.PlayerFriendlyAttack();

            if (Party.EnemyParty2.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Party 2 defeated");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.PlayerEnemyAttack2();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }

        if (Party.EnemyParty2.Count() == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All enemy parties defeated");
            Console.WriteLine("You proceed on to face the uncoded one...");
            Console.ForegroundColor = ConsoleColor.White;
        }

        Console.WriteLine();
        Thread.Sleep(2000);

        while (Party.EnemyParty3.Count() > 0)
        {
            Party.PlayerFriendlyAttack();

            if (Party.EnemyParty3.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Uncoded One has been slain");
                Console.WriteLine("You win");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }

            Party.PlayerEnemyAttack3();

            if (Party.FriendlyParty.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("True Programmer has been defeated");
                Console.WriteLine("Evil Wins");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
        break;
    }
}


public static class Party
{
    public static List<ICharacter> FriendlyParty = new List<ICharacter>();
    public static List<ICharacter> EnemyParty = new List<ICharacter>();
    public static List<ICharacter> EnemyParty2 = new List<ICharacter>();
    public static List<ICharacter> EnemyParty3 = new List<ICharacter>();

    public static void AddFriendly(ICharacter character)
    {
        FriendlyParty.Add(character);
    }

    public static void AddEnemyParty1(ICharacter character)
    {
        EnemyParty.Add(character);
    }
    public static void AddEnemyParty2(ICharacter character)
    {
        EnemyParty2.Add(character);
    }

    public static void AddEnemyParty3(ICharacter character)
    {
        EnemyParty3.Add(character);    
    }

    public static void FriendlyAttack()
    {
        for (int i = 0; i < FriendlyParty.Count(); i++)
        {
            FriendlyParty[i].AiAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void PlayerFriendlyAttack()
    {
        for (int i = 0; i < FriendlyParty.Count(); i++)
        {
            FriendlyParty[i].PlayerAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void EnemyAttack()
    {
        for (int i = 0; i < EnemyParty.Count(); i++)
        {
            EnemyParty[i].AiAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void PlayerEnemyAttack()
    {
        for (int i = 0; i < EnemyParty.Count(); i++)
        {
            EnemyParty[i].PlayerAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void EnemyAttack2()
    {
        for (int i = 0; i < EnemyParty2.Count(); i++)
        {
            EnemyParty2[i].AiAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void PlayerEnemyAttack2()
    {
        for (int i = 0; i < EnemyParty2.Count(); i++)
        {
            EnemyParty2[i].PlayerAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void EnemyAttack3()
    {
        for (int i = 0; i < EnemyParty3.Count(); i++)
        {
            EnemyParty3[i].AiAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }

    public static void PlayerEnemyAttack3()
    {
        for (int i = 0; i < EnemyParty3.Count(); i++)
        {
            EnemyParty3[i].PlayerAction();
            Console.WriteLine();
            Thread.Sleep(2000);
        }
    }
}

public interface ICharacter
{
    
    enum Actions;
    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int HP { get; set; }


    public void PlayerAction();
    public void AiAction();

}

public class TrueProgrammer : ICharacter
{
    enum Actions
    {
        Nothing,
        Punch
    }

    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int HP { get; set; }

    public TrueProgrammer(string name, int hp, string party)
    {
        Name = name;
        MaxHP = hp;
        HP = MaxHP;

        if (party == "friendly")
        {
            Party.AddFriendly(this);
        }

        if (party == "enemy")
        {
            Party.AddEnemyParty1(this);
        }


        if (party == "enemy 2")
        {
            Party.AddEnemyParty2(this);
        }

        if (party == "enemy 3")
        {
            Party.AddEnemyParty3(this);
        }
    }

    public void PlayerAction()
    {
        int damage = 0;
        Console.WriteLine($"It is {Name}'s turn");
        Console.WriteLine($"HP: {HP}/{MaxHP}");
        Console.WriteLine($"{Name} choose your next move");
        Console.WriteLine($"1) Nothing");
        Console.WriteLine($"2) Punch");
        int playerChoice = int.Parse(Console.ReadLine());
        Actions action = playerChoice switch
        {
            1 => Actions.Nothing,
            2 => Actions.Punch,
        };

        if (Party.EnemyParty.Count() > 0)
        {
            if (action != Actions.Nothing)
            {
                Random randomEnemy = new Random();
                int enemyChoice = randomEnemy.Next(Party.EnemyParty.Count - 1);
                Console.WriteLine($"{Name} did {action} on {Party.EnemyParty[enemyChoice]}");
                damage = 1;
                Party.EnemyParty[enemyChoice].HP -= damage;
                Console.WriteLine($"That {action} did {damage} damage on {Party.EnemyParty[enemyChoice].Name}");
                Console.WriteLine($"{Party.EnemyParty[enemyChoice].Name} is now at {Party.EnemyParty[enemyChoice].HP} /{Party.EnemyParty[enemyChoice].MaxHP}  HP");
                if (Party.EnemyParty[enemyChoice].HP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Party.EnemyParty[enemyChoice].Name} has been defeated");
                    Console.ForegroundColor = ConsoleColor.White;
                    Party.EnemyParty.Remove(Party.EnemyParty[enemyChoice]);
                }
            }
            else Console.WriteLine($"{Name} did {action}");
        }
        else if (Party.EnemyParty2.Count() > 0)
        {
            if (action != Actions.Nothing)
            {
                Random randomEnemy = new Random();
                int enemyChoice = randomEnemy.Next(Party.EnemyParty2.Count - 1);
                Console.WriteLine($"{Name} did {action} on {Party.EnemyParty2[enemyChoice]}");
                damage = 1;
                Party.EnemyParty2[enemyChoice].HP -= damage;
                Console.WriteLine($"That {action} did {damage} damage");
                Console.WriteLine($"{Party.EnemyParty2[enemyChoice].Name} is now at {Party.EnemyParty2[enemyChoice].HP}/{Party.EnemyParty2[enemyChoice].MaxHP} HP");
                if (Party.EnemyParty2[enemyChoice].HP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Party.EnemyParty2[enemyChoice].Name} has been defeated");
                    Console.ForegroundColor = ConsoleColor.White;
                    Party.EnemyParty2.Remove(Party.EnemyParty2[enemyChoice]);
                }

            }
            else Console.WriteLine($"{Name} did {action}");
        }

        else if (Party.EnemyParty3.Count() > 0)
        {
            if (action != Actions.Nothing)
            {
                Random randomEnemy = new Random();
                int enemyChoice = randomEnemy.Next(Party.EnemyParty3.Count - 1);
                Console.WriteLine($"{Name} did {action} on {Party.EnemyParty3[enemyChoice]}");
                damage = 1;
                Party.EnemyParty3[enemyChoice].HP -= damage;
                Console.WriteLine($"That {action} did {damage} damage");
                Console.WriteLine($"{Party.EnemyParty3[enemyChoice].Name} is now at {Party.EnemyParty3[enemyChoice].HP}/{Party.EnemyParty3[enemyChoice].MaxHP} HP");
                if (Party.EnemyParty3[enemyChoice].HP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Party.EnemyParty3[enemyChoice].Name} has been defeated");
                    Console.ForegroundColor = ConsoleColor.White;
                    Party.EnemyParty3.Remove(Party.EnemyParty3[enemyChoice]);
                }

            }

            else Console.WriteLine($"{Name} did {action}");
        }


    }

    public void AiAction()
    {
        int damage = 0;
        Console.WriteLine($"It is {Name}'s turn");
        Console.WriteLine($"HP: {HP}/{MaxHP}");
        Random random = new Random();
        int AiChoice = random.Next(1, 3);
        Actions action = AiChoice switch
        {
            1 => Actions.Nothing,
            2 => Actions.Punch,
        };

        if (Party.EnemyParty.Count() > 0)
        {
            if (action != Actions.Nothing)
            {
                Random randomEnemy = new Random();
                int enemyChoice = randomEnemy.Next(Party.EnemyParty.Count - 1);
                Console.WriteLine($"{Name} did {action} on {Party.EnemyParty[enemyChoice]}");
                damage = 1;
                Party.EnemyParty[enemyChoice].HP -= damage;
                Console.WriteLine($"That {action} did {damage} damage on {Party.EnemyParty[enemyChoice].Name}");
                Console.WriteLine($"{Party.EnemyParty[enemyChoice].Name} is now at {Party.EnemyParty[enemyChoice].HP} /{Party.EnemyParty[enemyChoice].MaxHP}  HP");
                if (Party.EnemyParty[enemyChoice].HP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Party.EnemyParty[enemyChoice].Name} has been defeated");
                    Console.ForegroundColor = ConsoleColor.White;
                    Party.EnemyParty.Remove(Party.EnemyParty[enemyChoice]);
                }
            }
            else Console.WriteLine($"{Name} did {action}");
        }
        else if (Party.EnemyParty2.Count() > 0)
        {
            if (action != Actions.Nothing)
            {
                Random randomEnemy = new Random();
                int enemyChoice = randomEnemy.Next(Party.EnemyParty2.Count - 1);
                Console.WriteLine($"{Name} did {action} on {Party.EnemyParty2[enemyChoice]}");
                damage = 1;
                Party.EnemyParty2[enemyChoice].HP -= damage;
                Console.WriteLine($"That {action} did {damage} damage");
                Console.WriteLine($"{Party.EnemyParty2[enemyChoice].Name} is now at {Party.EnemyParty2[enemyChoice].HP}/{Party.EnemyParty2[enemyChoice].MaxHP} HP");
                if (Party.EnemyParty2[enemyChoice].HP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Party.EnemyParty2[enemyChoice].Name} has been defeated");
                    Console.ForegroundColor = ConsoleColor.White;
                    Party.EnemyParty2.Remove(Party.EnemyParty2[enemyChoice]);
                }

            }
            else Console.WriteLine($"{Name} did {action}");
        }

        else if (Party.EnemyParty3.Count() > 0)
        {
            if (action != Actions.Nothing)
            {
                Random randomEnemy = new Random();
                int enemyChoice = randomEnemy.Next(Party.EnemyParty3.Count - 1);
                Console.WriteLine($"{Name} did {action} on {Party.EnemyParty3[enemyChoice]}");
                damage = 1;
                Party.EnemyParty3[enemyChoice].HP -= damage;
                Console.WriteLine($"That {action} did {damage} damage");
                Console.WriteLine($"{Party.EnemyParty3[enemyChoice].Name} is now at {Party.EnemyParty3[enemyChoice].HP}/{Party.EnemyParty3[enemyChoice].MaxHP} HP");
                if (Party.EnemyParty3[enemyChoice].HP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Party.EnemyParty3[enemyChoice].Name} has been defeated");
                    Console.ForegroundColor = ConsoleColor.White;
                    Party.EnemyParty3.Remove(Party.EnemyParty3[enemyChoice]);
                }

            }
            else Console.WriteLine($"{Name} did {action}");
        }
    }

}

public class Skeleton : ICharacter
{
    enum Actions
    {
        Nothing,
        BoneCrunch
    }

    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int HP { get; set; }

    public Skeleton(string name, int hp, string party)
    {
        Name = name;
        MaxHP = hp;
        HP = MaxHP;

        if (party == "friendly")
        {
            Party.AddFriendly(this);
        }

        if (party == "enemy")
        {
            Party.AddEnemyParty1(this);
        }


        if (party == "enemy 2")
        {
            Party.AddEnemyParty2(this);
        }

        if (party == "enemy 3")
        {
            Party.AddEnemyParty3(this);
        }
    }

    public void PlayerAction()
    {
        Random random = new Random();
        int damage = random.Next(2);
        Console.WriteLine($"It is {Name}'s turn");
        Console.WriteLine($"HP: {HP}/{MaxHP}");
        Console.WriteLine($"{Name} choose your next move");
        Console.WriteLine($"1) Nothing");
        Console.WriteLine($"2) Bone Crunch");
        int playerChoice = int.Parse(Console.ReadLine());
        Actions action = playerChoice switch
        {
            1 => Actions.Nothing,
            2 => Actions.BoneCrunch
        };

        if (action != Actions.Nothing)
        {
            Random randomEnemy = new Random();
            int enemyChoice = randomEnemy.Next(Party.FriendlyParty.Count - 1);
            Console.WriteLine($"{Name} did {action} on {Party.FriendlyParty[enemyChoice]}");
            Party.FriendlyParty[enemyChoice].HP -= damage;
            Console.WriteLine($"That {action} did {damage} damage");
            Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} is now at {Party.FriendlyParty[enemyChoice].HP}/{Party.FriendlyParty[enemyChoice].MaxHP} HP");
            if (Party.FriendlyParty[enemyChoice].HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} has been defeated");
                Console.ForegroundColor = ConsoleColor.White;
                Party.EnemyParty.Remove(Party.FriendlyParty[enemyChoice]);
            }

        }
        else Console.WriteLine($"{Name} did {action}");
    }

    public void AiAction()
    {
        Random random = new Random();
        int damage = random.Next(2);
        Console.WriteLine($"It is {Name}'s turn");
        Console.WriteLine($"HP: {HP}/{MaxHP}");
        int AiChoice = random.Next(1, 3);
        Actions action = AiChoice switch
        {
            1 => Actions.Nothing,
            2 => Actions.BoneCrunch
        };

        if (action != Actions.Nothing)
        {
            Random randomEnemy = new Random();
            int enemyChoice = randomEnemy.Next(Party.FriendlyParty.Count - 1);
            Console.WriteLine($"{Name} did {action} on {Party.FriendlyParty[enemyChoice]}");
            Party.FriendlyParty[enemyChoice].HP -= damage;
            Console.WriteLine($"That {action} did {damage} damage");
            Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} is now at {Party.FriendlyParty[enemyChoice].HP}/{Party.FriendlyParty[enemyChoice].MaxHP} HP");
            if (Party.FriendlyParty[enemyChoice].HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} has been defeated");
                Console.ForegroundColor = ConsoleColor.White;
                Party.EnemyParty.Remove(Party.FriendlyParty[enemyChoice]);
            }

        }
        else Console.WriteLine($"{Name} did {action}");
    }

}

public class TheUncodedOne : ICharacter
{
    enum Actions
    {
        Nothing,
        UnravelingAttack
    }

    public string Name { get; set; }
    public int MaxHP { get; set; }
    public int HP { get; set; }

    public TheUncodedOne(string name, int hp, string party)
    {
        Name = name;
        MaxHP = hp;
        HP = MaxHP;

        if (party == "friendly")
        {
            Party.AddFriendly(this);
        }

        if (party == "enemy")
        {
            Party.AddEnemyParty1(this);
        }


        if (party == "enemy 2")
        {
            Party.AddEnemyParty2(this);
        }

        if (party == "enemy 3")
        {
            Party.AddEnemyParty3(this);
        }
    }

    public void PlayerAction()
    {
        Random random = new Random();
        int damage = random.Next(3);
        Console.WriteLine($"It is {Name}'s turn");
        Console.WriteLine($"HP: {HP}/{MaxHP}");
        int playerChoice = int.Parse(Console.ReadLine());
        Console.WriteLine($"{Name} choose your next move");
        Console.WriteLine($"1) Nothing");
        Console.WriteLine($"2) Unraveling attack");
        Actions action = playerChoice switch
        {
            1 => Actions.Nothing,
            2 => Actions.UnravelingAttack
        };

        if (action != Actions.Nothing)
        {
            Random randomEnemy = new Random();
            int enemyChoice = randomEnemy.Next(Party.FriendlyParty.Count - 1);
            Console.WriteLine($"{Name} did {action} on {Party.FriendlyParty[enemyChoice]}");
            Party.FriendlyParty[enemyChoice].HP -= damage;
            Console.WriteLine($"That {action} did {damage} damage");
            Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} is now at {Party.FriendlyParty[enemyChoice].HP}/{Party.FriendlyParty[enemyChoice].MaxHP} HP");
            if (Party.FriendlyParty[enemyChoice].HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} has been defeated");
                Console.ForegroundColor = ConsoleColor.White;
                Party.EnemyParty.Remove(Party.FriendlyParty[enemyChoice]);
            }

        }
        else Console.WriteLine($"{Name} did {action}");
    }
    public void AiAction()
    {
        Random random = new Random();
        int damage = random.Next(3);
        Console.WriteLine($"It is {Name}'s turn");
        Console.WriteLine($"HP: {HP}/{MaxHP}");
        int AiChoice = random.Next(1, 3);
        Actions action = AiChoice switch
        {
            1 => Actions.Nothing,
            2 => Actions.UnravelingAttack
        };

        if (action != Actions.Nothing)
        {
            Random randomEnemy = new Random();
            int enemyChoice = randomEnemy.Next(Party.FriendlyParty.Count - 1);
            Console.WriteLine($"{Name} did {action} on {Party.FriendlyParty[enemyChoice]}");
            Party.FriendlyParty[enemyChoice].HP -= damage;
            Console.WriteLine($"That {action} did {damage} damage");
            Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} is now at {Party.FriendlyParty[enemyChoice].HP}/{Party.FriendlyParty[enemyChoice].MaxHP} HP");
            if (Party.FriendlyParty[enemyChoice].HP <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{Party.FriendlyParty[enemyChoice].Name} has been defeated");
                Console.ForegroundColor = ConsoleColor.White;
                Party.EnemyParty.Remove(Party.FriendlyParty[enemyChoice]);
            }

        }
        else Console.WriteLine($"{Name} did {action}");
    }

}
