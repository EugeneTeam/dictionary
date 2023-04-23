using dictionary.Entities;

namespace dictionary
{
    internal class FormPaginationService
    {

        public static void UpdatePaginationLabel(MainForm form, int? count)
        {
            if (count != null)
            {
                form.itemsInList.Text = string.Format("{0}/{1}", Word.Offset / Word.Limit, (count / GetLimit()).ToString());
            }
        }


        public static int GetLimit()
        {
            return Word.Limit;
        }

        public static int GetOffset()
        {
            return Word.Offset;
        }
    }
}
