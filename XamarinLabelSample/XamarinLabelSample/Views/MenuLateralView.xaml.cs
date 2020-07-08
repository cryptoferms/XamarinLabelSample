using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinLabelSample.Models;

namespace XamarinLabelSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateralView : MasterDetailPage
    {
        public List<MasterDetailViewItem> MenuList { get; set; }
        public MenuLateralView()
        {
            InitializeComponent();
            MenuList = new List<MasterDetailViewItem>();
            //Adicionando as páginas que serão navegadas em nosso menu lateral
            var page1 = new MasterDetailViewItem() { Title = "Pagina 1", Icon = "baseline_home_white_18dp.png", TargetType = typeof(PaginaPrincipal) };
            var page2 = new MasterDetailViewItem() { Title = "Pagina 2", Icon = "lucro.png", TargetType = typeof(PaginaPrincipal) };
            var page3 = new MasterDetailViewItem() { Title = "Pagina 3", Icon = "lucro.png", TargetType = typeof(PaginaPrincipal) };
            var page4 = new MasterDetailViewItem() { Title = "Pagina 4", Icon = "lucro.png", TargetType = typeof(PaginaPrincipal) };
            MenuList.Add(page1);
            MenuList.Add(page2);
            MenuList.Add(page3);
            MenuList.Add(page4);
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PaginaPrincipal)));
            this.BindingContext = this;
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (MasterDetailViewItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}