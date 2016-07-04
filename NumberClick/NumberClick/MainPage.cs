using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NumberClick {
    public class MainPage : ContentPage {
        int maxNumberClick = 50;
        int clicksNumber = 0;

        Label infoLabel = new Label() { HorizontalTextAlignment = TextAlignment.Center };
        Label label = new Label() { HorizontalTextAlignment = TextAlignment.Center };
        Button button = new Button() { Text = "Кликай!" };
        Button button2 = new Button() { Text = "Кликай!" };
        Button button3 = new Button() { Text = "Кликай!" };

        public MainPage() {
            updateStates();

            infoLabel.Text = String.Format("Привет!\nЦель этого великолепного приложения "
                + "прокачать твои навыки нажатия на кнопки.\n"
                + "Всего нужно кликнуть {0} раз.", maxNumberClick);

            button.Clicked += clicked;

            button2.IsVisible = false;
            button2.Clicked += clicked;

            button3.IsVisible = false;
            button3.Clicked += clicked;

            Content = new StackLayout {
                VerticalOptions = LayoutOptions.Center,

                Children = {
                    infoLabel,
                    button,
                    button2,
                    button3,
                    label,
                }
            };
        }

        private void updateStates() {
            if (clicksNumber == 10) {
                infoLabel.Text = "Ты просто великолепен! Но такими темпами это будет долго, давай я тебе помогу, добавив кнопки?";

                button2.IsVisible = true;
                button3.IsVisible = true;
            }

            label.Text = String.Format("Осталось кликнуть {0} раз.", maxNumberClick - clicksNumber);
        }

        private void clicked(object sender, EventArgs e) {
            if (clicksNumber == maxNumberClick) {
                infoLabel.Text = "Ты сделал это!";
                return;
            }

            clicksNumber++;
            updateStates();
        }
    }
}
