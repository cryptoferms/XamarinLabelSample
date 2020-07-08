using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace XamarinLabelSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FaturaView : ContentPage
    {
        public FaturaView()
        {
            InitializeComponent();
            FaturamentoView.Source = "https://docs.google.com/viewer?url=http://desenv1.algorix.com//Generix/Cons2ViaFaturaCliente.aspx?CdRede=9024&CdCliente=2002329&NuSeqFatura=57&IdUsu=2&ie6=rel.pdf&Tp=email";
            FaturamentoView.WidthRequest = 1000;
            FaturamentoView.HeightRequest = 1000;
        }
    }
}