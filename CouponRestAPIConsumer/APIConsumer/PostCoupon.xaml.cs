using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Http;
using Newtonsoft.Json;

namespace APIConsumer
{
    /// <summary>
    /// Interaction logic for PostCoupon.xaml
    /// </summary>
    public partial class PostCoupon : Window
    {
        private static readonly HttpClient client = new HttpClient();

        private static string url = "https://foxpeer-eval-test.apigee.net/api/coupons";
       // private string apiKey = "?apikey=ykAAcqrUlfUeYoFro1lTDNuwP1SZwGuT";
        public PostCoupon()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Coupon newCoupon = new Coupon();
                newCoupon.CouponCode = textCouponCode.Text;
                newCoupon.StoreName = textStoreName.Text;
                newCoupon.ItemName = textItemName.Text;

                if (textCouponCode.Text == "" || textStoreName.Text == "" || textItemName.Text == "")
                {
                    throw new Exception("Please fill all blanks");
                }
                string newCouponJsonString = JsonConvert.SerializeObject(newCoupon);
                var newCouponToPost = new StringContent(newCouponJsonString, Encoding.UTF8, "application/json");
                var postResult = client.PostAsync(url + APIKey.ApiKey, newCouponToPost).Result;
                if (postResult.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new Exception("Please enter correct API key!");
                }

                MessageBox.Show(postResult.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           
        }

        private void btnCancle_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
