using dictionary.DB;
using dictionary.DB.Init;
using dictionary.Entities;

namespace dictionary
{
    internal class FormService
    {
        public static void OnLoadMainForm(MainForm form)
        {
            CreateDb.Init();
            form.itemPerPageValue.Value = Constants.DEFAULT_LIMIT;
            Word.Limit = (int)form.itemPerPageValue.Value <= 0 ? Constants.DEFAULT_LIMIT : (int)form.itemPerPageValue.Value;


            if (Word.Offset == 0)
            {
                form.previewPage.Enabled = false;
            }
        }

        public static void UpdateWordList(MainForm form)
        {
            Dictionary<int, string>? words = GetWordList(FormPaginationService.GetLimit(), FormPaginationService.GetOffset());
            if (words != null)
            {
                RenderList(words, form);
            }
        }

        public static void ReloadWordList(MainForm form)
        {
            Dictionary<int, string>? words = GetWordList(FormPaginationService.GetLimit(), FormPaginationService.GetOffset());
            if (words != null)
            {
                RenderList(words, form);
            }
        }

        public static void SerachWord(MainForm form)
        {
            string searchText = form.searchValue.Text;
            Dictionary<int, string>? foundWords = Word.Search(searchText);
            if (foundWords != null && searchText != "")
            {
                RenderList(foundWords, form);
            }
            else
            {
                Dictionary<int, string>? words = GetWordList(FormPaginationService.GetLimit(), FormPaginationService.GetOffset());
                if (words != null)
                {
                    RenderList(words, form);
                }

            }
        }

        public static void SetItemCountPerPage(MainForm form)
        {
            Word.Limit = (int)form.itemPerPageValue.Value <= 0 ? Constants.DEFAULT_LIMIT : (int)form.itemPerPageValue.Value;
            Dictionary<int, string>? words = GetWordList(FormPaginationService.GetLimit(), FormPaginationService.GetOffset());
            if (words != null)
            {
                RenderList(words, form);
            }
        }

        public static void NextPage(MainForm form)
        {
            int currentLimit = Word.Limit;
            int currentOffset = Word.Offset;
            Int32? count = Word.Count();
            Word.Offset = (currentOffset / currentLimit + 1) * currentLimit;

            Dictionary<int, string>? words = GetWordList(
                FormPaginationService.GetLimit(),
                FormPaginationService.GetOffset()
                );
            if (words != null)
            {
                RenderList(words, form);
            }

            ButtonStateByNavigationValues(form, count);
            FormPaginationService.UpdatePaginationLabel(form, count);
        }
        public static void PreviewPage(MainForm form)
        {
            int currentLimit = Word.Limit;
            int currentOffset = Word.Offset;
            Word.Offset = (currentOffset / currentLimit - 1) * currentLimit;

            Dictionary<int, string>? words = GetWordList(
                FormPaginationService.GetLimit(),
                FormPaginationService.GetOffset()
                );
            if (words != null)
            {
                RenderList(words, form);
            }

            Int32? count = Word.Count();

            ButtonStateByNavigationValues(form, count);
            FormPaginationService.UpdatePaginationLabel(form, count);
        }

        private static void ButtonStateByNavigationValues(MainForm form, int? count)
        {
            form.previewPage.Enabled = !Convert.ToBoolean(Word.Offset == 0);
            form.nextPage.Enabled = !Convert.ToBoolean((Word.Offset / Word.Limit) == (count / FormPaginationService.GetLimit()));
        }

        private static Dictionary<int, string>? GetWordList(int? limit, int? offset)
        {
            return Word.GetList(limit, offset);
        }

        private static void RenderList(Dictionary<int, string> words, MainForm form)
        {
            if (words != null && words.Count > 0)
            {
                form.wordsList.Items.Clear();
            }

            if (words != null)
            {
                foreach (KeyValuePair<int, string> pair in words)
                {
                    form.wordsList.Items.Add(string.Format("{0} - {1}", pair.Key, pair.Value));
                }
            }

            Int32? count = Word.Count();
            FormPaginationService.UpdatePaginationLabel(form, count);
        }
    }
}
