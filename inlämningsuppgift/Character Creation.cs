

namespace inlämningsuppgift
{
    public class Character_Creation
    {
        public string _name;
        public string _characterClass;
        public int _damage;
        public int _hp;
        public int _maxHP;
        public int _gold;


        public Character_Creation(string name, string characterClass, int hp, int damage, int gold)
        {
            _name = name;
            _characterClass = characterClass;
            _hp = hp;
            _maxHP = hp;
            _damage = damage;
            _gold = gold;




        }
    }
}

