using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CandleNew.Classes;
using CandleNew.Forms;
using FontAwesome.Sharp;
using Newtonsoft.Json;

namespace CandleNew
{
    public partial class Form1 : Form
    {
        //Fields
        private readonly StainlessForm stainless = new StainlessForm();
        private readonly MetalForm metal = new MetalForm();
        private readonly WoodForm wood = new WoodForm();
        private readonly TubeForm tube = new TubeForm();
        private readonly MaketCalculating maketCalculating = new MaketCalculating();
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
        //Constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
/*            this.Text = string.Empty;*/
            /*            this.ControlBox = false;*/
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Dollar dollar = new Dollar();
            Console.WriteLine(dollar.ReturnDollar());

            Console.WriteLine("\n\n\n\n\n");

        }
        //Structs
        private struct RgBcolors
        {
            public static readonly Color Color1 = Color.FromArgb(172, 126, 241);
            public static readonly Color Color2 = Color.FromArgb(249, 118, 176);
            public static readonly Color Color3 = Color.FromArgb(253, 138, 114);
            public static readonly Color Color4 = Color.FromArgb(95, 77, 221);
            public static readonly Color Color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //IconCharForm
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            currentChildForm?.Hide();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender,RgBcolors.Color1);
            lblTitleChildForm.Text = "Труба";
            OpenChildForm(tube);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.Color2);
            lblTitleChildForm.Text = "Метал";
            OpenChildForm(metal);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.Color3);
            lblTitleChildForm.Text = "Дерево";
            OpenChildForm(wood);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.Color4);
            lblTitleChildForm.Text = "Нержавійка";
            OpenChildForm(stainless);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Hide();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.color6);
            lblTitleChildForm.Text = "Макетний прорахунок";
            OpenChildForm(maketCalculating);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RgBcolors.Color5);
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"
            };
            // image filters  
            if (open.ShowDialog() == DialogResult.OK)
            {

                var photoViewer = new Process();
                var pass = open.FileName;
                photoViewer.StartInfo.FileName = pass;
                photoViewer.Start();

            }
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
