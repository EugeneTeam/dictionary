using dictionary.DB;
using dictionary.DB.Init;
using dictionary.Entities;
using System.Windows.Forms;

namespace dictionary
{
    public partial class MainForm : Form
    {
        public NumericUpDown itemPerPageValue { get; }
        public ListBox wordsList { get; }
        public Label itemsInList { get; }
        public Button previewPage { get; }
        public Button nextPage { get; }
        public TextBox searchValue { get; }

        public MainForm()
        {
            InitializeComponent();

            this.itemPerPageValue = this.ItemPerPageValue;
            this.wordsList = this.WordsList;
            this.itemsInList = this.ItemsInList;
            this.previewPage = this.PreviewPage;
            this.nextPage = this.NextPage;
            this.searchValue = this.SearchValue;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormService.OnLoadMainForm(this);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            FormService.UpdateWordList(this);
        }

        private void ReloadList_Click(object sender, EventArgs e)
        {
            FormService.ReloadWordList(this);
        }

        private void ItemPerPageValue_ValueChanged(object sender, EventArgs e)
        {
            FormService.SetItemCountPerPage(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FormService.SerachWord(this);
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            FormService.NextPage(this);
        }

        private void PreviewPage_Click(object sender, EventArgs e)
        {
            FormService.PreviewPage(this);
        }

        private void WordsList_SelectedValueChanged(object sender, EventArgs e)
        {
            ListBox listbox = (ListBox)sender;
            string selectedItem = listbox.SelectedItem.ToString();

            string wordId = selectedItem.Split("-").First();

            MessageBox.Show(wordId.ToString());
        }
    }
}