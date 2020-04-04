using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using Xamarin.Forms;

namespace EmployeeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var client = new HttpClient();
            var json = await client.GetStringAsync("https://dummy.restapiexample.com/api/v1/employees");
            GetEmployeesDTO result = JsonConvert.DeserializeObject<GetEmployeesDTO>(json);

            lstEmployees.ItemsSource = result.data;
            lblStatus.Text = result.status;
        }
    }
}
