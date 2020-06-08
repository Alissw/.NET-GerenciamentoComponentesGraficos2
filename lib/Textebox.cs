using System.Drawing;

namespace lib
{
    public class TextBox : System.Windows.Forms.TextBox
    {
        public TextBox(){
            this.Size = new Size(230, 0);
            this.MaxLength = 40;             
        }
    }
}