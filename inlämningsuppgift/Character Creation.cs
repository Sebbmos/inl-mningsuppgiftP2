namespace inlämningsuppgift
{
    public class Character_Creation
    {             //Klass skaparen för warrior och mage
        public static Warrior CreateWarrior(string name)
        {
            return new Warrior(name, 150, 25, 0);

        }

        public static Mage CreateMage(string name)
        {
            return new Mage(name, 100, 50, 0);
        }

    }
}

