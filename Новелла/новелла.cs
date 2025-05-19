using System;

namespace BogatyrNovel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== БОГАТЫРСКИЕ ПРИКЛЮЧЕНИЯ ===");

            StartAdventure();
        }

        static int GetChoice(int maxOption)
        {
            int choice;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out choice) || choice >= 1 || choice <= maxOption)
                {
                    return choice;
                }
                Console.WriteLine($"Пожалуйста, введите число от 1 до {maxOption}");
            }
        }

        static void StartAdventure()
            {
                Console.Clear();

                Console.WriteLine("Вы - славный богатырь, защитник земли русской. Проснулись вы утром ранним от звука рога.");
                Console.WriteLine("Выехав на двор, видите: гонец от князя стоит, лицом бледен.");
                Console.WriteLine("\"Беда, богатырь! Напал на наши земли Змей Горыныч окаянный!\"");

                Console.WriteLine("Как поступите?");
                Console.WriteLine("1 - Немедленно скакать биться со Змеем");
                Console.WriteLine("2 - Сначала собрать дружину");
                Console.WriteLine("3 - Попросить благословения у старца-отшельника");
                Console.WriteLine("4 - Воспользоваться своему чутью");

                int choice = GetChoice(4);

                switch (choice)
                {
                    case 1:
                        FightAlone();
                        break;
                    case 2:
                        GatherArmy();
                        break;
                    case 3:
                        AskForBlessing();
                        break;
                    case 4:
                        SecretEnding();
                        break;
                }
            }

        static void FightAlone()
        {
            Console.Clear();
            Console.WriteLine("Вы скачете один к логову Змея Горыныча. По пути встречаете:");
            Console.WriteLine("1 - Старую ведьму у дороги");
            Console.WriteLine("2 - Раненого крестьянина");
            Console.WriteLine("3 - Таинственного старца в доспехах");

            int choice = GetChoice(3);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ведьма предлагает вам волшебное зелье силы.");
                    Console.WriteLine("Выпив его, вы чувствуете небывалую мощь!");
                    Console.WriteLine("В бою со Змеем вы побеждаете, но зелье было проклято - превращаетесь в камень.");
                    Console.WriteLine("КОНЕЦ 1: Герой-камень");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы помогаете крестьянину, теряя время.");
                    Console.WriteLine("Прибыв к логову, обнаруживаете сожженную деревню - опоздали.");
                    Console.WriteLine("КОНЕЦ 2: Горькое опоздание");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Старец оказывается самим Ильей Муромцем!");
                    Console.WriteLine("Он присоединяется к вам, и вместе вы побеждаете Змея.");
                    Console.WriteLine("КОНЕЦ 3: Слава богатырская");
                    break;
            }
        }

        static void GatherArmy()
        {
            Console.Clear();
            Console.WriteLine("Вы собираете дружину из 30 добрых молодцев.");
            Console.WriteLine("Как будете атаковать Змея?");
            Console.WriteLine("1 - Лобовой атакой");
            Console.WriteLine("2 - Хитростью, под покровом ночи");
            Console.WriteLine("3 - Подождать, пока Змей выйдет на охоту");

            int choice = GetChoice(3);
            
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ваша дружина храбро атакует, но Змей сжигает половину воинов.");
                    Console.WriteLine("Остальные разбегаются. Вы остаетесь один против чудовища...");
                    Console.WriteLine("КОНЕЦ 4: Доблестная гибель");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Ночью вы пробираетесь в логово и находите спящего Змея.");
                    Console.WriteLine("Ваши воины связывают его волшебными цепями.");
                    Console.WriteLine("Змея приводят к князю, и он становится защитником земли русской!");
                    Console.WriteLine("КОНЕЦ 5: Мудрая победа");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Дожидаясь, вы теряете бдительность. Змей нападает первым.");
                    Console.WriteLine("Ваша дружина разгромлена, а вы попадаете в плен.");
                    Console.WriteLine("КОНЕЦ 6: Пленник дракона");
                    break;
            }
        }

        static void AskForBlessing()
        {
            Console.Clear();
            Console.WriteLine("Вы находите старца-отшельника в глухом лесу. Он дает вам:");
            Console.WriteLine("1 - Волшебный меч-кладенец");
            Console.WriteLine("2 - Заговоренную стрелу");
            Console.WriteLine("3 - Наставление и мудрый совет");

            int choice = GetChoice(3);
            
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("С мечом-кладенцом вы легко побеждаете Змея!");
                    Console.WriteLine("Но меч оказывается проклятым - он забирает ваши годы жизни очень быстро.");
                    Console.WriteLine("КОНЕЦ 7: Цена победы");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Вы стреляете в Змея издалека. Стрела попадает ему в глаз.");
                    Console.WriteLine("Ослепленный Змей улетает за тридевять земель.");
                    Console.WriteLine("КОНЕЦ 8: Изгнание чудовища");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Следуя совету старца, вы находите яйцо, в котором спрятана смерть Змея.");
                    Console.WriteLine("Разбив его, вы уничтожаете Змея навсегда!");
                    Console.WriteLine("Но теперь вы знаете слишком много тайн...");
                    Console.WriteLine("КОНЕЦ 9: Познание истины");
                    break;
            }
        }

        static void SecretEnding()
        {
            Console.Clear();
            Console.WriteLine("Вы решаете не сражаться со Змеем, а поговорить с ним.");
            Console.WriteLine("Оказывается, Змей защищал землю от настоящей угрозы - темного колдуна.");
            Console.WriteLine("Объединив силы, вы побеждаете колдуна и становитесь союзниками.");
            Console.WriteLine("КОНЕЦ 10: Неожиданный союз");
        }
    }
}