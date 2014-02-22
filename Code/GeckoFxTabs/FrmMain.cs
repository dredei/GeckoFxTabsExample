#region Using

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gecko;

#endregion

#region Copyright

// Пример к статье: http://www.softez.pp.ua/2014/02/23/tabs-in-geckofx-c-sharp/
// Автор: dredei

#endregion

namespace GeckoFxTabs
{
    public partial class FrmMain : Form
    {
        private readonly Dictionary<GeckoWebBrowser, TabPage> _wbPages;

        public FrmMain()
        {
            // инициализация Xulrunner
            Xpcom.Initialize( Application.StartupPath + "\\xulrunner\\" );
            // устанавливаем UserAgent браузера в Firefox 22
            GeckoPreferences.User[ "general.useragent.override" ] =
                "Mozilla/5.0 (Windows NT 6.1; rv:22.0) Gecko/20130405 Firefox/22.0";
            this.InitializeComponent();
            this._wbPages = new Dictionary<GeckoWebBrowser, TabPage>();
            this.AddTab();
        }

        private GeckoWebBrowser GetWebBrowserByActiveTab()
        {
            // получаем активную вкладку
            TabPage selectedTab = this.tcBrowsersTabs.SelectedTab;
            // ищем первый элемент в словаре, значения которого (т.е. ссылка на вкладку) равна активной вкладке
            // данный метод возвратит либо ссылку на браузер, либо null
            return this._wbPages.FirstOrDefault( t => t.Value == selectedTab ).Key;
        }

        private void AddTab( string url = "http://www.google.ru/" )
        {
            TabPage tabPage = new TabPage( "Вкладка №" + ( this.tcBrowsersTabs.TabPages.Count + 1 ) );
            var webBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            // обработчик события изменения заголовка
            webBrowser.DocumentTitleChanged += this.webBrowser_DocumentTitleChanged;
            // обработчик создания окна
            webBrowser.CreateWindow2 += this.webBrowser_CreateWindow2;
            // обработчик события завершения загрузки
            webBrowser.DocumentCompleted += this.webBrowser_DocumentCompleted;
            // добавляем контрол браузера на новую вкладку
            tabPage.Controls.Add( webBrowser );
            // добавляет новую вкладку
            this.tcBrowsersTabs.TabPages.Add( tabPage );
            // делаем активной новую вкладку
            this.tcBrowsersTabs.SelectedTab = tabPage;
            // добавляем в словарь ссылку на браузер и вкладку
            this._wbPages.Add( webBrowser, tabPage );
            // загружаем страницу
            webBrowser.Navigate( url );
        }

        private void CloseActiveTab()
        {
            // получаем активную вкладку
            TabPage selectedTab = this.tcBrowsersTabs.SelectedTab;
            if ( selectedTab == null )
            {
                return;
            }
            // получаем ссылку на браузер
            GeckoWebBrowser webBrowser = this.GetWebBrowserByActiveTab();
            // удаляем со словаря
            this._wbPages.Remove( webBrowser );
            // уничтожаем браузер
            webBrowser.Dispose();
            webBrowser = null;
            // удаляем вкладку
            this.tcBrowsersTabs.TabPages.Remove( this.tcBrowsersTabs.SelectedTab );
            // принудительно запускаем сборщик мусора
            GC.Collect();
        }

        private void SetCurrentUrl()
        {
            GeckoWebBrowser webBrowser = this.GetWebBrowserByActiveTab();
            if ( webBrowser == null )
            {
                return;
            }
            this.tbUrl.Text = webBrowser.Url.ToString();
        }

        private void webBrowser_DocumentCompleted( object sender, EventArgs e )
        {
            this.SetCurrentUrl();
        }

        private void webBrowser_CreateWindow2( object sender, GeckoCreateWindow2EventArgs e )
        {
            // запрещаем создавать новые окна
            e.Cancel = true;
            var webBrowser = sender as GeckoWebBrowser;
            if ( webBrowser == null )
            {
                return;
            }
            webBrowser.Navigate( e.Uri );
        }

        private void webBrowser_DocumentTitleChanged( object sender, EventArgs e )
        {
            var webBrowser = sender as GeckoWebBrowser;
            if ( webBrowser == null )
            {
                return;
            }
            if ( !this._wbPages.ContainsKey( webBrowser ) )
            {
                return;
            }
            // зная ссылку на браузер получаем ссылку на вкладку
            TabPage tabPage = this._wbPages[ webBrowser ];
            // изменяем заголовок вкладки на заголовок страницы
            tabPage.Text = webBrowser.DocumentTitle;
        }

        private void tsmiAddTab_Click( object sender, EventArgs e )
        {
            this.AddTab();
        }

        private void tsmiCloseActiveTab_Click( object sender, EventArgs e )
        {
            this.CloseActiveTab();
        }

        private void btnGo_Click( object sender, EventArgs e )
        {
            GeckoWebBrowser webBrowser = this.GetWebBrowserByActiveTab();
            if ( webBrowser == null )
            {
                return;
            }
            // открываем указанную ссылку
            webBrowser.Navigate( this.tbUrl.Text );
        }

        private void tcBrowsersTabs_SelectedIndexChanged( object sender, EventArgs e )
        {
            this.SetCurrentUrl();
        }
    }
}