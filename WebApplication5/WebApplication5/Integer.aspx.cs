using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Text;

namespace WebApplication5
{
    public partial class Integer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox1.Text);
            
            
            if (int.TryParse(TextBox1.Text, out a))
            {
                Response.Write(sum(a));
            }
            else
            {
                Response.Write("The value entered is not a number");
            } 
           
        }
         static int Factorial(int n)
        {

            int res = 1;
            for (int i = 2; i <= n; i++)
                res *= i;
            return res;
        }
        static double sum(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum +=1+ 1.0+(1.0 / Factorial(i));

            return sum;
        }
    }
}