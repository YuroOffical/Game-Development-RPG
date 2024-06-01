using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Class
{
    public enum EntityClass { Warrior, Knight, Lancer, Thief, Ranger, Archer, Wizard, Mage, wtf}
    public abstract class Entity
    {
        #region field
        protected string _name;
        protected int _STR, _DEX, _WIS, _INT, _VIT;
        protected int _STRmod, _DEXmod, _INTmod, _WISmod, _VITmod;
        protected int _HP, _Mana, _ATK, _DEF, _SPECIAL, _CRIT;
        protected float  _HPmod, _ATKmod, _DEFmod , _Manamod, _SPECIALmod, _CRITmod;
        protected Random RNG;
        protected EntityClass _Class;
        #endregion 

        #region properties attribute and name
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public EntityClass CharacterClass
        {
            get { return _Class; }
            protected set { _Class = value; }
        }
        public int STR
        {
            get { return _STR * _STRmod; }
            protected set { _STR = value; }
        }
        public int DEX
        {
            get { return _DEX * _DEXmod; }
            protected set { _DEX = value; }
        }
        public int VIT
        {
            get { return _VIT * _VITmod; }
            protected set { _VIT = value; }
        }
        public int INT
        {
            get { return _INT * _INTmod; }
            protected set { _INT = value; }
        }
        public int WIS
        {
            get { return _WIS * _WISmod; }
            protected set { _WIS = value; }
        }
        #endregion 

        #region properties stats
        public int HP
        {
            get { return Convert.ToInt32(((_STR * 5) + (_VIT * 10))*_HPmod); }
            protected set { _HP = value; }
        }
        public int Mana
        {
            get { return Convert.ToInt32(((_INT * 10) + (_WIS * 5)) * _Manamod); }
            protected set { _Mana = value; }
        }
        public int ATK
        {
            get { return Convert.ToInt32(((_STR * 1) + (_DEX * 2)) * _ATKmod); }
            protected set { _ATK = value; }
        }
        public int DEF
        {
            get { return Convert.ToInt32(((_STR * 1.5) + (_VIT * 1.5)) * _DEFmod); }
            protected set { _DEF = value; }
        }
        public int SPECIAL
        {
            get { return Convert.ToInt32(((_WIS * 2) + (_INT * 1)) * _SPECIALmod); }
            protected set { _SPECIAL = value; }
        }
        public int CRIT
        {
            get { return Convert.ToInt32(((_DEX * 1) + (_WIS * 2)) * _CRITmod); }
            protected set { _CRIT = value; }
        }

        #endregion 

        #region constructor
        public Entity()
        {
            Name = "";
            CharacterClass = EntityClass.wtf;
            //attribute
            STR = 1;
            DEX = 1;
            VIT = 1;
            INT = 1;
            WIS = 1;
            //modifier
            _STRmod = 1;
            _DEXmod = 1;
            _VITmod = 1;
            _INTmod = 1;
            _WISmod = 1;
            //stats

        }
        #endregion 

        #region methods

        #endregion 
    }
}
