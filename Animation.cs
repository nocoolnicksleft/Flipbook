using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Flipbook
{
    public class Animation : IComparable
    {
        private Frame _lastSelectedFrame;

        public Frame LastSelectedFrame
        {
            get { return _lastSelectedFrame; }
            set { _lastSelectedFrame = value; }
        }

        private string _ID;

        public string ID
        {
            get { return _ID; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public UInt16 FrameCount
        {
            get { return (UInt16)Frames.Count; }
        }

        private Int16 _positionX;

        public Int16 PositionX
        {
            get { return _positionX; }
            set { _positionX = value; }
        }

        private Int16 _positionY;

        public Int16 PositionY
        {
            get { return _positionY; }
            set { _positionY = value; }
        }

        private UInt16 _delay;

        public UInt16 Delay
        {
            get { return _delay; }
            set { _delay = value; }
        }

        private String _remark;

        public String Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        public FrameCollection Frames;

        public Animation(string ID)
        {
            this._ID = ID;
            Frames = new FrameCollection();
        }

        public void AllFramesDirty()
        {
            Int16 sumX = 0;
            Int16 sumY = 0;
            UInt16 sumDelay = 0;

            sumX = _positionX;
            sumY = _positionY;
            sumDelay = _delay;

            foreach (Frame frm in this.Frames)
            {
                sumX += frm.OffsetX;
                sumY += frm.OffsetY;
                frm.EffectiveX = sumX;
                frm.EffectiveY = sumY;
                frm.EffectiveDelay = (UInt16)(frm.Delay + _delay);
                frm.Dirty = true;
            }
        }


        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return (this.ID.CompareTo(((Animation)obj).ID));
            }
            return 0;
        }

        #endregion

    }

    public class AnimationCollection : ArrayList
    {
        public int Add(Animation objItemToAdd)
        {
            return (base.Add(objItemToAdd));
        }

        public new Animation this[int index]
        {
            get
            {
                return ((Animation)base[index]);
            }
            set
            {
                base[index] = value;
            }
        }

        public int IndexOf(Animation value)
        {
            return (base.IndexOf(value));
        }

        public Animation FindByID(string value)
        {
            for (int i = 0; i < base.Count; i++)
            {
                if (((Animation)base[i]).ID == value) return (Animation)base[i];
            }
            return null;
        }
    }


}
