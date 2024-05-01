using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1
    {
        public TabbedPage1()
        {
            InitializeComponent();
            BarBackgroundColor = Color.FromHex("#C1FFC1"); // Нежно зеленый цвет для фона вкладок
            BarTextColor = Color.Black; // Черный текст для вкладок

            // Устанавливаем расположение вкладок внизу страницы для Android
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        }
    }
}