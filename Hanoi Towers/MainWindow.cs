using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hanoi_Towers
{
    public partial class MainWindow : Form
    {
        #region Properties
        // Stack for towers
        static Stack<int> firstTower = new Stack<int>();
        static Stack<int> secondTower = new Stack<int>();
        static Stack<int> thirdTower = new Stack<int>();
        PictureBox[] TowerBlins = new PictureBox[8];
        // Weight disk on top of the tower
        static int FrontOne = 1;
        static int FrontTwo = 10;
        static int FrontThree = 10;
        int SizeGame = 8; // Number of disks
        int NumRows = 1; // Number of row for write step
        // Start position for disks
        static int StartPos;
        static int StartPosX;
        static int StartPosY;

        bool isEnglish = true; // Language App

        string FirstWord = "Move ";
        string LastWord = " to ";

        bool isAutoCalculte = false;
        public static MainWindow Instance { get; private set; }

        Queue<int> numblin = new Queue<int>();
        Queue<Point> pointblin = new Queue<Point>();
        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            InitializeBlins();
            StartGame();
        }
        #endregion

        #region UI setter functions
        // Write disk img in mass
        void InitializeBlins()
        {
            TowerBlins[0] = pictureBox8;
            TowerBlins[1] = pictureBox7;
            TowerBlins[2] = pictureBox6;
            TowerBlins[3] = pictureBox5;
            TowerBlins[4] = pictureBox4;
            TowerBlins[5] = pictureBox3;
            TowerBlins[6] = pictureBox2;
            TowerBlins[7] = pictureBox1;
        }

        // Start settings and attributes
        void StartGame()
        {
            // Hide disk
            pictureBox12.Visible = false;
            pictureBox8.Visible = false;
            pictureBox7.Visible = false;
            pictureBox6.Visible = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            SizeGame = GameSize.Value;
            // Required disks showing
            if (SizeGame > 0)
                pictureBox8.Visible = true;
            if (SizeGame > 1)
                pictureBox7.Visible = true;
            if (SizeGame > 2)
                pictureBox6.Visible = true;
            if (SizeGame > 3)
                pictureBox5.Visible = true;
            if (SizeGame > 4)
                pictureBox4.Visible = true;
            if (SizeGame > 5)
                pictureBox3.Visible = true;
            if (SizeGame > 6)
                pictureBox2.Visible = true;
            if (SizeGame > 7)
                pictureBox1.Visible = true;
            // Start position disks
            for (int i = 0, j = SizeGame - 1; i < SizeGame; i++)
            {
                int X = 15 * (i + 9 - SizeGame);
                int Y = 380 - 40 * (i + 1);
                Point Pos = new Point(X, Y);
                TowerBlins[j].Location = Pos;
                j--;
            }
            InitializeValue();
            CheckControl(); // Get control for mouse
        }

        // Reset variables
        public void InitializeValue()
        {
            this.Controls.SetChildIndex(pictureBox9, 1000);
            this.Controls.SetChildIndex(pictureBox10, 1100);
            this.Controls.SetChildIndex(pictureBox11, 1200);
            this.Controls.SetChildIndex(pictureBox12, 1300);
            dataGridView1.Rows.Clear();
            NumRows = 1;
            firstTower.Clear();
            secondTower.Clear();
            thirdTower.Clear();
            firstTower.Push(10);
            secondTower.Push(10);
            thirdTower.Push(10);
            FrontOne = 1;
            FrontTwo = 10;
            FrontThree = 10;
            for (int i = 8; i > 0; i--)
                if (SizeGame >= i)
                    firstTower.Push(i);
        }
        #endregion

        #region Tower calculations
        /// <summary>
        /// Calculator for Tower movements
        /// </summary>
        /// <param name="number">the number of disks</param>
        /// <param name="from">the initialize tower</param>
        /// <param name="to">the destination tower</param>
        /// <param name="free">the free tower(helper tower)</param>
        void Towers(int number, int from, int to, int free)
        {
            if (number == 0)
                return;
            Towers(number - 1, from, free, to);
            int x;
            if (to == 1)
                x = 100;
            else if (to == 2)
                x = 500;
            else
                x = 900;
            StartPos = from;
            StartPosX = TowerBlins[number - 1].Location.X;
            StartPosY = TowerBlins[number - 1].Location.Y;
            int num = Convert.ToInt32(TowerBlins[number - 1].Tag.ToString());
            numblin.Enqueue(number - 1);
            pointblin.Enqueue(ControlMover.GetPos(x, num));

            Towers(number - 1, free, to, from);
        }
        #endregion

        #region Initialization function for Auto calculate
        void CalCulteTowers()
        {
            StartGame();
            ControlMover.RemoveEvents(pictureBox1);
            ControlMover.RemoveEvents(pictureBox2);
            ControlMover.RemoveEvents(pictureBox3);
            ControlMover.RemoveEvents(pictureBox4);
            ControlMover.RemoveEvents(pictureBox5);
            ControlMover.RemoveEvents(pictureBox6);
            ControlMover.RemoveEvents(pictureBox7);
            ControlMover.RemoveEvents(pictureBox8);
            Towers(GameSize.Value, 1, 3, 2);
        }
        #endregion

        // Writing steps in app
        void AddRow(int from, int to)
        {
            dataGridView1.Rows.Add(NumRows++, FirstWord + from.ToString() + LastWord + to.ToString());
        }

        #region Check values control
        // Check disks to give initial value to auto calculate for control
        public void CheckControl()
        {
            ControlMover.RemoveEvents(pictureBox1);
            ControlMover.RemoveEvents(pictureBox2);
            ControlMover.RemoveEvents(pictureBox3);
            ControlMover.RemoveEvents(pictureBox4);
            ControlMover.RemoveEvents(pictureBox5);
            ControlMover.RemoveEvents(pictureBox6);
            ControlMover.RemoveEvents(pictureBox7);
            ControlMover.RemoveEvents(pictureBox8);
            FrontOne = FrontOneBlin();
            FrontTwo = FrontTwoBlin();
            FrontThree = FrontThreeBlin();

            if (FrontOne == 10 && FrontTwo == 10)
            {
                if (isEnglish)
                    MessageBox.Show("You won!");
                else
                    MessageBox.Show("بابا باریکلا!");
                pictureBox12.Image = Properties.Resources.victory;
                pictureBox12.Visible = true;
            }
            // Possible disks for control
            if (FrontOne == 1 || FrontTwo == 1 || FrontThree == 1)
                ControlMover.AddEvents(pictureBox8);
            if (FrontOne == 2 || FrontTwo == 2 || FrontThree == 2)
                ControlMover.AddEvents(pictureBox7);
            if (FrontOne == 3 || FrontTwo == 3 || FrontThree == 3)
                ControlMover.AddEvents(pictureBox6);
            if (FrontOne == 4 || FrontTwo == 4 || FrontThree == 4)
                ControlMover.AddEvents(pictureBox5);
            if (FrontOne == 5 || FrontTwo == 5 || FrontThree == 5)
                ControlMover.AddEvents(pictureBox4);
            if (FrontOne == 6 || FrontTwo == 6 || FrontThree == 6)
                ControlMover.AddEvents(pictureBox3);
            if (FrontOne == 7 || FrontTwo == 7 || FrontThree == 7)
                ControlMover.AddEvents(pictureBox2);
            if (FrontOne == 8 || FrontTwo == 8 || FrontThree == 8)
                ControlMover.AddEvents(pictureBox1);
        }

        // The weight of the front disk | The left tower
        static int FrontOneBlin()
        {
            if (firstTower.Count() == 0)
                return 10;
            int num = firstTower.Pop();
            firstTower.Push(num);
            return num;
        }

        // The weight of the front disk | The center tower
        static int FrontTwoBlin()
        {
            if (secondTower.Count() == 0)
                return 10;
            int num = secondTower.Pop();
            secondTower.Push(num);
            return num;
        }

        // The weight of the front disk | The right tower
        static int FrontThreeBlin()
        {
            if (thirdTower.Count() == 0)
                return 10;
            int num = thirdTower.Pop();
            thirdTower.Push(num);
            return num;
        }
        #endregion

        #region Events
        // Control obj class (mouse)
        public static class ControlMover
        {
            public static bool ChangeCursor { get; set; }
            public static bool AllowMove { get; set; }
            public static bool AllowResize { get; set; }
            public static bool BringToFront { get; set; }
            public static int ResizingMargin { get; set; }
            public static int MinSize { get; set; }

            private static Point startMouse;
            private static Point startLocation;
            private static Size startSize;
            private static bool resizing = false;
            static Cursor oldCursor;

            static ControlMover()
            {
                ResizingMargin = 5;
                MinSize = 10;
                ChangeCursor = false;
                AllowMove = true;
                AllowResize = true;
                BringToFront = true;
            }

            // Add control possibility for obj
            public static void AddEvents(Control ctrl)
            {
                ctrl.MouseDown += ctrl_MouseDown;
                ctrl.MouseUp += ctrl_MouseUp;
                ctrl.MouseMove += ctrl_MouseMove;
            }

            // Remove control possibility for obj
            public static void RemoveEvents(Control ctrl)
            {
                ctrl.MouseDown -= ctrl_MouseDown;
                ctrl.MouseUp -= ctrl_MouseUp;
                ctrl.MouseMove -= ctrl_MouseMove;
            }

            // Method mouseUp
            private static void ctrl_MouseUp(object sender, MouseEventArgs e)
            {
                if (e.Button != MouseButtons.Left)
                    return;
                var ctrl = (sender as Control);
                ctrl.Cursor = oldCursor;
                int num = Convert.ToInt32(ctrl.Tag.ToString());
                ctrl.Location = GetPos(ctrl.Location.X, num);
            }

            // Method move mouse
            static void ctrl_MouseMove(object sender, MouseEventArgs e)
            {
                var ctrl = sender as Control;
                if (ChangeCursor)
                {
                    if ((e.X >= ctrl.Width - ResizingMargin) && (e.Y >= ctrl.Height - ResizingMargin) && AllowResize)
                        ctrl.Cursor = Cursors.SizeNWSE;
                    else
                    if (AllowMove)
                        ctrl.Cursor = Cursors.SizeAll;
                    else
                        ctrl.Cursor = Cursors.Default;
                }

                if (e.Button != MouseButtons.Left)
                    return;

                var l = ctrl.PointToScreen(e.Location);
                var dx = l.X - startMouse.X;
                var dy = l.Y - startMouse.Y;

                if (Math.Max(Math.Abs(dx), Math.Abs(dy)) > 1)
                {
                    if (resizing)
                    {
                        if (AllowResize)
                        {
                            ctrl.Size = new Size(Math.Max(MinSize, startSize.Width + dx), Math.Max(MinSize, startSize.Height + dy));
                            ctrl.Cursor = Cursors.SizeNWSE;
                            if (BringToFront) ctrl.BringToFront();
                        }
                    }
                    else
                    {
                        if (AllowMove)
                        {
                            Point newLoc = startLocation + new Size(dx, dy);
                            if (newLoc.X < 0) newLoc = new Point(0, newLoc.Y);
                            if (newLoc.Y < 0) newLoc = new Point(newLoc.X, 0);
                            ctrl.Location = newLoc;
                            ctrl.Cursor = Cursors.SizeAll;
                            if (BringToFront) ctrl.BringToFront();
                        }
                    }
                }
            }

            // Method Mouse down
            static void ctrl_MouseDown(object sender, MouseEventArgs e)
            {
                if (e.Button != MouseButtons.Left)
                    return;
                var ctrl = sender as Control;

                if (ctrl.Location.X < 333) // Save number of tower
                    StartPos = 1; // The left tower
                else if (ctrl.Location.X > 666)
                    StartPos = 3; // Right tower
                else
                    StartPos = 2; // Center tower
                StartPosX = ctrl.Location.X;
                StartPosY = ctrl.Location.Y;
                resizing = (e.X >= ctrl.Width - ResizingMargin) && (e.Y >= ctrl.Height - ResizingMargin) && AllowResize;
                startSize = ctrl.Size;
                startMouse = ctrl.PointToScreen(e.Location);
                startLocation = ctrl.Location;
                oldCursor = ctrl.Cursor;
            }

            // Check correct selection of the tower for the disk
            static bool CheckMove(int num, int Num_Blin)
            {
                if (num == 1)
                {
                    if (Num_Blin > FrontOne || num == StartPos)
                        return false;
                }
                else if (num == 2)
                {
                    if (Num_Blin > FrontTwo || num == StartPos)
                        return false;
                }
                else
                {
                    if (Num_Blin > FrontThree || num == StartPos)
                        return false;
                }
                return true;
            }

            // Set coordinets for disk (MouseUP event)
            // Check correct move position (return start position)
            public static Point GetPos(int x, int Num_Blin)
            {

                Point Pos = new Point(); // Position obj

                bool check = true; // Can set select of tower

                if (x < 333) // MouseUp on left tower
                {
                    check = CheckMove(1, Num_Blin); // Is it possible to place it here
                    Pos.X = 15 * (9 - Num_Blin); // Calculating position X
                    Pos.Y = 380 - 40 * firstTower.Count(); // Calculating position Y
                    if (check || MainWindow.Instance.isAutoCalculte)
                    // If is correct selected tower then to change values
                    {
                        MainWindow.Instance.AddRow(StartPos, 1); // Save step
                        firstTower.Push(Num_Blin); // Add weight disk
                        if (StartPos == 2) // Remove weight disk front tower
                            secondTower.Pop();
                        else if (StartPos == 3)
                            thirdTower.Pop();
                    }
                }
                else if (x > 666) // MouseUp on right tower
                {
                    check = CheckMove(3, Num_Blin);
                    Pos.X = 665 + 15 * (9 - Num_Blin);
                    Pos.Y = 380 - 40 * thirdTower.Count();
                    if (check || MainWindow.Instance.isAutoCalculte)
                    {
                        MainWindow.Instance.AddRow(StartPos, 3);
                        thirdTower.Push(Num_Blin);
                        if (StartPos == 1)
                            firstTower.Pop();
                        else if (StartPos == 2)
                            secondTower.Pop();
                    }
                }
                else // MouseUp on center tower
                {
                    check = CheckMove(2, Num_Blin);
                    Pos.X = 335 + 15 * (9 - Num_Blin);
                    Pos.Y = 380 - 40 * secondTower.Count();
                    if (check || MainWindow.Instance.isAutoCalculte)
                    {
                        MainWindow.Instance.AddRow(StartPos, 2);
                        secondTower.Push(Num_Blin);
                        if (StartPos == 1)
                            firstTower.Pop();
                        else if (StartPos == 3)
                            thirdTower.Pop();
                    }
                }
                if (!check && !MainWindow.Instance.isAutoCalculte) // Return disk on start position
                {
                    Pos.X = StartPosX;
                    Pos.Y = StartPosY;
                }
                if (!MainWindow.Instance.isAutoCalculte) // Change control for disks
                    MainWindow.Instance.CheckControl();
                return Pos;
            }
        }

        private void GameSizeBar_Scroll(object sender, EventArgs e)
        {
            if (isEnglish)
                GameSizelbl.Text = "Game Size: " + GameSize.Value.ToString();
            else
                GameSizelbl.Text = "تعداد دیسک: " + GameSize.Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            TowerBlins[numblin.Dequeue()].Location = pointblin.Dequeue();
            if (!(numblin.Count > 0))
            {
                pictureBox12.Visible = false;
                timer2.Enabled = false;
            }
        }

        // Start game (Player Mode)
        private void PlayerModebtn_Click(object sender, EventArgs e)
        {
            isAutoCalculte = false;
            StartGame();
        }

        // Translate Per/Eng
        private void ChangeLanguagebtn_Click(object sender, EventArgs e)
        {
            isEnglish = !isEnglish;
            if (isEnglish)
            {
                Calculatebtn.Text = "Calculate";
                StartGamebtn.Text = "Start New Game";
                FirstWord = "Move ";
                LastWord = " to ";
                GameSizelbl.Text = "Game Size: " + GameSize.Value.ToString();
                GameSizelbl.Font = new Font(GameSizelbl.Font.Name, 14, GameSizelbl.Font.Style);
                Translatebtn.Image = Properties.Resources.english_flag;
            }
            else
            {
                Calculatebtn.Text = "حساب کن";
                StartGamebtn.Text = "بازی جدید";
                FirstWord = " از  ";
                LastWord = " به  ";
                GameSizelbl.Text = "تعداد دیسک: " + GameSize.Value.ToString();
                GameSizelbl.Font = new Font(GameSizelbl.Font.Name, 11, GameSizelbl.Font.Style);
                Translatebtn.Image = Properties.Resources.Persian_flag;

            }
        }

        private void AutoCalculatebtn_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            isAutoCalculte = true;
            CalCulteTowers();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        #endregion
    }
}
