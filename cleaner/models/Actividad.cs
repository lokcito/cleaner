using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace cleaner.models
{
    public class Actividad
    {
        public int id;
        public string titulo { get; set; }
        public string detalle { get; set; }
        public List<Actividad> permanencia = new List<Actividad>();

        public Actividad()
        {
            //permanencia = new List<Actividad>();
        }

        public void cargarDatosIniciales() {
            int ncantidad = permanencia.Count;
            permanencia.Add(Actividad.crearActividad(ncantidad, "Salir a cenar", "Reservar..."));
        }
        public static Actividad crearActividad(int id, string titulo, string detalle){
            // Aqui se debe conectar la base de datos
            Actividad nuevo = new Actividad();
            nuevo.detalle = detalle;
            nuevo.titulo = titulo;
            nuevo.id = id + 1;
            return nuevo;
        }
        public void actualizar(string titulo, string detalle)
        {
            // Aqui se debe conectar la base de datos
            Debug.WriteLine("Actividad actualizada");
        }
        public static bool eliminarActividad(int i, IList<Actividad> data)
        {
            // Aqui se debe conectar la base de datos
            Debug.WriteLine("Actividad eliminada.");
            return true;
        }
        public static IList<Actividad> retornar_actividades()
        {
            // Aqui se debe conectar la base de datos
            Actividad actividad_obj = new Actividad();
            return actividad_obj.permanencia;
        }
    }
}
