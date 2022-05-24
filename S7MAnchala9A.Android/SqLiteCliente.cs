using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using S7MAnchala9A;

[assembly: Xamarin.Forms.Dependency(typeof(S7MAnchala9A.Droid.SqLiteCliente))]

namespace S7MAnchala9A.Droid
{
    public class SqLiteCliente : Database
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            var path = Path.Combine(documentPath, "uisrael.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}