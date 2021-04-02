using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
namespace KssOffice
{
    public partial class AdvBrowser : WebBrowser
    {
        private HtmlDocument document;
        private IDictionary<HtmlElement, string> dictionaryStyles = new Dictionary<HtmlElement, string>();

        public AdvBrowser()
        {
            InitializeComponent();

        }

        public AdvBrowser(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void AdvBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
         document = Document;
         document.MouseOver += new HtmlElementEventHandler(document_MouseOver);
         document.MouseLeave += new HtmlElementEventHandler(document_MouseLeave);
         document.MouseUp += new HtmlElementEventHandler(document_MouseUp);
        }

        private void document_MouseUp(object sender, HtmlElementEventArgs e)
        {
            StringBuilder xpath = new StringBuilder();
            HtmlElement element = Document.GetElementFromPoint(e.ClientMousePosition);
            while( element != null)
            {
                xpath.Append(element.TagName + (element.TagName == "" ? "" : "/"));
                element = element.Parent;
            }

            Text = xpath.ToString();

        }


        private void document_MouseLeave(object sender, HtmlElementEventArgs e)
        {
            HtmlElement element = e.FromElement;

            if (this.dictionaryStyles.ContainsKey(element))
            {
                string style = this.dictionaryStyles[element];
                this.dictionaryStyles.Remove(element);
                element.Style = style;
            }
        }

        private void document_MouseOver(object sender, HtmlElementEventArgs e)
        {
            HtmlElement element = e.ToElement;
            if (!this.dictionaryStyles.ContainsKey(element))
            {
                string style = element.Style;
                this.dictionaryStyles.Add(element, style);
                element.Style = style + "; background-color: yellow;";
                this.Text = element.Id ?? "(no id)";
            }
             
        }
    }
}
