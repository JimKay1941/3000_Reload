using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _3000_Reload
{
    public partial class Form1 : Form
    {
        private readonly OpenFileDialog _chooseInputFileDialog = new OpenFileDialog();
        private FileStream _reading;
        private StreamReader _inputLine;

        public Form1()
        {
            InitializeComponent();
            _chooseInputFileDialog.FileOk += OnInputFileDialogOk;
        }

        private void OnInputFileDialogOk(object sender, CancelEventArgs e)
        {
            textInputFile.Text = _chooseInputFileDialog.FileName;
            if (textInputFile.Text == "") return;

            _reading = new FileStream(textInputFile.Text, FileMode.Open, FileAccess.Read, FileShare.None);
            _inputLine = new StreamReader(_reading);
        }

        private void ChooseInput_Click(object sender, EventArgs e)
        {
            _chooseInputFileDialog.ShowDialog();
        }

        private void btnConectionString_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserConnectionString =
                "Data Source=" + textUrl.Text +
                ";Initial Catalog=ChineseStudy" +
                ";Persist Security Info=True;User ID=" + textUserId.Text +
                ";Password=" + textPassword.Text;
        }

        private void btnPurge_Click(object sender, EventArgs e)
        {
            string looker1 = Properties.Settings.Default.UserConnectionString;

            using (var farEastDataContext = new ChineseStudyDataContext(Properties.Settings.Default.UserConnectionString))
            {
                var dictionary = from s01 in farEastDataContext._3000_Characters
                                 select s01;
                farEastDataContext._3000_Characters.DeleteAllOnSubmit(dictionary);

                farEastDataContext.SubmitChanges();

                textStatus.Text = @"Purge Completed";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (_inputLine != null) _inputLine.Close();
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            textStatus.Text = @"";
            var InputCounter = 0;
            textInputCount.Text = @"0";
            string[] LineParts = null;

            if (_inputLine == null)
            {
                if (textInputFile.Text == "") return;

                _reading = new FileStream(textInputFile.Text, FileMode.Open, FileAccess.Read, FileShare.None);
                _inputLine = new StreamReader(_reading);
            }
            var InputLine = _inputLine.ReadLine();
            LineParts = InputLine.Split('\t');
            if (LineParts[1] == "FEseq")
            {
                InputLine = _inputLine.ReadLine();
            }

            if (InputLine != null)
            {
                using (var farEastDataContext = new ChineseStudyDataContext(Properties.Settings.Default.UserConnectionString))
                {
                    try
                    {
                        do
                        {
                            LineParts = InputLine.Split('\t');

                            InputCounter++;

                            var newrow = new _3000_Character();

                            //newrow.ID = Convert.ToInt32(LineParts[0]);
                            newrow.FEseq = LineParts[1];
                            newrow.Zhuyin = LineParts[2];
                            newrow.Traditional = LineParts[3];
                            newrow.English = LineParts[4];
                            newrow.NumPinyin = LineParts[5];
                            newrow.CritPinyin = LineParts[6];
                            newrow.Simplified = LineParts[7];
                            newrow.Cji = LineParts[8];

                            farEastDataContext._3000_Characters.InsertOnSubmit(newrow);
                            farEastDataContext.SubmitChanges();

                            InputLine = _inputLine.ReadLine();
                            
                        } while (InputLine != null);
                    }
                    catch (Exception exception)
                    {
                        textStatus.Text = exception.Message;
                        return;
                    }
                }
            }

            if (_inputLine != null) _inputLine.Close();
            textInputCount.Text = InputCounter.ToString(CultureInfo.InvariantCulture);
            if (textStatus.Text == "") textStatus.Text = @"Reload Completed!";
        }
    }
}