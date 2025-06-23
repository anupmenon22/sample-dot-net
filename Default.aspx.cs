using System;
using System.Web.UI;

namespace SampleDotNetApp
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize page on first load
                pnlResult.Visible = false;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string message = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                lblResult.Text = "Please enter your name.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
            else if (string.IsNullOrEmpty(message))
            {
                lblResult.Text = "Please enter a message.";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblResult.Text = $"Hello {name}! Your message '{message}' was received at {DateTime.Now:yyyy-MM-dd HH:mm:ss}.";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }

            pnlResult.Visible = true;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtMessage.Text = string.Empty;
            pnlResult.Visible = false;
        }
    }
}
