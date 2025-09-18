namespace inlämningsuppgift
{
    public class Character_Creation
    {
        public static Warrior CreateWarrior(string name)
        {
            return new Warrior(name, 150, 25, 0);

        }

        public static Mage CreateMage(string name)
        {
            return new Mage(name, 110, 15, 0, 200);
        }

    }
}

