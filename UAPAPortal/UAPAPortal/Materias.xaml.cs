using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UAPAPortal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Materias : ContentPage
    {
        public IList<MateriasM> Agrimensura { get; private set; } 
        public IList<MateriasM> AdminEmpresasTuristicas { get; private set; }
        public Materias()
        {
            InitializeComponent();
         

            BindingContext = this;
            MostrarCarreras();
            AgrimensuraMaterias();
            AdminEmpresasTuristicas();

        }

        public void AgrimensuraMaterias ()
        {
            Agrimensura = new List<MateriasM>();

            Agrimensura.Add(new MateriasM
            {
                NombreM = "Introducción a la Educación a Distancia"
            });
            Agrimensura.Add(new MateriasM
            {
                NombreM = "Español I"
            });
            Agrimensura.Add(new MateriasM
            {
                NombreM = "Infotecnología para el Aprendizaje"
            });
            Agrimensura.Add(new MateriasM
            {
                NombreM = "Propedéutico de Ingeniería"
            });
            Agrimensura.Add(new MateriasM
            {
                NombreM = "Matemática Básica"
            });
            Agrimensura.Add(new MateriasM
            {
                NombreM = "Introducción a la Agrimensura"
            });
            Agrimensura.Add(new MateriasM
            {
                NombreM = "Metodología de la Investigación I"
            });
        }
        public void AdminEmpresasTuristicas ()
        {
            AdminEmpresasTuristicas = new List<MateriasM>();

            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Introducción a la Educación a Distancia"
            });
            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Español I"
            });
            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Infotecnología para el Aprendizaje"
            });
            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Propedéutico de Ingeniería"
            });
            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Matemática Básica"
            });
            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Introducción a la Agrimensura"
            });
            AdminEmpresasTuristicas.Add(new MateriasM
            {
                NombreM = "Metodología de la Investigación I"
            });
        }

        public void MostrarCarreras()
        {
            PickerCarreras.Items.Add("Administración de Empresas");
            PickerCarreras.Items.Add("Administración de Empresas Turísticas");
            PickerCarreras.Items.Add("Ciencias de la Educación, Mención Ciencias Sociales");
            PickerCarreras.Items.Add("Ciencias de la Educación, Mención Lengua Española");
            PickerCarreras.Items.Add("Ciencias de la Educación, Mención Matemática-Física");
            PickerCarreras.Items.Add("Ciencias de la Educación, Mención Primer Ciclo de la Educación Básica");
            PickerCarreras.Items.Add("Contabilidad Empresarial");
            PickerCarreras.Items.Add("Ciencias de la Educación, Mención Educación Inicial");
            PickerCarreras.Items.Add("Derecho");
            PickerCarreras.Items.Add("Informática Gerencial");
            PickerCarreras.Items.Add("Lenguas Modernas Mención Turismo");
            PickerCarreras.Items.Add("Mercadeo");
            PickerCarreras.Items.Add("Psicología");
            PickerCarreras.Items.Add("Psicología Clínica");
            PickerCarreras.Items.Add("Psicología Educativa");
            PickerCarreras.Items.Add("Psicología Industrial");
            PickerCarreras.Items.Add("Licenciatura en Periodismo Digital");
            PickerCarreras.Items.Add("Ingeniería en Software");
            PickerCarreras.Items.Add("Legislación de Tierras");
            PickerCarreras.Items.Add("Educación, Mención Gestión de Centros Educativos");
            PickerCarreras.Items.Add("Educación Inicial");
            PickerCarreras.Items.Add("Mercadeo, Mención Gerencia de Mercadeo");
            PickerCarreras.Items.Add("Psicología Clínica");
            PickerCarreras.Items.Add("Historia, con orientación a la enseñanza");
            PickerCarreras.Items.Add("Derecho Civil y Procesal Civil Contemporáneos");
            PickerCarreras.Items.Add("Derecho Penal y Procesal Penal Contemporáneos");
            PickerCarreras.Items.Add("Gerencia de Recursos Humanos");
            PickerCarreras.Items.Add("Dirección Financiera");
            PickerCarreras.Items.Add("Gestión de la Tecnología Educativa.");
            PickerCarreras.Items.Add("Derecho Constitucional");
            PickerCarreras.Items.Add("Maestría en Terapia Familiar");
            PickerCarreras.Items.Add("Maestría En Gestión De Instituciones Educativas Virtuales");
            PickerCarreras.Items.Add("Gestión de Centros Educativos");
            PickerCarreras.Items.Add("Mercadeo");
            PickerCarreras.Items.Add("Educación, Mención Lengua Española, 2do. Ciclo");
            PickerCarreras.Items.Add("Lengua Española y Literatura, con orientación a la enseñanza");
            PickerCarreras.Items.Add("Educación, Mención Matemática y Física, 2do. Ciclo");
            PickerCarreras.Items.Add("Matemática, con orientación a la enseñanza");
            PickerCarreras.Items.Add("Educación, Mención Historia y Geografía");
            PickerCarreras.Items.Add("Historia, con orientación a la enseñanza");
            PickerCarreras.Items.Add("Biología, con orientación a la enseñanza");
            PickerCarreras.Items.Add("Informática, con orientación a la enseñanza");
        }

      

        private async void BtnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void PickerCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PickerResult = PickerCarreras.SelectedItem.ToString();
            
            

            if (PickerResult == "Agrimensura")
            {
                ListViewMaterias.ItemsSource = Agrimensura;
                ListViewMaterias.IsVisible = true;
            }
            else if(PickerResult == "Administración de Empresas Turísticas")
            {
                ListViewMaterias.ItemsSource = AdminEmpresasTuristicas;
                ListViewMaterias.IsVisible = true;
            }
            else if (PickerResult == "Ciencias de la Educación, Mención Ciencias Sociales")
            {
                ListViewMaterias.ItemsSource = Agrimensura;
                ListViewMaterias.IsVisible = true;
            }
            else if (PickerResult == "Administración de Empresas Turísticas")
            {
                ListViewMaterias.ItemsSource = Agrimensura;
                ListViewMaterias.IsVisible = true;
            }
            else if (PickerResult == "Ciencias de la Educación, Mención Lengua Española")
            {
                ListViewMaterias.ItemsSource = Agrimensura;
                ListViewMaterias.IsVisible = true;
            }
            else if (PickerResult == "Ciencias de la Educación, Mención Matemática-Física")
            {
                ListViewMaterias.ItemsSource = Agrimensura;
                ListViewMaterias.IsVisible = true;
            }





        }
    }
}