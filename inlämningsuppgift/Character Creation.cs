

namespace inlämningsuppgift
{
    public class Character_Creation
    {
        public string Name;
        public string CharacterClass;
        public int Damage;
        public int Hp;
        public int MaxHP;
        public int Gold;


        public Character_Creation(string name, string characterClass, int hp, int damage, int gold)
        {
            Name = name;
            CharacterClass = characterClass;
            Hp = hp;
            MaxHP = hp;
            Damage = damage;
            Gold = gold;




        }
    }
}

