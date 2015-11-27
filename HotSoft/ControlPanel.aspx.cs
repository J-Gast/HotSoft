using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotSoft
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardarCurso_Click(object sender, EventArgs e)
        {

        }
        private void ActualizarExperiencia()
        {
            ManejoBD.ManejoDatos Actualizar = new ManejoBD.ManejoDatos();
            Actualizar.Actualizar("ExperienciaAdmin", "Puntaje", Convert.ToInt32(RangeJunior.Value), "RolRequerido", "Junior");
            Actualizar.Actualizar("ExperienciaAdmin", "Puntaje", Convert.ToInt32(RangeMiddle.Value), "RolRequerido", "Middle");
            Actualizar.Actualizar("ExperienciaAdmin", "Puntaje", Convert.ToInt32(RangeSenior.Value), "RolRequerido", "Senior");
        }
        private void ActualizarEstudios()
        {
            ManejoBD.ManejoDatos Actualizar = new ManejoBD.ManejoDatos();
            int PuntajeLicenciatura = 0,PuntajeMaestria=0,PuntajeDoctorado=0;
            if(rbLicenciatura.Checked)
            {
                PuntajeLicenciatura = Convert.ToInt32(Range2.Value);
                PuntajeMaestria = Convert.ToInt32(Range2.Value)/3;
                PuntajeDoctorado = Convert.ToInt32(Range2.Value) / 6;
            }
            else if (rbMaestria.Checked)
            {
                PuntajeLicenciatura = Convert.ToInt32(Range2.Value) / 3;
                PuntajeMaestria = Convert.ToInt32(Range2.Value);
                PuntajeDoctorado = Convert.ToInt32(Range2.Value) / 3;
            }
            else
            {
                PuntajeLicenciatura = Convert.ToInt32(Range2.Value) / 6;
                PuntajeMaestria = Convert.ToInt32(Range2.Value) / 3;
                PuntajeDoctorado = Convert.ToInt32(Range2.Value);
            }
            Actualizar.Actualizar("EducacionAdmin", "Puntaje", PuntajeLicenciatura, "GradoEstudiosRequerido", "Licenciatura");
            Actualizar.Actualizar("EducacionAdmin", "Puntaje", PuntajeMaestria, "GradoEstudiosRequerido", "Maestria");
            Actualizar.Actualizar("EducacionAdmin", "Puntaje", PuntajeDoctorado, "GradoEstudiosRequerido", "Doctorado");

            Actualizar.Actualizar("EducacionAdmin", "CarreraAfin", cbAfin.Text);
        }
        private void ActualizarAptitudes()
        {
            ManejoBD.ManejoDatos Actualizar = new ManejoBD.ManejoDatos();
            if (ch1Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Trabajo en equipo");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Trabajo en equipo");
            if (ch2Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Facilidad de palabra");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Facilidad de palabra");
            if (ch3Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Facilidad de aprendizaje");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Facilidad de aprendizaje");
            if (ch4Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Buena comunicación");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Buena comunicación");
            if (ch5Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Puntualidad");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Puntualidad");
            if (ch6Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Bueno escuchando");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Bueno escuchando");
            if (ch7Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Liderazgo");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Liderazgo");
            if (ch8Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Perseverancia");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Perseverancia");
            if (ch9Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Capacidad de mantenerse actualizado");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Capacidad de mantenerse actualizado");
            if (ch10Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Afán de superación");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Afán de superación");
            if (ch11Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Responsable");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Responsable");
            if (ch12Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Alta ética");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Alta ética");
            if (ch13Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Conducta emprendedora");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Conducta emprendedora");
            if (ch14Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Innovador/a");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Innovador/a");
            if (ch15Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Autodidacta");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Autodidacta");
            if (ch16Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Conciencia de la realidad social");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Conciencia de la realidad social");
            if (ch17Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Interés por la investigación");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Interés por la investigación");
            if (ch18Apt.Checked)
                Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value), "Descripcion", "Trabajar bajo presión");
            else Actualizar.Actualizar("AptitudesAdmin", "Puntaje", Convert.ToInt32(Range4.Value) / 2, "Descripcion", "Trabajar bajo presión");
        }
        private void ActualizarHabilidades()
        {
            ManejoBD.ManejoDatos Actualizar = new ManejoBD.ManejoDatos();
            if (ch1Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Visual Basic");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Visual Basic");
            if (ch2Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "C");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "C");
            if (ch3Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "C++");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "C++");
            if (ch4Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Java");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Java");
            if (ch5Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Python");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Python");
            if (ch6Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Pascal");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Pascal");
            if (ch7Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "C#");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "C#");
            if (ch8Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Ruby");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Ruby");
            if (ch9Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "PHP");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "PHP");
            if (ch10Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "HTML");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "HTML");
            if (ch11Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "CSS");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "CSS");
            if (ch12Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "JavaScript");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "JavaScript");
            if (ch13Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Ensamblador");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Ensamblador");
            if (ch14Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Fortran");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Fortran");
            if (ch15Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "COBOL");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "COBOL");
            if (ch16Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "NesC");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "NesC");
            if (ch17Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "Prolog");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "Prolog");
            if (ch18Cert.Checked)
                Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value), "Descripcion", "UML");
            else Actualizar.Actualizar("HabilidadesAdmin", "Puntaje", Convert.ToInt32(Range3.Value) / 5, "Descripcion", "UML");
        }
        private void ActualizarCursos()
        {
            ManejoBD.ManejoDatos Actualizar = new ManejoBD.ManejoDatos();
            if (ch1Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Internet de las cosas");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Internet de las cosas");
            if (ch2Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Sistemas embebidos");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Sistemas embebidos");
            if (ch3Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "ERP");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "ERP");
            if (ch4Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "IHC");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "IHC");
            if (ch5Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "SQL Server");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "SQL Server");
            if (ch6Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Word");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Word");
            if (ch7Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Excel");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Excel");
            if (ch8Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Photoshop");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Photoshop");
            if (ch9Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Google Docs");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Google Docs");
            if (ch10Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Windows 10");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Windows 10");
            if (ch11Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Microsoft Azure");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Microsoft Azure");
            if (ch12Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "MS Dynamics");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "MS Dynamics");
            if (ch13Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Virtualización");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Virtualización");
            if (ch14Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Windows Server");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Windows Server");
            if (ch15Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Exchange Server");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Exchange Server");
            if (ch16Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Cloud Computing");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Cloud Computing");
            if (ch17Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "AngularJS");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "AngularJS");
            if (ch18Cur.Checked)
                Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value), "Descripcion", "Seguridad Informatica");
            else Actualizar.Actualizar("CursosAdmin", "Puntaje", Convert.ToInt32(Range5.Value) / 3, "Descripcion", "Seguridad Informatica");
        }
        private void ActualizarIdioma()
        {
            ManejoBD.ManejoDatos Actualizar = new ManejoBD.ManejoDatos();
            Actualizar.Actualizar("IdiomaAdmin", "Puntaje", Convert.ToInt32(RangoIngles.Value), "Descripcion", "Ingles");
            Actualizar.Actualizar("IdiomaAdmin", "Puntaje", Convert.ToInt32(RangoFrances.Value), "Descripcion", "Frances");
            Actualizar.Actualizar("IdiomaAdmin", "Puntaje", Convert.ToInt32(RangoPortugues.Value), "Descripcion", "Portugues");
            Actualizar.Actualizar("IdiomaAdmin", "Puntaje", Convert.ToInt32(RangoJapones.Value), "Descripcion", "Japones");
            Actualizar.Actualizar("IdiomaAdmin", "Puntaje", Convert.ToInt32(RangoChino.Value), "Descripcion", "Chino");

        }
        protected void btnGuardarIdioma_Click(object sender, EventArgs e)
        {
            //Estudios
            ActualizarEstudios();
            //Experiencia
            ActualizarExperiencia();
            //Aptitudes
            ActualizarAptitudes();
            //Habilidades
            ActualizarHabilidades();
            //Cursos
            ActualizarCursos();
            //Idiomas
            ActualizarIdioma();
        }
    }
}