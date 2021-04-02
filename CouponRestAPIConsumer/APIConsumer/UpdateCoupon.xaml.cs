using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using Newtonsoft.Json;
namespace APIConsumer
{
    /// <summary>
    /// Interaction logic for UpdateCoupon.xaml
    /// </summary>
    public partial class UpdateCoupon : Window
    {
        private static readonly HttpClient client = new HttpClient();

        private static string url = "https://foxpeer-eval-test.apigee.net/api/coupons";
       // private string apiKey = "?apikey=ykAAcqrUlfUeYoFro1lTDNuwP1SZwGuT";
        public UpdateCoupon()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Coupon updateCoupon = new Coupon();
                updateCoupon.Id = textCouponID.Text;
                updateCoupon.CouponCode = textCouponCode.Text;
                updateCoupon.StoreName = textStoreName.Text;
                updateCoupon.ItemName = textItemName.Text;

                if (textCouponCode.Text == "" || textStoreName.Text == "" || textItemName.Text == "")
                {
                    throw new Exception("Please fill all blanks");
                }

                string updateCouponJson = JsonConvert.SerializeObject(updateCoupon);
                var couponToUpdate = new StringContent(updateCouponJson, Encoding.UTF8, "application/json");
                var updateResult = client.PutAsync(url + "/" + updateCoupon.Id.ToString()+APIKey.ApiKey, couponToUpdate).Result;
                if (updateResult.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    throw new Exception("Please enter correct API key!");
                }

                if (updateResult.StatusCode == System.Net.HttpStatusCode.MethodNotAllowed || updateResult.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new Exception("Please enter correct coupon ID.");
                }
                MessageBox.Show(updateResult.ToString());
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
