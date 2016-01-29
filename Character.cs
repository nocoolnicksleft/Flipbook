using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Flipbook
{
    public class Character
    {
        public string Name;
        public string Remark;

        public GroupCollection Groups;

        public Character(string Name)
        {
            this.Name = Name;
            Groups = new GroupCollection();
        }
    }

    public class Group
    {
        public string Name;
        public String Remark;

        public AnimationCollection Animations;

        public Group(string Name)
        {
            this.Name = Name;
            Animations = new AnimationCollection();
        }
    }


    public class StringCollection : ArrayList
    {
        public int Add(String objItemToAdd)
        {
            return (base.Add(objItemToAdd));
        }

        public new String this[int index]
        {
            get
            {
                return ((String)base[index]);
            }
            set
            {
                base[index] = value;
            }
        }

        public int IndexOf(String value)
        {
            return (base.IndexOf(value));
        }

        public int TextIndex(String value)
        {
            for (int i = 0; i < base.Count; i++)
            {
                if (((String)base[i]) == value) return i;
            }
            return 0;
        }

    }

    public class GroupCollection : ArrayList
    {
        public int Add(Group objItemToAdd)
        {
            return (base.Add(objItemToAdd));
        }

        public new Group this[int index]
        {
            get
            {
                return ((Group)base[index]);
            }
            set
            {
                base[index] = value;
            }
        }

        public int IndexOf(Group value)
        {
            return (base.IndexOf(value));
        }

        public Group FindByName(String value)
        {
            for (int i = 0; i < base.Count; i++)
            {
                if (((Group)base[i]).Name == value) return (Group)base[i];
            }
            return null;
        }
    }

    public class CharacterCollection : ArrayList
    {
        public int Add(Character objItemToAdd)
        {
            return (base.Add(objItemToAdd));
        }

        public new Character this[int index]
        {
            get
            {
                return ((Character)base[index]);
            }
            set
            {
                base[index] = value;
            }
        }

        public int IndexOf(Character value)
        {
            return (base.IndexOf(value));
        }

        public Character FindByName(String value)
        {
            for (int i = 0; i < base.Count; i++)
            {
                if (((Character)base[i]).Name == value) return (Character)base[i];
            }
            return null;
        }
    }

}
