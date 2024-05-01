using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2
{
    public class NewPage : ContentPage
    {
        public NewPage()
        {
            // Здесь вы можете добавить содержимое новой страницы
            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Новая страница" }
                }
            };
        }
    }
}
