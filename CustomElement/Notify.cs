using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomElement
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:Notify runat=server></{0}:Notify>")]
    public class Notify : WebControl
    {

        protected override void OnInit(EventArgs e)
        {

            if (!Page.IsClientScriptBlockRegistered("MyNotifyScript"))
            {

                string JavaScriptCode = @"<script>
                function SomeJavaScriptFunction()
                {
                  // JavaScript code goes here
                }
                </script>";
                Page.RegisterClientScriptBlock("MyNotifyScript", JavaScriptCode);
            }
  
            base.OnInit(e);
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }


        [Bindable(true)]
        [DefaultValue("")]
        public string Title
        {
            get
            {
                String s = (String)ViewState["Title"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Title"] = value;
            }
        }

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(Title);
        }

        public void Show()
        {

        }
    }
}
