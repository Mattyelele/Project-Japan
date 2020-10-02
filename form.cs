// Decompiled with JetBrains decompiler
// Type: Project_Japan.form
// Assembly: Project Japan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 12264953-4A90-48AA-834A-171C83DEF005
// Assembly location: C:\Users\tekzl\Desktop\Project Japan\Project Japan.exe

using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using PS3Lib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Project_Japan
{
  public class form : MetroForm
  {
    public static PS3API PS3 = new PS3API(SelectAPI.TargetManager);
    public static PS3API PS32 = new PS3API(SelectAPI.TargetManager);
    public static PS3API PS31 = new PS3API(SelectAPI.TargetManager);
    public static CCAPI CCAPI = new CCAPI();
    private IContainer components = (IContainer) null;
    public static string userName;
    public static string userClan;
    private MetroButton metroButton1;
    private MetroButton metroButton2;
    private MetroButton metroButton3;
    private MetroTabControl metroTabControl1;
    private MetroTabPage metroTabPage1;
    private MetroLabel Welcome;
    private MetroTabPage metroTabPage2;
    private MetroTextBox NC;
    private MetroButton metroButton4;
    private MetroButton ProjectJapan;
    private MetroButton metroButton7;
    private MetroButton metroButton6;
    private MetroButton WangX;
    private MetroTabPage metroTabPage3;
    private MetroTabPage metroTabPage4;
    private MetroButton metroButton5;
    private NumericUpDown s;
    private MetroLabel ConnectedWith;
    private MetroLabel metroLabel3;
    private MetroLabel cp;
    private MetroLabel metroLabel15;
    private MetroLabel metroLabel14;
    private MetroLabel metroLabel13;
    private MetroLabel metroLabel12;
    private MetroLabel metroLabel11;
    private MetroLabel metroLabel10;
    private MetroLabel metroLabel9;
    private MetroLabel metroLabel8;
    private MetroLabel metroLabel7;
    private MetroLabel metroLabel6;
    private MetroLabel metroLabel5;
    private MetroLabel metroLabel4;
    private MetroRadioButton metroRadioButton2;
    private MetroRadioButton metroRadioButton1;
    private MetroLabel metroLabel19;
    private MetroLabel metroLabel18;
    private MetroLabel metroLabel1;
    private MetroLabel metroLabel21;
    private MetroLabel metroLabel17;
    private MetroLabel metroLabel16;
    private MetroLabel metroLabel2;
    private MetroLabel cpu;
    private MetroButton metroButton9;
    private MetroButton metroButton8;
    private MetroTextBox cid;
    private MetroLabel cn;
    private MetroButton metroButton10;
    private MetroButton metroButton11;
    private Timer timer1;
    private MetroButton metroButton12;
    private MetroTextBox metroTextBox1;
    private MetroButton metroButton13;
    private MetroTabPage metroTabPage6;
    private MetroButton metroButton14;
    private MetroLabel metroLabel22;
    private MetroLabel metroLabel20;
    private MetroButton metroButton15;
    private MetroButton metroButton16;
    private MetroButton metroButton17;

    public form()
    {
      this.InitializeComponent();
    }

    private void toolbox_Move(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    private void metroButton1_Click(object sender, EventArgs e)
    {
      try
      {
        form.PS3.ConnectTarget(0);
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Successfully Connected To PS3");
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Thank you for using Project Japan!");
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "you are super cool and super nice!");
        string firmwareType = form.PS3.CCAPI.GetFirmwareType();
        string firmwareVersion = form.PS3.CCAPI.GetFirmwareVersion();
        string temperatureCell = form.PS3.CCAPI.GetTemperatureCELL();
        string temperatureRsx = form.PS3.CCAPI.GetTemperatureRSX();
        this.metroLabel21.Text = temperatureCell;
        this.metroLabel1.Text = temperatureRsx;
        this.metroLabel18.Text = firmwareVersion;
        this.metroLabel19.Text = firmwareType;
        this.Refresh();
      }
      catch
      {
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Connect");
      }
    }

    private void metroButton2_Click(object sender, EventArgs e)
    {
      try
      {
        form.PS3.AttachProcess();
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Successfully Attached To Project Japan!");
        this.Welcome.Text = "Welcome: " + form.PS3.Extension.ReadString(33157404U);
      }
      catch
      {
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Attach :/");
      }
    }

    private void metroButton3_Click(object sender, EventArgs e)
    {
      form.PS3.DisconnectTarget();
      int num = (int) MessageBox.Show("You Have Successfully Disconnect your PS3 Console.", "Successful.", MessageBoxButtons.OK);
      this.Welcome.Text = "Welcome: ";
    }

    private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
    {
      form.PS3.ChangeAPI(SelectAPI.TargetManager);
      this.ConnectedWith.Text = "Connected with: TMAPI";
    }

    private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
    {
      form.PS3.ChangeAPI(SelectAPI.ControlConsole);
      this.ConnectedWith.Text = "Connected with: CCAPI";
    }

    private void metroButton4_Click(object sender, EventArgs e)
    {
      byte[] bytes = Encoding.ASCII.GetBytes(this.NC.Text);
      Array.Resize<byte>(ref bytes, bytes.Length + 31);
      form.PS3.SetMemory(33157404U, bytes);
      form.PS3.SetMemory(33157404U, bytes);
      this.cn.Text = "Current name:                                          " + form.PS3.Extension.ReadString(33157404U);
    }

    private void metroButton5_Click(object sender, EventArgs e)
    {
      byte[] bytes = Encoding.ASCII.GetBytes(this.ProjectJapan.Text);
      Array.Resize<byte>(ref bytes, bytes.Length + 31);
      form.PS3.SetMemory(33157404U, bytes);
      form.PS3.SetMemory(33157404U, bytes);
      this.cn.Text = "Current name:                                          " + form.PS3.Extension.ReadString(33157404U);
    }

    private void metroButton5_Click_1(object sender, EventArgs e)
    {
      byte[] bytes = Encoding.ASCII.GetBytes(this.WangX.Text);
      Array.Resize<byte>(ref bytes, bytes.Length + 31);
      form.PS3.SetMemory(33157404U, bytes);
      form.PS3.SetMemory(33157404U, bytes);
      this.cn.Text = "Current name:                                          " + form.PS3.Extension.ReadString(33157404U);
    }

    private void metroButton6_Click(object sender, EventArgs e)
    {
      byte[] bytes = Encoding.ASCII.GetBytes(this.metroButton6.Text);
      Array.Resize<byte>(ref bytes, bytes.Length + 31);
      form.PS3.SetMemory(33157404U, bytes);
      form.PS3.SetMemory(33157404U, bytes);
      this.cn.Text = "Current name:                                          " + form.PS3.Extension.ReadString(33157404U);
    }

    private void metroButton7_Click(object sender, EventArgs e)
    {
      byte[] bytes = Encoding.ASCII.GetBytes(this.metroButton7.Text);
      Array.Resize<byte>(ref bytes, bytes.Length + 31);
      form.PS3.SetMemory(33157404U, bytes);
      form.PS3.SetMemory(33157404U, bytes);
      this.cn.Text = "Current name:                                          " + form.PS3.Extension.ReadString(33157404U);
    }

    private void metroButton5_Click_2(object sender, EventArgs e)
    {
    }

    private void metroLabel17_Click(object sender, EventArgs e)
    {
    }

    private void metroRadioButton1_CheckedChanged_1(object sender, EventArgs e)
    {
      form.PS3.ChangeAPI(SelectAPI.TargetManager);
      this.ConnectedWith.Text = "Connected with: TMAPI";
    }

    private void metroRadioButton2_CheckedChanged_1(object sender, EventArgs e)
    {
      form.PS3.ChangeAPI(SelectAPI.ControlConsole);
      this.ConnectedWith.Text = "Connected with: CCAPI";
    }

    private void metroButton8_Click(object sender, EventArgs e)
    {
      if (this.cid.Text.Length == 32)
      {
        form.PS3.CCAPI.SetConsoleID(this.cid.Text);
        int num = (int) MessageBox.Show("Successfully Changed ConsoleID ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num1 = (int) MessageBox.Show("ConsoleID Must Be 32 characters long to work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void metroButton9_Click(object sender, EventArgs e)
    {
      if (this.cid.Text.Length == 32)
      {
        form.PS3.CCAPI.SetBootConsoleID(this.cid.Text, CCAPI.IdType.IDPS);
        int num = (int) MessageBox.Show("Successfully Changed Boot ID ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        int num1 = (int) MessageBox.Show("Boot ID Must Be 32 characters long to work", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }

    private void metroButton10_Click(object sender, EventArgs e)
    {
    }

    private void metroButton11_Click(object sender, EventArgs e)
    {
      if (!this.metroButton11.Enabled)
        ;
      this.timer1.Start();
    }

    private void metroButton12_Click(object sender, EventArgs e)
    {
      if (this.metroButton12.Enabled)
        ;
      this.timer1.Stop();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      this.Name = this.NC.Text;
      int num = new Random().Next(0, 9);
      form.PS3.SetMemory(33157404U, Encoding.ASCII.GetBytes("^" + num.ToString() + this.Name + "\0"));
      form.PS3.SetMemory(33157404U, Encoding.ASCII.GetBytes("^" + num.ToString() + this.Name + "\0"));
      form.PS3.SetMemory(33157404U, Encoding.ASCII.GetBytes("^" + num.ToString() + this.Name + "\0"));
      form.PS3.SetMemory(33157404U, Encoding.ASCII.GetBytes("^" + num.ToString() + this.Name + "\0"));
    }

    private void metroButton13_Click(object sender, EventArgs e)
    {
      byte[] buffer = new byte[4]
      {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
      };
      form.PS3.SetMemory(21910569U, buffer);
    }

    private void metroButton14_Click(object sender, EventArgs e)
    {
      byte[] buffer = new byte[4]
      {
        (byte) 15,
        byte.MaxValue,
        (byte) 0,
        (byte) 0
      };
      form.PS3.SetMemory(21910569U, buffer);
    }

    private void metroButton16_Click(object sender, EventArgs e)
    {
      byte[] buffer1 = new byte[4]
      {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
      };
      form.PS3.SetMemory(21898460U, buffer1);
      byte[] buffer2 = new byte[4]
      {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
      };
      form.PS3.SetMemory(21898580U, buffer2);
      byte[] buffer3 = new byte[4]
      {
        (byte) 15,
        byte.MaxValue,
        byte.MaxValue,
        byte.MaxValue
      };
      form.PS3.SetMemory(21898580U, buffer3);
    }

    private void metroButton17_Click(object sender, EventArgs e)
    {
      try
      {
        form.PS3.ConnectTarget(0);
      }
      catch
      {
        form.PS3.CCAPI.Notify(CCAPI.NotifyIcon.INFO, "Failed To Connect");
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      this.metroButton1 = new MetroButton();
      this.metroButton2 = new MetroButton();
      this.metroButton3 = new MetroButton();
      this.metroTabControl1 = new MetroTabControl();
      this.metroTabPage1 = new MetroTabPage();
      this.metroButton9 = new MetroButton();
      this.metroButton8 = new MetroButton();
      this.cid = new MetroTextBox();
      this.metroLabel19 = new MetroLabel();
      this.metroLabel18 = new MetroLabel();
      this.metroLabel1 = new MetroLabel();
      this.metroLabel21 = new MetroLabel();
      this.metroLabel17 = new MetroLabel();
      this.metroLabel16 = new MetroLabel();
      this.metroLabel2 = new MetroLabel();
      this.cpu = new MetroLabel();
      this.metroRadioButton2 = new MetroRadioButton();
      this.metroRadioButton1 = new MetroRadioButton();
      this.metroLabel3 = new MetroLabel();
      this.ConnectedWith = new MetroLabel();
      this.Welcome = new MetroLabel();
      this.metroTabPage2 = new MetroTabPage();
      this.metroButton12 = new MetroButton();
      this.metroButton11 = new MetroButton();
      this.cn = new MetroLabel();
      this.metroButton7 = new MetroButton();
      this.metroButton6 = new MetroButton();
      this.WangX = new MetroButton();
      this.ProjectJapan = new MetroButton();
      this.NC = new MetroTextBox();
      this.metroButton4 = new MetroButton();
      this.metroTabPage4 = new MetroTabPage();
      this.metroTextBox1 = new MetroTextBox();
      this.metroButton10 = new MetroButton();
      this.metroLabel15 = new MetroLabel();
      this.metroLabel14 = new MetroLabel();
      this.metroLabel13 = new MetroLabel();
      this.metroLabel12 = new MetroLabel();
      this.metroLabel11 = new MetroLabel();
      this.metroLabel10 = new MetroLabel();
      this.metroLabel9 = new MetroLabel();
      this.metroLabel8 = new MetroLabel();
      this.metroLabel7 = new MetroLabel();
      this.metroLabel6 = new MetroLabel();
      this.metroLabel5 = new MetroLabel();
      this.metroLabel4 = new MetroLabel();
      this.cp = new MetroLabel();
      this.s = new NumericUpDown();
      this.metroButton5 = new MetroButton();
      this.metroTabPage3 = new MetroTabPage();
      this.timer1 = new Timer(this.components);
      this.metroButton13 = new MetroButton();
      this.metroTabPage6 = new MetroTabPage();
      this.metroButton14 = new MetroButton();
      this.metroButton15 = new MetroButton();
      this.metroButton16 = new MetroButton();
      this.metroLabel20 = new MetroLabel();
      this.metroLabel22 = new MetroLabel();
      this.metroButton17 = new MetroButton();
      this.metroTabControl1.SuspendLayout();
      this.metroTabPage1.SuspendLayout();
      this.metroTabPage2.SuspendLayout();
      this.metroTabPage4.SuspendLayout();
      this.s.BeginInit();
      this.metroTabPage6.SuspendLayout();
      this.SuspendLayout();
      this.metroButton1.Highlight = false;
      this.metroButton1.Location = new Point(223, 19);
      this.metroButton1.Name = "metroButton1";
      this.metroButton1.Size = new Size(214, 72);
      this.metroButton1.Style = MetroColorStyle.Blue;
      this.metroButton1.StyleManager = (MetroStyleManager) null;
      this.metroButton1.TabIndex = 0;
      this.metroButton1.Text = "Connect";
      this.metroButton1.Theme = MetroThemeStyle.Light;
      this.metroButton1.Click += new EventHandler(this.metroButton1_Click);
      this.metroButton2.Highlight = false;
      this.metroButton2.Location = new Point(223, 97);
      this.metroButton2.Name = "metroButton2";
      this.metroButton2.Size = new Size(105, 40);
      this.metroButton2.Style = MetroColorStyle.Blue;
      this.metroButton2.StyleManager = (MetroStyleManager) null;
      this.metroButton2.TabIndex = 1;
      this.metroButton2.Text = "Attach";
      this.metroButton2.Theme = MetroThemeStyle.Light;
      this.metroButton2.Click += new EventHandler(this.metroButton2_Click);
      this.metroButton3.Highlight = false;
      this.metroButton3.Location = new Point(334, 97);
      this.metroButton3.Name = "metroButton3";
      this.metroButton3.Size = new Size(103, 40);
      this.metroButton3.Style = MetroColorStyle.Blue;
      this.metroButton3.StyleManager = (MetroStyleManager) null;
      this.metroButton3.TabIndex = 2;
      this.metroButton3.Text = "Disconnect";
      this.metroButton3.Theme = MetroThemeStyle.Light;
      this.metroButton3.Click += new EventHandler(this.metroButton3_Click);
      this.metroTabControl1.Controls.Add((Control) this.metroTabPage1);
      this.metroTabControl1.Controls.Add((Control) this.metroTabPage2);
      this.metroTabControl1.Controls.Add((Control) this.metroTabPage4);
      this.metroTabControl1.Controls.Add((Control) this.metroTabPage3);
      this.metroTabControl1.Controls.Add((Control) this.metroTabPage6);
      this.metroTabControl1.CustomBackground = false;
      this.metroTabControl1.FontSize = MetroTabControlSize.Medium;
      this.metroTabControl1.FontWeight = MetroTabControlWeight.Light;
      this.metroTabControl1.Location = new Point(-1, 63);
      this.metroTabControl1.Name = "metroTabControl1";
      this.metroTabControl1.SelectedIndex = 0;
      this.metroTabControl1.Size = new Size(723, 387);
      this.metroTabControl1.Style = MetroColorStyle.Red;
      this.metroTabControl1.StyleManager = (MetroStyleManager) null;
      this.metroTabControl1.TabIndex = 3;
      this.metroTabControl1.TextAlign = ContentAlignment.MiddleLeft;
      this.metroTabControl1.Theme = MetroThemeStyle.Light;
      this.metroTabControl1.UseStyleColors = false;
      this.metroTabPage1.Controls.Add((Control) this.metroButton17);
      this.metroTabPage1.Controls.Add((Control) this.metroButton9);
      this.metroTabPage1.Controls.Add((Control) this.metroButton8);
      this.metroTabPage1.Controls.Add((Control) this.cid);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel19);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel18);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel1);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel21);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel17);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel16);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel2);
      this.metroTabPage1.Controls.Add((Control) this.cpu);
      this.metroTabPage1.Controls.Add((Control) this.metroRadioButton2);
      this.metroTabPage1.Controls.Add((Control) this.metroRadioButton1);
      this.metroTabPage1.Controls.Add((Control) this.metroLabel3);
      this.metroTabPage1.Controls.Add((Control) this.ConnectedWith);
      this.metroTabPage1.Controls.Add((Control) this.Welcome);
      this.metroTabPage1.Controls.Add((Control) this.metroButton3);
      this.metroTabPage1.Controls.Add((Control) this.metroButton2);
      this.metroTabPage1.Controls.Add((Control) this.metroButton1);
      this.metroTabPage1.CustomBackground = false;
      this.metroTabPage1.HorizontalScrollbar = false;
      this.metroTabPage1.HorizontalScrollbarBarColor = true;
      this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPage1.HorizontalScrollbarSize = 10;
      this.metroTabPage1.Location = new Point(4, 35);
      this.metroTabPage1.Name = "metroTabPage1";
      this.metroTabPage1.Size = new Size(715, 348);
      this.metroTabPage1.Style = MetroColorStyle.Blue;
      this.metroTabPage1.StyleManager = (MetroStyleManager) null;
      this.metroTabPage1.TabIndex = 0;
      this.metroTabPage1.Text = "Connection";
      this.metroTabPage1.Theme = MetroThemeStyle.Light;
      this.metroTabPage1.VerticalScrollbar = false;
      this.metroTabPage1.VerticalScrollbarBarColor = true;
      this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPage1.VerticalScrollbarSize = 10;
      this.metroButton9.Highlight = false;
      this.metroButton9.Location = new Point(332, 303);
      this.metroButton9.Name = "metroButton9";
      this.metroButton9.Size = new Size(105, 23);
      this.metroButton9.Style = MetroColorStyle.Blue;
      this.metroButton9.StyleManager = (MetroStyleManager) null;
      this.metroButton9.TabIndex = 27;
      this.metroButton9.Text = "Set Boot CID";
      this.metroButton9.Theme = MetroThemeStyle.Light;
      this.metroButton9.Click += new EventHandler(this.metroButton9_Click);
      this.metroButton8.Highlight = false;
      this.metroButton8.Location = new Point(223, 303);
      this.metroButton8.Name = "metroButton8";
      this.metroButton8.Size = new Size(105, 23);
      this.metroButton8.Style = MetroColorStyle.Blue;
      this.metroButton8.StyleManager = (MetroStyleManager) null;
      this.metroButton8.TabIndex = 26;
      this.metroButton8.Text = "Set CID";
      this.metroButton8.Theme = MetroThemeStyle.Light;
      this.metroButton8.Click += new EventHandler(this.metroButton8_Click);
      this.cid.CustomBackground = false;
      this.cid.CustomForeColor = false;
      this.cid.FontSize = MetroTextBoxSize.Small;
      this.cid.FontWeight = MetroTextBoxWeight.Regular;
      this.cid.Location = new Point(223, 267);
      this.cid.Multiline = false;
      this.cid.Name = "cid";
      this.cid.SelectedText = "";
      this.cid.Size = new Size(214, 23);
      this.cid.Style = MetroColorStyle.Blue;
      this.cid.StyleManager = (MetroStyleManager) null;
      this.cid.TabIndex = 25;
      this.cid.Theme = MetroThemeStyle.Light;
      this.cid.UseStyleColors = false;
      this.metroLabel19.AutoSize = true;
      this.metroLabel19.CustomBackground = false;
      this.metroLabel19.CustomForeColor = false;
      this.metroLabel19.FontSize = MetroLabelSize.Medium;
      this.metroLabel19.FontWeight = MetroLabelWeight.Light;
      this.metroLabel19.LabelMode = MetroLabelMode.Default;
      this.metroLabel19.Location = new Point(580, 266);
      this.metroLabel19.Name = "metroLabel19";
      this.metroLabel19.Size = new Size(117, 19);
      this.metroLabel19.Style = MetroColorStyle.Blue;
      this.metroLabel19.StyleManager = (MetroStyleManager) null;
      this.metroLabel19.TabIndex = 24;
      this.metroLabel19.Text = "Nothing to show :/";
      this.metroLabel19.Theme = MetroThemeStyle.Light;
      this.metroLabel19.UseStyleColors = false;
      this.metroLabel18.AutoSize = true;
      this.metroLabel18.CustomBackground = false;
      this.metroLabel18.CustomForeColor = false;
      this.metroLabel18.FontSize = MetroLabelSize.Medium;
      this.metroLabel18.FontWeight = MetroLabelWeight.Light;
      this.metroLabel18.LabelMode = MetroLabelMode.Default;
      this.metroLabel18.Location = new Point(580, 303);
      this.metroLabel18.Name = "metroLabel18";
      this.metroLabel18.Size = new Size(117, 19);
      this.metroLabel18.Style = MetroColorStyle.Blue;
      this.metroLabel18.StyleManager = (MetroStyleManager) null;
      this.metroLabel18.TabIndex = 23;
      this.metroLabel18.Text = "Nothing to show :/";
      this.metroLabel18.Theme = MetroThemeStyle.Light;
      this.metroLabel18.UseStyleColors = false;
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.CustomBackground = false;
      this.metroLabel1.CustomForeColor = false;
      this.metroLabel1.FontSize = MetroLabelSize.Medium;
      this.metroLabel1.FontWeight = MetroLabelWeight.Light;
      this.metroLabel1.LabelMode = MetroLabelMode.Default;
      this.metroLabel1.Location = new Point(61, 303);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new Size(117, 19);
      this.metroLabel1.Style = MetroColorStyle.Blue;
      this.metroLabel1.StyleManager = (MetroStyleManager) null;
      this.metroLabel1.TabIndex = 22;
      this.metroLabel1.Text = "Nothing to show :/";
      this.metroLabel1.Theme = MetroThemeStyle.Light;
      this.metroLabel1.UseStyleColors = false;
      this.metroLabel21.AutoSize = true;
      this.metroLabel21.CustomBackground = false;
      this.metroLabel21.CustomForeColor = false;
      this.metroLabel21.FontSize = MetroLabelSize.Medium;
      this.metroLabel21.FontWeight = MetroLabelWeight.Light;
      this.metroLabel21.LabelMode = MetroLabelMode.Default;
      this.metroLabel21.Location = new Point(61, 266);
      this.metroLabel21.Name = "metroLabel21";
      this.metroLabel21.Size = new Size(117, 19);
      this.metroLabel21.Style = MetroColorStyle.Blue;
      this.metroLabel21.StyleManager = (MetroStyleManager) null;
      this.metroLabel21.TabIndex = 21;
      this.metroLabel21.Text = "Nothing to show :/";
      this.metroLabel21.Theme = MetroThemeStyle.Light;
      this.metroLabel21.UseStyleColors = false;
      this.metroLabel17.AutoSize = true;
      this.metroLabel17.CustomBackground = false;
      this.metroLabel17.CustomForeColor = false;
      this.metroLabel17.FontSize = MetroLabelSize.Medium;
      this.metroLabel17.FontWeight = MetroLabelWeight.Light;
      this.metroLabel17.LabelMode = MetroLabelMode.Default;
      this.metroLabel17.Location = new Point(461, 303);
      this.metroLabel17.Name = "metroLabel17";
      this.metroLabel17.Size = new Size(113, 19);
      this.metroLabel17.Style = MetroColorStyle.Blue;
      this.metroLabel17.StyleManager = (MetroStyleManager) null;
      this.metroLabel17.TabIndex = 17;
      this.metroLabel17.Text = "Firmware Version:";
      this.metroLabel17.Theme = MetroThemeStyle.Light;
      this.metroLabel17.UseStyleColors = false;
      this.metroLabel17.Click += new EventHandler(this.metroLabel17_Click);
      this.metroLabel16.AutoSize = true;
      this.metroLabel16.CustomBackground = false;
      this.metroLabel16.CustomForeColor = false;
      this.metroLabel16.FontSize = MetroLabelSize.Medium;
      this.metroLabel16.FontWeight = MetroLabelWeight.Light;
      this.metroLabel16.LabelMode = MetroLabelMode.Default;
      this.metroLabel16.Location = new Point(476, 266);
      this.metroLabel16.Name = "metroLabel16";
      this.metroLabel16.Size = new Size(98, 19);
      this.metroLabel16.Style = MetroColorStyle.Blue;
      this.metroLabel16.StyleManager = (MetroStyleManager) null;
      this.metroLabel16.TabIndex = 16;
      this.metroLabel16.Text = "Firmware Type:";
      this.metroLabel16.Theme = MetroThemeStyle.Light;
      this.metroLabel16.UseStyleColors = false;
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.CustomBackground = false;
      this.metroLabel2.CustomForeColor = false;
      this.metroLabel2.FontSize = MetroLabelSize.Medium;
      this.metroLabel2.FontWeight = MetroLabelWeight.Light;
      this.metroLabel2.LabelMode = MetroLabelMode.Default;
      this.metroLabel2.Location = new Point(17, 303);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new Size(35, 19);
      this.metroLabel2.Style = MetroColorStyle.Blue;
      this.metroLabel2.StyleManager = (MetroStyleManager) null;
      this.metroLabel2.TabIndex = 15;
      this.metroLabel2.Text = "RSX:";
      this.metroLabel2.Theme = MetroThemeStyle.Light;
      this.metroLabel2.UseStyleColors = false;
      this.cpu.AutoSize = true;
      this.cpu.CustomBackground = false;
      this.cpu.CustomForeColor = false;
      this.cpu.FontSize = MetroLabelSize.Medium;
      this.cpu.FontWeight = MetroLabelWeight.Light;
      this.cpu.LabelMode = MetroLabelMode.Default;
      this.cpu.Location = new Point(17, 266);
      this.cpu.Name = "cpu";
      this.cpu.Size = new Size(38, 19);
      this.cpu.Style = MetroColorStyle.Blue;
      this.cpu.StyleManager = (MetroStyleManager) null;
      this.cpu.TabIndex = 14;
      this.cpu.Text = "CPU:";
      this.cpu.Theme = MetroThemeStyle.Light;
      this.cpu.UseStyleColors = false;
      this.metroRadioButton2.AutoSize = true;
      this.metroRadioButton2.CustomBackground = false;
      this.metroRadioButton2.CustomForeColor = false;
      this.metroRadioButton2.FontSize = MetroLinkSize.Small;
      this.metroRadioButton2.FontWeight = MetroLinkWeight.Regular;
      this.metroRadioButton2.Location = new Point(235, 143);
      this.metroRadioButton2.Name = "metroRadioButton2";
      this.metroRadioButton2.Size = new Size(57, 15);
      this.metroRadioButton2.Style = MetroColorStyle.Blue;
      this.metroRadioButton2.StyleManager = (MetroStyleManager) null;
      this.metroRadioButton2.TabIndex = 13;
      this.metroRadioButton2.TabStop = true;
      this.metroRadioButton2.Text = "CCAPI";
      this.metroRadioButton2.Theme = MetroThemeStyle.Light;
      this.metroRadioButton2.UseStyleColors = false;
      this.metroRadioButton2.UseVisualStyleBackColor = true;
      this.metroRadioButton2.CheckedChanged += new EventHandler(this.metroRadioButton2_CheckedChanged_1);
      this.metroRadioButton1.AutoSize = true;
      this.metroRadioButton1.CustomBackground = false;
      this.metroRadioButton1.CustomForeColor = false;
      this.metroRadioButton1.FontSize = MetroLinkSize.Small;
      this.metroRadioButton1.FontWeight = MetroLinkWeight.Regular;
      this.metroRadioButton1.Location = new Point(351, 143);
      this.metroRadioButton1.Name = "metroRadioButton1";
      this.metroRadioButton1.Size = new Size(59, 15);
      this.metroRadioButton1.Style = MetroColorStyle.Blue;
      this.metroRadioButton1.StyleManager = (MetroStyleManager) null;
      this.metroRadioButton1.TabIndex = 12;
      this.metroRadioButton1.TabStop = true;
      this.metroRadioButton1.Text = "TMAPI";
      this.metroRadioButton1.Theme = MetroThemeStyle.Light;
      this.metroRadioButton1.UseStyleColors = false;
      this.metroRadioButton1.UseVisualStyleBackColor = true;
      this.metroRadioButton1.CheckedChanged += new EventHandler(this.metroRadioButton1_CheckedChanged_1);
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.CustomBackground = false;
      this.metroLabel3.CustomForeColor = false;
      this.metroLabel3.FontSize = MetroLabelSize.Medium;
      this.metroLabel3.FontWeight = MetroLabelWeight.Light;
      this.metroLabel3.LabelMode = MetroLabelMode.Default;
      this.metroLabel3.Location = new Point(642, 303);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new Size(0, 0);
      this.metroLabel3.Style = MetroColorStyle.Blue;
      this.metroLabel3.StyleManager = (MetroStyleManager) null;
      this.metroLabel3.TabIndex = 11;
      this.metroLabel3.Theme = MetroThemeStyle.Light;
      this.metroLabel3.UseStyleColors = false;
      this.ConnectedWith.AutoSize = true;
      this.ConnectedWith.CustomBackground = false;
      this.ConnectedWith.CustomForeColor = false;
      this.ConnectedWith.FontSize = MetroLabelSize.Medium;
      this.ConnectedWith.FontWeight = MetroLabelWeight.Light;
      this.ConnectedWith.LabelMode = MetroLabelMode.Default;
      this.ConnectedWith.Location = new Point(3, 329);
      this.ConnectedWith.Name = "ConnectedWith";
      this.ConnectedWith.Size = new Size(186, 19);
      this.ConnectedWith.Style = MetroColorStyle.Blue;
      this.ConnectedWith.StyleManager = (MetroStyleManager) null;
      this.ConnectedWith.TabIndex = 10;
      this.ConnectedWith.Text = "Connected with:                     ";
      this.ConnectedWith.Theme = MetroThemeStyle.Light;
      this.ConnectedWith.UseStyleColors = false;
      this.Welcome.AutoSize = true;
      this.Welcome.CustomBackground = false;
      this.Welcome.CustomForeColor = false;
      this.Welcome.FontSize = MetroLabelSize.Medium;
      this.Welcome.FontWeight = MetroLabelWeight.Light;
      this.Welcome.LabelMode = MetroLabelMode.Default;
      this.Welcome.Location = new Point(537, 329);
      this.Welcome.Name = "Welcome";
      this.Welcome.Size = new Size(175, 19);
      this.Welcome.Style = MetroColorStyle.Blue;
      this.Welcome.StyleManager = (MetroStyleManager) null;
      this.Welcome.TabIndex = 3;
      this.Welcome.Text = "Welcome:                           ";
      this.Welcome.Theme = MetroThemeStyle.Light;
      this.Welcome.UseStyleColors = false;
      this.metroTabPage2.Controls.Add((Control) this.metroButton12);
      this.metroTabPage2.Controls.Add((Control) this.metroButton11);
      this.metroTabPage2.Controls.Add((Control) this.cn);
      this.metroTabPage2.Controls.Add((Control) this.metroButton7);
      this.metroTabPage2.Controls.Add((Control) this.metroButton6);
      this.metroTabPage2.Controls.Add((Control) this.WangX);
      this.metroTabPage2.Controls.Add((Control) this.ProjectJapan);
      this.metroTabPage2.Controls.Add((Control) this.NC);
      this.metroTabPage2.Controls.Add((Control) this.metroButton4);
      this.metroTabPage2.CustomBackground = false;
      this.metroTabPage2.HorizontalScrollbar = false;
      this.metroTabPage2.HorizontalScrollbarBarColor = true;
      this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPage2.HorizontalScrollbarSize = 10;
      this.metroTabPage2.Location = new Point(4, 35);
      this.metroTabPage2.Name = "metroTabPage2";
      this.metroTabPage2.Size = new Size(715, 348);
      this.metroTabPage2.Style = MetroColorStyle.Blue;
      this.metroTabPage2.StyleManager = (MetroStyleManager) null;
      this.metroTabPage2.TabIndex = 1;
      this.metroTabPage2.Text = "Name Changer";
      this.metroTabPage2.Theme = MetroThemeStyle.Light;
      this.metroTabPage2.VerticalScrollbar = false;
      this.metroTabPage2.VerticalScrollbarBarColor = true;
      this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPage2.VerticalScrollbarSize = 10;
      this.metroButton12.Highlight = false;
      this.metroButton12.Location = new Point(183, 62);
      this.metroButton12.Name = "metroButton12";
      this.metroButton12.Size = new Size(75, 23);
      this.metroButton12.Style = MetroColorStyle.Blue;
      this.metroButton12.StyleManager = (MetroStyleManager) null;
      this.metroButton12.TabIndex = 10;
      this.metroButton12.Text = "Stop";
      this.metroButton12.Theme = MetroThemeStyle.Light;
      this.metroButton12.Click += new EventHandler(this.metroButton12_Click);
      this.metroButton11.Highlight = false;
      this.metroButton11.Location = new Point(99, 62);
      this.metroButton11.Name = "metroButton11";
      this.metroButton11.Size = new Size(78, 23);
      this.metroButton11.Style = MetroColorStyle.Blue;
      this.metroButton11.StyleManager = (MetroStyleManager) null;
      this.metroButton11.TabIndex = 9;
      this.metroButton11.Text = "Flash";
      this.metroButton11.Theme = MetroThemeStyle.Light;
      this.metroButton11.Click += new EventHandler(this.metroButton11_Click);
      this.cn.AutoSize = true;
      this.cn.CustomBackground = false;
      this.cn.CustomForeColor = false;
      this.cn.FontSize = MetroLabelSize.Medium;
      this.cn.FontWeight = MetroLabelWeight.Light;
      this.cn.LabelMode = MetroLabelMode.Default;
      this.cn.Location = new Point(3, 329);
      this.cn.Name = "cn";
      this.cn.Size = new Size(573, 19);
      this.cn.Style = MetroColorStyle.Blue;
      this.cn.StyleManager = (MetroStyleManager) null;
      this.cn.TabIndex = 8;
      this.cn.Text = "Current name:                                                                                                                        ";
      this.cn.Theme = MetroThemeStyle.Light;
      this.cn.UseStyleColors = false;
      this.metroButton7.Highlight = false;
      this.metroButton7.Location = new Point(12, 225);
      this.metroButton7.Name = "metroButton7";
      this.metroButton7.Size = new Size(81, 23);
      this.metroButton7.Style = MetroColorStyle.Blue;
      this.metroButton7.StyleManager = (MetroStyleManager) null;
      this.metroButton7.TabIndex = 7;
      this.metroButton7.Text = "<3";
      this.metroButton7.Theme = MetroThemeStyle.Light;
      this.metroButton7.Click += new EventHandler(this.metroButton7_Click);
      this.metroButton6.Highlight = false;
      this.metroButton6.Location = new Point(12, 196);
      this.metroButton6.Name = "metroButton6";
      this.metroButton6.Size = new Size(81, 23);
      this.metroButton6.Style = MetroColorStyle.Blue;
      this.metroButton6.StyleManager = (MetroStyleManager) null;
      this.metroButton6.TabIndex = 6;
      this.metroButton6.Text = "ZeyyX- <3";
      this.metroButton6.Theme = MetroThemeStyle.Light;
      this.metroButton6.Click += new EventHandler(this.metroButton6_Click);
      this.WangX.Highlight = false;
      this.WangX.Location = new Point(12, 167);
      this.WangX.Name = "WangX";
      this.WangX.Size = new Size(81, 23);
      this.WangX.Style = MetroColorStyle.Blue;
      this.WangX.StyleManager = (MetroStyleManager) null;
      this.WangX.TabIndex = 5;
      this.WangX.Text = "WangX-- <3";
      this.WangX.Theme = MetroThemeStyle.Light;
      this.WangX.Click += new EventHandler(this.metroButton5_Click_1);
      this.ProjectJapan.Highlight = false;
      this.ProjectJapan.Location = new Point(12, 138);
      this.ProjectJapan.Name = "ProjectJapan";
      this.ProjectJapan.Size = new Size(81, 23);
      this.ProjectJapan.Style = MetroColorStyle.Blue;
      this.ProjectJapan.StyleManager = (MetroStyleManager) null;
      this.ProjectJapan.TabIndex = 4;
      this.ProjectJapan.Text = "Project Japan";
      this.ProjectJapan.Theme = MetroThemeStyle.Light;
      this.ProjectJapan.Click += new EventHandler(this.metroButton5_Click);
      this.NC.CustomBackground = false;
      this.NC.CustomForeColor = false;
      this.NC.FontSize = MetroTextBoxSize.Small;
      this.NC.FontWeight = MetroTextBoxWeight.Regular;
      this.NC.Location = new Point(18, 33);
      this.NC.Multiline = false;
      this.NC.Name = "NC";
      this.NC.SelectedText = "";
      this.NC.Size = new Size(240, 23);
      this.NC.Style = MetroColorStyle.Blue;
      this.NC.StyleManager = (MetroStyleManager) null;
      this.NC.TabIndex = 3;
      this.NC.Theme = MetroThemeStyle.Light;
      this.NC.UseStyleColors = false;
      this.metroButton4.Highlight = false;
      this.metroButton4.Location = new Point(18, 62);
      this.metroButton4.Name = "metroButton4";
      this.metroButton4.Size = new Size(75, 23);
      this.metroButton4.Style = MetroColorStyle.Blue;
      this.metroButton4.StyleManager = (MetroStyleManager) null;
      this.metroButton4.TabIndex = 2;
      this.metroButton4.Text = "Set";
      this.metroButton4.Theme = MetroThemeStyle.Light;
      this.metroButton4.Click += new EventHandler(this.metroButton4_Click);
      this.metroTabPage4.Controls.Add((Control) this.metroTextBox1);
      this.metroTabPage4.Controls.Add((Control) this.metroButton10);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel15);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel14);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel13);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel12);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel11);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel10);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel9);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel8);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel7);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel6);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel5);
      this.metroTabPage4.Controls.Add((Control) this.metroLabel4);
      this.metroTabPage4.Controls.Add((Control) this.cp);
      this.metroTabPage4.Controls.Add((Control) this.s);
      this.metroTabPage4.Controls.Add((Control) this.metroButton5);
      this.metroTabPage4.CustomBackground = false;
      this.metroTabPage4.HorizontalScrollbar = false;
      this.metroTabPage4.HorizontalScrollbarBarColor = true;
      this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPage4.HorizontalScrollbarSize = 10;
      this.metroTabPage4.Location = new Point(4, 35);
      this.metroTabPage4.Name = "metroTabPage4";
      this.metroTabPage4.Size = new Size(715, 348);
      this.metroTabPage4.Style = MetroColorStyle.Blue;
      this.metroTabPage4.StyleManager = (MetroStyleManager) null;
      this.metroTabPage4.TabIndex = 3;
      this.metroTabPage4.Text = "Account";
      this.metroTabPage4.Theme = MetroThemeStyle.Light;
      this.metroTabPage4.VerticalScrollbar = false;
      this.metroTabPage4.VerticalScrollbarBarColor = true;
      this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPage4.VerticalScrollbarSize = 10;
      this.metroTextBox1.CustomBackground = false;
      this.metroTextBox1.CustomForeColor = false;
      this.metroTextBox1.FontSize = MetroTextBoxSize.Small;
      this.metroTextBox1.FontWeight = MetroTextBoxWeight.Regular;
      this.metroTextBox1.Location = new Point(51, 136);
      this.metroTextBox1.Multiline = false;
      this.metroTextBox1.Name = "metroTextBox1";
      this.metroTextBox1.SelectedText = "";
      this.metroTextBox1.Size = new Size(119, 23);
      this.metroTextBox1.Style = MetroColorStyle.Blue;
      this.metroTextBox1.StyleManager = (MetroStyleManager) null;
      this.metroTextBox1.TabIndex = 18;
      this.metroTextBox1.Text = "metroTextBox1";
      this.metroTextBox1.Theme = MetroThemeStyle.Light;
      this.metroTextBox1.UseStyleColors = false;
      this.metroButton10.Highlight = false;
      this.metroButton10.Location = new Point(422, 221);
      this.metroButton10.Name = "metroButton10";
      this.metroButton10.Size = new Size(91, 23);
      this.metroButton10.Style = MetroColorStyle.Blue;
      this.metroButton10.StyleManager = (MetroStyleManager) null;
      this.metroButton10.TabIndex = 17;
      this.metroButton10.Text = "Refresh";
      this.metroButton10.Theme = MetroThemeStyle.Light;
      this.metroButton10.Click += new EventHandler(this.metroButton10_Click);
      this.metroLabel15.AutoSize = true;
      this.metroLabel15.CustomBackground = false;
      this.metroLabel15.CustomForeColor = false;
      this.metroLabel15.FontSize = MetroLabelSize.Medium;
      this.metroLabel15.FontWeight = MetroLabelWeight.Light;
      this.metroLabel15.LabelMode = MetroLabelMode.Default;
      this.metroLabel15.Location = new Point(601, 140);
      this.metroLabel15.Name = "metroLabel15";
      this.metroLabel15.Size = new Size(188, 19);
      this.metroLabel15.Style = MetroColorStyle.Blue;
      this.metroLabel15.StyleManager = (MetroStyleManager) null;
      this.metroLabel15.TabIndex = 16;
      this.metroLabel15.Text = "Time Played:                          ";
      this.metroLabel15.Theme = MetroThemeStyle.Light;
      this.metroLabel15.UseStyleColors = false;
      this.metroLabel14.AutoSize = true;
      this.metroLabel14.CustomBackground = false;
      this.metroLabel14.CustomForeColor = false;
      this.metroLabel14.FontSize = MetroLabelSize.Medium;
      this.metroLabel14.FontWeight = MetroLabelWeight.Light;
      this.metroLabel14.LabelMode = MetroLabelMode.Default;
      this.metroLabel14.Location = new Point(601, 103);
      this.metroLabel14.Name = "metroLabel14";
      this.metroLabel14.Size = new Size(155, 19);
      this.metroLabel14.Style = MetroColorStyle.Blue;
      this.metroLabel14.StyleManager = (MetroStyleManager) null;
      this.metroLabel14.TabIndex = 15;
      this.metroLabel14.Text = "Deaths:                          ";
      this.metroLabel14.Theme = MetroThemeStyle.Light;
      this.metroLabel14.UseStyleColors = false;
      this.metroLabel13.AutoSize = true;
      this.metroLabel13.CustomBackground = false;
      this.metroLabel13.CustomForeColor = false;
      this.metroLabel13.FontSize = MetroLabelSize.Medium;
      this.metroLabel13.FontWeight = MetroLabelWeight.Light;
      this.metroLabel13.LabelMode = MetroLabelMode.Default;
      this.metroLabel13.Location = new Point(433, 159);
      this.metroLabel13.Name = "metroLabel13";
      this.metroLabel13.Size = new Size(152, 19);
      this.metroLabel13.Style = MetroColorStyle.Blue;
      this.metroLabel13.StyleManager = (MetroStyleManager) null;
      this.metroLabel13.TabIndex = 14;
      this.metroLabel13.Text = "Streak:                          ";
      this.metroLabel13.Theme = MetroThemeStyle.Light;
      this.metroLabel13.UseStyleColors = false;
      this.metroLabel12.AutoSize = true;
      this.metroLabel12.CustomBackground = false;
      this.metroLabel12.CustomForeColor = false;
      this.metroLabel12.FontSize = MetroLabelSize.Medium;
      this.metroLabel12.FontWeight = MetroLabelWeight.Light;
      this.metroLabel12.LabelMode = MetroLabelMode.Default;
      this.metroLabel12.Location = new Point(601, 84);
      this.metroLabel12.Name = "metroLabel12";
      this.metroLabel12.Size = new Size(152, 19);
      this.metroLabel12.Style = MetroColorStyle.Blue;
      this.metroLabel12.StyleManager = (MetroStyleManager) null;
      this.metroLabel12.TabIndex = 13;
      this.metroLabel12.Text = "Assists:                          ";
      this.metroLabel12.Theme = MetroThemeStyle.Light;
      this.metroLabel12.UseStyleColors = false;
      this.metroLabel11.AutoSize = true;
      this.metroLabel11.CustomBackground = false;
      this.metroLabel11.CustomForeColor = false;
      this.metroLabel11.FontSize = MetroLabelSize.Medium;
      this.metroLabel11.FontWeight = MetroLabelWeight.Light;
      this.metroLabel11.LabelMode = MetroLabelMode.Default;
      this.metroLabel11.Location = new Point(433, 140);
      this.metroLabel11.Name = "metroLabel11";
      this.metroLabel11.Size = new Size(176, 19);
      this.metroLabel11.Style = MetroColorStyle.Blue;
      this.metroLabel11.StyleManager = (MetroStyleManager) null;
      this.metroLabel11.TabIndex = 12;
      this.metroLabel11.Text = "Headshots:                          ";
      this.metroLabel11.Theme = MetroThemeStyle.Light;
      this.metroLabel11.UseStyleColors = false;
      this.metroLabel10.AutoSize = true;
      this.metroLabel10.CustomBackground = false;
      this.metroLabel10.CustomForeColor = false;
      this.metroLabel10.FontSize = MetroLabelSize.Medium;
      this.metroLabel10.FontWeight = MetroLabelWeight.Light;
      this.metroLabel10.LabelMode = MetroLabelMode.Default;
      this.metroLabel10.Location = new Point(601, 122);
      this.metroLabel10.Name = "metroLabel10";
      this.metroLabel10.Size = new Size(137, 19);
      this.metroLabel10.Style = MetroColorStyle.Blue;
      this.metroLabel10.StyleManager = (MetroStyleManager) null;
      this.metroLabel10.TabIndex = 11;
      this.metroLabel10.Text = "Kills:                          ";
      this.metroLabel10.Theme = MetroThemeStyle.Light;
      this.metroLabel10.UseStyleColors = false;
      this.metroLabel9.AutoSize = true;
      this.metroLabel9.CustomBackground = false;
      this.metroLabel9.CustomForeColor = false;
      this.metroLabel9.FontSize = MetroLabelSize.Medium;
      this.metroLabel9.FontWeight = MetroLabelWeight.Light;
      this.metroLabel9.LabelMode = MetroLabelMode.Default;
      this.metroLabel9.Location = new Point(433, 121);
      this.metroLabel9.Name = "metroLabel9";
      this.metroLabel9.Size = new Size(179, 19);
      this.metroLabel9.Style = MetroColorStyle.Blue;
      this.metroLabel9.StyleManager = (MetroStyleManager) null;
      this.metroLabel9.TabIndex = 10;
      this.metroLabel9.Text = "Win Streak:                          ";
      this.metroLabel9.Theme = MetroThemeStyle.Light;
      this.metroLabel9.UseStyleColors = false;
      this.metroLabel8.AutoSize = true;
      this.metroLabel8.CustomBackground = false;
      this.metroLabel8.CustomForeColor = false;
      this.metroLabel8.FontSize = MetroLabelSize.Medium;
      this.metroLabel8.FontWeight = MetroLabelWeight.Light;
      this.metroLabel8.LabelMode = MetroLabelMode.Default;
      this.metroLabel8.Location = new Point(601, 65);
      this.metroLabel8.Name = "metroLabel8";
      this.metroLabel8.Size = new Size(138, 19);
      this.metroLabel8.Style = MetroColorStyle.Blue;
      this.metroLabel8.StyleManager = (MetroStyleManager) null;
      this.metroLabel8.TabIndex = 9;
      this.metroLabel8.Text = "Ties:                          ";
      this.metroLabel8.Theme = MetroThemeStyle.Light;
      this.metroLabel8.UseStyleColors = false;
      this.metroLabel7.AutoSize = true;
      this.metroLabel7.CustomBackground = false;
      this.metroLabel7.CustomForeColor = false;
      this.metroLabel7.FontSize = MetroLabelSize.Medium;
      this.metroLabel7.FontWeight = MetroLabelWeight.Light;
      this.metroLabel7.LabelMode = MetroLabelMode.Default;
      this.metroLabel7.Location = new Point(601, 45);
      this.metroLabel7.Name = "metroLabel7";
      this.metroLabel7.Size = new Size(152, 19);
      this.metroLabel7.Style = MetroColorStyle.Blue;
      this.metroLabel7.StyleManager = (MetroStyleManager) null;
      this.metroLabel7.TabIndex = 8;
      this.metroLabel7.Text = "Losses:                          ";
      this.metroLabel7.Theme = MetroThemeStyle.Light;
      this.metroLabel7.UseStyleColors = false;
      this.metroLabel6.AutoSize = true;
      this.metroLabel6.CustomBackground = false;
      this.metroLabel6.CustomForeColor = false;
      this.metroLabel6.FontSize = MetroLabelSize.Medium;
      this.metroLabel6.FontWeight = MetroLabelWeight.Light;
      this.metroLabel6.LabelMode = MetroLabelMode.Default;
      this.metroLabel6.Location = new Point(433, 102);
      this.metroLabel6.Name = "metroLabel6";
      this.metroLabel6.Size = new Size(144, 19);
      this.metroLabel6.Style = MetroColorStyle.Blue;
      this.metroLabel6.StyleManager = (MetroStyleManager) null;
      this.metroLabel6.TabIndex = 7;
      this.metroLabel6.Text = "Wins:                          ";
      this.metroLabel6.Theme = MetroThemeStyle.Light;
      this.metroLabel6.UseStyleColors = false;
      this.metroLabel5.AutoSize = true;
      this.metroLabel5.CustomBackground = false;
      this.metroLabel5.CustomForeColor = false;
      this.metroLabel5.FontSize = MetroLabelSize.Medium;
      this.metroLabel5.FontWeight = MetroLabelWeight.Light;
      this.metroLabel5.LabelMode = MetroLabelMode.Default;
      this.metroLabel5.Location = new Point(433, 83);
      this.metroLabel5.Name = "metroLabel5";
      this.metroLabel5.Size = new Size(149, 19);
      this.metroLabel5.Style = MetroColorStyle.Blue;
      this.metroLabel5.StyleManager = (MetroStyleManager) null;
      this.metroLabel5.TabIndex = 6;
      this.metroLabel5.Text = "Score:                          ";
      this.metroLabel5.Theme = MetroThemeStyle.Light;
      this.metroLabel5.UseStyleColors = false;
      this.metroLabel4.AutoSize = true;
      this.metroLabel4.CustomBackground = false;
      this.metroLabel4.CustomForeColor = false;
      this.metroLabel4.FontSize = MetroLabelSize.Medium;
      this.metroLabel4.FontWeight = MetroLabelWeight.Light;
      this.metroLabel4.LabelMode = MetroLabelMode.Default;
      this.metroLabel4.Location = new Point(422, 35);
      this.metroLabel4.Name = "metroLabel4";
      this.metroLabel4.Size = new Size(145, 19);
      this.metroLabel4.Style = MetroColorStyle.Blue;
      this.metroLabel4.StyleManager = (MetroStyleManager) null;
      this.metroLabel4.TabIndex = 5;
      this.metroLabel4.Text = "Level:                          ";
      this.metroLabel4.Theme = MetroThemeStyle.Light;
      this.metroLabel4.UseStyleColors = false;
      this.cp.AutoSize = true;
      this.cp.CustomBackground = false;
      this.cp.CustomForeColor = false;
      this.cp.FontSize = MetroLabelSize.Medium;
      this.cp.FontWeight = MetroLabelWeight.Light;
      this.cp.LabelMode = MetroLabelMode.Default;
      this.cp.Location = new Point(422, 64);
      this.cp.Name = "cp";
      this.cp.Size = new Size(163, 19);
      this.cp.Style = MetroColorStyle.Blue;
      this.cp.StyleManager = (MetroStyleManager) null;
      this.cp.TabIndex = 4;
      this.cp.Text = "Prestige:                          ";
      this.cp.Theme = MetroThemeStyle.Light;
      this.cp.UseStyleColors = false;
      this.s.Location = new Point(15, 35);
      this.s.Name = "s";
      this.s.Size = new Size(120, 20);
      this.s.TabIndex = 3;
      this.metroButton5.Highlight = false;
      this.metroButton5.Location = new Point(18, 61);
      this.metroButton5.Name = "metroButton5";
      this.metroButton5.Size = new Size(117, 23);
      this.metroButton5.Style = MetroColorStyle.Blue;
      this.metroButton5.StyleManager = (MetroStyleManager) null;
      this.metroButton5.TabIndex = 2;
      this.metroButton5.Text = "Set";
      this.metroButton5.Theme = MetroThemeStyle.Light;
      this.metroButton5.Click += new EventHandler(this.metroButton5_Click_2);
      this.metroTabPage3.CustomBackground = false;
      this.metroTabPage3.HorizontalScrollbar = false;
      this.metroTabPage3.HorizontalScrollbarBarColor = true;
      this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPage3.HorizontalScrollbarSize = 10;
      this.metroTabPage3.Location = new Point(4, 35);
      this.metroTabPage3.Name = "metroTabPage3";
      this.metroTabPage3.Size = new Size(715, 348);
      this.metroTabPage3.Style = MetroColorStyle.Blue;
      this.metroTabPage3.StyleManager = (MetroStyleManager) null;
      this.metroTabPage3.TabIndex = 2;
      this.metroTabPage3.Text = "Non-Host";
      this.metroTabPage3.Theme = MetroThemeStyle.Light;
      this.metroTabPage3.VerticalScrollbar = false;
      this.metroTabPage3.VerticalScrollbarBarColor = true;
      this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPage3.VerticalScrollbarSize = 10;
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.metroButton13.Highlight = false;
      this.metroButton13.Location = new Point(20, 37);
      this.metroButton13.Name = "metroButton13";
      this.metroButton13.Size = new Size(115, 23);
      this.metroButton13.Style = MetroColorStyle.Blue;
      this.metroButton13.StyleManager = (MetroStyleManager) null;
      this.metroButton13.TabIndex = 2;
      this.metroButton13.Text = "On";
      this.metroButton13.Theme = MetroThemeStyle.Light;
      this.metroButton13.Click += new EventHandler(this.metroButton13_Click);
      this.metroTabPage6.Controls.Add((Control) this.metroLabel22);
      this.metroTabPage6.Controls.Add((Control) this.metroLabel20);
      this.metroTabPage6.Controls.Add((Control) this.metroButton15);
      this.metroTabPage6.Controls.Add((Control) this.metroButton16);
      this.metroTabPage6.Controls.Add((Control) this.metroButton14);
      this.metroTabPage6.Controls.Add((Control) this.metroButton13);
      this.metroTabPage6.CustomBackground = false;
      this.metroTabPage6.HorizontalScrollbar = false;
      this.metroTabPage6.HorizontalScrollbarBarColor = true;
      this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
      this.metroTabPage6.HorizontalScrollbarSize = 10;
      this.metroTabPage6.Location = new Point(4, 35);
      this.metroTabPage6.Name = "metroTabPage6";
      this.metroTabPage6.Size = new Size(715, 348);
      this.metroTabPage6.Style = MetroColorStyle.Blue;
      this.metroTabPage6.StyleManager = (MetroStyleManager) null;
      this.metroTabPage6.TabIndex = 5;
      this.metroTabPage6.Text = "Host";
      this.metroTabPage6.Theme = MetroThemeStyle.Light;
      this.metroTabPage6.VerticalScrollbar = false;
      this.metroTabPage6.VerticalScrollbarBarColor = true;
      this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
      this.metroTabPage6.VerticalScrollbarSize = 10;
      this.metroButton14.Highlight = false;
      this.metroButton14.Location = new Point(141, 37);
      this.metroButton14.Name = "metroButton14";
      this.metroButton14.Size = new Size(115, 23);
      this.metroButton14.Style = MetroColorStyle.Blue;
      this.metroButton14.StyleManager = (MetroStyleManager) null;
      this.metroButton14.TabIndex = 3;
      this.metroButton14.Text = "Off";
      this.metroButton14.Theme = MetroThemeStyle.Light;
      this.metroButton14.Click += new EventHandler(this.metroButton14_Click);
      this.metroButton15.Highlight = false;
      this.metroButton15.Location = new Point(141, 101);
      this.metroButton15.Name = "metroButton15";
      this.metroButton15.Size = new Size(115, 23);
      this.metroButton15.Style = MetroColorStyle.Blue;
      this.metroButton15.StyleManager = (MetroStyleManager) null;
      this.metroButton15.TabIndex = 5;
      this.metroButton15.Text = "Off";
      this.metroButton15.Theme = MetroThemeStyle.Light;
      this.metroButton16.Highlight = false;
      this.metroButton16.Location = new Point(20, 101);
      this.metroButton16.Name = "metroButton16";
      this.metroButton16.Size = new Size(115, 23);
      this.metroButton16.Style = MetroColorStyle.Blue;
      this.metroButton16.StyleManager = (MetroStyleManager) null;
      this.metroButton16.TabIndex = 4;
      this.metroButton16.Text = "On";
      this.metroButton16.Theme = MetroThemeStyle.Light;
      this.metroButton16.Click += new EventHandler(this.metroButton16_Click);
      this.metroLabel20.AutoSize = true;
      this.metroLabel20.CustomBackground = false;
      this.metroLabel20.CustomForeColor = false;
      this.metroLabel20.FontSize = MetroLabelSize.Medium;
      this.metroLabel20.FontWeight = MetroLabelWeight.Light;
      this.metroLabel20.LabelMode = MetroLabelMode.Default;
      this.metroLabel20.Location = new Point(95, 15);
      this.metroLabel20.Name = "metroLabel20";
      this.metroLabel20.Size = new Size(73, 19);
      this.metroLabel20.Style = MetroColorStyle.Blue;
      this.metroLabel20.StyleManager = (MetroStyleManager) null;
      this.metroLabel20.TabIndex = 6;
      this.metroLabel20.Text = "God Mode";
      this.metroLabel20.Theme = MetroThemeStyle.Light;
      this.metroLabel20.UseStyleColors = false;
      this.metroLabel22.AutoSize = true;
      this.metroLabel22.CustomBackground = false;
      this.metroLabel22.CustomForeColor = false;
      this.metroLabel22.FontSize = MetroLabelSize.Medium;
      this.metroLabel22.FontWeight = MetroLabelWeight.Light;
      this.metroLabel22.LabelMode = MetroLabelMode.Default;
      this.metroLabel22.Location = new Point(86, 79);
      this.metroLabel22.Name = "metroLabel22";
      this.metroLabel22.Size = new Size(91, 19);
      this.metroLabel22.Style = MetroColorStyle.Blue;
      this.metroLabel22.StyleManager = (MetroStyleManager) null;
      this.metroLabel22.TabIndex = 7;
      this.metroLabel22.Text = "Infinity Ammo";
      this.metroLabel22.Theme = MetroThemeStyle.Light;
      this.metroLabel22.UseStyleColors = false;
      this.metroButton17.Highlight = false;
      this.metroButton17.Location = new Point(443, 19);
      this.metroButton17.Name = "metroButton17";
      this.metroButton17.Size = new Size(30, 118);
      this.metroButton17.Style = MetroColorStyle.Blue;
      this.metroButton17.StyleManager = (MetroStyleManager) null;
      this.metroButton17.TabIndex = 28;
      this.metroButton17.Text = ";)";
      this.metroButton17.Theme = MetroThemeStyle.Light;
      this.metroButton17.Click += new EventHandler(this.metroButton17_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(723, 451);
      this.Controls.Add((Control) this.metroTabControl1);
      this.Location = new Point(0, 0);
      this.MaximizeBox = false;
      this.Name = nameof (form);
      this.Resizable = false;
      this.Style = MetroColorStyle.Red;
      this.Text = "Project Japan";
      this.Load += new EventHandler(this.Form1_Load);
      this.metroTabControl1.ResumeLayout(false);
      this.metroTabPage1.ResumeLayout(false);
      this.metroTabPage1.PerformLayout();
      this.metroTabPage2.ResumeLayout(false);
      this.metroTabPage2.PerformLayout();
      this.metroTabPage4.ResumeLayout(false);
      this.metroTabPage4.PerformLayout();
      this.s.EndInit();
      this.metroTabPage6.ResumeLayout(false);
      this.metroTabPage6.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
