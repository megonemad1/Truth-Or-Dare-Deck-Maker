using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cardpackWriter
{
    public struct _data
    {
        public int points;
        public string question;
        public bool male, female;
        public override string ToString()
        {
            return question;
        }
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            ClearUI();

            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (RtbQuestion.Text != "" && (ChkMale.Checked || ChkFemale.Checked))
                storeItem();
            else
                MessageBox.Show("no question added, or no valid gender");
            if (CmbCurrentlyCreated.SelectedIndex != -1)
            {
                CmbCurrentlyCreated.Items.Remove(CmbCurrentlyCreated.SelectedItem);
            }
        }

        private void storeItem()
        {
            DialogResult NoPlayer = System.Windows.Forms.DialogResult.Yes;
            if (!RtbQuestion.Text.Contains("/p0"))
                NoPlayer = MessageBox.Show("this question has no /p0 flag is this ok?","flag warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (NoPlayer == System.Windows.Forms.DialogResult.Yes)
            {
                CmbCurrentlyCreated.Items.Add(new _data() { question = RtbQuestion.Text, points = (int)NmrPointsValue.Value, male = ChkMale.Checked, female = ChkFemale.Checked });
                ClearUI();
            }
        }

        private void ClearUI()
        {
            RtbQuestion.Text = "";
            NmrPointsValue.Value = 100;
            ChkMale.Checked = true;
            ChkFemale.Checked = true;
        }

        private void CmbCurrentlyCreated_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCurrentlyCreated.SelectedIndex != -1)
            {
                var card = (_data)CmbCurrentlyCreated.SelectedItem;
                RtbQuestion.Text = card.question;
                NmrPointsValue.Value = card.points;
                ChkMale.Checked = card.male;
                ChkFemale.Checked = card.female;

            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (CmbCurrentlyCreated.SelectedIndex != -1)
            {
                var index = CmbCurrentlyCreated.SelectedIndex;
                CmbCurrentlyCreated.SelectedIndex = -1;
                CmbCurrentlyCreated.Items.RemoveAt(index);

            }
            RtbQuestion.Text = "";
            NmrPointsValue.Value = 0;
            ChkMale.Checked = true;
            ChkFemale.Checked = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (RtbQuestion.Text == "")
                if (CmbCurrentlyCreated.Items.Count == 0)
                    MessageBox.Show("No stored cards, hit next to store then save when you have made a deck");
                else
                    saveFileDialog1.ShowDialog();
            else
                MessageBox.Show("hit next to store the card before saving");
        }

        void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            string rtn = "[";
            List<string> items = new List<string>();
            foreach (object ocard in CmbCurrentlyCreated.Items)
            {
                var card = (_data)ocard;
                Regex players = new Regex("\\/p[0-9]", RegexOptions.Singleline);
                var matches = players.Matches(card.question);
                HashSet<string> playercount = new HashSet<string>();
                foreach (var c in matches)
                {
                    playercount.Add(c.ToString());
                }
                items.Add("{\"targetno\": " + playercount.Count + ", \"points\": " + card.points + ", \"themes\": [], \"question\": \"" + card.question + "\", \"aplicablegenders\": [" + ((card.male) ? "\"m\"" : "") + ((card.male && card.female) ? "," : "") + ((card.female) ? "\"f\"" : "") + "]}");
            }
            rtn += String.Join(",", items) + "]";

            StreamWriter SW = new StreamWriter(saveFileDialog1.FileName);
            SW.Write(rtn);
            SW.Close();
            SW.Dispose();
            CmbCurrentlyCreated.Items.Clear();
        }
        /*
   Regex players = new Regex("\\/p[0-9]", RegexOptions.Singleline);
            var matches = players.Matches(Console.ReadLine());
            foreach (var a in matches)
                Console.WriteLine(a.ToString());
            Console.ReadLine();
  */
    }
}
