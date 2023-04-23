using dictionary.DB;
using dictionary.DB.Init;
using dictionary.Entities;
using System.Windows.Forms;

namespace dictionary
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateDb.Init();
            ItemPerPageValue.Value = Constants.DEFAULT_LIMIT;
            Word.Limit = (int)ItemPerPageValue.Value <= 0 ? Constants.DEFAULT_LIMIT : (int)ItemPerPageValue.Value;


            if (Word.Offset == 0)
            {
                PreviewPage.Enabled = false;
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            Dictionary<int, string>? words = GetWordList(GetLimit(), GetOffset());
            if (words != null)
            {
                UpdateWordList(words);
            }
        }

        private void UpdateWordList(Dictionary<int, string> words)
        {
            if (words != null && words.Count > 0)
            {
                WordsList.Items.Clear();
            }

            if (words != null)
            {
                foreach (KeyValuePair<int, string> pair in words)
                {
                    WordsList.Items.Add(string.Format("{0} - {1}", pair.Key, pair.Value));
                }
            }

            Int32? count = Word.Count();
            if (count != null)
            {
                ItemsInList.Text = (count / 10).ToString();
            }
        }

        private Dictionary<int, string>? GetWordList(int? limit, int? offset)
        {
            return Word.GetList(limit, offset);
        }

        private int GetLimit()
        {
            return Word.Limit;
        }

        private int GetOffset()
        {
            return Word.Offset;
        }

        private void ReloadList_Click(object sender, EventArgs e)
        {
            Dictionary<int, string>? words = GetWordList(GetLimit(), GetOffset());
            if (words != null)
            {
                UpdateWordList(words);
            }
        }

        private void ItemPerPageValue_ValueChanged(object sender, EventArgs e)
        {
            Word.Limit = (int)ItemPerPageValue.Value <= 0 ? Constants.DEFAULT_LIMIT : (int)ItemPerPageValue.Value;
            Dictionary<int, string>? words = GetWordList(GetLimit(), GetOffset());
            if (words != null)
            {
                UpdateWordList(words);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchValue.Text;
            Dictionary<int, string>? foundWords = Word.Search(searchText);
            if (foundWords != null && searchText != "")
            {
                UpdateWordList(foundWords);
            }
            else
            {
                Dictionary<int, string>? words = GetWordList(GetLimit(), GetOffset());
                if (words != null)
                {
                    UpdateWordList(words);
                }

            }
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            int currentLimit = Word.Limit;
            int currentOffset = Word.Offset;
            Int32? count = Word.Count();
            Word.Offset = (currentOffset / currentLimit + 1) * currentLimit;

            Dictionary<int, string>? words = GetWordList(GetLimit(), GetOffset());
            if (words != null)
            {
                UpdateWordList(words);
            }


            PreviewPage.Enabled = !Convert.ToBoolean(Word.Offset == 0);
            NextPage.Enabled = !Convert.ToBoolean((Word.Offset / Word.Limit) == (count / GetLimit()));

            if (count != null)
            {
                ItemsInList.Text = string.Format("{0}/{1}", Word.Offset / Word.Limit, (count / GetLimit()).ToString());
            }
        }

        private void PreviewPage_Click(object sender, EventArgs e)
        {
            int currentLimit = Word.Limit;
            int currentOffset = Word.Offset;
            Word.Offset = (currentOffset / currentLimit - 1) * currentLimit;

            Dictionary<int, string>? words = GetWordList(GetLimit(), GetOffset());
            if (words != null)
            {
                UpdateWordList(words);
            }

            Int32? count = Word.Count();

            PreviewPage.Enabled = !Convert.ToBoolean(Word.Offset == 0);
            NextPage.Enabled = !Convert.ToBoolean((Word.Offset / Word.Limit) == (count / GetLimit()));


            if (count != null)
            {
                ItemsInList.Text = string.Format("{0}/{1}", Word.Offset / Word.Limit, (count / GetLimit()).ToString());
            }
        }

        private void WordsList_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            string selectedItem = listbox?.SelectedItem.ToString();

            string wordId = selectedItem.Split("-").First();

            MessageBox.Show(wordId.ToString());
        }
    }
}