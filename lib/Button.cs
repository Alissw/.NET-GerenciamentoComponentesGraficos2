using System.Drawing;
namespace lib{
    public class Button : System.Windows.Forms.Button
    {
        public Button(){
            this.Size = new Size(100,30);
            this.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);            
        }
    }
}