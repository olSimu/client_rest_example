using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientREST_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClientREST.init();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            int idInt;
            Photo a=null;
            if (id != null && int.TryParse(id, out idInt))
            {
                a=await ClientREST.GetPhotoAsync("/Photos/" + id);
                textBoxTitle.Text = a.title;
                textBoxAlbumID.Text = a.albumId.ToString();
                textBoxUrl.Text = a.url;
                textBoxThumbnailUrl.Text = a.thumbnailUrl;
            }
            

        }
    }

    public class Photo
    {
        public int albumId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }


    class ClientREST
    {

        static HttpClient client = new HttpClient();

        public static void init()
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }

        static void ShowProduct(Photo Photo)
        {
            Console.WriteLine(Photo.ToString());
        }

        public static async Task<Photo> GetPhotoAsync(string path)
        {
            Photo product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await JsonSerializer.DeserializeAsync<Photo>(await response.Content.ReadAsStreamAsync());
            }
            return product;
        }

        static async Task<Uri> CreateProductAsync(Photo product)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "/Photos", product);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Photo> UpdateProductAsync(Photo product)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/Photos/{product.id}", product);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            product = await JsonSerializer.DeserializeAsync<Photo>(await response.Content.ReadAsStreamAsync());
            return product;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"/Photos/{id}");
            return response.StatusCode;
        }


        /*static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }*/

        /*static async Task RunAsync()
        {
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Photo Photo = null;

                // Get an existing product
                Photo = await GetPhotoAsync("/Photos/1");
                ShowProduct(Photo);

                //Create a new product
                Photo = new Photo();
                Photo.id = 99; Photo.title = "Test"; Photo.PhotoId = 1;
                var url = await CreateProductAsync(Photo);
                Console.WriteLine($"New Photo reated at {url}");
                /*
                Photo = await GetPhotoAsync(url);
                ShowProduct(Photo);*/
        /*
                // Update the product
                Console.WriteLine("Updating title...");
                Photo.title = "Test2";
                await UpdateProductAsync(Photo);

                // Delete the product
                var statusCode = await DeleteProductAsync(Photo.id + "");
                Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }*/

    }
}
