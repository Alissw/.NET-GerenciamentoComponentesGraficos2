using System.Drawing;

namespace lib{
    public class Label : System.Windows.Forms.Label
    {
        public Label(){
        
        this.Font = new Font("Arial", 10, FontStyle.Bold);
        this.ForeColor = Color.Blue;

        }
    }
}