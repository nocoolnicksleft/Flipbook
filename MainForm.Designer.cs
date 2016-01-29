namespace Flipbook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel tlpFrame;
            System.Windows.Forms.TableLayoutPanel tlpAnimation;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtFrameHeight = new System.Windows.Forms.Label();
            this.txtFrameWidth = new System.Windows.Forms.Label();
            this.lblFrameWidth = new System.Windows.Forms.Label();
            this.lblFrameHeight = new System.Windows.Forms.Label();
            this.lblFrameEffectiveX = new System.Windows.Forms.Label();
            this.txtFrameEffectiveX = new System.Windows.Forms.Label();
            this.lblFrameOffsetX = new System.Windows.Forms.Label();
            this.lblFrameEffectiveY = new System.Windows.Forms.Label();
            this.udFrameOffsetX = new System.Windows.Forms.NumericUpDown();
            this.txtFrameEffectiveY = new System.Windows.Forms.Label();
            this.lblFrameEffectiveDelay = new System.Windows.Forms.Label();
            this.txtFrameEffectiveDelay = new System.Windows.Forms.Label();
            this.lblFrameDelay = new System.Windows.Forms.Label();
            this.lblFrameOffsetY = new System.Windows.Forms.Label();
            this.udFrameDelay = new System.Windows.Forms.NumericUpDown();
            this.udFrameOffsetY = new System.Windows.Forms.NumericUpDown();
            this.txtAnimationFrames = new System.Windows.Forms.Label();
            this.lblAnimationCount = new System.Windows.Forms.Label();
            this.lblAnimationPositionX = new System.Windows.Forms.Label();
            this.udAnimationPositionX = new System.Windows.Forms.NumericUpDown();
            this.lblAnimationDelay = new System.Windows.Forms.Label();
            this.lblAnimationPositionY = new System.Windows.Forms.Label();
            this.udAnimationDelay = new System.Windows.Forms.NumericUpDown();
            this.udAnimationPositionY = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnRunReverse = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRunForward = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSaveFrame = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveComposite = new System.Windows.Forms.ToolStripButton();
            this.btnZoom = new System.Windows.Forms.ToolStripButton();
            this.btnGenerateSource = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbCharacter = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddbGroup = new System.Windows.Forms.ToolStripDropDownButton();
            this.ddbID = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLoadBackground = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbBackground = new System.Windows.Forms.ToolStripDropDownButton();
            this.imageToolStripMenuItemImage = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItemWhite = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItemBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItemRed = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItemGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItemBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItemAlpha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ddbFPS = new System.Windows.Forms.ToolStripDropDownButton();
            this.fpsToolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.fpsToolStripMenuItem30 = new System.Windows.Forms.ToolStripMenuItem();
            this.fpsToolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.fpsToolStripMenuItem60 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rolloverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableAlphaChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableTransparencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableHelpersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblFrame = new System.Windows.Forms.Label();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbFramePosition = new System.Windows.Forms.TrackBar();
            this.txtFrameNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.udY1 = new System.Windows.Forms.NumericUpDown();
            this.udY2 = new System.Windows.Forms.NumericUpDown();
            this.udX1 = new System.Windows.Forms.NumericUpDown();
            this.udX2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            tlpFrame = new System.Windows.Forms.TableLayoutPanel();
            tlpAnimation = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tlpFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFrameOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFrameDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFrameOffsetY)).BeginInit();
            tlpAnimation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udAnimationPositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAnimationDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAnimationPositionY)).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFramePosition)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX2)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFrame
            // 
            tlpFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tlpFrame.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tlpFrame.ColumnCount = 2;
            tlpFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tlpFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            tlpFrame.Controls.Add(this.txtFrameHeight, 1, 1);
            tlpFrame.Controls.Add(this.txtFrameWidth, 1, 0);
            tlpFrame.Controls.Add(this.lblFrameWidth, 0, 0);
            tlpFrame.Controls.Add(this.lblFrameHeight, 0, 1);
            tlpFrame.Controls.Add(this.lblFrameEffectiveX, 0, 2);
            tlpFrame.Controls.Add(this.txtFrameEffectiveX, 1, 2);
            tlpFrame.Controls.Add(this.lblFrameOffsetX, 0, 5);
            tlpFrame.Controls.Add(this.lblFrameEffectiveY, 0, 3);
            tlpFrame.Controls.Add(this.udFrameOffsetX, 1, 5);
            tlpFrame.Controls.Add(this.txtFrameEffectiveY, 1, 3);
            tlpFrame.Controls.Add(this.lblFrameEffectiveDelay, 0, 4);
            tlpFrame.Controls.Add(this.txtFrameEffectiveDelay, 1, 4);
            tlpFrame.Controls.Add(this.lblFrameDelay, 0, 7);
            tlpFrame.Controls.Add(this.lblFrameOffsetY, 0, 6);
            tlpFrame.Controls.Add(this.udFrameDelay, 1, 7);
            tlpFrame.Controls.Add(this.udFrameOffsetY, 1, 6);
            tlpFrame.ForeColor = System.Drawing.SystemColors.ControlText;
            tlpFrame.Location = new System.Drawing.Point(307, 56);
            tlpFrame.Name = "tlpFrame";
            tlpFrame.RowCount = 8;
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpFrame.Size = new System.Drawing.Size(170, 221);
            tlpFrame.TabIndex = 17;
            // 
            // txtFrameHeight
            // 
            this.txtFrameHeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFrameHeight.Location = new System.Drawing.Point(90, 28);
            this.txtFrameHeight.Name = "txtFrameHeight";
            this.txtFrameHeight.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtFrameHeight.Size = new System.Drawing.Size(62, 19);
            this.txtFrameHeight.TabIndex = 9;
            this.txtFrameHeight.Text = "120";
            // 
            // txtFrameWidth
            // 
            this.txtFrameWidth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFrameWidth.Location = new System.Drawing.Point(90, 1);
            this.txtFrameWidth.Name = "txtFrameWidth";
            this.txtFrameWidth.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtFrameWidth.Size = new System.Drawing.Size(62, 19);
            this.txtFrameWidth.TabIndex = 8;
            this.txtFrameWidth.Text = "120";
            // 
            // lblFrameWidth
            // 
            this.lblFrameWidth.CausesValidation = false;
            this.lblFrameWidth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFrameWidth.Location = new System.Drawing.Point(4, 1);
            this.lblFrameWidth.Name = "lblFrameWidth";
            this.lblFrameWidth.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameWidth.Size = new System.Drawing.Size(35, 19);
            this.lblFrameWidth.TabIndex = 6;
            this.lblFrameWidth.Text = "Width";
            // 
            // lblFrameHeight
            // 
            this.lblFrameHeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFrameHeight.Location = new System.Drawing.Point(4, 28);
            this.lblFrameHeight.Name = "lblFrameHeight";
            this.lblFrameHeight.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameHeight.Size = new System.Drawing.Size(38, 19);
            this.lblFrameHeight.TabIndex = 7;
            this.lblFrameHeight.Text = "Height";
            // 
            // lblFrameEffectiveX
            // 
            this.lblFrameEffectiveX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFrameEffectiveX.Location = new System.Drawing.Point(4, 55);
            this.lblFrameEffectiveX.Name = "lblFrameEffectiveX";
            this.lblFrameEffectiveX.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameEffectiveX.Size = new System.Drawing.Size(59, 19);
            this.lblFrameEffectiveX.TabIndex = 10;
            this.lblFrameEffectiveX.Text = "Effective X";
            // 
            // txtFrameEffectiveX
            // 
            this.txtFrameEffectiveX.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFrameEffectiveX.Location = new System.Drawing.Point(90, 55);
            this.txtFrameEffectiveX.Name = "txtFrameEffectiveX";
            this.txtFrameEffectiveX.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtFrameEffectiveX.Size = new System.Drawing.Size(62, 19);
            this.txtFrameEffectiveX.TabIndex = 11;
            this.txtFrameEffectiveX.Text = "0";
            // 
            // lblFrameOffsetX
            // 
            this.lblFrameOffsetX.Location = new System.Drawing.Point(4, 136);
            this.lblFrameOffsetX.Name = "lblFrameOffsetX";
            this.lblFrameOffsetX.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameOffsetX.Size = new System.Drawing.Size(45, 19);
            this.lblFrameOffsetX.TabIndex = 3;
            this.lblFrameOffsetX.Text = "Offset X";
            // 
            // lblFrameEffectiveY
            // 
            this.lblFrameEffectiveY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFrameEffectiveY.Location = new System.Drawing.Point(4, 82);
            this.lblFrameEffectiveY.Name = "lblFrameEffectiveY";
            this.lblFrameEffectiveY.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameEffectiveY.Size = new System.Drawing.Size(59, 19);
            this.lblFrameEffectiveY.TabIndex = 12;
            this.lblFrameEffectiveY.Text = "Effective Y";
            // 
            // udFrameOffsetX
            // 
            this.udFrameOffsetX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udFrameOffsetX.CausesValidation = false;
            this.udFrameOffsetX.Location = new System.Drawing.Point(90, 139);
            this.udFrameOffsetX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udFrameOffsetX.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.udFrameOffsetX.Name = "udFrameOffsetX";
            this.udFrameOffsetX.Size = new System.Drawing.Size(46, 20);
            this.udFrameOffsetX.TabIndex = 0;
            this.udFrameOffsetX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udFrameOffsetX.ValueChanged += new System.EventHandler(this.udFrameOffsetX_ValueChanged);
            // 
            // txtFrameEffectiveY
            // 
            this.txtFrameEffectiveY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFrameEffectiveY.Location = new System.Drawing.Point(90, 82);
            this.txtFrameEffectiveY.Name = "txtFrameEffectiveY";
            this.txtFrameEffectiveY.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtFrameEffectiveY.Size = new System.Drawing.Size(62, 19);
            this.txtFrameEffectiveY.TabIndex = 13;
            this.txtFrameEffectiveY.Text = "0";
            // 
            // lblFrameEffectiveDelay
            // 
            this.lblFrameEffectiveDelay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFrameEffectiveDelay.Location = new System.Drawing.Point(4, 109);
            this.lblFrameEffectiveDelay.Name = "lblFrameEffectiveDelay";
            this.lblFrameEffectiveDelay.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameEffectiveDelay.Size = new System.Drawing.Size(61, 19);
            this.lblFrameEffectiveDelay.TabIndex = 15;
            this.lblFrameEffectiveDelay.Text = "Total Delay";
            // 
            // txtFrameEffectiveDelay
            // 
            this.txtFrameEffectiveDelay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFrameEffectiveDelay.Location = new System.Drawing.Point(90, 109);
            this.txtFrameEffectiveDelay.Name = "txtFrameEffectiveDelay";
            this.txtFrameEffectiveDelay.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtFrameEffectiveDelay.Size = new System.Drawing.Size(62, 19);
            this.txtFrameEffectiveDelay.TabIndex = 14;
            this.txtFrameEffectiveDelay.Text = "0";
            // 
            // lblFrameDelay
            // 
            this.lblFrameDelay.Location = new System.Drawing.Point(4, 190);
            this.lblFrameDelay.Name = "lblFrameDelay";
            this.lblFrameDelay.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameDelay.Size = new System.Drawing.Size(34, 19);
            this.lblFrameDelay.TabIndex = 5;
            this.lblFrameDelay.Text = "Delay";
            // 
            // lblFrameOffsetY
            // 
            this.lblFrameOffsetY.Location = new System.Drawing.Point(4, 163);
            this.lblFrameOffsetY.Name = "lblFrameOffsetY";
            this.lblFrameOffsetY.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblFrameOffsetY.Size = new System.Drawing.Size(45, 19);
            this.lblFrameOffsetY.TabIndex = 4;
            this.lblFrameOffsetY.Text = "Offset Y";
            // 
            // udFrameDelay
            // 
            this.udFrameDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udFrameDelay.CausesValidation = false;
            this.udFrameDelay.Location = new System.Drawing.Point(90, 193);
            this.udFrameDelay.Name = "udFrameDelay";
            this.udFrameDelay.Size = new System.Drawing.Size(46, 20);
            this.udFrameDelay.TabIndex = 2;
            this.udFrameDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udFrameDelay.ValueChanged += new System.EventHandler(this.udFrameDelay_ValueChanged);
            // 
            // udFrameOffsetY
            // 
            this.udFrameOffsetY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udFrameOffsetY.CausesValidation = false;
            this.udFrameOffsetY.Location = new System.Drawing.Point(90, 166);
            this.udFrameOffsetY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udFrameOffsetY.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.udFrameOffsetY.Name = "udFrameOffsetY";
            this.udFrameOffsetY.Size = new System.Drawing.Size(46, 20);
            this.udFrameOffsetY.TabIndex = 1;
            this.udFrameOffsetY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udFrameOffsetY.ValueChanged += new System.EventHandler(this.udFrameOffsetY_ValueChanged);
            // 
            // tlpAnimation
            // 
            tlpAnimation.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tlpAnimation.ColumnCount = 2;
            tlpAnimation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tlpAnimation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            tlpAnimation.Controls.Add(this.txtAnimationFrames, 1, 0);
            tlpAnimation.Controls.Add(this.lblAnimationCount, 0, 0);
            tlpAnimation.Controls.Add(this.lblAnimationPositionX, 0, 5);
            tlpAnimation.Controls.Add(this.udAnimationPositionX, 1, 5);
            tlpAnimation.Controls.Add(this.lblAnimationDelay, 0, 7);
            tlpAnimation.Controls.Add(this.lblAnimationPositionY, 0, 6);
            tlpAnimation.Controls.Add(this.udAnimationDelay, 1, 7);
            tlpAnimation.Controls.Add(this.udAnimationPositionY, 1, 6);
            tlpAnimation.ForeColor = System.Drawing.SystemColors.ControlText;
            tlpAnimation.Location = new System.Drawing.Point(506, 57);
            tlpAnimation.Name = "tlpAnimation";
            tlpAnimation.RowCount = 8;
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tlpAnimation.Size = new System.Drawing.Size(170, 221);
            tlpAnimation.TabIndex = 19;
            // 
            // txtAnimationFrames
            // 
            this.txtAnimationFrames.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAnimationFrames.Location = new System.Drawing.Point(90, 1);
            this.txtAnimationFrames.Name = "txtAnimationFrames";
            this.txtAnimationFrames.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.txtAnimationFrames.Size = new System.Drawing.Size(69, 19);
            this.txtAnimationFrames.TabIndex = 8;
            this.txtAnimationFrames.Text = "0";
            // 
            // lblAnimationCount
            // 
            this.lblAnimationCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAnimationCount.Location = new System.Drawing.Point(4, 1);
            this.lblAnimationCount.Name = "lblAnimationCount";
            this.lblAnimationCount.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAnimationCount.Size = new System.Drawing.Size(41, 19);
            this.lblAnimationCount.TabIndex = 6;
            this.lblAnimationCount.Text = "Frames";
            // 
            // lblAnimationPositionX
            // 
            this.lblAnimationPositionX.Location = new System.Drawing.Point(4, 136);
            this.lblAnimationPositionX.Name = "lblAnimationPositionX";
            this.lblAnimationPositionX.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAnimationPositionX.Size = new System.Drawing.Size(54, 19);
            this.lblAnimationPositionX.TabIndex = 3;
            this.lblAnimationPositionX.Text = "Position X";
            // 
            // udAnimationPositionX
            // 
            this.udAnimationPositionX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udAnimationPositionX.CausesValidation = false;
            this.udAnimationPositionX.Location = new System.Drawing.Point(90, 139);
            this.udAnimationPositionX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udAnimationPositionX.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.udAnimationPositionX.Name = "udAnimationPositionX";
            this.udAnimationPositionX.Size = new System.Drawing.Size(46, 20);
            this.udAnimationPositionX.TabIndex = 0;
            this.udAnimationPositionX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udAnimationPositionX.ValueChanged += new System.EventHandler(this.udAnimationPositionX_ValueChanged);
            // 
            // lblAnimationDelay
            // 
            this.lblAnimationDelay.Location = new System.Drawing.Point(4, 190);
            this.lblAnimationDelay.Name = "lblAnimationDelay";
            this.lblAnimationDelay.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAnimationDelay.Size = new System.Drawing.Size(34, 19);
            this.lblAnimationDelay.TabIndex = 5;
            this.lblAnimationDelay.Text = "Delay";
            // 
            // lblAnimationPositionY
            // 
            this.lblAnimationPositionY.Location = new System.Drawing.Point(4, 163);
            this.lblAnimationPositionY.Name = "lblAnimationPositionY";
            this.lblAnimationPositionY.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblAnimationPositionY.Size = new System.Drawing.Size(54, 19);
            this.lblAnimationPositionY.TabIndex = 4;
            this.lblAnimationPositionY.Text = "Position Y";
            // 
            // udAnimationDelay
            // 
            this.udAnimationDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udAnimationDelay.CausesValidation = false;
            this.udAnimationDelay.Location = new System.Drawing.Point(90, 193);
            this.udAnimationDelay.Name = "udAnimationDelay";
            this.udAnimationDelay.Size = new System.Drawing.Size(46, 20);
            this.udAnimationDelay.TabIndex = 2;
            this.udAnimationDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udAnimationDelay.ValueChanged += new System.EventHandler(this.udAnimationDelay_ValueChanged);
            // 
            // udAnimationPositionY
            // 
            this.udAnimationPositionY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udAnimationPositionY.CausesValidation = false;
            this.udAnimationPositionY.Location = new System.Drawing.Point(90, 166);
            this.udAnimationPositionY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udAnimationPositionY.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.udAnimationPositionY.Name = "udAnimationPositionY";
            this.udAnimationPositionY.Size = new System.Drawing.Size(46, 20);
            this.udAnimationPositionY.TabIndex = 1;
            this.udAnimationPositionY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udAnimationPositionY.ValueChanged += new System.EventHandler(this.udAnimationPositionY_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(90, 22);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "120";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(90, 1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "120";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(26, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 192);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Location = new System.Drawing.Point(42, 255);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(27, 23);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnRunReverse
            // 
            this.btnRunReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRunReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunReverse.Location = new System.Drawing.Point(75, 255);
            this.btnRunReverse.Name = "btnRunReverse";
            this.btnRunReverse.Size = new System.Drawing.Size(27, 23);
            this.btnRunReverse.TabIndex = 3;
            this.btnRunReverse.Text = "<<";
            this.btnRunReverse.UseVisualStyleBackColor = false;
            this.btnRunReverse.Click += new System.EventHandler(this.btnRunReverse_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrevious.Location = new System.Drawing.Point(108, 255);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(27, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(141, 255);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(27, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "|";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Location = new System.Drawing.Point(174, 255);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRunForward
            // 
            this.btnRunForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRunForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRunForward.Location = new System.Drawing.Point(207, 255);
            this.btnRunForward.Name = "btnRunForward";
            this.btnRunForward.Size = new System.Drawing.Size(27, 23);
            this.btnRunForward.TabIndex = 7;
            this.btnRunForward.Text = ">>";
            this.btnRunForward.UseVisualStyleBackColor = false;
            this.btnRunForward.Click += new System.EventHandler(this.btnRunForward_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Location = new System.Drawing.Point(240, 255);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(27, 23);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnRefresh,
            this.btnSaveFrame,
            this.toolStripButtonSaveComposite,
            this.btnZoom,
            this.btnGenerateSource,
            this.toolStripSeparator1,
            this.ddbCharacter,
            this.ddbGroup,
            this.ddbID,
            this.toolStripSeparator2,
            this.btnLoadBackground,
            this.toolStripSeparator5,
            this.ddbBackground,
            this.toolStripSeparator3,
            this.ddbFPS,
            this.toolStripSeparator4,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(706, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "toolStripButton1";
            this.btnOpen.ToolTipText = "Open Animation Directory (*.png)";
            this.btnOpen.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.ToolTipText = "Reload Data";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveFrame
            // 
            this.btnSaveFrame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveFrame.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFrame.Image")));
            this.btnSaveFrame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveFrame.Name = "btnSaveFrame";
            this.btnSaveFrame.Size = new System.Drawing.Size(23, 22);
            this.btnSaveFrame.Text = "toolStripButton1";
            this.btnSaveFrame.ToolTipText = "Save Frame Parameters";
            this.btnSaveFrame.Click += new System.EventHandler(this.btnSaveFrame_Click);
            // 
            // toolStripButtonSaveComposite
            // 
            this.toolStripButtonSaveComposite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveComposite.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveComposite.Image")));
            this.toolStripButtonSaveComposite.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolStripButtonSaveComposite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveComposite.Name = "toolStripButtonSaveComposite";
            this.toolStripButtonSaveComposite.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveComposite.Text = "toolStripButton1";
            this.toolStripButtonSaveComposite.ToolTipText = "Write composite images";
            this.toolStripButtonSaveComposite.Click += new System.EventHandler(this.toolStripButtonSaveComposite_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoom.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom.Image")));
            this.btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(23, 22);
            this.btnZoom.Text = "toolStripButton1";
            this.btnZoom.ToolTipText = "Zoom current frame";
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnGenerateSource
            // 
            this.btnGenerateSource.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGenerateSource.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateSource.Image")));
            this.btnGenerateSource.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerateSource.Name = "btnGenerateSource";
            this.btnGenerateSource.Size = new System.Drawing.Size(23, 22);
            this.btnGenerateSource.Text = "toolStripButton1";
            this.btnGenerateSource.ToolTipText = "Generate Source";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ddbCharacter
            // 
            this.ddbCharacter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbCharacter.Image = ((System.Drawing.Image)(resources.GetObject("ddbCharacter.Image")));
            this.ddbCharacter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbCharacter.Name = "ddbCharacter";
            this.ddbCharacter.Size = new System.Drawing.Size(92, 22);
            this.ddbCharacter.Text = "(No Character)";
            this.ddbCharacter.ToolTipText = "Select Character";
            this.ddbCharacter.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ddbCharacter_DropDownItemClicked);
            // 
            // ddbGroup
            // 
            this.ddbGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbGroup.Image = ((System.Drawing.Image)(resources.GetObject("ddbGroup.Image")));
            this.ddbGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbGroup.Name = "ddbGroup";
            this.ddbGroup.Size = new System.Drawing.Size(73, 22);
            this.ddbGroup.Text = "(No Group)";
            this.ddbGroup.ToolTipText = "Select Animation Group";
            this.ddbGroup.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ddbGroup_DropDownItemClicked);
            // 
            // ddbID
            // 
            this.ddbID.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbID.Image = ((System.Drawing.Image)(resources.GetObject("ddbID.Image")));
            this.ddbID.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbID.Name = "ddbID";
            this.ddbID.Size = new System.Drawing.Size(74, 22);
            this.ddbID.Text = "(No Frame)";
            this.ddbID.ToolTipText = "Select Sequence";
            this.ddbID.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ddbID_DropDownItemClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLoadBackground
            // 
            this.btnLoadBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadBackground.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadBackground.Image")));
            this.btnLoadBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadBackground.Name = "btnLoadBackground";
            this.btnLoadBackground.Size = new System.Drawing.Size(23, 22);
            this.btnLoadBackground.Text = "toolStripButton2";
            this.btnLoadBackground.ToolTipText = "Load Background Image";
            this.btnLoadBackground.Click += new System.EventHandler(this.btnLoadBackground_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ddbBackground
            // 
            this.ddbBackground.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbBackground.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItemImage,
            this.imageToolStripMenuItemWhite,
            this.imageToolStripMenuItemBlack,
            this.imageToolStripMenuItemRed,
            this.imageToolStripMenuItemGreen,
            this.imageToolStripMenuItemBlue,
            this.imageToolStripMenuItemAlpha});
            this.ddbBackground.Image = ((System.Drawing.Image)(resources.GetObject("ddbBackground.Image")));
            this.ddbBackground.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbBackground.Name = "ddbBackground";
            this.ddbBackground.Size = new System.Drawing.Size(76, 22);
            this.ddbBackground.Text = "Background";
            this.ddbBackground.ToolTipText = "Select Background Content";
            this.ddbBackground.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ddbBackground_DropDownItemClicked);
            // 
            // imageToolStripMenuItemImage
            // 
            this.imageToolStripMenuItemImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imageToolStripMenuItemImage.Name = "imageToolStripMenuItemImage";
            this.imageToolStripMenuItemImage.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemImage.Text = "Image";
            this.imageToolStripMenuItemImage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // imageToolStripMenuItemWhite
            // 
            this.imageToolStripMenuItemWhite.Name = "imageToolStripMenuItemWhite";
            this.imageToolStripMenuItemWhite.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemWhite.Text = "White";
            // 
            // imageToolStripMenuItemBlack
            // 
            this.imageToolStripMenuItemBlack.Name = "imageToolStripMenuItemBlack";
            this.imageToolStripMenuItemBlack.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemBlack.Text = "Black";
            // 
            // imageToolStripMenuItemRed
            // 
            this.imageToolStripMenuItemRed.Name = "imageToolStripMenuItemRed";
            this.imageToolStripMenuItemRed.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemRed.Text = "Red";
            // 
            // imageToolStripMenuItemGreen
            // 
            this.imageToolStripMenuItemGreen.Name = "imageToolStripMenuItemGreen";
            this.imageToolStripMenuItemGreen.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemGreen.Text = "Green";
            // 
            // imageToolStripMenuItemBlue
            // 
            this.imageToolStripMenuItemBlue.Name = "imageToolStripMenuItemBlue";
            this.imageToolStripMenuItemBlue.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemBlue.Text = "Blue";
            // 
            // imageToolStripMenuItemAlpha
            // 
            this.imageToolStripMenuItemAlpha.Name = "imageToolStripMenuItemAlpha";
            this.imageToolStripMenuItemAlpha.Size = new System.Drawing.Size(104, 22);
            this.imageToolStripMenuItemAlpha.Text = "Alpha";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ddbFPS
            // 
            this.ddbFPS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddbFPS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fpsToolStripMenuItem25,
            this.fpsToolStripMenuItem30,
            this.fpsToolStripMenuItem50,
            this.fpsToolStripMenuItem60});
            this.ddbFPS.Image = ((System.Drawing.Image)(resources.GetObject("ddbFPS.Image")));
            this.ddbFPS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddbFPS.Name = "ddbFPS";
            this.ddbFPS.Size = new System.Drawing.Size(50, 22);
            this.ddbFPS.Tag = "30";
            this.ddbFPS.Text = "30 fps";
            this.ddbFPS.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ddbFPS.ToolTipText = "Change Framerate";
            this.ddbFPS.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ddbFPS_DropDownItemClicked);
            // 
            // fpsToolStripMenuItem25
            // 
            this.fpsToolStripMenuItem25.Name = "fpsToolStripMenuItem25";
            this.fpsToolStripMenuItem25.Size = new System.Drawing.Size(104, 22);
            this.fpsToolStripMenuItem25.Tag = "25";
            this.fpsToolStripMenuItem25.Text = "25 fps";
            // 
            // fpsToolStripMenuItem30
            // 
            this.fpsToolStripMenuItem30.Name = "fpsToolStripMenuItem30";
            this.fpsToolStripMenuItem30.Size = new System.Drawing.Size(104, 22);
            this.fpsToolStripMenuItem30.Tag = "30";
            this.fpsToolStripMenuItem30.Text = "30 fps";
            // 
            // fpsToolStripMenuItem50
            // 
            this.fpsToolStripMenuItem50.Name = "fpsToolStripMenuItem50";
            this.fpsToolStripMenuItem50.Size = new System.Drawing.Size(104, 22);
            this.fpsToolStripMenuItem50.Tag = "50";
            this.fpsToolStripMenuItem50.Text = "50 fps";
            // 
            // fpsToolStripMenuItem60
            // 
            this.fpsToolStripMenuItem60.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fpsToolStripMenuItem60.Name = "fpsToolStripMenuItem60";
            this.fpsToolStripMenuItem60.Size = new System.Drawing.Size(104, 22);
            this.fpsToolStripMenuItem60.Tag = "60";
            this.fpsToolStripMenuItem60.Text = "60 fps";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolloverToolStripMenuItem,
            this.disableAlphaChannelToolStripMenuItem,
            this.disableTransparencyToolStripMenuItem,
            this.disableHelpersToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButton1.Text = "Options";
            this.toolStripDropDownButton1.ToolTipText = "Select Options";
            // 
            // rolloverToolStripMenuItem
            // 
            this.rolloverToolStripMenuItem.Name = "rolloverToolStripMenuItem";
            this.rolloverToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolloverToolStripMenuItem.Text = "Rollover";
            this.rolloverToolStripMenuItem.Click += new System.EventHandler(this.rolloverToolStripMenuItem_Click);
            // 
            // disableAlphaChannelToolStripMenuItem
            // 
            this.disableAlphaChannelToolStripMenuItem.Checked = true;
            this.disableAlphaChannelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableAlphaChannelToolStripMenuItem.Name = "disableAlphaChannelToolStripMenuItem";
            this.disableAlphaChannelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableAlphaChannelToolStripMenuItem.Text = "Disable Alpha Channel";
            this.disableAlphaChannelToolStripMenuItem.Visible = false;
            this.disableAlphaChannelToolStripMenuItem.Click += new System.EventHandler(this.useAlphaChannelToolStripMenuItem_Click);
            // 
            // disableTransparencyToolStripMenuItem
            // 
            this.disableTransparencyToolStripMenuItem.Name = "disableTransparencyToolStripMenuItem";
            this.disableTransparencyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableTransparencyToolStripMenuItem.Text = "Disable Transparency";
            this.disableTransparencyToolStripMenuItem.Click += new System.EventHandler(this.disableTransparencyToolStripMenuItem_Click);
            // 
            // disableHelpersToolStripMenuItem
            // 
            this.disableHelpersToolStripMenuItem.Name = "disableHelpersToolStripMenuItem";
            this.disableHelpersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableHelpersToolStripMenuItem.Text = "Disable Helpers";
            this.disableHelpersToolStripMenuItem.Click += new System.EventHandler(this.disableHelpersToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(706, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(691, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // lblFrame
            // 
            this.lblFrame.Location = new System.Drawing.Point(304, 40);
            this.lblFrame.Name = "lblFrame";
            this.lblFrame.Size = new System.Drawing.Size(36, 13);
            this.lblFrame.TabIndex = 13;
            this.lblFrame.Text = "Frame";
            // 
            // lblAnimation
            // 
            this.lblAnimation.Location = new System.Drawing.Point(503, 40);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(56, 13);
            this.lblAnimation.TabIndex = 14;
            this.lblAnimation.Text = "Sequence";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbFramePosition
            // 
            this.tbFramePosition.AutoSize = false;
            this.tbFramePosition.LargeChange = 1;
            this.tbFramePosition.Location = new System.Drawing.Point(26, 285);
            this.tbFramePosition.Maximum = 40;
            this.tbFramePosition.Name = "tbFramePosition";
            this.tbFramePosition.Size = new System.Drawing.Size(256, 42);
            this.tbFramePosition.TabIndex = 16;
            this.tbFramePosition.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbFramePosition.ValueChanged += new System.EventHandler(this.tbFramePosition_ValueChanged);
            // 
            // txtFrameNo
            // 
            this.txtFrameNo.BackColor = System.Drawing.Color.Transparent;
            this.txtFrameNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrameNo.Location = new System.Drawing.Point(182, 30);
            this.txtFrameNo.Name = "txtFrameNo";
            this.txtFrameNo.Size = new System.Drawing.Size(100, 23);
            this.txtFrameNo.TabIndex = 18;
            this.txtFrameNo.Text = "001";
            this.txtFrameNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.CausesValidation = false;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(4, 1);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.udY1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.udY2, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.udX1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.udX2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(307, 285);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 57);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.CausesValidation = false;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(4, 29);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "V2";
            // 
            // udY1
            // 
            this.udY1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udY1.CausesValidation = false;
            this.udY1.Location = new System.Drawing.Point(117, 4);
            this.udY1.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.udY1.Name = "udY1";
            this.udY1.Size = new System.Drawing.Size(46, 20);
            this.udY1.TabIndex = 2;
            this.udY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udY1.ValueChanged += new System.EventHandler(this.udY1_ValueChanged);
            // 
            // udY2
            // 
            this.udY2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udY2.CausesValidation = false;
            this.udY2.Location = new System.Drawing.Point(117, 32);
            this.udY2.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.udY2.Name = "udY2";
            this.udY2.Size = new System.Drawing.Size(46, 20);
            this.udY2.TabIndex = 3;
            this.udY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udY2.ValueChanged += new System.EventHandler(this.udY2_ValueChanged);
            // 
            // udX1
            // 
            this.udX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udX1.CausesValidation = false;
            this.udX1.Location = new System.Drawing.Point(35, 4);
            this.udX1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udX1.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.udX1.Name = "udX1";
            this.udX1.Size = new System.Drawing.Size(44, 20);
            this.udX1.TabIndex = 1;
            this.udX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udX1.ValueChanged += new System.EventHandler(this.udX1_ValueChanged);
            // 
            // udX2
            // 
            this.udX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.udX2.CausesValidation = false;
            this.udX2.Location = new System.Drawing.Point(35, 32);
            this.udX2.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.udX2.Name = "udX2";
            this.udX2.Size = new System.Drawing.Size(44, 20);
            this.udX2.TabIndex = 4;
            this.udX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.udX2.ValueChanged += new System.EventHandler(this.udX2_ValueChanged);
            // 
            // label4
            // 
            this.label4.CausesValidation = false;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(4, 1);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label4.Size = new System.Drawing.Size(24, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "V1";
            // 
            // label5
            // 
            this.label5.CausesValidation = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(86, 1);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "H1";
            // 
            // label7
            // 
            this.label7.CausesValidation = false;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(86, 29);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.label7.Size = new System.Drawing.Size(24, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "H2";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(706, 370);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(tlpAnimation);
            this.Controls.Add(this.txtFrameNo);
            this.Controls.Add(tlpFrame);
            this.Controls.Add(this.tbFramePosition);
            this.Controls.Add(this.lblAnimation);
            this.Controls.Add(this.lblFrame);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnRunForward);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnRunReverse);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Flipbook";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            tlpFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udFrameOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFrameDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFrameOffsetY)).EndInit();
            tlpAnimation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udAnimationPositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAnimationDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udAnimationPositionY)).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFramePosition)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udX2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnRunReverse;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRunForward;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton ddbCharacter;
        private System.Windows.Forms.ToolStripDropDownButton ddbGroup;
        private System.Windows.Forms.ToolStripDropDownButton ddbID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSaveFrame;
        private System.Windows.Forms.ToolStripButton btnLoadBackground;
        private System.Windows.Forms.ToolStripButton btnGenerateSource;
        private System.Windows.Forms.ToolStripDropDownButton ddbFPS;
        private System.Windows.Forms.Label lblFrame;
        private System.Windows.Forms.Label lblAnimation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fpsToolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem fpsToolStripMenuItem30;
        private System.Windows.Forms.ToolStripMenuItem fpsToolStripMenuItem50;
        private System.Windows.Forms.ToolStripMenuItem fpsToolStripMenuItem60;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.TrackBar tbFramePosition;
        private System.Windows.Forms.Label lblFrameDelay;
        private System.Windows.Forms.Label lblFrameOffsetY;
        private System.Windows.Forms.Label lblFrameOffsetX;
        private System.Windows.Forms.NumericUpDown udFrameDelay;
        private System.Windows.Forms.NumericUpDown udFrameOffsetY;
        private System.Windows.Forms.NumericUpDown udFrameOffsetX;
        private System.Windows.Forms.Label lblFrameWidth;
        private System.Windows.Forms.Label txtFrameHeight;
        private System.Windows.Forms.Label txtFrameWidth;
        private System.Windows.Forms.Label lblFrameHeight;
        private System.Windows.Forms.Label txtFrameEffectiveY;
        private System.Windows.Forms.Label lblFrameEffectiveY;
        private System.Windows.Forms.Label txtFrameEffectiveX;
        private System.Windows.Forms.Label lblFrameEffectiveX;
        private System.Windows.Forms.Label lblFrameEffectiveDelay;
        private System.Windows.Forms.Label txtFrameEffectiveDelay;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem rolloverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableAlphaChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableTransparencyToolStripMenuItem;
        private System.Windows.Forms.Label txtFrameNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton ddbBackground;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemWhite;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemImage;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemBlack;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemRed;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemGreen;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemBlue;
        private System.Windows.Forms.Label txtAnimationFrames;
        private System.Windows.Forms.Label lblAnimationCount;
        private System.Windows.Forms.Label lblAnimationPositionX;
        private System.Windows.Forms.NumericUpDown udAnimationPositionX;
        private System.Windows.Forms.Label lblAnimationDelay;
        private System.Windows.Forms.Label lblAnimationPositionY;
        private System.Windows.Forms.NumericUpDown udAnimationDelay;
        private System.Windows.Forms.NumericUpDown udAnimationPositionY;
        private System.Windows.Forms.ToolStripButton btnZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown udX2;
        private System.Windows.Forms.NumericUpDown udY2;
        private System.Windows.Forms.NumericUpDown udX1;
        private System.Windows.Forms.NumericUpDown udY1;
        private System.Windows.Forms.ToolStripMenuItem disableHelpersToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveComposite;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItemAlpha;
    }
}

