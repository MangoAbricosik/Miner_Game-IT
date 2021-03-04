using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miner_Game_IT
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    Random rand = new Random();
    Button[] bt = new Button[25];
    int[] bombs = new int[25];
    private void button1_Click(object sender, EventArgs e)
    {
      button1.Hide();

      Random();
    }
    public void Start(int ValueB)
    {
      if (VinOrDefeat(ValueB))
        return;

      bt[ValueB ].Text = Proverka(ValueB);
    } 
    public void Random()
    {
      for (int i = 0; i < 5; i++)
      {
        bombs[rand.Next(0, 24)] = 1;
      }
    }
    public string Proverka(int ValueB)
    {
      int cout = 0;

      try
      {
                                   if (bombs[ValueB - 5] == 1) cout++;
        if (bombs[ValueB - 1] == 1)                                  cout++; if (bombs[ValueB + 1] == 1) cout++;
                                   if (bombs[ValueB + 5] == 1) cout++;
      }
      catch (Exception) { }

      return cout.ToString();
    }
    public bool VinOrDefeat(int ValueB)
    {
      if (bombs[ValueB] == 1)
      {
        foreach (var item in bt)
        {
          item.Text = "Бомба!";
          item.Enabled = false;
        }
        return true;
      }
      else return false;      
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      bt[0]  = button2;   bt[1]  = button3;   bt[2]  = button4;   bt[3]  = button5;   bt[4]  = button6;
      bt[5]  = button7;   bt[6]  = button8;   bt[7]  = button9;   bt[8]  = button10;   bt[9]  = button11;
      bt[10] = button12;  bt[11] = button13;  bt[12] = button14;  bt[13] = button15;  bt[14] = button16;
      bt[15] = button17;  bt[16] = button18;  bt[17] = button19;  bt[18] = button20;  bt[19] = button21;
      bt[20] = button22;  bt[21] = button23;  bt[22] = button24;  bt[23] = button25;  bt[24] = button26;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Start(0);
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Start(1);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      Start(2);
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Start(3);
    }

    private void button6_Click(object sender, EventArgs e)
    {
      Start(4);
    }

    private void button7_Click(object sender, EventArgs e)
    {
      Start(5);
    }

    private void button8_Click(object sender, EventArgs e)
    {
      Start(6);
    }

    private void button9_Click(object sender, EventArgs e)
    {
      Start(7);
    }

    private void button10_Click(object sender, EventArgs e)
    {
      Start(8);
    }

    private void button11_Click(object sender, EventArgs e)
    {
      Start(9);
    }

    private void button12_Click(object sender, EventArgs e)
    {
      Start(10);
    }

    private void button13_Click(object sender, EventArgs e)
    { 
      Start(11);
    }

    private void button14_Click(object sender, EventArgs e)
    {
      Start(12);
    }

    private void button15_Click(object sender, EventArgs e)
    {
      Start(13);
    }

    private void button16_Click(object sender, EventArgs e)
    {
      Start(14);
    }

    private void button17_Click(object sender, EventArgs e)
    {
      Start(15);
    }

    private void button18_Click(object sender, EventArgs e)
    {
      Start(16);
    }

    private void button19_Click(object sender, EventArgs e)
    {
      Start(17);
    }

    private void button20_Click(object sender, EventArgs e)
    {
      Start(18);
    }

    private void button21_Click(object sender, EventArgs e)
    {
      Start(19);
    }

    private void button22_Click(object sender, EventArgs e)
    {
      Start(20);
    }

    private void button23_Click(object sender, EventArgs e)
    {
      Start(21);
    }

    private void button24_Click(object sender, EventArgs e)
    {
      Start(22);
    }

    private void button25_Click(object sender, EventArgs e)
    {
      Start(23);
    }

    private void button26_Click(object sender, EventArgs e)
    {
      Start(24);
    }
  }
}
