using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboriginalSyllabics
{
    public partial class Syllabics : Form
    {
        string[] letters = { "" , "p", "t", "k","s","sh","ch","n","m","y","w","l","r"};
        string[] vow = { "ay", "ee", "oo", "ah","" };
        char[][] syl = {
            new char[]{'ᐁ','ᐃ','ᐅ','ᐊ'},
            new char[]{'ᐯ','ᐱ','ᐳ','ᐸ'},
            new char[]{'ᑌ','ᑎ','ᑐ','ᑕ'},
            new char[]{'ᑫ','ᑭ','ᑯ','ᑲ'},
            new char[]{'ᓭ','ᓯ','ᓱ','ᓴ'},
            new char[]{'ᔐ','ᔑ','ᔓ','ᔕ'},
            new char[]{'ᒉ','ᒋ','ᒍ','ᒐ'},
            new char[] {'ᓀ','ᓂ','ᓄ','ᓇ'},
            new char[] {'ᒣ','ᒥ','ᒧ','ᒪ'},
            new char[] {'ᔦ','ᔨ','ᔪ','ᔭ'},
            new char[] {'ᐌ','ᐎ','ᐒ','ᐗ'},
            new char[] {'ᓓ','ᓕ','ᓗ','ᓚ'},
            new char[] {'ᕃ','ᕆ','ᕈ','ᕋ' }
        };

        //ᕃᕆᕈᕋ
        List<Button> sylbtn;
        public Syllabics()
        {
            InitializeComponent();
        }
        void sylclick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            txtSyl.Text += btn.Text;
            if (txtRoman.Text.Count() > 0)
                txtRoman.Text += "-";
            txtRoman.Text += btn.Name; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tablegroup.ColumnCount = syl[0].Count();
            tablegroup.RowCount = syl.Count();
            sylbtn = new List<Button>();
            for(int l = 0; l < syl.Count(); l++)
            {
                for (int i = 0; i < syl[l].Count(); i++)
                {
                    Button newbtn = new Button();

                    //sylbtngroup.Controls.Add(newbtn);
                    tablegroup.Controls.Add(newbtn, i, l);
                    sylbtn.Add(newbtn);
                    newbtn.Name = letters[l] + vow[i];
                    newbtn.Text = syl[l][i].ToString();
                    newbtn.TabIndex = 1;
                    newbtn.Dock = DockStyle.Fill;
                    newbtn.Font = new Font("Aboriginal", 15);
                    newbtn.Click += sylclick;
                    
                    //newbtn.Size = new System.Drawing.Size(273, 196);
                    //newbtn.Location = new System.Drawing.Point(156, 71);
                }
            }
            ;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtRoman.Text = "";
            txtSyl.Text = "";
        }
    }
}
