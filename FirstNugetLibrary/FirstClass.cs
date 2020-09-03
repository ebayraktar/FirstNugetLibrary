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
            Test(context);
        }

        /// <summary>
        /// A <see cref="FirstClass"/> Test 
        /// </summary>
        /// <param name="context">The context.</param>
        public void Test(Context context)
        {
            Toast.MakeText(context, "Success", ToastLength.Short).Show();
        }

    }
}
