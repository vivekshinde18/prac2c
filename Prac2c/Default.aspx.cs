using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Pract2c : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    public class quadeqtn
    {
        public double d, x1, x2;
        public string msg;
        public quadeqtn(int a, int b, int c)
        {
            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x1 = -b / (2.0 * a);
                x2 = x1;
                msg = "Both the roots are equal<br>1st Root is:" + x1 + "<br>2nd Root is:" + x2 +
                "<br>";
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                msg = "Both the roots are real and different<br>1st Root is:" + x1 + "<br>2nd Root is:" + x2 + " < br > ";
            }
            else
            {
                msg = "Roots are imaginary, No solution.";
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a, b, c;
        a = Int32.Parse(TextBox1.Text);
        b = Int32.Parse(TextBox2.Text);
        c = Int32.Parse(TextBox3.Text);
        quadeqtn qe = new quadeqtn(a, b, c);
        Response.Write(qe.msg);
    }
}
