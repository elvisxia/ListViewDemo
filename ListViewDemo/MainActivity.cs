using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace ListViewDemo
{
    [Activity(Label = "ListViewDemo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        ListView exampleListView;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            exampleListView = FindViewById<ListView>(Resource.Id.exampleListView);

            var items = InitList();

            exampleListView.Adapter = new ExampleListAdapter(this, items);

            exampleListView.ItemClick += ExampleListView_ItemClick;
        }

        private void ExampleListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            //the following codes are triggered correctly
            var abc = 123;
        }

        private List<Item> InitList()
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(new Item(i, "Item " + i));
            }
            return items;
        }
    }


    public class Item
    {
        public Item(int id, string text)
        {
            this.Id = id;
            this.Text = text;
        }
        public int Id { get; set; }
        public string Text { get; set; }
    }
}

