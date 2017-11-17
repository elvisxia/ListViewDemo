using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewDemo
{
    public class ExampleListAdapter : BaseAdapter<Item>
    {
        private Activity mContext;
        private List<Item> mList;

        public ExampleListAdapter(Activity context, List<Item> list)
        {
            mContext = context;
            mList = list;
        }

        public override Item this[int position] => mList[position];

        public override int Count => mList.Count;

        public override long GetItemId(int position)
        {
            return mList[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = mList[position];

            if (convertView == null)
            {
                convertView = mContext.LayoutInflater.Inflate(Resource.Layout.CustomRowView,null);
            }

            convertView.FindViewById<TextView>(Resource.Id.mText).Text = item.Text;
            return convertView;
        }
    }
}