using dictionary.DB;
using dictionary.DB.Init;
using dictionary.Entities;

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
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            Dictionary<int, string>? words = GetWordList(GetLimit(), 0);
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
            return (int)ItemPerPageValue.Value <= 0 ? Constants.DEFAULT_LIMIT : (int)ItemPerPageValue.Value;
        }

        private void ReloadList_Click(object sender, EventArgs e)
        {
            Dictionary<int, string>? words = GetWordList(GetLimit(), 0);
            if (words != null)
            {
                UpdateWordList(words);
            }
        }

        private void ItemPerPageValue_ValueChanged(object sender, EventArgs e)
        {
            Dictionary<int, string>? words = GetWordList(GetLimit(), 0);
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
                Dictionary<int, string>? words = GetWordList(GetLimit(), 0);
                if (words != null)
                {
                    UpdateWordList(words);
                }

            }
        }
    }
}