using System;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;

namespace NUIXaml_Exemplos
{
    public class Program : NUIApplication
    {
        //Animation animation;
        protected override void OnCreate()
        {
            base.OnCreate();
            Window window = Window.Instance;
            window.BackgroundColor = Color.Black;
            //window.KeyEvent += OnKeyEvent;

            XamlPage page = new XamlPage();
            page.PositionUsesPivotPoint = true;
            page.ParentOrigin = ParentOrigin.Center;
            page.PivotPoint = PivotPoint.Center;
            page.Size = new Size(1920, 1080, 0);
            window.Add(page);
     }

        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
