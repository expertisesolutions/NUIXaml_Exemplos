using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace NUIXaml_Exemplos
{
    public partial class XamlPage : View
    {
        public XamlPage() : base ()
        {
            InitializeComponent();
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }
            if (type == DisposeTypes.Explicit)
            {
            }
            base.Dispose(type);
        }

        public void OnButtonClicked(object sender, EventArgs e)
        {
              
        }


    }
}
