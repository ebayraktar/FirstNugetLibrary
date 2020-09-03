using Android.Content;
using Android.Widget;

namespace FirstNugetLibrary
{
    /// <summary>
    /// First Class For Test
    /// </summary>
    public class FirstClass
    {
        /// <summary>
        /// Test Class
        /// </summary>
        public FirstClass()
        {
            
        }

        /// <summary>
        /// Prints the message
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        public void Print(Context context, string message)
        {
            Toast.MakeText(context, message, ToastLength.Short).Show();
        }

    }
}
