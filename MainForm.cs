using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using Microsoft.Win32;
using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Flipbook
{
    public partial class MainForm : Form
    {
        #region Locals

        Zoom _zoomform; 

        private string _currentPath = "";
        private CharacterCollection _characters = new CharacterCollection();

        private Animation _currentAnimation;
        private Character _currentCharacter;
        private Group _currentGroup;
        private Frame _currentFrame;

        private string _currentBackground = "";

        private bool _reverse = false;
        private bool _rollover = false;
        private bool _disableTransparency = false;
        private bool _disableAlphaChannel = false;
        private bool _fileDirty = false;
        private bool _disableHelpers = false;

        private int _fpsvalue = 30;

        private int _countdown = 0;

        private BackgroundStyle _backgroundStyle = BackgroundStyle.White;
        private FrameSpeedOption _fps = FrameSpeedOption.FPS30;

        private bool _updateSliderEventDisable = false;
        private bool _updateHelperEventDisable = false;


        private const string _configRegistryKey = @"Software\Seip\Flipbook";

        #endregion

        #region Private Methods

        private void SetBackgroundStyle(BackgroundStyle value)
        {
            _backgroundStyle = value;
            
            if (_backgroundStyle == BackgroundStyle.Image) imageToolStripMenuItemImage.Checked = true;
            else imageToolStripMenuItemImage.Checked = false;

            if (_backgroundStyle == BackgroundStyle.White) imageToolStripMenuItemWhite.Checked = true;
            else imageToolStripMenuItemWhite.Checked = false;

            if (_backgroundStyle == BackgroundStyle.Black) imageToolStripMenuItemBlack.Checked = true;
            else imageToolStripMenuItemBlack.Checked = false;

            if (_backgroundStyle == BackgroundStyle.Red) imageToolStripMenuItemRed.Checked = true;
            else imageToolStripMenuItemRed.Checked = false;

            if (_backgroundStyle == BackgroundStyle.Green) imageToolStripMenuItemGreen.Checked = true;
            else imageToolStripMenuItemGreen.Checked = false;

            if (_backgroundStyle == BackgroundStyle.Blue) imageToolStripMenuItemBlue.Checked = true;
            else imageToolStripMenuItemBlue.Checked = false;

            if (_backgroundStyle == BackgroundStyle.Alpha) imageToolStripMenuItemAlpha.Checked = true;
            else imageToolStripMenuItemAlpha.Checked = false;
        }

        private void SetFrameSpeed(FrameSpeedOption value)
        {
            _fps = value;

            if (_fps == FrameSpeedOption.FPS25)
            {
                fpsToolStripMenuItem25.Checked = true;
                _fpsvalue = 25;
            }
            else fpsToolStripMenuItem25.Checked = false;

            if (_fps == FrameSpeedOption.FPS30)
            {
                fpsToolStripMenuItem30.Checked = true;
                _fpsvalue = 30;
            }
            else fpsToolStripMenuItem30.Checked = false;

            if (_fps == FrameSpeedOption.FPS50)
            {
                fpsToolStripMenuItem50.Checked = true;
                _fpsvalue = 50;
            }
            else fpsToolStripMenuItem50.Checked = false;

            if (_fps == FrameSpeedOption.FPS60)
            {
                fpsToolStripMenuItem60.Checked = true;
                _fpsvalue = 60;
            }
            else fpsToolStripMenuItem60.Checked = false;

            ddbFPS.Text = _fpsvalue + " fps";
        }

        private void SaveConfig()
        {
            RegistryKey key_prog;
            RegistryKey key_seip;
            RegistryKey key_flipbook;
 
            key_prog = Registry.CurrentUser.OpenSubKey("Software", true);

            key_seip = key_prog.OpenSubKey("Seip",true);

            if (key_seip == null) key_seip = key_prog.CreateSubKey("Seip");

            key_flipbook = key_seip.OpenSubKey("Flipbook",true);

            if (key_flipbook == null) key_flipbook = key_seip.CreateSubKey("Flipbook");

            key_flipbook.SetValue("CurrentPath", _currentPath, RegistryValueKind.String);

            key_flipbook.SetValue("CurrentBackground", _currentBackground, RegistryValueKind.String);

            if (_disableAlphaChannel)
             key_flipbook.SetValue("DisableAlphaChannel", 1, RegistryValueKind.DWord);
            else
             key_flipbook.SetValue("DisableAlphaChannel", 0, RegistryValueKind.DWord);

            if (_disableTransparency)
                key_flipbook.SetValue("DisableTransparency", 1, RegistryValueKind.DWord);
            else
                key_flipbook.SetValue("DisableTransparency", 0, RegistryValueKind.DWord);

            if (_disableHelpers)
                key_flipbook.SetValue("DisableHelpers", 1, RegistryValueKind.DWord);
            else
                key_flipbook.SetValue("DisableHelpers", 0, RegistryValueKind.DWord);

            if (_rollover)
                key_flipbook.SetValue("Rollover", 1, RegistryValueKind.DWord);
            else
                key_flipbook.SetValue("Rollover", 0, RegistryValueKind.DWord);

            key_flipbook.SetValue("BackgroundStyle", (int) _backgroundStyle, RegistryValueKind.DWord);

            key_flipbook.SetValue("FPS", (int)_fps, RegistryValueKind.DWord);

            key_flipbook.SetValue("HelperX1", (int)udX1.Value, RegistryValueKind.DWord);
            key_flipbook.SetValue("HelperX2", (int)udX2.Value, RegistryValueKind.DWord);
            key_flipbook.SetValue("HelperY1", (int)udY1.Value, RegistryValueKind.DWord);
            key_flipbook.SetValue("HelperY2", (int)udY2.Value, RegistryValueKind.DWord);

            if (_currentAnimation != null) key_flipbook.SetValue("CurrentAnimation", _currentAnimation.ID, RegistryValueKind.String);
            
            key_flipbook.Close();

            key_seip.Close();

            key_prog.Close();
        }

        private void LoadConfig()
        {
            RegistryKey key;
            key = Registry.CurrentUser.OpenSubKey(_configRegistryKey, false);
            if (key != null)
            {
                _currentPath = key.GetValue("CurrentPath", "").ToString();
                _currentBackground = key.GetValue("CurrentBackground", "").ToString();

                if ((int)key.GetValue("Rollover", 0) != 0) _rollover = true;
                if ((int)key.GetValue("DisableAlphaChannel", 0) != 0) _disableAlphaChannel = true;
                if ((int)key.GetValue("DisableTransparency", 0) != 0) _disableTransparency = true;
                if ((int)key.GetValue("DisableHelpers", 0) != 0) _disableHelpers = true;

                _backgroundStyle = (BackgroundStyle)key.GetValue("BackgroundStyle", 0);
                _fps = (FrameSpeedOption)key.GetValue("FPS",0);

                _updateHelperEventDisable = true;

                udX1.Value = (int)key.GetValue("HelperX1", 0);
                udX2.Value = (int)key.GetValue("HelperX2", 0);
                udY1.Value = (int)key.GetValue("HelperY1", 0);
                udY2.Value = (int)key.GetValue("HelperY2", 0);

                _updateHelperEventDisable = false;

                key.Close();
            }
        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Display()
        {
            ddbCharacter.DropDownItems.Clear();
            ddbCharacter.Text = "(none)";

            ddbGroup.DropDownItems.Clear();
            ddbGroup.Text = "(none)";

            ddbID.DropDownItems.Clear();
            ddbID.Text = "(none)";

            _currentAnimation = null;
            _currentFrame = null;
            
            foreach (Character chr in _characters)
            {
               ToolStripMenuItem itm = new ToolStripMenuItem();
               itm.DisplayStyle = ToolStripItemDisplayStyle.Text;
               itm.Text = chr.Name;
               itm.Tag = chr;
               ddbCharacter.DropDownItems.Add(itm);
            }
            if (_characters.Count > 0) DisplayCharacter(_characters[0]);
            else
            {
                ddbCharacter.Text = "(none)";
            }
            
        }

        private void DisplayCharacter(Character chr)
        {
            ddbCharacter.Text = chr.Name;

            ddbGroup.DropDownItems.Clear();
            ddbGroup.Text = "";

            foreach (Group grp in chr.Groups)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem();
                itm.DisplayStyle = ToolStripItemDisplayStyle.Text;
                itm.Text = grp.Name;
                itm.Tag = grp;
                ddbGroup.DropDownItems.Add(itm);
            }
            if (chr.Groups.Count > 0) DisplayGroup(chr.Groups[0]);
            else
            {
                ddbGroup.Text = "(none)";
            }

            _currentCharacter = chr;
        }

        private void DisplayGroup(Group grp)
        {
            ddbGroup.Text = grp.Name;

            ddbID.DropDownItems.Clear();
            ddbID.Text = "";

            foreach (Animation ani in grp.Animations)
            {
                ToolStripMenuItem itm = new ToolStripMenuItem();
                itm.DisplayStyle = ToolStripItemDisplayStyle.Text;
                itm.Text = ani.ID.ToString();
                itm.Tag = ani;
                ddbID.DropDownItems.Add(itm);
            }
            if (grp.Animations.Count > 0) DisplayAnimation(grp.Animations[0]);
            else
            {
                _currentAnimation = null;
                ddbID.Text = "(none)";
            }
            _currentGroup = grp;
        }

        private void DisplayAnimation(Animation ani)
        {
            timer1.Stop();
            _currentAnimation = ani;
            _currentAnimation.AllFramesDirty();

            ddbID.Text = _currentAnimation.ID.ToString();
            
            txtAnimationFrames.Text = _currentAnimation.FrameCount.ToString();

            // muss vor DisplayFrame gesetzt werden, sonst evtl Überlauf
            _updateSliderEventDisable = true;
            tbFramePosition.Value = 0;
            _updateSliderEventDisable = false;
            tbFramePosition.Maximum = _currentAnimation.FrameCount - 1;

            if (_currentAnimation.Frames.Count > 0)
            {
                if (_currentAnimation.LastSelectedFrame != null)
                {
                    DisplayFrame(_currentAnimation.LastSelectedFrame);
                }
                else
                {
                    DisplayFrame(_currentAnimation.Frames[0]);
                }
            }
            else
            {
                _currentFrame = null;
            }

            // muss nach DisplayFrame gesetzt werden, sonst mehrfaches BuildImage durch ValueChange-Ereignisse
            udAnimationPositionX.Value = _currentAnimation.PositionX;
            udAnimationPositionY.Value = _currentAnimation.PositionY;
            udAnimationDelay.Value = _currentAnimation.Delay;
        }

        private void DisplayFrame(Frame frm)
        {
            if (frm != null)
            {
                _currentFrame = frm;

                int index;

                index = _currentAnimation.Frames.IndexOf(frm);

                if (index >= 0)
                {
                    _currentAnimation.LastSelectedFrame = _currentFrame;
                    // System.Diagnostics.Debug.WriteLine(_currentAnimation.ID + " -> " + _currentFrame.ID);
                    _updateSliderEventDisable = true;
                    tbFramePosition.Value = index;
                    _updateSliderEventDisable = false;

                    txtFrameNo.Text = tbFramePosition.Value.ToString();

                    udFrameOffsetX.Value = _currentFrame.OffsetX;
                    udFrameOffsetY.Value = _currentFrame.OffsetY;
                    udFrameDelay.Value = _currentFrame.Delay;

                    txtFrameHeight.Text = _currentFrame.Height.ToString();
                    txtFrameWidth.Text = _currentFrame.Width.ToString();
                    txtFrameEffectiveX.Text = _currentFrame.EffectiveX.ToString();
                    txtFrameEffectiveY.Text = _currentFrame.EffectiveY.ToString();
                    txtFrameEffectiveDelay.Text = _currentFrame.EffectiveDelay.ToString();

                    if (_currentFrame.Dirty) BuildImage(_currentFrame);

                    pictureBox1.Image = _currentFrame.ImageCache;

                    if (_zoomform != null) _zoomform.ShowImage(_currentFrame.ImageCache);
                }
                else
                {
                    MessageBox.Show("Bing");
                }
            }
        }

        private void BuildImage(Frame frm)
        {
            if (frm != null)
            {
                
                Bitmap newImage;

                Rectangle destRect;

                newImage = new Bitmap(256, 192);

                Graphics g = Graphics.FromImage(newImage);

                if (_disableTransparency) g.CompositingMode = CompositingMode.SourceCopy;
                else g.CompositingMode = CompositingMode.SourceOver;

                g.CompositingQuality = CompositingQuality.Default;
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.SmoothingMode = SmoothingMode.None;


                if (_backgroundStyle == BackgroundStyle.Image)
                {
                    if (_currentBackground != "")
                    {
                        if (!File.Exists(_currentBackground))
                        {
                            _currentBackground = "";
                            SaveConfig();
                        }
                        else
                        {
                            Bitmap bmpSourceBG = new Bitmap(_currentBackground);

                            destRect = new Rectangle(0, 0, bmpSourceBG.Width, bmpSourceBG.Height);

                            g.DrawImage(bmpSourceBG, destRect, 0, 0, bmpSourceBG.Width, bmpSourceBG.Height, GraphicsUnit.Pixel, null);
                        }
                    }
                }
                else if (_backgroundStyle == BackgroundStyle.Black)
                {
                    g.FillRectangle(Brushes.Black, 0, 0, newImage.Width, newImage.Height);
                }
                else if (_backgroundStyle == BackgroundStyle.Green)
                {
                    g.FillRectangle(Brushes.Green, 0, 0, newImage.Width, newImage.Height);
                }
                else if (_backgroundStyle == BackgroundStyle.Red)
                {
                    g.FillRectangle(Brushes.Red, 0, 0, newImage.Width, newImage.Height);
                }
                else if (_backgroundStyle == BackgroundStyle.Blue)
                {
                    g.FillRectangle(Brushes.Blue, 0, 0, newImage.Width, newImage.Height);
                }
                else if (_backgroundStyle == BackgroundStyle.White)
                {
                    g.FillRectangle(Brushes.White, 0, 0, newImage.Width, newImage.Height);
                }


                Bitmap bmpSourceSprite = new Bitmap(frm.Path);

                int w = bmpSourceSprite.Width;
                int h = bmpSourceSprite.Height;

                int x = frm.EffectiveX;
                int y = frm.EffectiveY;

                destRect = new Rectangle(x, y, w, h);

                g.DrawImage(bmpSourceSprite, destRect, 0, 0, w, h, GraphicsUnit.Pixel, null);


                if (!_disableHelpers)
                {
                    if (udX1.Value > 0)
                        g.DrawLine(Pens.Black, (int)udX1.Value, 0, (int)udX1.Value, pictureBox1.Height);

                    if (udX2.Value > 0)
                        g.DrawLine(Pens.Black, (int)udX2.Value, 0, (int)udX2.Value, pictureBox1.Height);

                    if (udY1.Value > 0)
                        g.DrawLine(Pens.Black, 0, (int)udY1.Value, pictureBox1.Width, (int)udY1.Value);

                    if (udY2.Value > 0)
                        g.DrawLine(Pens.Black, 0, (int)udY2.Value, pictureBox1.Width, (int)udY2.Value);
                }

                g.Dispose();

                frm.Width = (UInt16)w;
                frm.Height = (UInt16)h;
                frm.ImageCache = newImage;
                frm.Dirty = false;

            }
        }

        private void AllFramesDirty(Animation ani)
        {
            if (ani != null)
            {
                ani.AllFramesDirty();
            }
        }

        private void FirstFrame()
        {
            if (_currentAnimation != null)
            {
                if (_currentAnimation.FrameCount > 0)
                {
                    DisplayFrame(_currentAnimation.Frames[0]);
                }
            }
        }

        private void LastFrame()
        {
            if (_currentAnimation != null)
            {
                if (_currentAnimation.FrameCount > 0)
                {
                    DisplayFrame(_currentAnimation.Frames[_currentAnimation.Frames.Count - 1]);
                }
            }
        }

        private void NextFrame()
        {
            if (_currentFrame != null)
            {
                if (_currentAnimation.Frames.IndexOf(_currentFrame) < (_currentAnimation.Frames.Count - 1))
                    DisplayFrame(_currentAnimation.Frames[_currentAnimation.Frames.IndexOf(_currentFrame) + 1]);
            }
        }

        private void PreviousFrame()
        {
            if (_currentFrame != null)
            {
                if (_currentAnimation.Frames.IndexOf(_currentFrame) > 0)
                    DisplayFrame(_currentAnimation.Frames[_currentAnimation.Frames.IndexOf(_currentFrame) - 1]);
            }
        }

        private void LoadDirectory()
        {
            if (_currentPath != "")
            {
                Application.UseWaitCursor = true;

                toolStripStatusLabel1.Text = "Loading";

                _characters.Clear();

                try
                {

                    Bitmap tmpBitmap;

                    DirectoryInfo dir = new DirectoryInfo(_currentPath);

                    foreach (FileInfo file in dir.GetFiles("*.png"))
                    {
                        string[] filenameparts = file.Name.Split(new char[] { '.' });

                        string[] elements = filenameparts[0].Split(new char[] { '_' });

                        if (elements.Length == 4)
                        {

                            Character character = _characters.FindByName(elements[0]);
                            if (character == null)
                            {
                                character = new Character(elements[0]);
                                _characters.Add(character);
                            }

                            Group group = character.Groups.FindByName(elements[1]);
                            if (group == null)
                            {
                                group = new Group(elements[1]);
                                character.Groups.Add(group);
                            }

                            Animation animation = group.Animations.FindByID(elements[2]);
                            if (animation == null)
                            {
                                animation = new Animation(elements[2]);
                                group.Animations.Add(animation);
                                group.Animations.Sort();
                            }

                            Frame frame = animation.Frames.FindByID(int.Parse(elements[3]));
                            if (frame == null)
                            {
                                frame = new Frame(UInt16.Parse(elements[3]));
                                frame.Path = file.FullName;
                                animation.Frames.Add(frame);
                                animation.Frames.Sort();

                                tmpBitmap = new Bitmap(_currentPath + "\\" + file.Name);
                                frame.Width = (ushort)tmpBitmap.Width;
                                frame.Height = (ushort)tmpBitmap.Height;
                            }

                        }
                        else
                        {
                            // MessageBox.Show("Invalid Filename: " + file.Name, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }


                    LoadData();

                    Display();

                    SaveConfig();

                }

                catch
                {
                    MessageBox.Show("Error loading directory " + _currentPath, "Flipbook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //finally
                //{
                //    
                //}

                Application.UseWaitCursor = false;
                toolStripStatusLabel1.Text = "Ready";
                
            }

        }

        private void SaveData()
        {
            foreach (Character chr in _characters)
            {
                foreach (Group grp in chr.Groups)
                {
                    foreach (Animation ani in grp.Animations)
                    {

                            string filePath = _currentPath + "\\" + chr.Name + "_" + grp.Name + "_" + ani.ID.ToString() + ".ani.bin";

                            using (BinaryWriter sw = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                            {
                                sw.Write((Int32)4711); // magic number
                                sw.Write((Int32)3);    // file version
                                // sw.Write(ani.ID); // off in v2
                                sw.Write(ani.Frames[0].Width);
                                sw.Write(ani.Frames[0].Height);
                                sw.Write(ani.PositionX);
                                sw.Write(ani.PositionY);
                                sw.Write(ani.Delay);
                                sw.Write(ani.FrameCount);

                                foreach (Frame frm in ani.Frames)
                                {
                                    sw.Write(frm.ID);
                                    sw.Write(frm.OffsetX);
                                    sw.Write(frm.OffsetY);
                                    sw.Write(frm.Delay);
                                }
                            }

                        }
                    }
            }
            _fileDirty = false;
        }

        private void LoadData()
        {
            foreach (Character chr in _characters)
            {
                foreach (Group grp in chr.Groups)
                {
                    foreach (Animation ani in grp.Animations)
                    {

                        string filePath = _currentPath + "\\" + chr.Name + "_" + grp.Name + "_" + ani.ID.ToString() + ".ani.bin";

                        if (File.Exists(filePath))
                        {

                            using (BinaryReader sw = new BinaryReader(File.Open(filePath, FileMode.Open)))
                            {
                                int magicnumber = sw.ReadInt32(); // magic number
                                
                                int fileversion = sw.ReadInt32(); // file version

                                if (fileversion == 1)
                                {
                                    sw.ReadString(); // ID
                                    ani.PositionX = sw.ReadInt16();
                                    ani.PositionY = sw.ReadInt16();
                                    ani.Delay = sw.ReadUInt16();
                                }
                                else if (fileversion == 2)
                                {
                                    sw.ReadInt32(); // Width
                                    sw.ReadInt32(); // Height
                                    ani.PositionX = sw.ReadInt16();
                                    ani.PositionY = sw.ReadInt16();
                                    ani.Delay = sw.ReadUInt16();
                                }
                                else if (fileversion == 3)
                                {
                                    sw.ReadInt16(); // Width
                                    sw.ReadInt16(); // Height
                                    ani.PositionX = sw.ReadInt16();
                                    ani.PositionY = sw.ReadInt16();
                                    ani.Delay = sw.ReadUInt16();
                                } 
                                
                                UInt16 FrameCount = sw.ReadUInt16();

                                int i = 0;

                                foreach (Frame frm in ani.Frames)
                                {
                                    if (i < FrameCount)
                                    {
                                        sw.ReadUInt16(); // ID
                                        frm.OffsetX = sw.ReadInt16();
                                        frm.OffsetY = sw.ReadInt16();
                                        frm.Delay = sw.ReadUInt16();

                                    }
                                }

                            }
                        }

                    }
                }
            }
            Display();
            _fileDirty = false;
            _currentAnimation.AllFramesDirty();
        }

        private void SetRollover(bool value)
        {
            _rollover = value;
            rolloverToolStripMenuItem.Checked = _rollover;
        }

        private void SetDisableAlphaChannel(bool value)
        {
            disableAlphaChannelToolStripMenuItem.Checked = value;
            if (_disableAlphaChannel != value)
            {
                _disableAlphaChannel = value;
                _currentAnimation.AllFramesDirty();
                DisplayFrame(_currentFrame);
            }
            
        }

        private void SetDisableTransparency(bool value)
        {
            disableTransparencyToolStripMenuItem.Checked = value;
            if (_disableTransparency != value)
            {
                _disableTransparency = value;
                AllFramesDirty(_currentAnimation);
                DisplayFrame(_currentFrame);
                SaveConfig();
            }

        }

        private void CheckSaveData()
        {
            if (_fileDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save your changes?", "Flipbook", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) SaveData();
            }
        }


        private void _zoomform_HandleDestroyed(object sender, EventArgs e)
        {
            _zoomform = null;
        }


        #endregion

        #region Overrides

        /*
        protected override bool IsInputKey(Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Left:
                case Keys.Right:

                case Keys.Home:
                case Keys.End:

                return true;
            }
            return base.IsInputKey(keyData);
        }
         

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home) FirstFrame();
            else if (e.KeyCode == Keys.End) LastFrame();
            else if (e.KeyCode == Keys.Left) PreviousFrame();
            else if (e.KeyCode == Keys.Right) NextFrame();
            else base.OnKeyDown(e);
        }
         * */

        #endregion

        #region Event Handlers

        private void ddbFPS_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == fpsToolStripMenuItem25) SetFrameSpeed(FrameSpeedOption.FPS25);
            else if (e.ClickedItem == fpsToolStripMenuItem30) SetFrameSpeed(FrameSpeedOption.FPS30);
            else if (e.ClickedItem == fpsToolStripMenuItem50) SetFrameSpeed(FrameSpeedOption.FPS50);
            else if (e.ClickedItem == fpsToolStripMenuItem60) SetFrameSpeed(FrameSpeedOption.FPS60);
            SaveConfig();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CheckSaveData();
            LoadDirectory();
        }

        private void pgAnimation_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            _currentAnimation.AllFramesDirty();
            DisplayFrame(_currentFrame);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = _currentPath;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

                _currentPath = folderBrowserDialog1.SelectedPath;
                LoadDirectory();
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            FirstFrame();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LastFrame();
        }

        private void btnRunForward_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (_currentAnimation != null)
            {
                _reverse = false;
                timer1.Interval = 1000 / _fpsvalue;
                timer1.Start();
            }
        }

        private void btnRunReverse_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (_currentAnimation != null)
            {
                _reverse = true;
                timer1.Interval = 1000 / _fpsvalue;
                timer1.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_countdown > 0) _countdown--;
            else
            {
                if (_reverse)
                {
                    if (_currentFrame == _currentAnimation.Frames[0])
                    {
                        if (_rollover) LastFrame();
                        else timer1.Stop();
                    }
                    else
                    {
                        PreviousFrame();
                        _countdown = _currentFrame.EffectiveDelay;
                    }
                }
                else
                {
                    if (_currentFrame == _currentAnimation.Frames[_currentAnimation.Frames.Count - 1])
                    {
                        if (_rollover) FirstFrame();
                        else timer1.Stop();
                    }
                    else
                    {
                        NextFrame();
                        _countdown = _currentFrame.EffectiveDelay;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfig();

            SetRollover(_rollover);
            SetDisableAlphaChannel(_disableAlphaChannel);
            SetDisableTransparency(_disableTransparency);
            SetFrameSpeed(_fps);
            SetBackgroundStyle(_backgroundStyle);
            SetDisableHelpers(_disableHelpers);

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoadDirectory();

        }


        private void ddbCharacter_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DisplayCharacter((Character)e.ClickedItem.Tag);
        }

        private void ddbGroup_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DisplayGroup((Group)e.ClickedItem.Tag);
        }

        private void ddbID_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DisplayAnimation((Animation)e.ClickedItem.Tag);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            NextFrame();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            PreviousFrame();
        }

        private void btnLoadBackground_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = _currentPath;
            openFileDialog1.InitialDirectory = _currentBackground;
            openFileDialog1.Filter = "Portable Network Graphics (*.png)|*.png";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _currentBackground = openFileDialog1.FileName;
                SetBackgroundStyle(BackgroundStyle.Image);
                BuildImage(_currentFrame);
                AllFramesDirty(_currentAnimation);
                DisplayFrame(_currentFrame);
                SaveConfig();
            }

        }

        private void btnSaveFrame_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void tbFramePosition_ValueChanged(object sender, EventArgs e)
        {
            if (!_updateSliderEventDisable)
            {
                if (_currentAnimation != null)
                {
                    DisplayFrame(_currentAnimation.Frames[tbFramePosition.Value]);
                }
            }
        }

        private void udFrameOffsetX_ValueChanged(object sender, EventArgs e)
        {
            if (_currentAnimation != null)
            {
                if (_currentFrame.OffsetX != (Int16)udFrameOffsetX.Value)
                {
                    _currentFrame.OffsetX = (Int16)udFrameOffsetX.Value;
                    _currentAnimation.AllFramesDirty();
                    DisplayFrame(_currentFrame);
                    _fileDirty = true;
                }
            }
        }

        private void udFrameOffsetY_ValueChanged(object sender, EventArgs e)
        {
            if (_currentAnimation != null)
            {
                if (_currentFrame.OffsetY != (Int16)udFrameOffsetY.Value)
                {
                    _currentFrame.OffsetY = (Int16)udFrameOffsetY.Value;
                    _currentAnimation.AllFramesDirty();
                    DisplayFrame(_currentFrame);
                    _fileDirty = true;
                }
            }
        }

        private void udFrameDelay_ValueChanged(object sender, EventArgs e)
        {
            if (_currentAnimation != null)
            {
                if (_currentFrame.Delay != (UInt16)udFrameDelay.Value)
                {
                    _currentFrame.Delay = (UInt16)udFrameDelay.Value;
                    _currentAnimation.AllFramesDirty();
                    DisplayFrame(_currentFrame);
                    _fileDirty = true;
                }
            }
        }

        private void udAnimationPositionX_ValueChanged(object sender, EventArgs e)
        {
            if (_currentAnimation != null)
            {
                if (_currentAnimation.PositionX != (Int16)udAnimationPositionX.Value)
                {
                    _currentAnimation.PositionX = (Int16)udAnimationPositionX.Value;
                    _currentAnimation.AllFramesDirty();
                    if (_currentFrame != null) DisplayFrame(_currentFrame);
                    _fileDirty = true;
                }
            }
        }

        private void udAnimationPositionY_ValueChanged(object sender, EventArgs e)
        {
            if (_currentAnimation != null)
            {
                if (_currentAnimation.PositionY != (Int16)udAnimationPositionY.Value)
                {
                    _currentAnimation.PositionY = (Int16)udAnimationPositionY.Value;
                    _currentAnimation.AllFramesDirty();
                    if (_currentFrame != null) DisplayFrame(_currentFrame);
                    _fileDirty = true;
                }
            }
        }

        private void udAnimationDelay_ValueChanged(object sender, EventArgs e)
        {
            if (_currentAnimation != null)
            {
                if (_currentAnimation.Delay != (UInt16)udAnimationDelay.Value)
                {
                    _currentAnimation.Delay = (UInt16)udAnimationDelay.Value;
                    _currentAnimation.AllFramesDirty();
                    if (_currentFrame != null) DisplayFrame(_currentFrame);
                    _fileDirty = true;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckSaveData();
        }

        private void rolloverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRollover(!_rollover);
            SaveConfig();
        }

        private void useAlphaChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDisableAlphaChannel(!_disableAlphaChannel);
            SaveConfig();
        }


        private void disableTransparencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDisableTransparency(!_disableTransparency);
            SaveConfig();
        }

        private void ddbBackground_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == imageToolStripMenuItemImage) SetBackgroundStyle(BackgroundStyle.Image);
            else if (e.ClickedItem == imageToolStripMenuItemWhite) SetBackgroundStyle(BackgroundStyle.White);
            else if (e.ClickedItem == imageToolStripMenuItemBlack) SetBackgroundStyle(BackgroundStyle.Black);
            else if (e.ClickedItem == imageToolStripMenuItemRed) SetBackgroundStyle(BackgroundStyle.Red);
            else if (e.ClickedItem == imageToolStripMenuItemGreen) SetBackgroundStyle(BackgroundStyle.Green);
            else if (e.ClickedItem == imageToolStripMenuItemBlue) SetBackgroundStyle(BackgroundStyle.Blue);
            else if (e.ClickedItem == imageToolStripMenuItemAlpha) SetBackgroundStyle(BackgroundStyle.Alpha);
            SaveConfig();
            AllFramesDirty(_currentAnimation);
            DisplayFrame(_currentFrame);
        }

        private void btnZoom_Click(object sender, EventArgs e)
        {
            if (_currentFrame != null)
            {
                if (_zoomform == null)
                {
                    _zoomform = new Zoom();
                    _zoomform.HandleDestroyed += new EventHandler(_zoomform_HandleDestroyed);
                }

                if (_currentFrame.Dirty) BuildImage(_currentFrame);

                _zoomform.ShowImage(_currentFrame.ImageCache);

                _zoomform.Show();
                _zoomform.BringToFront();
            }

        }

        #endregion

        private void udX1_ValueChanged(object sender, EventArgs e)
        {
            if (!_updateHelperEventDisable)
            {
                AllFramesDirty(_currentAnimation);
                DisplayFrame(_currentFrame);
                SaveConfig();
            }
        }

        private void udX2_ValueChanged(object sender, EventArgs e)
        {
            if (!_updateHelperEventDisable)
            {
                AllFramesDirty(_currentAnimation);
                DisplayFrame(_currentFrame);
                SaveConfig();
            }
        }

        private void udY1_ValueChanged(object sender, EventArgs e)
        {
            if (!_updateHelperEventDisable)
            {
                AllFramesDirty(_currentAnimation);
                DisplayFrame(_currentFrame);
                SaveConfig();
            }
        }

        private void udY2_ValueChanged(object sender, EventArgs e)
        {
            if (!_updateHelperEventDisable)
            {
                AllFramesDirty(_currentAnimation);
                DisplayFrame(_currentFrame);
                SaveConfig();
            }
        }

        private void disableHelpersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDisableHelpers(!_disableHelpers);
            SaveConfig();
        }

        private void SetDisableHelpers(bool p)
        {
            disableHelpersToolStripMenuItem.Checked = p;
            if (p != _disableHelpers)
            {
                _disableHelpers = p;
                _currentAnimation.AllFramesDirty();
                DisplayFrame(_currentFrame);
                SaveConfig();
            }
        }

        private void SaveComposite()
        {
            if (_currentGroup != null)
            {

                string path;
                path = _currentPath + "\\composite\\";

                Application.UseWaitCursor = true;

                if (!Directory.Exists(path))
                {
                    try
                    {
                        Directory.CreateDirectory(path);
                    }
                    catch
                    {
                        DialogResult result;
                        result = MessageBox.Show("Unable to find or create directory " + path, "Flipbook", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto forgetit_label;
                    }
                }


                int animationcount = _currentGroup.Animations.Count;
                int i = 1;

                foreach (Animation ani in _currentGroup.Animations)
                {

                    ani.AllFramesDirty();

                    toolStripStatusLabel1.Text = "Saving composite images of all animations... (" + i.ToString() + "/" + animationcount.ToString() + ")";
                    Application.DoEvents();

                    foreach (Frame frm in ani.Frames)
                    {
                        string filename;
                        filename = "c_" + _currentCharacter.Name + "_" + _currentGroup.Name + "_" + ani.ID + "_" + frm.ID.ToString("000") + ".png";

                        if (frm.Dirty) BuildImage(frm);

                    retry_label:

                        try
                        {
                            frm.ImageCache.Save(path + filename, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        catch
                        {
                            DialogResult result;
                            result = MessageBox.Show("Error saving file " + filename, "Flipbook", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                            if (result == DialogResult.Abort) goto forgetit_label;
                            if (result == DialogResult.Ignore) continue;
                            goto retry_label;
                        }
                    }

                    i++;
                }

            forgetit_label:

                Application.UseWaitCursor = false;
                toolStripStatusLabel1.Text = "Ready";
            }
        }

        private void toolStripButtonSaveComposite_Click(object sender, EventArgs e)
        {
            SaveComposite();
        }



    }

    
}