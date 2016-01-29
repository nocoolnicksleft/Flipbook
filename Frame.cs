using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Flipbook
{
    public class Frame : IComparable
    {
        public Bitmap ImageCache;

        private UInt16 _height;

        public UInt16 Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private UInt16 _width;

        public UInt16 Width
        {
            get { return _width; }
            set { _width = value; }
        }


        private UInt16 _effectiveDelay;

        public UInt16 EffectiveDelay
        {
            get { return _effectiveDelay; }
            set { _effectiveDelay = value; }
        }

        private Int16 _effectiveX;

        public Int16 EffectiveX
        {
            get { return _effectiveX; }
            set { _effectiveX = value; }
        }

        private Int16 _effectiveY;

        public Int16 EffectiveY
        {
            get { return _effectiveY; }
            set { _effectiveY = value; }
        }


        private bool _dirty;

        [Browsable(false)]
        public bool Dirty
        {
            get { return _dirty; }
            set { _dirty = value; }
        }

        private UInt16 _id;

        public UInt16 ID
        {
            get { return _id; }
        }

        private Int16 _offsetX;

        public Int16 OffsetX
        {
            get { return _offsetX; }
            set { _offsetX = value; }
        }

        private Int16 _offsetY;

        public Int16 OffsetY
        {
            get { return _offsetY; }
            set { _offsetY = value; }
        }

        private UInt16 _delay;

        public UInt16 Delay
        {
            get { return _delay; }
            set { _delay = value; }
        }

        private String _sound;

        public String Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        private String _remark;

        public String Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }

        private string _path;

        [Browsable(false)]
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public Frame(UInt16 ID)
        {
            this._id = ID;
            ImageCache = null;
            _dirty = true;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return (this.ID.CompareTo(((Frame)obj).ID));
            }
            return 0;
        }

        #endregion
    }

    public class FrameCollection : ArrayList
    {
        public int Add(Frame objItemToAdd)
        {
            return (base.Add(objItemToAdd));
        }

        public new Frame this[int index]
        {
            get
            {
                return ((Frame)base[index]);
            }
            set
            {
                base[index] = value;
            }
        }

        public int IndexOf(Frame value)
        {
            return (base.IndexOf(value));
        }

        public Frame FindByID(int value)
        {
            for (int i = 0; i < base.Count; i++)
            {
                if (((Frame)base[i]).ID == value) return (Frame)base[i];
            }
            return null;
        }
    }

}
