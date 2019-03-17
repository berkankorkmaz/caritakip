using System.Windows.Forms;

namespace CariHesapTakibi
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.BackColor = System.Drawing.Color.White;
        }

        public virtual void RefreshForm() { }
    }
}
