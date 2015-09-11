using our_map.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace our_map
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class map_page : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        string placeToGo;


        public map_page()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void loselost_Completed(object sender, object e)
        {
            show_map.Begin();
        }

        private void goWhere_TextChanged(object sender, TextChangedEventArgs e)
        {
            placeToGo = goWhere.Text; 
            if (stackPanel.Visibility == Windows.UI.Xaml.Visibility.Visible)
                loselost.Begin();
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            switch (placeToGo)
            {
                case "meca":
                    goto_meca.Begin();
                    break;

                case "elec":
                    goto_elec.Begin();
                    break;

                case "e3":
                    goto_e3.Begin();
                    break;

                case "m":
                    goto_Mng.Begin();
                    break;

                case "pro":
                    goto_pro.Begin();
                    break;

                case "c12":
                    goto_c12.Begin();
                    break;
                
                case "c11":
                    goto_c11.Begin();
                    break;
                
                case "ssp prayer":
                    goto_ssppray.Begin();
                    break;
                
                case "c27":
                    goto_c27.Begin();
                    break;

                case "c26":
                    goto_c26.Begin();
                    break;

                case "c28":
                    goto_c28.Begin();
                    break;

                case "c40":
                    goto_c40.Begin();
                    break;
                
                case "c39":
                    goto_c39.Begin();
                    break;

                case "c38":
                    goto_c38.Begin();
                    break;

                case "h11":
                    goto_h11.Begin();
                    break;

                case "hall 1":
                    goto_hall1.Begin();
                    break;

                case "l4":
                    goto_l4.Begin();
                    break;

                case "l2":
                    goto_l2.Begin();
                    break;

                case "l5":
                    goto_l5.Begin();
                    break;

                case "l3":
                    goto_l3.Begin();
                    break;

                case "l8":
                    goto_l8.Begin();
                    break;
                
                case "p14":
                    goto_p14.Begin();
                    break;

                case "k3":
                    goto_k3.Begin();
                    break;

                case "k1":
                    goto_k1.Begin();
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(map_page));
        }
    }
}
