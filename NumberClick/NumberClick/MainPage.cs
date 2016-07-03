using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NumberClick
{
    public class MainPage : ContentPage
    {
        int clicksNumber = 0;
        Label label = new Label() { HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center };
        Button button = new Button() { Text = "Кликай!" };

        public MainPage()
        {
            updateStates();

            button.Clicked += (object sender, EventArgs e) =>
            {
                clicksNumber++;
                updateStates();
            };

            Content = new StackLayout
            {
                Children = {
                    button,
                    label,
                }
            };
        }

        private void updateStates()
        {
            label.Text = String.Format("Всего кликов {0}.", clicksNumber);
        }
    }
}
