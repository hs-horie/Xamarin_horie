using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_horie
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //クリックイベント作成
            NextButton.Clicked += NextButton_Clicked;
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            // 表示画面を入れ替える
            Application.Current.MainPage = new MyPage();

            // モーダル遷移
            //Navigation.PushModalAsync(new MyPage());

            // モーダレス遷移
            //Navigation.PushAsync(new MyPage());
        }
    }
}
