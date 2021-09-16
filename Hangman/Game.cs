using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class HangmanGame : Form
    {
        public HangmanGame()
        {
            InitializeComponent();
        } 
        ListView _listView; // For add score or word
        Word _word; //For get methods in the class Word 
        string _sAskedWord; //Asked word to user
        bool _bControlClick = false; //Control for click to start button
        int _iRegister = 0; //Register for count of known letter
        Label[]_lLettersLabelArray; //Array for known or have to know letter labels
        /// <summary>
        /// Method for new game
        /// </summary>
        /// <param name="iScore"> hiding place for user score
        /// <param name="sUserName"> hiding place for user name
        private void New_Game(int iScore,string sUserName)
        {
            userNameTxtBx.Text = sUserName;
            lettersPanel.Controls.Clear();
            lettersListview.Items.Clear();
            lettersLabelPanel.Controls.Clear();
            retriesLabel.Text = "0";
            _bControlClick = false;
            _iRegister = 0;
            scoreLabel.Text = iScore.ToString();
        }
        /// <summary>
        /// Method for game tab
        /// </summary>
           private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Game(0, "");
            lettersPanel.Size = new Size(301, 235);
            lettersPanel.Controls.Clear();
            countOfLetterComboBox.Items.Clear();
            wordPanel.Visible = false;
            gamePanel.Visible = true;
            _word = new Word();

            //Fill to combobox by letter numbers
            countOfLetterComboBox.Items.Add("Farketmez");
            countOfLetterComboBox.SelectedIndex = 0;
            for (int j = 0; j < _word._sWordsArray.Length; j++)
            {
                if (!countOfLetterComboBox.Items.Contains(_word._sWordsArray[j].Length.ToString()))
                {
                    countOfLetterComboBox.Items.Add(_word._sWordsArray[j].Length.ToString());
                }
            }
        }
        /// <summary>
        /// Method for add letter buttons 
        /// </summary>
        private void BrushUp_Button()
        {
            string sABC = "abcdefghijklmnoprstuvyz";
            char[] cABCarray = sABC.ToCharArray();
            for (int i = 0; i < cABCarray.Length; i++)
            {

                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.Text = Convert.ToString(cABCarray[i]);
                btn.Size = new Size(40, 40);
                btn.Click += new EventHandler(btn_Click);
                lettersPanel.Controls.Add(btn);
            }
        }
        /// <summary>
        /// Method for game start
        /// </summary>
        private void startButton_Click(object sender, EventArgs e)
        {
            if (_bControlClick == false)
            {
                if (String.IsNullOrEmpty(userNameTxtBx.Text))
                    MessageBox.Show("Lütfen kullanıcı adınızı giriniz!");
                else
                {
                    
                    BrushUp_Button();
                    //Random word by combobox selected item
                    if (countOfLetterComboBox.SelectedIndex == 0)
                    {
                        _word = new Word(true, 0);
                        _sAskedWord = _word.AskedWord;
                    }
                    else
                    {
                        _word = new Word(false, Convert.ToInt32(countOfLetterComboBox.SelectedItem));
                        _sAskedWord = _word.AskedWord;
                    }
                    //Value retries for user estimate
                    retriesLabel.Text = _sAskedWord.Length.ToString();
                    _lLettersLabelArray = new Label[_sAskedWord.Length];
                    //Creat label until count of random word  for random word letter           
                    for (int i = 0; i < _sAskedWord.Length; i++)
                    {
                        Label lbl = new Label();
                        lbl.Size = new Size(40, 40);
                        lbl.Font = new Font(Font.FontFamily, 20);
                        lbl.Name = "letterLbl" + i;
                        lbl.Text = "_";
                        _lLettersLabelArray[i] = lbl;
                        lettersLabelPanel.Controls.Add(lbl);
                    }

                    retriesLabel.Text = (_sAskedWord.Length * 2).ToString();
                    _bControlClick = true;
                }
            }
            else if (MessageBox.Show("Yeni oyun başlatmak istediğinize emin misiniz?", "Yeni Oyun", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                New_Game(0,"");
            }
            else{}
        }
        /// <summary>
        /// Method user and users score to hide with | in file txt
        /// </summary>
        /// /// <param name="sUserName"> hiding place for user name to write file
        /// <param name="sScore"> hiding place for user score to write file
        private void Print_Score(string sUserName,string sScore)
        {
            FileStream fs = new FileStream("Skorlar.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(sUserName+"|"+sScore);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// Method to click a letter button
        /// </summary>
        private void btn_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if (_sAskedWord.Contains(btn.Text))
            {
                //In word to asked if available click button letter 
                btn.BackColor = Color.Green;
                for (int i = 0; i < _sAskedWord.Length; i++)
                {
                    if (btn.Text == _sAskedWord[i].ToString())
                    {
                        //Add to created labels
                        _lLettersLabelArray[i].Text = btn.Text;
                        _iRegister++;
                    }
                   
                }
                //If all of label is full, exact word
                if (_iRegister == _sAskedWord.Length)
                { 
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + _iRegister * 10).ToString();
                    //Ask user "do or die"
                    if (MessageBox.Show("Tebrikler Kazandınız! Yeniden oynamak ister misiniz?", "Oynamaya Devam Et!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       
                        New_Game(Convert.ToInt32(scoreLabel.Text), userNameTxtBx.Text);

                    }
                    else
                    {
                       
                        Print_Score(userNameTxtBx.Text, scoreLabel.Text);
                        MessageBox.Show("Skorunuz Başarıyla kaydedilmiştir!");
                        New_Game(0, "");
                    }
                }
            }
            else
            {
                //If user misestimation letter
                btn.BackColor = Color.Red;
                lettersListview.Items.Add(btn.Text);
                retriesLabel.Text = (Convert.ToInt32(retriesLabel.Text) - 1).ToString();
                
                //If user misestimation word 
                if (retriesLabel.Text == "0")
                {
                    scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + _iRegister * 10).ToString();
                    if (MessageBox.Show("Kaybettiniz! Yeniden oynamak ister misiniz?", "Oynamaya Devam Et!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                       
                        New_Game(Convert.ToInt32(scoreLabel.Text), userNameTxtBx.Text);
                        BrushUp_Button();
                    }
                    else
                    {
                        
                        Print_Score(userNameTxtBx.Text, scoreLabel.Text);
                        MessageBox.Show("Skorunuz Başarıyla kaydedilmiştir!");
                        New_Game(0, "");
                        
                    }
                }
            }
        }
        /// <summary>
        /// Method for other tabs 
        /// </summary>
        /// <param name="sColumns1"> storage unit for listview column in tab
        /// <param name="sColumns2"> storage unit for listview column in tab
        /// <param name="bPanelVisible"> storeage unit for one of panel visible in tab
        private void Create_MenuItemTab(string sColumns1, string sColumns2,bool bPanelVisible)
        {
            wordPanel.Visible = bPanelVisible;
            gamePanel.Visible = false;
            lettersPanel.Controls.Clear();
            _listView = new ListView();
            _listView.Size = new Size(301, 443);
            _listView.FullRowSelect = true;
            _listView.Columns.Add(sColumns1, 210);
            _listView.Columns.Add(sColumns2);
            _listView.View = View.Details;
            lettersPanel.Size = new Size(301, 443);
            lettersPanel.Controls.Add(_listView);
        }
        /// <summary>
        /// Method for listview to add to words or scores
        /// </summary>
        /// <param name="sFilePath"> storage unit for file path intra words file
        private void Add_ListviewItem(string sFilePath)
        {
            string [] sTxtArray= File.ReadAllLines(sFilePath, Encoding.UTF8);
            
            for (int i = 0; i < sTxtArray.Length; i++)
            {
                string[] sTxtSplit = sTxtArray[i].Split('|');
                ListViewItem listViewItem = new ListViewItem(sTxtSplit);
                _listView.Items.Add(listViewItem);
                
            }
        }
        /// <summary>
        /// Method for score list tab
        /// </summary>
        private void scoreListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_MenuItemTab("Kullanıcı Adı", "Skor", false);
            Add_ListviewItem("Skorlar.txt");
        }
        /// <summary>
        /// Method for words list tab
        /// </summary> 
        private void addWordToolStripMenuItem_Click_1(object sender, EventArgs e)
        { 
            Create_MenuItemTab("KELİMELER",String.Empty,true);
            Add_ListviewItem("Kelimeler.txt");

        }
        /// <summary>
        /// Method for textboox control
        /// </summary>
        private void wordAddTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /// <summary>
        /// Method for word to add to listview and file
        /// </summary>
        private void wordAddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(wordAddTxtBx.Text))
                MessageBox.Show("Lütfen bir kelime giriniz!");
            else
            {
                //Get rid of Turkish character 
                string sAdaptedWord = wordAddTxtBx.Text.Replace('ç', 'c').Replace('ö', 'o').Replace('ğ','g').Replace('ı','i').Replace('ş','s').Replace('ü','u');
                sAdaptedWord = sAdaptedWord.ToLower();
                _word = new Word();
                _word.Add(sAdaptedWord);
                _listView.Items.Add(sAdaptedWord);
                wordAddTxtBx.Clear();
            }
        }
        /// <summary>
        /// Method for word to remove in listview and file
        /// </summary>
        private void wordRemoveButton_Click(object sender, EventArgs e)
        {
            if (_listView.SelectedItems.Count==0)
                MessageBox.Show("Lütfen bir kelime seçiniz!");
            else
            {
                _word = new Word();
                _word.Remove(_listView.SelectedItems[0].Text);
                _listView.Items.Remove(_listView.SelectedItems[0]);
            }
        }

     
    }
}
