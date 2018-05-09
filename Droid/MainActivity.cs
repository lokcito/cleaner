using Android.App;
using Android.Widget;
using Android.Content;
using Android.OS;
using cleaner.models;

namespace cleaner.Droid
{
    [Activity(Label = "cleaner", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Actividad actividadPermanente = new Actividad();
        Button btnGuardar;
        EditText editTextTitulo;
        EditText editTextDetalle;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            actividadPermanente.cargarDatosIniciales();
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            btnGuardar = FindViewById<Button>(Resource.Id.btnGuardar);

            editTextTitulo = FindViewById<EditText>(Resource.Id.editTextTitulo);
            editTextDetalle = FindViewById<EditText>(Resource.Id.editTextDetalle);

            btnGuardar.Click += delegate { guardarActividad(); };
        }

        protected void guardarActividad() {
            Actividad.crearActividad(actividadPermanente.permanencia.Count, editTextTitulo.Text, editTextDetalle.Text);
            Toast.MakeText(this, "Se agregó una tarea.", ToastLength.Long).Show();

            //Intent myIntent = new Intent(this, typeof(MyLista)); //myIntent.PutExtra("key", myAttribute); StartActivity(myIntent);
            //StartActivity(myIntent);
        }
    }
}

